Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CustomerRentalHistory
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    Private Sub CustomerRentalHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerRentalHistory()
    End Sub

    ' Function to Load Rental History for Logged-in Customer
    Private Sub LoadCustomerRentalHistory()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT RentalID, FurnitureID, RentalDate, ReturnDate, Status FROM Rentals WHERE UserID = @UserID"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", LoggedInCustomerID) ' Fetch logged-in user's rental history

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                dgvRentalHistory.DataSource = dt
                dgvRentalHistory.Columns("RentalID").HeaderText = "Rental ID"
                dgvRentalHistory.Columns("FurnitureID").HeaderText = "Furniture"
                dgvRentalHistory.Columns("RentalDate").HeaderText = "Rental Date"
                dgvRentalHistory.Columns("ReturnDate").HeaderText = "Return Date"
                dgvRentalHistory.Columns("Status").HeaderText = "Status"

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading rental history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event: When a row is selected, show details in TextBoxes
    Private Sub dgvRentalHistory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentalHistory.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRentalHistory.Rows(e.RowIndex)
            txtRentalID.Text = row.Cells("RentalID").Value.ToString()
            txtRentalDate.Text = row.Cells("RentalDate").Value.ToString()
            txtReturnDate.Text = row.Cells("ReturnDate").Value.ToString()
            txtStatus.Text = row.Cells("Status").Value.ToString()
        End If
    End Sub
End Class
