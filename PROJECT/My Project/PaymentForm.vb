Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient
Imports ZXing ' For QR Code Generation

Public Class PaymentForm
    Private TotalAmount As Decimal
    Private OrderID As Integer ' Order/Rental ID

    ' Constructor to receive total amount & Order/Rental ID
    Public Sub New(amount As Decimal, orderID As Integer)
        InitializeComponent()
        Me.TotalAmount = amount
        Me.OrderID = orderID
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display Total Amount and Order/Rental ID
        lblTotalAmount.Text = "Total Amount: ₹ " & TotalAmount.ToString("0.00")
        lblOrderID.Text = "Order ID: " & OrderID.ToString()

        ' Populate Payment Method ComboBox
        cmbPaymentMethod.Items.Clear()
        cmbPaymentMethod.Items.Add("Cash on Delivery (COD)")
        cmbPaymentMethod.Items.Add("Scan QR Code")
        cmbPaymentMethod.Items.Add("UPI ID")
        cmbPaymentMethod.Items.Add("Card Payment")

        ' Default Selection
        cmbPaymentMethod.SelectedIndex = 0 ' Default: COD

        ' Hide all payment-specific fields initially
        HidePaymentFields()
    End Sub

    ' Method to Hide All Payment Fields
    Private Sub HidePaymentFields()
        ' Hide Labels
        lblPaymentDetails.Visible = False
        lblExpiryDate.Visible = False
        lblCVV.Visible = False

        ' Hide Inputs
        txtPaymentDetails.Visible = False
        txtExpiryDate.Visible = False
        txtCVV.Visible = False
        btnGenerateQR.Visible = False
        picQRCode.Visible = False
    End Sub

    ' When Payment Method is Changed
    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        ' Hide all fields initially
        HidePaymentFields()

        Dim selectedMethod As String = cmbPaymentMethod.SelectedItem.ToString()

        ' Show relevant fields based on selection
        If selectedMethod = "Card Payment" Then
            lblPaymentDetails.Text = "Enter Card Number:"
            lblPaymentDetails.Visible = True
            txtPaymentDetails.Visible = True

            lblExpiryDate.Visible = True
            txtExpiryDate.Visible = True

            lblCVV.Visible = True
            txtCVV.Visible = True
        ElseIf selectedMethod = "UPI ID" Then
            lblPaymentDetails.Text = "Enter UPI ID:"
            lblPaymentDetails.Visible = True
            txtPaymentDetails.Visible = True
        ElseIf selectedMethod = "Scan QR Code" Then
            btnGenerateQR.Visible = True
        End If
    End Sub

    ' Validate & Process Payment
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim selectedMethod As String = cmbPaymentMethod.SelectedItem.ToString()

        ' Validate Card Payment
        If selectedMethod = "Card Payment" Then
            If txtPaymentDetails.Text.Length <> 16 OrElse Not IsNumeric(txtPaymentDetails.Text) Then
                MessageBox.Show("Invalid Card Number! Must be 16 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtExpiryDate.Text.Length <> 5 OrElse txtExpiryDate.Text(2) <> "/"c Then
                MessageBox.Show("Invalid Expiry Date! Format: MM/YY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If txtCVV.Text.Length <> 3 OrElse Not IsNumeric(txtCVV.Text) Then
                MessageBox.Show("Invalid CVV! Must be 3 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Validate UPI Payment
        If selectedMethod = "UPI ID" AndAlso txtPaymentDetails.Text.Trim() = "" Then
            MessageBox.Show("Please enter a valid UPI ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Process Payment
        MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    ' Generate QR Code for Payment
    Private Sub btnGenerateQR_Click(sender As Object, e As EventArgs) Handles btnGenerateQR.Click
        ' Set QR Code Image Path (Replace with actual file path)
        Dim qrCodeImagePath As String = "C:\Users\Admin\Pictures\FURNITURE\QRCODE.JPG"

        ' Check if file exists before loading
        If File.Exists(qrCodeImagePath) Then
            picQRCode.Image = Image.FromFile(qrCodeImagePath) ' Load QR Code Image
            picQRCode.Visible = True ' Show PictureBox
        Else
            MessageBox.Show("QR Code image not found! Please check the file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
