<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaceOrderOrRentalFurniture
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        lblOrderType = New Label()
        lblRentalDate = New Label()
        lblReturnDate = New Label()
        cmbOrderType = New ComboBox()
        dtpRentalDate = New DateTimePicker()
        dtpReturnDate = New DateTimePicker()
        btnConfirm = New Button()
        btnCancel = New Button()
        lblFurnitureID = New Label()
        lblQuantity = New Label()
        txtFurnitureID = New TextBox()
        numQuantity = New NumericUpDown()
        lblTotalAmount = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._9fa42090_b4f3_4922_8c80_9ccf71c3542f2
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(911, 397)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkGoldenrod
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(327, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 30)
        Label1.TabIndex = 1
        Label1.Text = "ORDER/RENTAL DETAILS"
        ' 
        ' lblOrderType
        ' 
        lblOrderType.AutoSize = True
        lblOrderType.BackColor = Color.DarkKhaki
        lblOrderType.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderType.Location = New Point(269, 86)
        lblOrderType.Name = "lblOrderType"
        lblOrderType.Size = New Size(168, 21)
        lblOrderType.TabIndex = 2
        lblOrderType.Text = "SELECT ORDER TYPE"
        ' 
        ' lblRentalDate
        ' 
        lblRentalDate.AutoSize = True
        lblRentalDate.BackColor = Color.RosyBrown
        lblRentalDate.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalDate.Location = New Point(477, 140)
        lblRentalDate.Name = "lblRentalDate"
        lblRentalDate.Size = New Size(121, 21)
        lblRentalDate.TabIndex = 3
        lblRentalDate.Text = "RENTAL DATE"
        ' 
        ' lblReturnDate
        ' 
        lblReturnDate.AutoSize = True
        lblReturnDate.BackColor = Color.RosyBrown
        lblReturnDate.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReturnDate.Location = New Point(477, 198)
        lblReturnDate.Name = "lblReturnDate"
        lblReturnDate.Size = New Size(123, 21)
        lblReturnDate.TabIndex = 4
        lblReturnDate.Text = "RETURN DATE"
        ' 
        ' cmbOrderType
        ' 
        cmbOrderType.FormattingEnabled = True
        cmbOrderType.Location = New Point(453, 88)
        cmbOrderType.Name = "cmbOrderType"
        cmbOrderType.Size = New Size(185, 23)
        cmbOrderType.TabIndex = 5
        ' 
        ' dtpRentalDate
        ' 
        dtpRentalDate.Location = New Point(627, 138)
        dtpRentalDate.Name = "dtpRentalDate"
        dtpRentalDate.Size = New Size(200, 23)
        dtpRentalDate.TabIndex = 6
        ' 
        ' dtpReturnDate
        ' 
        dtpReturnDate.Location = New Point(627, 196)
        dtpReturnDate.Name = "dtpReturnDate"
        dtpReturnDate.Size = New Size(200, 23)
        dtpReturnDate.TabIndex = 7
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.YellowGreen
        btnConfirm.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirm.Location = New Point(320, 259)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(239, 41)
        btnConfirm.TabIndex = 8
        btnConfirm.Text = "CONFIRM ORDER/RENTAL"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.HotTrack
        btnCancel.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(398, 318)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(89, 38)
        btnCancel.TabIndex = 9
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblFurnitureID
        ' 
        lblFurnitureID.AutoSize = True
        lblFurnitureID.BackColor = Color.Salmon
        lblFurnitureID.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFurnitureID.Location = New Point(48, 140)
        lblFurnitureID.Name = "lblFurnitureID"
        lblFurnitureID.Size = New Size(125, 21)
        lblFurnitureID.TabIndex = 10
        lblFurnitureID.Text = "FURNITURE ID"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.BackColor = Color.Salmon
        lblQuantity.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(78, 198)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(95, 21)
        lblQuantity.TabIndex = 11
        lblQuantity.Text = "QUANTITY"
        ' 
        ' txtFurnitureID
        ' 
        txtFurnitureID.Location = New Point(202, 142)
        txtFurnitureID.Name = "txtFurnitureID"
        txtFurnitureID.Size = New Size(185, 23)
        txtFurnitureID.TabIndex = 12
        ' 
        ' numQuantity
        ' 
        numQuantity.Location = New Point(202, 196)
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(93, 23)
        numQuantity.TabIndex = 13
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.Location = New Point(699, 247)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(62, 21)
        lblTotalAmount.TabIndex = 14
        lblTotalAmount.Text = "Label3"
        ' 
        ' PlaceOrderOrRentalFurniture
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(913, 397)
        Controls.Add(lblTotalAmount)
        Controls.Add(numQuantity)
        Controls.Add(txtFurnitureID)
        Controls.Add(lblQuantity)
        Controls.Add(lblFurnitureID)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(dtpReturnDate)
        Controls.Add(dtpRentalDate)
        Controls.Add(cmbOrderType)
        Controls.Add(lblReturnDate)
        Controls.Add(lblRentalDate)
        Controls.Add(lblOrderType)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "PlaceOrderOrRentalFurniture"
        Text = "PlaceOrderOrRentalFurniture"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOrderType As Label
    Friend WithEvents lblRentalDate As Label
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents cmbOrderType As ComboBox
    Friend WithEvents dtpRentalDate As DateTimePicker
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblFurnitureID As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtFurnitureID As TextBox
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents lblTotalAmount As Label
End Class
