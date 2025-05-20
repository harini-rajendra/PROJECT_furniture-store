<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDashboard
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
        btnBrowseFurniture = New Button()
        btnViewCart = New Button()
        btnTrackOrderRental = New Button()
        btnLogout = New Button()
        btnOrderHistory = New Button()
        btnRentalHistory = New Button()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.f6e410ba_5f6f_4736_93fe_e324afe4efbe1
        PictureBox1.Location = New Point(3, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(918, 401)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(383, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 30)
        Label1.TabIndex = 1
        ' 
        ' btnBrowseFurniture
        ' 
        btnBrowseFurniture.BackColor = Color.DeepSkyBlue
        btnBrowseFurniture.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowseFurniture.Location = New Point(136, 77)
        btnBrowseFurniture.Name = "btnBrowseFurniture"
        btnBrowseFurniture.Size = New Size(166, 48)
        btnBrowseFurniture.TabIndex = 2
        btnBrowseFurniture.Text = "BROWSE FURNITURE"
        btnBrowseFurniture.UseVisualStyleBackColor = False
        ' 
        ' btnViewCart
        ' 
        btnViewCart.BackColor = Color.DeepSkyBlue
        btnViewCart.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewCart.Location = New Point(409, 77)
        btnViewCart.Name = "btnViewCart"
        btnViewCart.Size = New Size(127, 48)
        btnViewCart.TabIndex = 3
        btnViewCart.Text = "VIEW CART"
        btnViewCart.UseVisualStyleBackColor = False
        ' 
        ' btnTrackOrderRental
        ' 
        btnTrackOrderRental.BackColor = Color.DeepSkyBlue
        btnTrackOrderRental.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTrackOrderRental.Location = New Point(644, 77)
        btnTrackOrderRental.Name = "btnTrackOrderRental"
        btnTrackOrderRental.Size = New Size(179, 48)
        btnTrackOrderRental.TabIndex = 4
        btnTrackOrderRental.Text = "TRACK ORDER AND RENTAL"
        btnTrackOrderRental.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LimeGreen
        btnLogout.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = SystemColors.Desktop
        btnLogout.Location = New Point(430, 219)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(106, 45)
        btnLogout.TabIndex = 5
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnOrderHistory
        ' 
        btnOrderHistory.BackColor = Color.DeepSkyBlue
        btnOrderHistory.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOrderHistory.Location = New Point(264, 142)
        btnOrderHistory.Name = "btnOrderHistory"
        btnOrderHistory.Size = New Size(158, 52)
        btnOrderHistory.TabIndex = 6
        btnOrderHistory.Text = "ORDER HISTORY"
        btnOrderHistory.UseVisualStyleBackColor = False
        ' 
        ' btnRentalHistory
        ' 
        btnRentalHistory.BackColor = Color.DeepSkyBlue
        btnRentalHistory.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRentalHistory.Location = New Point(509, 142)
        btnRentalHistory.Name = "btnRentalHistory"
        btnRentalHistory.Size = New Size(164, 51)
        btnRentalHistory.TabIndex = 7
        btnRentalHistory.Text = "RENTAL HISTORY"
        btnRentalHistory.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(323, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(310, 32)
        Label2.TabIndex = 8
        Label2.Text = "CUSTOMER DASHBOARD"
        ' 
        ' CustomerDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(924, 396)
        Controls.Add(Label2)
        Controls.Add(btnRentalHistory)
        Controls.Add(btnOrderHistory)
        Controls.Add(btnLogout)
        Controls.Add(btnTrackOrderRental)
        Controls.Add(btnViewCart)
        Controls.Add(btnBrowseFurniture)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "CustomerDashboard"
        Text = "CustomerDashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBrowseFurniture As Button
    Friend WithEvents btnViewCart As Button
    Friend WithEvents btnTrackOrderRental As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnOrderHistory As Button
    Friend WithEvents btnRentalHistory As Button
    Friend WithEvents Label2 As Label


End Class
