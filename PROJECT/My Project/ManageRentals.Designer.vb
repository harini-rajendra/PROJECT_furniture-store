<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageRentals
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
        lblRentalID = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtRentalID = New TextBox()
        dtpRentalDate = New DateTimePicker()
        dtpReturnDate = New DateTimePicker()
        dgvRentals = New DataGridView()
        cmbRentalStatus = New ComboBox()
        btnUpdate = New Button()
        btnCancel = New Button()
        Label5 = New Label()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvRentals, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._9e4a6b02_0679_4b6f_bb4f_b0421886e560
        PictureBox1.Location = New Point(-1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(918, 373)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblRentalID
        ' 
        lblRentalID.AutoSize = True
        lblRentalID.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        lblRentalID.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalID.Location = New Point(166, 89)
        lblRentalID.Name = "lblRentalID"
        lblRentalID.Size = New Size(88, 20)
        lblRentalID.TabIndex = 1
        lblRentalID.Text = "RENTAL ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(60, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 2
        Label2.Text = "label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(485, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 21)
        Label3.TabIndex = 3
        Label3.Text = "RENTAL DATE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label4.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(485, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 21)
        Label4.TabIndex = 4
        Label4.Text = "RETURN DATE"
        ' 
        ' txtRentalID
        ' 
        txtRentalID.Location = New Point(272, 90)
        txtRentalID.Name = "txtRentalID"
        txtRentalID.Size = New Size(121, 23)
        txtRentalID.TabIndex = 5
        ' 
        ' dtpRentalDate
        ' 
        dtpRentalDate.Location = New Point(610, 83)
        dtpRentalDate.Name = "dtpRentalDate"
        dtpRentalDate.Size = New Size(200, 23)
        dtpRentalDate.TabIndex = 6
        ' 
        ' dtpReturnDate
        ' 
        dtpReturnDate.Location = New Point(610, 126)
        dtpReturnDate.Name = "dtpReturnDate"
        dtpReturnDate.Size = New Size(200, 23)
        dtpReturnDate.TabIndex = 7
        ' 
        ' dgvRentals
        ' 
        dgvRentals.BackgroundColor = Color.Cornsilk
        dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRentals.Location = New Point(49, 219)
        dgvRentals.Name = "dgvRentals"
        dgvRentals.Size = New Size(811, 142)
        dgvRentals.TabIndex = 8
        ' 
        ' cmbRentalStatus
        ' 
        cmbRentalStatus.FormattingEnabled = True
        cmbRentalStatus.Location = New Point(272, 128)
        cmbRentalStatus.Name = "cmbRentalStatus"
        cmbRentalStatus.Size = New Size(121, 23)
        cmbRentalStatus.TabIndex = 9
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnUpdate.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.Cornsilk
        btnUpdate.Location = New Point(295, 178)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(148, 35)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "UPDATE STATUS"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnCancel.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Cornsilk
        btnCancel.Location = New Point(485, 178)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(123, 35)
        btnCancel.TabIndex = 11
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label5.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(167, 131)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 12
        Label5.Text = "STATUS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LimeGreen
        Label6.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(362, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(211, 30)
        Label6.TabIndex = 13
        Label6.Text = "MANAGE RENTALS"
        ' 
        ' ManageRentals
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 373)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(cmbRentalStatus)
        Controls.Add(dgvRentals)
        Controls.Add(dtpReturnDate)
        Controls.Add(dtpRentalDate)
        Controls.Add(txtRentalID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblRentalID)
        Controls.Add(PictureBox1)
        Name = "ManageRentals"
        Text = "ManageRentals"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvRentals, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRentalID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRentalID As TextBox
    Friend WithEvents dtpRentalDate As DateTimePicker
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents dgvRentals As DataGridView
    Friend WithEvents cmbRentalStatus As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
