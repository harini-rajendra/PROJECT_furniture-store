Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ManageRentals
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    Private Sub ManageRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load rental data when the form is loaded
        LoadRentalData()
    End Sub

    ' Function to Load Rental Data into DataGridView
    Private Sub LoadRentalData()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT RentalID, RentalDate, ReturnDate, Status FROM Rentals"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                dgvRentals.DataSource = dt

                ' Set column headers
                dgvRentals.Columns("RentalID").HeaderText = "Rental ID"
                dgvRentals.Columns("RentalDate").HeaderText = "Rental Date"
                dgvRentals.Columns("ReturnDate").HeaderText = "Return Date"
                dgvRentals.Columns("Status").HeaderText = "Status"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading rental data: " & ex.Message)
        End Try
    End Sub

    ' Function to Fetch Username for Selected Rental
    Private Sub FetchUsernameForRental(rentalID As String)
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT U.Username FROM Rentals R INNER JOIN Users U ON R.UserID = U.UserID WHERE R.RentalID = @rentalID"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@rentalID", rentalID)

                con.Open()
                Dim result As Object = cmd.ExecuteScalar()
                con.Close()

                ' If a username is found, set it to label2
                If result IsNot Nothing Then
                    Label2.Text = result.ToString()
                Else
                    Label2.Text = "N/A"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching username: " & ex.Message)
        End Try
    End Sub

    ' Event: When a Row in DataGridView is Clicked, Fill the Fields
    Private Sub dgvRentals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentals.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRentals.Rows(e.RowIndex)

            ' Set the Rental ID in the text box (not in label)
            txtRentalID.Text = row.Cells("RentalID").Value.ToString()

            ' Set Rental and Return Dates
            dtpRentalDate.Value = Convert.ToDateTime(row.Cells("RentalDate").Value)
            dtpReturnDate.Value = Convert.ToDateTime(row.Cells("ReturnDate").Value)

            ' Fetch and display Username
            FetchUsernameForRental(txtRentalID.Text)

            ' Set Status ComboBox
            Dim rentalStatus As String = row.Cells("Status").Value.ToString()
            UpdateStatusComboBox(rentalStatus)
        End If
    End Sub

    ' Function to Update Rental Status
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtRentalID.Text = "" Or cmbRentalStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a rental and status to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Rentals SET Status=@status, RentalDate=@rentalDate, ReturnDate=@returnDate WHERE RentalID=@rentalID"
                Dim cmd As New SqlCommand(query, con)

                ' Update rental details
                cmd.Parameters.AddWithValue("@rentalID", txtRentalID.Text)
                cmd.Parameters.AddWithValue("@status", cmbRentalStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@rentalDate", dtpRentalDate.Value)
                cmd.Parameters.AddWithValue("@returnDate", dtpReturnDate.Value)

                con.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                con.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("Rental updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadRentalData()  ' Reload the data to reflect changes
                Else
                    MessageBox.Show("Rental not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating rental: " & ex.Message)
        End Try
    End Sub

    ' Function to Handle Cancel Button Click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearFields()
    End Sub

    ' Function to Clear Input Fields
    Private Sub ClearFields()
        txtRentalID.Clear()
        UpdateStatusComboBox("Pending") ' Reset ComboBox
        dtpRentalDate.Value = DateTime.Now
        dtpReturnDate.Value = DateTime.Now
        Label2.Text = "N/A"
    End Sub

    ' Function to Set the ComboBox Options Based on Status
    Private Sub UpdateStatusComboBox(currentStatus As String)
        cmbRentalStatus.Items.Clear()

        If currentStatus = "Completed" Then
            ' If status is completed, only show "Completed"
            cmbRentalStatus.Items.Add("Completed")
            cmbRentalStatus.SelectedIndex = 0
            cmbRentalStatus.Enabled = False ' Disable ComboBox
        Else
            ' Otherwise, show all options
            cmbRentalStatus.Items.Add("Pending")
            cmbRentalStatus.Items.Add("Approved")
            cmbRentalStatus.Items.Add("Rejected")

            cmbRentalStatus.SelectedItem = currentStatus
            cmbRentalStatus.Enabled = True ' Enable ComboBox
        End If
    End Sub
End Class
