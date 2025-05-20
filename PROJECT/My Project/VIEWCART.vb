Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ViewCart
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"
    Public Property orderType As String

    Private Sub ViewCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCart()
    End Sub

    ' Load Cart Items
    Public Sub LoadCart()
        Try
            Using con As New SqlConnection(connectionString)
                ' Updated Query: Includes FurnitureName & handles NULL RentalPrice
                Dim query As String = "SELECT CartID, c.FurnitureID, f.FurnitureName, c.Quantity, f.Price, 
                       ISNULL(f.RentalPrice, 0) AS RentalPrice, c.OrderType 
                       FROM Cart c 
                       INNER JOIN Furniture f ON c.FurnitureID = f.FurnitureID 
                       WHERE c.UserID = @UserID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@UserID", LoggedInCustomerID)

                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()

                    con.Open()
                    adapter.Fill(dt)
                    con.Close()

                    If dt.Rows.Count > 0 Then
                        dgvCart.AutoGenerateColumns = True
                        dgvCart.DataSource = dt
                        CalculateTotal() ' Call this to update total amount
                    Else
                        MessageBox.Show("No items found in the cart.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading cart: " & ex.Message)
        End Try
    End Sub

    ' Proceed to Payment or Rental
    Private Sub btnProceedToPay_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If dgvCart.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvCart.SelectedRows(0)
            Dim furnitureID As Integer = Convert.ToInt32(row.Cells("FurnitureID").Value)
            Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim orderType As String = row.Cells("OrderType").Value.ToString()
            Dim totalAmount As Decimal

            If orderType = "Rent" Then
                Dim rentalPrice As Decimal = Convert.ToDecimal(row.Cells("RentalPrice").Value)
                totalAmount = rentalPrice * quantity
            Else
                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                totalAmount = price * quantity
            End If

            ' Open PlaceOrderOrRentalFurniture form and pass data
            Dim orderForm As New PlaceOrderOrRentalFurniture(furnitureID, quantity, orderType, totalAmount)
            orderForm.Show()

            ' Close the current cart form
            Me.Close()
        Else
            MessageBox.Show("Please select an item to proceed.")
        End If
    End Sub

    ' Calculate Total Amount
    Private Sub CalculateTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells("OrderType").Value IsNot Nothing Then
                Dim orderType As String = row.Cells("OrderType").Value.ToString()
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)

                If orderType = "Rent" Then
                    If row.Cells("RentalPrice").Value IsNot DBNull.Value Then
                        total += Convert.ToDecimal(row.Cells("RentalPrice").Value) * quantity
                    End If
                Else
                    If row.Cells("Price").Value IsNot DBNull.Value Then
                        total += Convert.ToDecimal(row.Cells("Price").Value) * quantity
                    End If
                End If
            End If
        Next
        lblTotalAmount.Text = "Total: ₹" & total.ToString("N2")
    End Sub

    ' Remove Selected Item from Cart
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvCart.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to remove.")
            Return
        End If

        Dim cartID As Integer = Convert.ToInt32(dgvCart.SelectedRows(0).Cells("CartID").Value)

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Cart WHERE CartID = @CartID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CartID", cartID)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MessageBox.Show("Item removed successfully!")
                    LoadCart()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error removing item: " & ex.Message)
        End Try
    End Sub

    ' Clear Entire Cart
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear your cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using con As New SqlConnection(connectionString)
                    Dim query As String = "DELETE FROM Cart WHERE UserID = @UserID"
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@UserID", LoggedInCustomerID)

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        MessageBox.Show("Cart cleared successfully!")
                        LoadCart()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error clearing cart: " & ex.Message)
            End Try
        End If
    End Sub
End Class
