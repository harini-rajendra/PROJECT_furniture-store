<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerOrderHistory
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
        dgvCustomerOrders = New DataGridView()
        txtUserID = New TextBox()
        lblUserID = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCustomerOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.e623a417_5e17_4c84_94c7_761f528b2578
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(899, 376)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(350, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 37)
        Label1.TabIndex = 1
        Label1.Text = "YOUR_ORDERS"
        ' 
        ' dgvCustomerOrders
        ' 
        dgvCustomerOrders.BackgroundColor = Color.Cornsilk
        dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomerOrders.Location = New Point(32, 163)
        dgvCustomerOrders.Name = "dgvCustomerOrders"
        dgvCustomerOrders.Size = New Size(819, 201)
        dgvCustomerOrders.TabIndex = 2
        ' 
        ' txtUserID
        ' 
        txtUserID.Location = New Point(468, 118)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(114, 23)
        txtUserID.TabIndex = 3
        ' 
        ' lblUserID
        ' 
        lblUserID.AutoSize = True
        lblUserID.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblUserID.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserID.Location = New Point(329, 117)
        lblUserID.Name = "lblUserID"
        lblUserID.Size = New Size(112, 20)
        lblUserID.TabIndex = 4
        lblUserID.Text = "CUSTOMER ID"
        ' 
        ' CustomerOrderHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(896, 376)
        Controls.Add(lblUserID)
        Controls.Add(txtUserID)
        Controls.Add(dgvCustomerOrders)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "CustomerOrderHistory"
        Text = "CustomerOrderHistory"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCustomerOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCustomerOrders As DataGridView
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblUserID As Label
End Class
