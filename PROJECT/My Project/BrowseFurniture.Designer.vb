<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseFurniture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowseFurniture))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        cmbCategory = New ComboBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnAddToCart = New Button()
        DataGridViewFurniture = New DataGridView()
        Label2 = New Label()
        pbFurnitureImage = New PictureBox()
        btnViewCart = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewFurniture, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbFurnitureImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1078, 420)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Orange
        Label1.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(401, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 25)
        Label1.TabIndex = 1
        Label1.Text = "BROWSE FURNITURE"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(152, 151)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(173, 23)
        cmbCategory.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(152, 93)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(162, 23)
        txtSearch.TabIndex = 3
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MediumBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Franklin Gothic Heavy", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.Azure
        btnSearch.Location = New Point(14, 83)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(97, 41)
        btnSearch.TabIndex = 4
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.BackColor = Color.MediumBlue
        btnAddToCart.FlatStyle = FlatStyle.Popup
        btnAddToCart.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddToCart.ForeColor = Color.AliceBlue
        btnAddToCart.Location = New Point(14, 291)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(151, 39)
        btnAddToCart.TabIndex = 5
        btnAddToCart.Text = "AddToCart"
        btnAddToCart.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewFurniture
        ' 
        DataGridViewFurniture.BackgroundColor = SystemColors.ControlLightLight
        DataGridViewFurniture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewFurniture.Location = New Point(171, 243)
        DataGridViewFurniture.Name = "DataGridViewFurniture"
        DataGridViewFurniture.Size = New Size(834, 164)
        DataGridViewFurniture.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gold
        Label2.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 22)
        Label2.TabIndex = 7
        Label2.Text = "CATEGORY"
        ' 
        ' pbFurnitureImage
        ' 
        pbFurnitureImage.Location = New Point(414, 60)
        pbFurnitureImage.Name = "pbFurnitureImage"
        pbFurnitureImage.Size = New Size(390, 177)
        pbFurnitureImage.SizeMode = PictureBoxSizeMode.Zoom
        pbFurnitureImage.TabIndex = 8
        pbFurnitureImage.TabStop = False
        ' 
        ' btnViewCart
        ' 
        btnViewCart.BackColor = Color.MediumBlue
        btnViewCart.FlatStyle = FlatStyle.Flat
        btnViewCart.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewCart.ForeColor = SystemColors.ControlLightLight
        btnViewCart.Location = New Point(14, 355)
        btnViewCart.Name = "btnViewCart"
        btnViewCart.Size = New Size(148, 40)
        btnViewCart.TabIndex = 9
        btnViewCart.Text = "ViewCart"
        btnViewCart.UseVisualStyleBackColor = False
        ' 
        ' BrowseFurniture
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 419)
        Controls.Add(btnViewCart)
        Controls.Add(pbFurnitureImage)
        Controls.Add(Label2)
        Controls.Add(DataGridViewFurniture)
        Controls.Add(btnAddToCart)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(cmbCategory)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "BrowseFurniture"
        Text = "BrowseFurniture"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewFurniture, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFurnitureImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents DataGridViewFurniture As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents pbFurnitureImage As PictureBox
    Friend WithEvents btnViewCart As Button
End Class
