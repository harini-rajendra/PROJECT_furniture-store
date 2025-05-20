<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrderAndRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewOrderAndRental))
        PictureBox1 = New PictureBox()
        dgvOrdersRentals = New DataGridView()
        txtOrderRentalID = New TextBox()
        cmbFilter = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        btnUpdateStatus = New Button()
        btnRefresh = New Button()
        Label4 = New Label()
        cmbStatus = New ComboBox()
        btnClose = New Button()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOrdersRentals, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gold
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(915, 398)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dgvOrdersRentals
        ' 
        dgvOrdersRentals.BackgroundColor = Color.LightCyan
        dgvOrdersRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrdersRentals.Location = New Point(80, 222)
        dgvOrdersRentals.Name = "dgvOrdersRentals"
        dgvOrdersRentals.Size = New Size(741, 163)
        dgvOrdersRentals.TabIndex = 8
        ' 
        ' txtOrderRentalID
        ' 
        txtOrderRentalID.Location = New Point(434, 67)
        txtOrderRentalID.Name = "txtOrderRentalID"
        txtOrderRentalID.Size = New Size(143, 23)
        txtOrderRentalID.TabIndex = 9
        ' 
        ' cmbFilter
        ' 
        cmbFilter.FormattingEnabled = True
        cmbFilter.Location = New Point(119, 67)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(121, 23)
        cmbFilter.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(317, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 30)
        Label1.TabIndex = 11
        Label1.Text = "VIEW ORDER AND RENTAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gold
        Label2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 12
        Label2.Text = "VIEW"
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.BackColor = Color.CornflowerBlue
        btnUpdateStatus.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateStatus.Location = New Point(317, 122)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(150, 41)
        btnUpdateStatus.TabIndex = 14
        btnUpdateStatus.Text = "UPDATE STATUS"
        btnUpdateStatus.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.CornflowerBlue
        btnRefresh.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(507, 122)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(101, 41)
        btnRefresh.TabIndex = 15
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Gold
        Label4.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(653, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 16
        Label4.Text = "STATUS"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(736, 71)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 23)
        cmbStatus.TabIndex = 17
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.DarkOrange
        btnClose.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(408, 184)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(84, 32)
        btnClose.TabIndex = 18
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Gold
        Label3.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(277, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 20)
        Label3.TabIndex = 19
        Label3.Text = "ORDER/RENTAL ID"
        ' 
        ' ViewOrderAndRental
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 397)
        Controls.Add(Label3)
        Controls.Add(btnClose)
        Controls.Add(cmbStatus)
        Controls.Add(Label4)
        Controls.Add(btnRefresh)
        Controls.Add(btnUpdateStatus)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbFilter)
        Controls.Add(txtOrderRentalID)
        Controls.Add(dgvOrdersRentals)
        Controls.Add(PictureBox1)
        Name = "ViewOrderAndRental"
        Text = "ViewOrderAndRental"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOrdersRentals, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvOrdersRentals As DataGridView
    Friend WithEvents txtOrderRentalID As TextBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label3 As Label


End Class
