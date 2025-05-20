
Public Class CustomerDashboard
    Private Sub btnBrowseFurniture_Click(sender As Object, e As EventArgs) Handles btnBrowseFurniture.Click
        BrowseFurniture.Show()
    End Sub

    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        VIEWCART.Show()
    End Sub

    Private Sub btnTrackOrderRental_Click(sender As Object, e As EventArgs) Handles btnTrackOrderRental.Click
        TrackOrderAndRental.Show()
    End Sub

    Private Sub btnOrderHistory_Click(sender As Object, e As EventArgs) Handles btnOrderHistory.Click
        CustomerOrderHistory.Show()
    End Sub

    Private Sub btnRentalHistory_Click(sender As Object, e As EventArgs) Handles btnRentalHistory.Click
        CustomerRentalHistory.Show()
    End Sub



    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirmLogout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmLogout = DialogResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class