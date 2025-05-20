Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class BrowseFurniture
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True; Trust Server Certificate=True"

    Private Sub BrowseFurniture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFurnitureData()
        LoadCategories()
    End Sub
    ' Event: When a Row is Clicked in DataGridView
    Private Sub DataGridViewFurniture_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFurniture.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DataGridViewFurniture.Rows(e.RowIndex)

                ' Ensure ImagePath column has a valid value
                If selectedRow.Cells("ImagePath").Value IsNot Nothing AndAlso Not IsDBNull(selectedRow.Cells("ImagePath").Value) Then
                    Dim imagePath As String = selectedRow.Cells("ImagePath").Value.ToString()

                    ' Check if file exists
                    If File.Exists(imagePath) Then
                        ' Free previous image memory before setting a new one
                        If pbFurnitureImage.Image IsNot Nothing Then
                            pbFurnitureImage.Image.Dispose()
                            pbFurnitureImage.Image = Nothing
                        End If

                        ' Load the image without locking the file
                        Using tempImage As Image = Image.FromFile(imagePath)
                            pbFurnitureImage.Image = New Bitmap(tempImage)
                        End Using
                    Else
                        pbFurnitureImage.Image = Nothing
                        MessageBox.Show("Image file not found: " & imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    pbFurnitureImage.Image = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to Load Furniture Data into DataGridView
    Private Sub LoadFurnitureData(Optional ByVal category As String = "", Optional ByVal search As String = "")
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT FurnitureID, FurnitureName, Category, Price, Stock, ImagePath,RentalPrice FROM Furniture WHERE 1=1"

                If Not String.IsNullOrEmpty(category) AndAlso category <> "All" Then
                    query &= " AND Category = @category"
                End If

                If Not String.IsNullOrEmpty(search) Then
                    query &= " AND FurnitureName LIKE @search"
                End If

                Dim cmd As New SqlCommand(query, con)
                If Not String.IsNullOrEmpty(category) AndAlso category <> "All" Then
                    cmd.Parameters.AddWithValue("@category", category)
                End If

                If Not String.IsNullOrEmpty(search) Then
                    cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                DataGridViewFurniture.DataSource = dt

                ' Set column headers
                DataGridViewFurniture.Columns("FurnitureID").HeaderText = "ID"
                DataGridViewFurniture.Columns("FurnitureName").HeaderText = "Name"
                DataGridViewFurniture.Columns("Category").HeaderText = "Category"
                DataGridViewFurniture.Columns("Price").HeaderText = "Price (₹)"
                DataGridViewFurniture.Columns("RentalPrice").HeaderText = "RentalPrice (₹)"
                DataGridViewFurniture.Columns("Stock").HeaderText = "Stock"
                DataGridViewFurniture.Columns("ImagePath").Visible = False

                ' Add Image Column if not exists
                If Not DataGridViewFurniture.Columns.Contains("FurnitureImage") Then
                    Dim imgColumn As New DataGridViewImageColumn()
                    imgColumn.Name = "FurnitureImage"
                    imgColumn.HeaderText = "Image"
                    imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
                    DataGridViewFurniture.Columns.Add(imgColumn)
                End If

                ' Load images into DataGridView
                For Each row As DataGridViewRow In DataGridViewFurniture.Rows
                    If Not row.IsNewRow Then
                        Dim imagePath As String = If(row.Cells("ImagePath").Value IsNot DBNull.Value, row.Cells("ImagePath").Value.ToString(), "")
                        row.Cells("FurnitureImage").Value = LoadImage(imagePath)
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading furniture data: " & ex.Message)
        End Try
    End Sub

    ' Function to Load Image Without Locking File
    Private Function LoadImage(imagePath As String) As Image
        If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
            Try
                Using fs As New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                    Return Image.FromStream(fs)
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End If
        Return Nothing
    End Function

    ' Load Categories into ComboBox
    Private Sub LoadCategories()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT DISTINCT Category FROM Furniture"
                Dim cmd As New SqlCommand(query, con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                con.Open()
                adapter.Fill(dt)
                con.Close()

                cmbCategory.Items.Clear()
                cmbCategory.Items.Add("All") ' Default option

                For Each row As DataRow In dt.Rows
                    cmbCategory.Items.Add(row("Category").ToString())
                Next

                cmbCategory.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If DataGridViewFurniture.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewFurniture.SelectedRows(0)

            Dim furnitureID As Integer = Convert.ToInt32(selectedRow.Cells("FurnitureID").Value)
            Dim furnitureName As String = selectedRow.Cells("FurnitureName").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("Price").Value)
            Dim RentalPrice As Decimal = Convert.ToDecimal(selectedRow.Cells("RentalPrice").Value)
            Dim quantity As Integer = 1  ' Default quantity (You can add a NumericUpDown for user input)

            ' Ensure user is logged in
            If LoggedInCustomerID = 0 Then
                MessageBox.Show("Please log in before adding items to the cart.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Using con As New SqlConnection(connectionString)
                    Dim query As String = "INSERT INTO Cart (UserID, FurnitureID, Quantity, Price) VALUES (@UserID, @FurnitureID, @Quantity, @Price)"
                    Dim cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@UserID", LoggedInCustomerID)
                    cmd.Parameters.AddWithValue("@FurnitureID", furnitureID)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@RentalPrice", RentalPrice)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    ' Convert price to Indian Rupees format
                    Dim formattedPrice As String = "₹" & price.ToString("N2")
                    MessageBox.Show("Added to Cart: " & furnitureName & " - " & formattedPrice, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error adding item to cart: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a furniture item to add to cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        If LoggedInCustomerID = 0 Then
            MessageBox.Show("Please log in to view your cart.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cartForm As New VIEWCART()
        cartForm.Show()
        cartForm.LoadCart()
    End Sub

    ' Search and Filter Events
    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadFurnitureData(cmbCategory.SelectedItem.ToString(), txtSearch.Text)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadFurnitureData(cmbCategory.SelectedItem.ToString(), txtSearch.Text)
    End Sub


End Class
