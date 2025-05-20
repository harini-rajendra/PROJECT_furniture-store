Public Class AdminDashboard
    Private Sub btnManageFurnitureStock_Click(sender As Object, e As EventArgs) Handles btnManageFurnitureStock.Click
        Dim furnitureForm As New FurnitureManagement()
        furnitureForm.Show()
    End Sub

    Private Sub btnManageStaff_Click(sender As Object, e As EventArgs) Handles btnManageStaff.Click
        Dim staffForm As New StaffManagement()
        staffForm.Show()
    End Sub

    Private Sub btnManageCustomer_Click(sender As Object, e As EventArgs) Handles btnManageCustomer.Click
        Dim customerForm As New CustomerManagement()
        customerForm.Show()
    End Sub

    Private Sub btnViewOrderAndRental_Click(sender As Object, e As EventArgs) Handles btnViewOrderAndRental.Click
        Dim orderRentalForm As New ViewOrderAndRental()
        orderRentalForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close() ' Closes the admin dashboard
    End Sub
End Class

