Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CustomerManagement
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    ' Load all customers when the form loads
    Private Sub CustomerManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    ' Function to Load Customers from Users table where Role = 'Customer'
    Private Sub LoadCustomers()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT UserID, Username, PhoneNo, Address FROM Users WHERE Role = 'Customer'"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                dgvCustomers.DataSource = dt ' Fixed DataGridView name
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to Search Customers by ID or Username
    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        If txtSearchCustomer.Text = "" Then
            MessageBox.Show("Please enter Customer ID or Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT UserID, Username, PhoneNo, Address FROM Users WHERE Role = 'Customer' AND (UserID = @search OR Username LIKE '%' + @search + '%')"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@search", txtSearchCustomer.Text)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                If dt.Rows.Count > 0 Then
                    dgvCustomers.DataSource = dt
                Else
                    MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    dgvCustomers.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to Delete Customer
    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If txtSearchCustomer.Text = "" Then
            MessageBox.Show("Please enter a Customer ID to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Users WHERE UserID = @UserID AND Role = 'Customer'"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", txtSearchCustomer.Text)

                con.Open()
                Dim result As Integer = cmd.ExecuteNonQuery()
                con.Close()

                If result > 0 Then
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadCustomers() ' Refresh list after deletion
                Else
                    MessageBox.Show("Customer not found or cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Refresh Customer List
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadCustomers()
    End Sub
End Class