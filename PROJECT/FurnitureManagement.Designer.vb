<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FurnitureManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FurnitureManagement))
        PictureBox1 = New PictureBox()
        lblFurnitureName = New Label()
        cmbCategory = New Label()
        lblPrice = New Label()
        lblStock = New Label()
        txtFurnitureName = New TextBox()
        txtPrice = New TextBox()
        txtStock = New TextBox()
        CategorySection = New ComboBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        Label5 = New Label()
        DataGridViewFurniture = New DataGridView()
        btnUploadImage = New Button()
        PictureBoxFurniture = New PictureBox()
        lblFurnitureManagement = New Label()
        lblRentalPrice = New Label()
        txtRentalPrice = New TextBox()
        txtSearch = New TextBox()
        txtFurnitureID = New TextBox()
        lblFurnitureID = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewFurniture, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxFurniture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1062, 419)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblFurnitureName
        ' 
        lblFurnitureName.AutoSize = True
        lblFurnitureName.BackColor = Color.Gold
        lblFurnitureName.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFurnitureName.Location = New Point(50, 96)
        lblFurnitureName.Name = "lblFurnitureName"
        lblFurnitureName.Size = New Size(146, 20)
        lblFurnitureName.TabIndex = 1
        lblFurnitureName.Text = "FURNITURE_NAME"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.AutoSize = True
        cmbCategory.BackColor = Color.Gold
        cmbCategory.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCategory.Location = New Point(107, 129)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(89, 20)
        cmbCategory.TabIndex = 2
        cmbCategory.Text = "CATEGORY"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.Gold
        lblPrice.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrice.Location = New Point(475, 100)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(51, 20)
        lblPrice.TabIndex = 3
        lblPrice.Text = "PRICE"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.BackColor = Color.Gold
        lblStock.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStock.Location = New Point(468, 71)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(58, 20)
        lblStock.TabIndex = 4
        lblStock.Text = "STOCK"
        ' 
        ' txtFurnitureName
        ' 
        txtFurnitureName.Location = New Point(202, 97)
        txtFurnitureName.Name = "txtFurnitureName"
        txtFurnitureName.Size = New Size(178, 23)
        txtFurnitureName.TabIndex = 5
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(532, 97)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(135, 23)
        txtPrice.TabIndex = 6
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(532, 68)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(135, 23)
        txtStock.TabIndex = 7
        ' 
        ' CategorySection
        ' 
        CategorySection.FormattingEnabled = True
        CategorySection.Location = New Point(202, 130)
        CategorySection.Name = "CategorySection"
        CategorySection.Size = New Size(178, 23)
        CategorySection.TabIndex = 9
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.GreenYellow
        btnAdd.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(689, 119)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(98, 30)
        btnAdd.TabIndex = 10
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.GreenYellow
        btnUpdate.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(689, 160)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(98, 30)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.GreenYellow
        btnDelete.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(689, 72)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(98, 32)
        btnDelete.TabIndex = 12
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.GreenYellow
        btnSearch.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(300, 194)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 30)
        btnSearch.TabIndex = 13
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Gold
        Label5.Location = New Point(229, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 14
        ' 
        ' DataGridViewFurniture
        ' 
        DataGridViewFurniture.BackgroundColor = Color.Linen
        DataGridViewFurniture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewFurniture.Location = New Point(80, 252)
        DataGridViewFurniture.Name = "DataGridViewFurniture"
        DataGridViewFurniture.Size = New Size(874, 157)
        DataGridViewFurniture.TabIndex = 15
        ' 
        ' btnUploadImage
        ' 
        btnUploadImage.BackColor = Color.Blue
        btnUploadImage.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUploadImage.ForeColor = SystemColors.ButtonFace
        btnUploadImage.Location = New Point(859, 206)
        btnUploadImage.Name = "btnUploadImage"
        btnUploadImage.Size = New Size(134, 36)
        btnUploadImage.TabIndex = 16
        btnUploadImage.Text = "UploadImage"
        btnUploadImage.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxFurniture
        ' 
        PictureBoxFurniture.Location = New Point(804, 28)
        PictureBoxFurniture.Name = "PictureBoxFurniture"
        PictureBoxFurniture.Size = New Size(236, 172)
        PictureBoxFurniture.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxFurniture.TabIndex = 17
        PictureBoxFurniture.TabStop = False
        ' 
        ' lblFurnitureManagement
        ' 
        lblFurnitureManagement.AutoSize = True
        lblFurnitureManagement.BackColor = Color.DarkKhaki
        lblFurnitureManagement.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFurnitureManagement.Location = New Point(368, 18)
        lblFurnitureManagement.Name = "lblFurnitureManagement"
        lblFurnitureManagement.Size = New Size(299, 30)
        lblFurnitureManagement.TabIndex = 19
        lblFurnitureManagement.Text = "FURNITURE MANAGEMENT"
        ' 
        ' lblRentalPrice
        ' 
        lblRentalPrice.AutoSize = True
        lblRentalPrice.BackColor = Color.Gold
        lblRentalPrice.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalPrice.Location = New Point(402, 129)
        lblRentalPrice.Name = "lblRentalPrice"
        lblRentalPrice.Size = New Size(124, 21)
        lblRentalPrice.TabIndex = 20
        lblRentalPrice.Text = "RENTAL PRICE"
        ' 
        ' txtRentalPrice
        ' 
        txtRentalPrice.Location = New Point(532, 128)
        txtRentalPrice.Name = "txtRentalPrice"
        txtRentalPrice.Size = New Size(135, 23)
        txtRentalPrice.TabIndex = 21
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(424, 194)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(139, 23)
        txtSearch.TabIndex = 22
        ' 
        ' txtFurnitureID
        ' 
        txtFurnitureID.Location = New Point(202, 65)
        txtFurnitureID.Name = "txtFurnitureID"
        txtFurnitureID.Size = New Size(100, 23)
        txtFurnitureID.TabIndex = 23
        ' 
        ' lblFurnitureID
        ' 
        lblFurnitureID.AutoSize = True
        lblFurnitureID.BackColor = Color.Gold
        lblFurnitureID.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFurnitureID.Location = New Point(80, 64)
        lblFurnitureID.Name = "lblFurnitureID"
        lblFurnitureID.Size = New Size(116, 20)
        lblFurnitureID.TabIndex = 24
        lblFurnitureID.Text = "FURNITURE_ID"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FurnitureManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1052, 421)
        Controls.Add(lblFurnitureID)
        Controls.Add(txtFurnitureID)
        Controls.Add(txtSearch)
        Controls.Add(txtRentalPrice)
        Controls.Add(lblRentalPrice)
        Controls.Add(lblFurnitureManagement)
        Controls.Add(PictureBoxFurniture)
        Controls.Add(btnUploadImage)
        Controls.Add(DataGridViewFurniture)
        Controls.Add(Label5)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(CategorySection)
        Controls.Add(txtStock)
        Controls.Add(txtPrice)
        Controls.Add(txtFurnitureName)
        Controls.Add(lblStock)
        Controls.Add(lblPrice)
        Controls.Add(cmbCategory)
        Controls.Add(lblFurnitureName)
        Controls.Add(PictureBox1)
        Name = "FurnitureManagement"
        Text = "FurnitureManagement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewFurniture, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxFurniture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblFurnitureName As Label
    Friend WithEvents cmbCategory As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents txtFurnitureName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents CategorySection As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridViewFurniture As DataGridView
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents PictureBoxFurniture As PictureBox
    Friend WithEvents lblFurnitureManagement As Label
    Friend WithEvents lblRentalPrice As Label
    Friend WithEvents txtRentalPrice As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtFurnitureID As TextBox
    Friend WithEvents lblFurnitureID As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
