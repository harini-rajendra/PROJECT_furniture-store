<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageOrders
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
        lblCustomerName = New Label()
        Label3 = New Label()
        cmbOrderStatus = New ComboBox()
        btnUpdateStatus = New Button()
        dgvOrders = New DataGridView()
        txtOrderID = New TextBox()
        btnCancel = New Button()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._5dd09db7_dca1_4225_8646_41448c5fd1a9
        PictureBox1.Location = New Point(3, -11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(902, 384)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkBlue
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(152, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 30)
        Label1.TabIndex = 1
        Label1.Text = "OrderID"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.BackColor = SystemColors.ControlLight
        lblCustomerName.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerName.Location = New Point(152, 65)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(80, 30)
        lblCustomerName.TabIndex = 2
        lblCustomerName.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Navy
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(406, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 3
        Label3.Text = "STATUS"
        ' 
        ' cmbOrderStatus
        ' 
        cmbOrderStatus.BackColor = Color.AliceBlue
        cmbOrderStatus.FormattingEnabled = True
        cmbOrderStatus.Location = New Point(511, 110)
        cmbOrderStatus.Name = "cmbOrderStatus"
        cmbOrderStatus.Size = New Size(133, 23)
        cmbOrderStatus.TabIndex = 4
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.BackColor = SystemColors.HotTrack
        btnUpdateStatus.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateStatus.ForeColor = Color.FloralWhite
        btnUpdateStatus.Location = New Point(658, 134)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(172, 34)
        btnUpdateStatus.TabIndex = 5
        btnUpdateStatus.Text = "UPDATE STATUS"
        btnUpdateStatus.UseVisualStyleBackColor = False
        ' 
        ' dgvOrders
        ' 
        dgvOrders.BackgroundColor = Color.Cornsilk
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrders.Location = New Point(51, 223)
        dgvOrders.Name = "dgvOrders"
        dgvOrders.Size = New Size(801, 150)
        dgvOrders.TabIndex = 6
        ' 
        ' txtOrderID
        ' 
        txtOrderID.BackColor = Color.AliceBlue
        txtOrderID.Location = New Point(264, 111)
        txtOrderID.Name = "txtOrderID"
        txtOrderID.Size = New Size(125, 23)
        txtOrderID.TabIndex = 7
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.HotTrack
        btnCancel.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Cornsilk
        btnCancel.Location = New Point(659, 174)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(171, 32)
        btnCancel.TabIndex = 8
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label4.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(349, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 30)
        Label4.TabIndex = 9
        Label4.Text = "MANAGE ORDER"
        ' 
        ' ManageOrders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 374)
        Controls.Add(Label4)
        Controls.Add(btnCancel)
        Controls.Add(txtOrderID)
        Controls.Add(dgvOrders)
        Controls.Add(btnUpdateStatus)
        Controls.Add(cmbOrderStatus)
        Controls.Add(Label3)
        Controls.Add(lblCustomerName)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "ManageOrders"
        Text = "ManageOrders"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbOrderStatus As ComboBox
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
End Class
