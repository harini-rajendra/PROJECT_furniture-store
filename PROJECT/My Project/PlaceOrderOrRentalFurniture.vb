Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class PlaceOrderOrRentalFurniture
    ' Variables to store received data
    Private FurnitureID As Integer
    Private Quantity As Integer
    Private OrderType As String
    Private TotalAmount As Decimal
    Private FurniturePrice As Decimal
    Private RentalPrice As Decimal
    Private OrderID As Integer ' Order ID variable

    ' Database connection string
    Private connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True;Trust Server Certificate=True"

    ' Constructor to receive data from ViewCart
    Public Sub New(furnitureID As Integer, quantity As Integer, orderType As String, totalAmount As Decimal)
        InitializeComponent()
        Me.FurnitureID = furnitureID
        Me.Quantity = quantity
        Me.OrderType = orderType
        Me.TotalAmount = totalAmount
    End Sub

    Private Sub PlaceOrderOrRentalFurniture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default values
        txtFurnitureID.Text = FurnitureID.ToString()
        numQuantity.Value = Quantity

        ' Populate ComboBox safely
        cmbOrderType.Items.Clear()
        cmbOrderType.Items.AddRange(New String() {"Buy", "Rent"})

        ' Ensure correct order type selection
        If cmbOrderType.Items.Contains(OrderType) Then
            cmbOrderType.SelectedItem = OrderType
        Else
            cmbOrderType.SelectedIndex = 0 ' Default to "Buy"
        End If

        ' Retrieve Furniture Price from Database
        RetrieveFurniturePricing(FurnitureID)

        ' Generate Order ID
        OrderID = GenerateOrderID()

        ' Update total amount initially
        UpdateTotalAmount()
    End Sub

    ' Function to retrieve furniture price and rental price from database
    Private Sub RetrieveFurniturePricing(furnitureID As Integer)
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT Price, RentalPrice FROM Furniture WHERE FurnitureID = @FurnitureID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@FurnitureID", furnitureID)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        FurniturePrice = Convert.ToDecimal(reader("Price"))
                        RentalPrice = Convert.ToDecimal(reader("RentalPrice"))
                    Else
                        FurniturePrice = 0
                        RentalPrice = 0
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving price: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to generate a unique Order ID
    Private Function GenerateOrderID() As Integer
        Dim newOrderID As Integer = 1
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT ISNULL(MAX(OrderID), 0) + 1 FROM Orders"
                Using cmd As New SqlCommand(query, con)
                    newOrderID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Order ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return newOrderID
    End Function

    ' Event when Order Type is changed
    Private Sub cmbOrderType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrderType.SelectedIndexChanged
        ' Show rental fields only if "Rent" is selected
        Dim isRental As Boolean = (cmbOrderType.SelectedItem IsNot Nothing AndAlso cmbOrderType.SelectedItem.ToString() = "Rent")
        dtpRentalDate.Visible = isRental
        dtpReturnDate.Visible = isRental
        lblRentalDate.Visible = isRental
        lblReturnDate.Visible = isRental

        ' Update total amount based on selection
        UpdateTotalAmount()
    End Sub

    ' Event when Quantity is changed
    Private Sub numQuantity_ValueChanged(sender As Object, e As EventArgs) Handles numQuantity.ValueChanged
        ' Update total amount when quantity changes
        UpdateTotalAmount()
    End Sub
    Private Sub dtpRentalDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpRentalDate.ValueChanged
        UpdateTotalAmount()
    End Sub

    Private Sub dtpReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturnDate.ValueChanged
        UpdateTotalAmount()
    End Sub

    ' Function to update total amount
    Private Sub UpdateTotalAmount()
        Dim quantity As Integer = CInt(numQuantity.Value)
        Dim orderType As String = If(cmbOrderType IsNot Nothing AndAlso cmbOrderType.SelectedItem IsNot Nothing, cmbOrderType.SelectedItem.ToString(), "Buy")

        If orderType = "Buy" Then
            TotalAmount = FurniturePrice * quantity
        Else
            ' Ensure rental date and return date are valid
            Dim rentalDays As Integer = (dtpReturnDate.Value.Date - dtpRentalDate.Value.Date).Days
            If rentalDays <= 0 Then rentalDays = 1 ' Minimum 1 day rental
            TotalAmount = RentalPrice * quantity * rentalDays
        End If

        lblTotalAmount.Text = "₹ " & TotalAmount.ToString("0.00")
    End Sub


    ' Confirm Order Button Click
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Validate rental date
        If cmbOrderType.SelectedItem IsNot Nothing AndAlso cmbOrderType.SelectedItem.ToString() = "Rent" Then
            If dtpRentalDate.Value >= dtpReturnDate.Value Then
                MessageBox.Show("Return Date must be later than Rental Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        ' Save order details to database
        If SaveOrderToDatabase() Then
            ' Proceed to Payment
            Dim confirmResult As DialogResult = MessageBox.Show("Total Amount: ₹ " & TotalAmount.ToString("0.00") & vbCrLf & "Do you want to proceed to payment?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.Yes Then
                Dim paymentForm As New PaymentForm(TotalAmount, OrderID)
                paymentForm.Show()
                Me.Close()
            End If
        End If
    End Sub

    ' Function to save order to database
    Private Function SaveOrderToDatabase() As Boolean
        Try
            ' Insert into Orders table
            Dim orderQuery As String = "INSERT INTO Orders (UserID, FurnitureID, Quantity, TotalPrice, OrderType, OrderDate) 
                            VALUES (@CustomerID, @FurnitureID, @Quantity, @TotalPrice, @OrderType, GETDATE());
                            SELECT SCOPE_IDENTITY();" ' Get the generated OrderID

            Using con As New SqlConnection(connectionString)
                con.Open()
                Using cmd As New SqlCommand(orderQuery, con)
                    cmd.Parameters.AddWithValue("@CustomerID", LoggedInCustomerID)
                    cmd.Parameters.AddWithValue("@FurnitureID", FurnitureID)
                    cmd.Parameters.AddWithValue("@Quantity", numQuantity.Value)
                    cmd.Parameters.AddWithValue("@TotalPrice", TotalAmount)
                    cmd.Parameters.AddWithValue("@OrderType", cmbOrderType.SelectedItem.ToString())

                    Dim OrderID As Integer = Convert.ToInt32(cmd.ExecuteScalar()) ' Get new OrderID

                    ' If it's a rental, insert into Rentals table
                    ' If it's a rental, insert into Rentals table
                    If cmbOrderType.SelectedItem.ToString() = "Rent" Then
                        Dim rentalQuery As String = "INSERT INTO Rentals (UserID, FurnitureID, Quantity, RentalDate, ReturnDate, TotalPrice, Status) 
                                 VALUES (@UserID, @FurnitureID, @Quantity, @RentalDate, @ReturnDate, @TotalPrice, 'Pending');"

                        Using rentalCmd As New SqlCommand(rentalQuery, con)
                            rentalCmd.Parameters.AddWithValue("@UserID", LoggedInCustomerID)
                            rentalCmd.Parameters.AddWithValue("@FurnitureID", FurnitureID)
                            rentalCmd.Parameters.AddWithValue("@Quantity", numQuantity.Value)
                            rentalCmd.Parameters.AddWithValue("@RentalDate", dtpRentalDate.Value)
                            rentalCmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value)
                            rentalCmd.Parameters.AddWithValue("@TotalPrice", TotalAmount)
                            rentalCmd.ExecuteNonQuery()
                        End Using
                    End If

                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Error saving order: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Cancel Button Click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class