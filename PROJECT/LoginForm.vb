Imports Microsoft.Data.SqlClient

Public Class LoginForm
    ' 🔹 Variable to track password visibility
    Private isPasswordVisible As Boolean = False

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim form2 As New RegistrationForm()
        Me.Hide()
        RegistrationForm.Show()
    End Sub

    ' 🔹 Step 1: Define the connection string
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 🔹 Step 2: Create a SqlConnection object
        Dim connection As New SqlConnection(connectionString)

        ' 🔹 Step 3: Define SQL Query to retrieve UserID and Role
        Dim query As String = "SELECT UserID, Role FROM Users WHERE Username = @username AND Password = @password"

        ' 🔹 Step 4: Create a SqlCommand and associate it with the connection
        Dim cmd As New SqlCommand(query, connection)

        ' 🔹 Step 5: Add parameters
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)

        Try
            ' 🔹 Step 6: Open the connection before executing the command
            connection.Open()

            ' 🔹 Step 7: Execute the query
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' 🔹 Step 8: Process the result
            If reader.Read() Then
                Dim userID As Integer = Convert.ToInt32(reader("UserID"))
                Dim role As String = reader("Role").ToString()

                ' 🔹 Assign userID to a global variable for tracking logged-in customer
                LoggedInCustomerID = userID

                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 🔹 Redirect based on role
                If role = "ADMIN" Then
                    AdminDashboard.Show()
                ElseIf role = "Staff" Then
                    StaffDahboard_UI.Show()
                ElseIf role = "Customer" Then
                    CustomerDashboard.Show()
                End If

                Me.Hide() ' Hide login form after successful login

            Else
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' 🔹 Step 9: Close the reader and connection
            reader.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 🔹 Function to toggle password visibility when eye button is clicked
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TogglePasswordVisibility()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowHidePassword.Click
        TogglePasswordVisibility()
    End Sub

    ' 🔹 Function to Toggle Password Visibility and Change Icon
    Private Sub TogglePasswordVisibility()
        ' Toggle password visibility
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
    End Sub

    ' Call this function when the button is clicked
    Private Sub btnShowHidePassword_Click(sender As Object, e As EventArgs) Handles btnShowHidePassword.Click, btnShowHidePassword.Click
        TogglePasswordVisibility()
    End Sub


    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ' Ensure password characters are hidden initially
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class
