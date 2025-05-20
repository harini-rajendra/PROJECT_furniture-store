Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class RegistrationForm
    ' Change this connection string according to your SQL Server configuration
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate = True"

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Get user input
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim phoneno As String = txtPhoneno.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        ' Validate input
        If username = "" Or password = "" Or phoneno = "" Or address = "" Or email = "" Then
            MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 🔹 Validate Phone Number (Must be exactly 10 digits)
        If Not IsNumeric(phoneno) OrElse phoneno.Length <> 10 Then
            MessageBox.Show("Phone Number must be exactly 10 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 🔹 Validate Email (Must end with @gmail.com)
        If Not email.EndsWith("@gmail.com") Then
            MessageBox.Show("Email must be in the format 'example@gmail.com'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Encrypt Password (Optional)
        Dim encryptedPassword As String = password ' You can hash this for security

        ' Insert into database
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO users (FullName, Username, Password, Role, phoneno, address) VALUES (@FullName, @Username, @Password, 'Customer', @PhoneNo, @Address)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FullName", email) ' Storing email in FullName column
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", encryptedPassword)
                    cmd.Parameters.AddWithValue("@PhoneNo", phoneno)
                    cmd.Parameters.AddWithValue("@Address", address)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear textboxes
                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtPhoneno.Clear()
                    txtAddress.Clear()
                    txtEmail.Clear()
                End Using
            End Using
        Catch ex As SqlException When ex.Number = 2627 ' Unique constraint error for Username
            MessageBox.Show("Username already exists! Choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button to go back to Login Form
    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        Me.Hide()
        LoginForm.Show() ' Assuming LoginForm is the Login Form
    End Sub
End Class
