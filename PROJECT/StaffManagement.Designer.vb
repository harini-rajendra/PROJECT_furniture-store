<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffManagement
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
        Label2 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        txtAddress = New TextBox()
        txtPhoneNo = New TextBox()
        btnAddStaff = New Button()
        btnUpdateStaff = New Button()
        btnDeleteStaff = New Button()
        DataGridViewStaff = New DataGridView()
        Label4 = New Label()
        Label5 = New Label()
        txtPassword = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewStaff, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.d8e48688_c935_46d8_804d_fbc8c3e46e44
        PictureBox1.Location = New Point(-2, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(926, 400)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Tan
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.ImageAlign = ContentAlignment.TopLeft
        Label1.Location = New Point(226, 71)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.Yes
        Label1.Size = New Size(107, 23)
        Label1.TabIndex = 1
        Label1.Text = " USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Tan
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(247, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 23)
        Label2.TabIndex = 2
        Label2.Text = "ADDRESS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Tan
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(235, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 23)
        Label3.TabIndex = 3
        Label3.Text = "PHONE NO"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(379, 67)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(202, 23)
        txtUsername.TabIndex = 4
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(379, 140)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(202, 23)
        txtAddress.TabIndex = 5
        ' 
        ' txtPhoneNo
        ' 
        txtPhoneNo.Location = New Point(379, 179)
        txtPhoneNo.Name = "txtPhoneNo"
        txtPhoneNo.Size = New Size(202, 23)
        txtPhoneNo.TabIndex = 6
        ' 
        ' btnAddStaff
        ' 
        btnAddStaff.BackColor = Color.OliveDrab
        btnAddStaff.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddStaff.ForeColor = SystemColors.InactiveCaptionText
        btnAddStaff.Location = New Point(675, 54)
        btnAddStaff.Name = "btnAddStaff"
        btnAddStaff.Size = New Size(139, 36)
        btnAddStaff.TabIndex = 7
        btnAddStaff.Text = "ADD STAFF"
        btnAddStaff.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateStaff
        ' 
        btnUpdateStaff.BackColor = Color.OliveDrab
        btnUpdateStaff.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateStaff.ForeColor = SystemColors.InactiveCaptionText
        btnUpdateStaff.ImageAlign = ContentAlignment.BottomRight
        btnUpdateStaff.Location = New Point(675, 98)
        btnUpdateStaff.Name = "btnUpdateStaff"
        btnUpdateStaff.RightToLeft = RightToLeft.Yes
        btnUpdateStaff.Size = New Size(139, 36)
        btnUpdateStaff.TabIndex = 8
        btnUpdateStaff.Text = "UPDATE STAFF"
        btnUpdateStaff.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteStaff
        ' 
        btnDeleteStaff.BackColor = Color.OliveDrab
        btnDeleteStaff.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteStaff.Location = New Point(675, 140)
        btnDeleteStaff.Name = "btnDeleteStaff"
        btnDeleteStaff.Size = New Size(139, 34)
        btnDeleteStaff.TabIndex = 9
        btnDeleteStaff.Text = "DELETE STAFF"
        btnDeleteStaff.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewStaff
        ' 
        DataGridViewStaff.BackgroundColor = Color.SeaShell
        DataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewStaff.Location = New Point(70, 238)
        DataGridViewStaff.Name = "DataGridViewStaff"
        DataGridViewStaff.Size = New Size(766, 136)
        DataGridViewStaff.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label4.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(320, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(242, 30)
        Label4.TabIndex = 11
        Label4.Text = "STAFF MANAGEMENT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Tan
        Label5.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(237, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 20)
        Label5.TabIndex = 12
        Label5.Text = "PASSWORD"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(379, 104)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(202, 23)
        txtPassword.TabIndex = 13
        ' 
        ' StaffManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(923, 399)
        Controls.Add(txtPassword)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridViewStaff)
        Controls.Add(btnDeleteStaff)
        Controls.Add(btnUpdateStaff)
        Controls.Add(btnAddStaff)
        Controls.Add(txtPhoneNo)
        Controls.Add(txtAddress)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "StaffManagement"
        Text = "StaffManagement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewStaff, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnUpdateStaff As Button
    Friend WithEvents btnDeleteStaff As Button
    Friend WithEvents DataGridViewStaff As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox

    
End Class
