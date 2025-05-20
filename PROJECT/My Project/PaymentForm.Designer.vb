<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblPaymentMethod = New Label()
        lblTotalAmount = New Label()
        lblOrderID = New Label()
        cmbPaymentMethod = New ComboBox()
        txtPaymentDetails = New TextBox()
        btnPay = New Button()
        btnCancel = New Button()
        btnGenerateQR = New Button()
        picQRCode = New PictureBox()
        txtCVV = New TextBox()
        Label1 = New Label()
        lblPaymentDetails = New Label()
        lblExpiryDate = New Label()
        lblCVV = New Label()
        txtExpiryDate = New MaskedTextBox()
        CType(picQRCode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentMethod.Location = New Point(113, 135)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(156, 20)
        lblPaymentMethod.TabIndex = 0
        lblPaymentMethod.Text = "PAYMENT METHOD"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.Location = New Point(400, 75)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(139, 20)
        lblTotalAmount.TabIndex = 1
        lblTotalAmount.Text = "AMOUNT TO PAY"
        ' 
        ' lblOrderID
        ' 
        lblOrderID.AutoSize = True
        lblOrderID.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderID.Location = New Point(114, 75)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(79, 20)
        lblOrderID.TabIndex = 2
        lblOrderID.Text = "ORDER ID"
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(322, 132)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(133, 23)
        cmbPaymentMethod.TabIndex = 3
        ' 
        ' txtPaymentDetails
        ' 
        txtPaymentDetails.Location = New Point(322, 176)
        txtPaymentDetails.Name = "txtPaymentDetails"
        txtPaymentDetails.Size = New Size(180, 23)
        txtPaymentDetails.TabIndex = 4
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = SystemColors.HotTrack
        btnPay.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPay.Location = New Point(202, 315)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(170, 45)
        btnPay.TabIndex = 5
        btnPay.Text = "CONFIRM PAYMENT"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.HotTrack
        btnCancel.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(460, 315)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(109, 45)
        btnCancel.TabIndex = 6
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnGenerateQR
        ' 
        btnGenerateQR.BackColor = SystemColors.HotTrack
        btnGenerateQR.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerateQR.Location = New Point(725, 251)
        btnGenerateQR.Name = "btnGenerateQR"
        btnGenerateQR.Size = New Size(174, 45)
        btnGenerateQR.TabIndex = 7
        btnGenerateQR.Text = "GENERATE QR CODE"
        btnGenerateQR.UseVisualStyleBackColor = False
        ' 
        ' picQRCode
        ' 
        picQRCode.Image = My.Resources.Resources.ab0b2367_ed20_47f2_9529_d628c66dac0b
        picQRCode.Location = New Point(725, 89)
        picQRCode.Name = "picQRCode"
        picQRCode.Size = New Size(168, 144)
        picQRCode.SizeMode = PictureBoxSizeMode.StretchImage
        picQRCode.TabIndex = 8
        picQRCode.TabStop = False
        ' 
        ' txtCVV
        ' 
        txtCVV.Location = New Point(322, 251)
        txtCVV.Name = "txtCVV"
        txtCVV.Size = New Size(121, 23)
        txtCVV.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(381, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 30)
        Label1.TabIndex = 11
        Label1.Text = "PAYMENT FORM"
        ' 
        ' lblPaymentDetails
        ' 
        lblPaymentDetails.AutoSize = True
        lblPaymentDetails.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentDetails.Location = New Point(114, 175)
        lblPaymentDetails.Name = "lblPaymentDetails"
        lblPaymentDetails.Size = New Size(155, 20)
        lblPaymentDetails.TabIndex = 12
        lblPaymentDetails.Text = "ENTER CARD/UPI ID"
        ' 
        ' lblExpiryDate
        ' 
        lblExpiryDate.AutoSize = True
        lblExpiryDate.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExpiryDate.Location = New Point(162, 213)
        lblExpiryDate.Name = "lblExpiryDate"
        lblExpiryDate.Size = New Size(107, 20)
        lblExpiryDate.TabIndex = 13
        lblExpiryDate.Text = "EXPIRY DATE"
        ' 
        ' lblCVV
        ' 
        lblCVV.AutoSize = True
        lblCVV.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCVV.Location = New Point(213, 246)
        lblCVV.Name = "lblCVV"
        lblCVV.Size = New Size(40, 20)
        lblCVV.TabIndex = 14
        lblCVV.Text = "CVV"
        ' 
        ' txtExpiryDate
        ' 
        txtExpiryDate.Location = New Point(322, 214)
        txtExpiryDate.Name = "txtExpiryDate"
        txtExpiryDate.Size = New Size(100, 23)
        txtExpiryDate.TabIndex = 15
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 412)
        Controls.Add(txtExpiryDate)
        Controls.Add(lblCVV)
        Controls.Add(lblExpiryDate)
        Controls.Add(lblPaymentDetails)
        Controls.Add(Label1)
        Controls.Add(txtCVV)
        Controls.Add(picQRCode)
        Controls.Add(btnGenerateQR)
        Controls.Add(btnCancel)
        Controls.Add(btnPay)
        Controls.Add(txtPaymentDetails)
        Controls.Add(cmbPaymentMethod)
        Controls.Add(lblOrderID)
        Controls.Add(lblTotalAmount)
        Controls.Add(lblPaymentMethod)
        Name = "PaymentForm"
        Text = "PaymentForm"
        CType(picQRCode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents txtPaymentDetails As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnGenerateQR As Button
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPaymentDetails As Label
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents lblCVV As Label
    Friend WithEvents txtExpiryDate As MaskedTextBox
End Class
