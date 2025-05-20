<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
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
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        txtEmail = New TextBox()
        Label6 = New Label()
        btnBackToLogin = New Button()
        Label5 = New Label()
        txtAddress = New TextBox()
        txtPhoneno = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnSubmit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._9d87594c_d5a7_40d3_b3b8_0059b0fbd1f51
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(890, 480)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkGray
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(btnBackToLogin)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtPhoneno)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnSubmit)
        GroupBox1.Location = New Point(322, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(269, 282)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(105, 159)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(121, 23)
        txtEmail.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(39, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 12
        Label6.Text = "Email"
        ' 
        ' btnBackToLogin
        ' 
        btnBackToLogin.BackColor = Color.LightSeaGreen
        btnBackToLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackToLogin.Location = New Point(78, 247)
        btnBackToLogin.Name = "btnBackToLogin"
        btnBackToLogin.Size = New Size(121, 29)
        btnBackToLogin.TabIndex = 11
        btnBackToLogin.Text = "BackToLogin"
        btnBackToLogin.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.RosyBrown
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(7, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(252, 25)
        Label5.TabIndex = 10
        Label5.Text = "CUSTOMER REGISTRATION"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(105, 131)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(121, 23)
        txtAddress.TabIndex = 9
        ' 
        ' txtPhoneno
        ' 
        txtPhoneno.Location = New Point(105, 188)
        txtPhoneno.Name = "txtPhoneno"
        txtPhoneno.Size = New Size(121, 23)
        txtPhoneno.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(105, 102)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(121, 23)
        txtPassword.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(105, 73)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(121, 23)
        txtUsername.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 5
        Label4.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 4
        Label3.Text = "PhoneNo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LimeGreen
        btnSubmit.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(90, 217)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(93, 28)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(893, 371)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "RegistrationForm"
        Text = "RegistrationForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneno As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBackToLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label

End Class


