Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ViewOrderAndRental
    ' Database connection string
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True;Trust Server Certificate=True"

    Private Sub ViewOrderAndRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the View Filter ComboBox
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("Orders")
        cmbFilter.Items.Add("Rentals")

        ' Populate the Status ComboBox
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Processing")
        cmbStatus.Items.Add("Completed")
        cmbStatus.Items.Add("Cancelled")

        ' Set default selections
        If cmbFilter.Items.Count > 0 Then
            cmbFilter.SelectedIndex = 0 ' Default to "Orders"
            LoadData("Orders")
        End If

        If cmbStatus.Items.Count > 0 Then
            cmbStatus.SelectedIndex = 0 ' Default to "Pending"
        End If
    End Sub


    ' Load Data Based on Selection (Orders or Rentals)
    Private Sub LoadData(tableName As String)
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = ""

                If tableName = "Orders" Then
                    query = "SELECT OrderID AS ID, UserID, FurnitureID, Quantity, OrderDate, Status FROM Orders"
                ElseIf tableName = "Rentals" Then
                    query = "SELECT RentalID AS ID, UserID, FurnitureID, Quantity, RentalDate, ReturnDate, Status FROM Rentals"
                End If

                Using cmd As New SqlCommand(query, con)
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        con.Open()
                        adapter.Fill(dt)
                        con.Close()

                        dgvOrdersRentals.DataSource = dt
                        dgvOrdersRentals.ClearSelection()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' When Filter (Orders/Rentals) is Changed
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        If cmbFilter.SelectedItem IsNot Nothing Then
            LoadData(cmbFilter.SelectedItem.ToString())
        End If
    End Sub

    ' When a Row in DataGridView is Clicked, Fill Order/Rental ID
    Private Sub dgvOrdersRentals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdersRentals.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvOrdersRentals.Rows(e.RowIndex)

            ' Ensure the row has enough columns
            If row.Cells.Count >= 6 Then
                txtOrderRentalID.Text = row.Cells(0).Value.ToString() ' Fetch Order/Rental ID
                cmbStatus.SelectedItem = row.Cells(5).Value.ToString() ' Fetch Status
            End If
        End If
    End Sub

    ' Update Order/Rental Status
    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If txtOrderRentalID.Text = "" Then
            MessageBox.Show("Please select an order or rental to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a valid status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim tableName As String = If(cmbFilter.SelectedItem.ToString() = "Orders", "Orders", "Rentals")
                Dim idColumn As String = If(tableName = "Orders", "OrderID", "RentalID")

                Dim query As String = $"UPDATE {tableName} SET Status=@status WHERE {idColumn}=@id"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@id", txtOrderRentalID.Text)

                    con.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    con.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadData(tableName) ' Refresh DataGridView
                    Else
                        MessageBox.Show("Failed to update status. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Refresh Data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If cmbFilter.SelectedItem IsNot Nothing Then
            LoadData(cmbFilter.SelectedItem.ToString())
        End If
    End Sub

    ' Close the Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class