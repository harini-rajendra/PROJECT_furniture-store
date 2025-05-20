<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIEWCART
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
        dgvCart = New DataGridView()
        btnRemove = New Button()
        btnProceed = New Button()
        btnClear = New Button()
        lblShoppingCart = New Label()
        lblTotalAmount = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.istockphoto_1445857687_612x612
        PictureBox1.Location = New Point(266, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(420, 183)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dgvCart
        ' 
        dgvCart.BackgroundColor = Color.Cornsilk
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.Location = New Point(46, 216)
        dgvCart.Name = "dgvCart"
        dgvCart.Size = New Size(814, 136)
        dgvCart.TabIndex = 1
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.CornflowerBlue
        btnRemove.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemove.Location = New Point(772, 135)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(88, 29)
        btnRemove.TabIndex = 2
        btnRemove.Text = "REMOVE"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnProceed
        ' 
        btnProceed.BackColor = Color.DarkBlue
        btnProceed.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProceed.ForeColor = SystemColors.ControlLight
        btnProceed.Location = New Point(622, 349)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(263, 29)
        btnProceed.TabIndex = 3
        btnProceed.Text = "PROCEED TO ORDER/RENTAL"
        btnProceed.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Coral
        btnClear.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(772, 184)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(88, 26)
        btnClear.TabIndex = 4
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblShoppingCart
        ' 
        lblShoppingCart.AutoSize = True
        lblShoppingCart.BackColor = SystemColors.InactiveCaption
        lblShoppingCart.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblShoppingCart.Location = New Point(410, 9)
        lblShoppingCart.Name = "lblShoppingCart"
        lblShoppingCart.Size = New Size(135, 30)
        lblShoppingCart.TabIndex = 5
        lblShoppingCart.Text = "YOUR CART"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.BackColor = SystemColors.AppWorkspace
        lblTotalAmount.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmount.ForeColor = SystemColors.ControlText
        lblTotalAmount.Location = New Point(12, 125)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(0, 20)
        lblTotalAmount.TabIndex = 6
        ' 
        ' VIEWCART
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(897, 381)
        Controls.Add(lblTotalAmount)
        Controls.Add(lblShoppingCart)
        Controls.Add(btnClear)
        Controls.Add(btnProceed)
        Controls.Add(btnRemove)
        Controls.Add(dgvCart)
        Controls.Add(PictureBox1)
        Name = "VIEWCART"
        Text = "VIEWCART"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents lblTotalAmount As Label


End Class
