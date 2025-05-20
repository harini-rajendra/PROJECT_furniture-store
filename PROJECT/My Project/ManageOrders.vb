Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ManageOrders
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    Private Sub frmManageOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrdersData()
        HideOrderDetails() ' Initially Hide Fields
    End Sub

    ' ✅ Load Orders into DataGridView
    Private Sub LoadOrdersData()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT O.OrderID, U.Username, O.OrderDate, O.Status 
                                       FROM Orders O 
                                       INNER JOIN Users U ON O.UserID = U.UserID"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                dgvOrders.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading orders data: " & ex.Message)
        End Try
    End Sub

    ' ✅ When a Row in DataGridView is Clicked, Fill the Fields
    Private Sub dgvOrders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvOrders.Rows(e.RowIndex)

            ' Populate Order ID and Customer Name
            txtOrderID.Text = row.Cells("OrderID").Value.ToString()
            lblCustomerName.Text = row.Cells("Username").Value.ToString()

            ' Set Default Status in ComboBox
            cmbOrderStatus.Items.Clear()
            Dim currentStatus As String = row.Cells("Status").Value.ToString()

            ' If the order is completed, only show "Completed"
            If currentStatus = "Completed" Then
                cmbOrderStatus.Items.Add("Completed")
                cmbOrderStatus.SelectedIndex = 0
                cmbOrderStatus.Enabled = False
            Else
                cmbOrderStatus.Items.Add(currentStatus) ' Set Current Status
                cmbOrderStatus.SelectedItem = currentStatus

                ' Add Other Status Options
                If currentStatus = "Pending" Then
                    cmbOrderStatus.Items.Add("Shipped")
                    cmbOrderStatus.Items.Add("Delivered")
                    cmbOrderStatus.Items.Add("Cancelled")
                ElseIf currentStatus = "Shipped" Then
                    cmbOrderStatus.Items.Add("Delivered")
                    cmbOrderStatus.Items.Add("Cancelled")
                ElseIf currentStatus = "Cancelled" Then
                    cmbOrderStatus.Items.Add("Reordered")
                End If

                cmbOrderStatus.Enabled = True
            End If

            ' Show Order Details
            ShowOrderDetails()
        End If
    End Sub

    ' ✅ Update Order Status
    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        If txtOrderID.Text = "" Or cmbOrderStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an order and status!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "UPDATE Orders SET Status=@status WHERE OrderID=@orderID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@status", cmbOrderStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text)
                    cmd.ExecuteNonQuery()
                End Using
                con.Close()
            End Using

            MessageBox.Show("Order status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadOrdersData()
            HideOrderDetails()
        Catch ex As Exception
            MessageBox.Show("Error updating order: " & ex.Message)
        End Try
    End Sub

    ' ✅ Hide Order Details
    Private Sub HideOrderDetails()
        txtOrderID.Clear()
        lblCustomerName.Text = ""
        cmbOrderStatus.Items.Clear()
        cmbOrderStatus.SelectedIndex = -1

        ' Hide Controls
        lblCustomerName.Visible = False
        txtOrderID.Visible = False
        cmbOrderStatus.Visible = False
        btnUpdateStatus.Visible = False
    End Sub

    ' ✅ Show Order Details
    Private Sub ShowOrderDetails()
        lblCustomerName.Visible = True
        txtOrderID.Visible = True
        cmbOrderStatus.Visible = True
        btnUpdateStatus.Visible = True
    End Sub

    ' ✅ Cancel Order Update
    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        HideOrderDetails()
    End Sub
End Class