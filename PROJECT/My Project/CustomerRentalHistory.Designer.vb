<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRentalHistory
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
        dgvRentalHistory = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtRentalID = New TextBox()
        txtStatus = New TextBox()
        txtRentalDate = New TextBox()
        txtReturnDate = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvRentalHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._8bebca42_8244_404b_ad6a_56ee70780f70
        PictureBox1.Location = New Point(-2, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(911, 374)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(359, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 37)
        Label1.TabIndex = 1
        Label1.Text = "YOUR_RENTALS"
        ' 
        ' dgvRentalHistory
        ' 
        dgvRentalHistory.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        dgvRentalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRentalHistory.Location = New Point(42, 159)
        dgvRentalHistory.Name = "dgvRentalHistory"
        dgvRentalHistory.Size = New Size(811, 201)
        dgvRentalHistory.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(556, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 20)
        Label2.TabIndex = 3
        Label2.Text = "RETURN DATE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label3.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(556, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 4
        Label3.Text = "RENTAL DATE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label4.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(93, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 5
        Label4.Text = "RENTAL ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Label5.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(320, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 6
        Label5.Text = "STATUS"
        ' 
        ' txtRentalID
        ' 
        txtRentalID.Location = New Point(187, 79)
        txtRentalID.Name = "txtRentalID"
        txtRentalID.Size = New Size(100, 23)
        txtRentalID.TabIndex = 7
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(407, 79)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(119, 23)
        txtStatus.TabIndex = 8
        ' 
        ' txtRentalDate
        ' 
        txtRentalDate.Location = New Point(695, 83)
        txtRentalDate.Name = "txtRentalDate"
        txtRentalDate.Size = New Size(125, 23)
        txtRentalDate.TabIndex = 9
        ' 
        ' txtReturnDate
        ' 
        txtReturnDate.Location = New Point(695, 121)
        txtReturnDate.Name = "txtReturnDate"
        txtReturnDate.Size = New Size(125, 23)
        txtReturnDate.TabIndex = 10
        ' 
        ' CustomerRentalHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(909, 372)
        Controls.Add(txtReturnDate)
        Controls.Add(txtRentalDate)
        Controls.Add(txtStatus)
        Controls.Add(txtRentalID)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dgvRentalHistory)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "CustomerRentalHistory"
        Text = "CustomerRentalHistory"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvRentalHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRentalHistory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRentalID As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtRentalDate As TextBox
    Friend WithEvents txtReturnDate As TextBox
End Class
