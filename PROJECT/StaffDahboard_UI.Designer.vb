<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffDahboard_UI
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
        lblStaffDashboard = New Label()
        PictureBox3 = New PictureBox()
        btnManageOrders = New Button()
        btnManageRentals = New Button()
        btnViewOrders = New Button()
        btnLogOut = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStaffDashboard
        ' 
        lblStaffDashboard.AutoSize = True
        lblStaffDashboard.BackColor = Color.BurlyWood
        lblStaffDashboard.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaffDashboard.Location = New Point(340, 45)
        lblStaffDashboard.Name = "lblStaffDashboard"
        lblStaffDashboard.Size = New Size(220, 30)
        lblStaffDashboard.TabIndex = 2
        lblStaffDashboard.Text = "STAFF DASHBOARD"
        lblStaffDashboard.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._338289bb_f3c1_4e48_9978_7186e7839849
        PictureBox3.Location = New Point(-4, -6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(926, 424)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' btnManageOrders
        ' 
        btnManageOrders.BackColor = Color.LightSalmon
        btnManageOrders.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageOrders.Location = New Point(116, 160)
        btnManageOrders.Name = "btnManageOrders"
        btnManageOrders.Size = New Size(166, 41)
        btnManageOrders.TabIndex = 5
        btnManageOrders.Text = "MANAGE ORDER"
        btnManageOrders.UseVisualStyleBackColor = False
        ' 
        ' btnManageRentals
        ' 
        btnManageRentals.BackColor = Color.LightSalmon
        btnManageRentals.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageRentals.Location = New Point(373, 160)
        btnManageRentals.Name = "btnManageRentals"
        btnManageRentals.Size = New Size(175, 41)
        btnManageRentals.TabIndex = 6
        btnManageRentals.Text = "MANAGE RENTAL"
        btnManageRentals.UseVisualStyleBackColor = False
        ' 
        ' btnViewOrders
        ' 
        btnViewOrders.BackColor = Color.LightSalmon
        btnViewOrders.FlatStyle = FlatStyle.Flat
        btnViewOrders.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewOrders.Location = New Point(622, 160)
        btnViewOrders.Name = "btnViewOrders"
        btnViewOrders.Size = New Size(216, 41)
        btnViewOrders.TabIndex = 7
        btnViewOrders.Text = "VIEW FURNITURE STOCK"
        btnViewOrders.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.DeepSkyBlue
        btnLogOut.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.Location = New Point(406, 268)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(104, 36)
        btnLogOut.TabIndex = 8
        btnLogOut.Text = "LOGOUT"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' StaffDahboard_UI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(923, 401)
        Controls.Add(btnLogOut)
        Controls.Add(btnViewOrders)
        Controls.Add(btnManageRentals)
        Controls.Add(btnManageOrders)
        Controls.Add(lblStaffDashboard)
        Controls.Add(PictureBox3)
        Name = "StaffDahboard_UI"
        Text = "STAFF DASHBOARD"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblStaffDashboard As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnManageOrders As Button
    Friend WithEvents btnManageRentals As Button
    Friend WithEvents btnViewOrders As Button
    Friend WithEvents btnLogOut As Button
End Class
