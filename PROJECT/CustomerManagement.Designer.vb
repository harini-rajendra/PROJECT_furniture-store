<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerManagement
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
        txtSearchCustomer = New TextBox()
        dgvCustomers = New DataGridView()
        btnDeleteCustomer = New Button()
        btnRefresh = New Button()
        Label1 = New Label()
        btnSearchCustomer = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._0979c136_c2ac_4649_a3c4_ad4f04924e09
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(921, 399)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtSearchCustomer
        ' 
        txtSearchCustomer.Location = New Point(447, 79)
        txtSearchCustomer.Name = "txtSearchCustomer"
        txtSearchCustomer.Size = New Size(206, 23)
        txtSearchCustomer.TabIndex = 2
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.BackgroundColor = Color.Tan
        dgvCustomers.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.GridColor = SystemColors.MenuText
        dgvCustomers.Location = New Point(58, 250)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.Size = New Size(795, 132)
        dgvCustomers.TabIndex = 3
        ' 
        ' btnDeleteCustomer
        ' 
        btnDeleteCustomer.BackColor = Color.IndianRed
        btnDeleteCustomer.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteCustomer.ImageAlign = ContentAlignment.MiddleRight
        btnDeleteCustomer.Location = New Point(277, 144)
        btnDeleteCustomer.Name = "btnDeleteCustomer"
        btnDeleteCustomer.Size = New Size(194, 37)
        btnDeleteCustomer.TabIndex = 4
        btnDeleteCustomer.Text = "DELETE CUSTOMER"
        btnDeleteCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.IndianRed
        btnRefresh.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(494, 144)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 39)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(311, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 30)
        Label1.TabIndex = 6
        Label1.Text = "CUSTOMER MANAGEMENT"
        ' 
        ' btnSearchCustomer
        ' 
        btnSearchCustomer.BackColor = Color.Indigo
        btnSearchCustomer.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchCustomer.ForeColor = Color.Cornsilk
        btnSearchCustomer.Location = New Point(277, 79)
        btnSearchCustomer.Name = "btnSearchCustomer"
        btnSearchCustomer.Size = New Size(164, 33)
        btnSearchCustomer.TabIndex = 7
        btnSearchCustomer.Text = "SEARCH CUSTOMER"
        btnSearchCustomer.UseVisualStyleBackColor = False
        ' 
        ' CustomerManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 394)
        Controls.Add(btnSearchCustomer)
        Controls.Add(Label1)
        Controls.Add(btnRefresh)
        Controls.Add(btnDeleteCustomer)
        Controls.Add(dgvCustomers)
        Controls.Add(txtSearchCustomer)
        Controls.Add(PictureBox1)
        Name = "CustomerManagement"
        Text = "CustomerManagement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchCustomer As Button
End Class
