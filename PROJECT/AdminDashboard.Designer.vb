<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        btnManageFurnitureStock = New Button()
        btnManageStaff = New Button()
        btnManageCustomer = New Button()
        btnViewOrderAndRental = New Button()
        btnLogout = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._88bbc1c6_72bb_4f6d_b22d_9509ca056557
        PictureBox1.Location = New Point(-4, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(914, 403)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Aqua
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.InactiveCaptionText
        Label1.Location = New Point(338, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 30)
        Label1.TabIndex = 1
        Label1.Text = "ADMIN DASHBOARD"
        ' 
        ' btnManageFurnitureStock
        ' 
        btnManageFurnitureStock.BackColor = Color.MediumSlateBlue
        btnManageFurnitureStock.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageFurnitureStock.ForeColor = SystemColors.ActiveCaptionText
        btnManageFurnitureStock.Location = New Point(199, 150)
        btnManageFurnitureStock.Name = "btnManageFurnitureStock"
        btnManageFurnitureStock.Size = New Size(247, 39)
        btnManageFurnitureStock.TabIndex = 2
        btnManageFurnitureStock.Text = "MANAGE FURNITURE STOCK"
        btnManageFurnitureStock.UseVisualStyleBackColor = False
        ' 
        ' btnManageStaff
        ' 
        btnManageStaff.BackColor = Color.MediumSlateBlue
        btnManageStaff.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageStaff.Location = New Point(474, 82)
        btnManageStaff.Name = "btnManageStaff"
        btnManageStaff.Size = New Size(231, 39)
        btnManageStaff.TabIndex = 3
        btnManageStaff.Text = "MANAGE STAFF"
        btnManageStaff.UseVisualStyleBackColor = False
        ' 
        ' btnManageCustomer
        ' 
        btnManageCustomer.BackColor = Color.MediumSlateBlue
        btnManageCustomer.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageCustomer.Location = New Point(199, 81)
        btnManageCustomer.Name = "btnManageCustomer"
        btnManageCustomer.Size = New Size(247, 40)
        btnManageCustomer.TabIndex = 4
        btnManageCustomer.Text = "MANAGE CUSTOMER"
        btnManageCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnViewOrderAndRental
        ' 
        btnViewOrderAndRental.BackColor = Color.MediumSlateBlue
        btnViewOrderAndRental.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewOrderAndRental.Location = New Point(474, 150)
        btnViewOrderAndRental.Name = "btnViewOrderAndRental"
        btnViewOrderAndRental.Size = New Size(231, 40)
        btnViewOrderAndRental.TabIndex = 5
        btnViewOrderAndRental.Text = "VIEW ORDER AND RENTAL"
        btnViewOrderAndRental.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.DeepSkyBlue
        btnLogout.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(388, 234)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(111, 41)
        btnLogout.TabIndex = 6
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(909, 400)
        Controls.Add(btnLogout)
        Controls.Add(btnViewOrderAndRental)
        Controls.Add(btnManageCustomer)
        Controls.Add(btnManageStaff)
        Controls.Add(btnManageFurnitureStock)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "AdminDashboard"
        StartPosition = FormStartPosition.Manual
        Text = "AdminDashboard"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnManageFurnitureStock As Button
    Friend WithEvents btnManageStaff As Button
    Friend WithEvents btnManageCustomer As Button
    Friend WithEvents btnViewOrderAndRental As Button
    Friend WithEvents btnLogout As Button
End Class
