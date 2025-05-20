Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class StaffManagement
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    Private Sub StaffManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffData()
    End Sub

    ' Function to Load Staff Data into DataGridView
    Private Sub LoadStaffData()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT UserID, Username, Address, PhoneNo FROM Users WHERE role='Staff'"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                DataGridViewStaff.DataSource = dt

                ' Set Column Headers
                DataGridViewStaff.Columns("UserID").HeaderText = "ID"
                DataGridViewStaff.Columns("Username").HeaderText = "Username"
                DataGridViewStaff.Columns("Address").HeaderText = "Address"
                DataGridViewStaff.Columns("PhoneNo").HeaderText = "Phone No"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading staff data: " & ex.Message)
        End Try
    End Sub

    ' Function to Add New Staff
    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtAddress.Text = "" Or txtPhoneNo.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Users (Username, Password, Address, PhoneNo, Role) VALUES (@username, @password, @address, @phoneNo, 'Staff')"
                Dim cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text) ' Note: Store password securely in a real system
                cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@phoneNo", txtPhoneNo.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadStaffData()
                ClearFields()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding staff: " & ex.Message)
        End Try
    End Sub

    ' Function to Update Staff Details
    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        If txtUsername.Text = "" Or txtAddress.Text = "" Or txtPhoneNo.Text = "" Then
            MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Users SET Password=@password, Address=@address, PhoneNo=@phoneNo WHERE Username=@username AND Role='Staff'"
                Dim cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@phoneNo", txtPhoneNo.Text)

                con.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                con.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadStaffData()
                    ClearFields()
                Else
                    MessageBox.Show("Staff not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating staff: " & ex.Message)
        End Try
    End Sub

    ' Function to Delete Staff
    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Enter the Username to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Users WHERE Username=@username AND Role='Staff'"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)

                con.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                con.Close()

                If rowsAffected > 0 Then
                    MessageBox.Show("Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadStaffData()
                    ClearFields()
                Else
                    MessageBox.Show("Staff not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting staff: " & ex.Message)
        End Try
    End Sub

    ' Function to Clear Input Fields
    Private Sub ClearFields()
        txtUsername.Clear()
        txtPassword.Clear()
        txtAddress.Clear()
        txtPhoneNo.Clear()
    End Sub

    ' Event: When a Row in DataGridView is Clicked, Fill the Fields
    Private Sub DataGridViewStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStaff.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewStaff.Rows(e.RowIndex)
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtAddress.Text = row.Cells("Address").Value.ToString()
            txtPhoneNo.Text = row.Cells("PhoneNo").Value.ToString()
        End If
    End Sub
End Class