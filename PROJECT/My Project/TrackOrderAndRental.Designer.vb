<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackOrderAndRental
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
        txtOrderID = New TextBox()
        dgvOrders = New DataGridView()
        btnSearch = New Button()
        btnRefresh = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._9047f547_1ad9_4660_aa78_4da692199680
        PictureBox1.Location = New Point(-2, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(918, 394)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.BlueViolet
        Label1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(271, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(371, 30)
        Label1.TabIndex = 1
        Label1.Text = "TRACK YOUR ORDER AND RENTAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkGoldenrod
        Label2.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(252, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 25)
        Label2.TabIndex = 2
        Label2.Text = "ORDER/RENTAL ID"
        ' 
        ' txtOrderID
        ' 
        txtOrderID.Location = New Point(490, 120)
        txtOrderID.Name = "txtOrderID"
        txtOrderID.Size = New Size(173, 23)
        txtOrderID.TabIndex = 3
        ' 
        ' dgvOrders
        ' 
        dgvOrders.BackgroundColor = SystemColors.ControlLight
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrders.Location = New Point(60, 227)
        dgvOrders.Name = "dgvOrders"
        dgvOrders.Size = New Size(785, 150)
        dgvOrders.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Blue
        btnSearch.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ControlLight
        btnSearch.Location = New Point(363, 182)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(96, 39)
        btnSearch.TabIndex = 5
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Blue
        btnRefresh.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = SystemColors.ControlLight
        btnRefresh.Location = New Point(490, 182)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(103, 39)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' TrackOrderAndRental
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 399)
        Controls.Add(btnRefresh)
        Controls.Add(btnSearch)
        Controls.Add(dgvOrders)
        Controls.Add(txtOrderID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "TrackOrderAndRental"
        Text = "TrackOrderAndRental"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
End Class
