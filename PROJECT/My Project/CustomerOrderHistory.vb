Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CustomerOrderHistory
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"


    Private Sub CustomerOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = LoggedInCustomerID.ToString() ' Display UserID in label
        LoadOrderHistory()
    End Sub

    ' Function to Load Order History for Logged-in Customer
    Private Sub LoadOrderHistory()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT OrderID, FurnitureID, Quantity, TotalPrice, Status, OrderDate FROM Orders WHERE UserID = @UserID"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", LoggedInCustomerID) ' Ensure LoggedInCustomerID is set after login

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                dgvCustomerOrders.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading order history: " & ex.Message)
        End Try
    End Sub

    ' Refresh Order History

End Class