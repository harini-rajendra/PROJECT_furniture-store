Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class TrackOrderAndRental
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    ' Load all orders and rentals when the form loads
    Private Sub TrackOrderAndRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllOrdersAndRentals()
    End Sub

    ' Function to Load All Orders and Rentals
    Private Sub LoadAllOrdersAndRentals()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT O.OrderID AS ID, U.Username, 'Order' AS OrderType, 
                                              O.Status, O.OrderDate, NULL AS RentalDate, NULL AS ReturnDate
                                       FROM Orders O
                                       INNER JOIN Users U ON O.UserID = U.UserID
                                       UNION ALL
                                       SELECT R.RentalID AS ID, U.Username, 'Rent' AS OrderType, 
                                              R.Status, NULL AS OrderDate, R.RentalDate, R.ReturnDate
                                       FROM Rentals R
                                       INNER JOIN Users U ON R.UserID = U.UserID"

                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                dgvOrders.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading orders and rentals: " & ex.Message)
        End Try
    End Sub

    ' Search Order/Rental by ID
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtOrderID.Text = "" Then
            MessageBox.Show("Please enter an Order/Rental ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT O.OrderID AS ID, U.Username, 'Order' AS OrderType, 
                                              O.Status, O.OrderDate, NULL AS RentalDate, NULL AS ReturnDate
                                       FROM Orders O
                                       INNER JOIN Users U ON O.UserID = U.UserID
                                       WHERE O.OrderID = @orderID
                                       UNION ALL
                                       SELECT R.RentalID AS ID, U.Username, 'Rent' AS OrderType, 
                                              R.Status, NULL AS OrderDate, R.RentalDate, R.ReturnDate
                                       FROM Rentals R
                                       INNER JOIN Users U ON R.UserID = U.UserID
                                       WHERE R.RentalID = @orderID"

                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                If dt.Rows.Count > 0 Then
                    dgvOrders.DataSource = dt
                Else
                    MessageBox.Show("No order or rental found with the given ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgvOrders.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching order/rental: " & ex.Message)
        End Try
    End Sub

    ' Refresh Button - Load all orders and rentals again
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtOrderID.Clear()
        LoadAllOrdersAndRentals()
    End Sub
End Class
