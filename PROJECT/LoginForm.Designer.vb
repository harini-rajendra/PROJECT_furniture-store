<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        btnShowHidePassword = New Button()
        Label1 = New Label()
        btnRegister = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblPassword = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._9d87594c_d5a7_40d3_b3b8_0059b0fbd1f5
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(916, 396)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlDark
        GroupBox1.Controls.Add(btnShowHidePassword)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnRegister)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(lblUsername)
        GroupBox1.Controls.Add(lblPassword)
        GroupBox1.Location = New Point(333, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(295, 178)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' btnShowHidePassword
        ' 
        btnShowHidePassword.BackgroundImage = CType(resources.GetObject("btnShowHidePassword.BackgroundImage"), Image)
        btnShowHidePassword.BackgroundImageLayout = ImageLayout.Stretch
        btnShowHidePassword.Location = New Point(248, 78)
        btnShowHidePassword.Name = "btnShowHidePassword"
        btnShowHidePassword.Size = New Size(41, 27)
        btnShowHidePassword.TabIndex = 9
        btnShowHidePassword.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkKhaki
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(91, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 21)
        Label1.TabIndex = 8
        Label1.Text = "LOGIN FORM"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.LightSeaGreen
        btnRegister.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(148, 132)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(88, 40)
        btnRegister.TabIndex = 7
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LimeGreen
        btnLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(54, 132)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(88, 40)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(110, 78)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(140, 23)
        txtPassword.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(110, 38)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(140, 23)
        txtUsername.TabIndex = 4
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(45, 41)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(64, 15)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(45, 85)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(59, 15)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(917, 396)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "LoginForm"
        Text = "LoginForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowHidePassword As Button


End Class