Public Class StaffDahboard_UI
    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        ManageOrders.Show()
    End Sub

    Private Sub btnManageRentals_Click(sender As Object, e As EventArgs) Handles btnManageRentals.Click
        ManageRentals.Show()
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        ViewOrderAndRental.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim confirmLogout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmLogout = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class