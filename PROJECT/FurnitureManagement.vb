Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class FurnitureManagement
    Dim connectionString As String = "Data Source=DESKTOP-UV1D89P;Initial Catalog=woodenaura;Integrated Security=True;Trust Server Certificate=True"
    Dim selectedImagePath As String = ""

    ' ✅ Load Data When Form Opens
    Private Sub FurnitureManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadFurnitureData()
    End Sub

    ' ✅ Load Categories into ComboBox
    Private Sub LoadCategories()
        Try
            CategorySection.Items.Clear()
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT DISTINCT Category FROM Furniture WHERE Category IS NOT NULL"
                Dim cmd As New SqlCommand(query, con)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    CategorySection.Items.Add(reader("Category").ToString().Trim())
                End While
            End Using
            CategorySection.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    ' ✅ Load Furniture Data into DataGridView
    Private Sub LoadFurnitureData()
        Try
            Dim query As String = "SELECT FurnitureID, FurnitureName, Stock, Price, RentalPrice, Category, ImagePath FROM Furniture"
            Dim dt As New DataTable()

            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            DataGridViewFurniture.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading furniture data: " & ex.Message)
        End Try
    End Sub

    ' ✅ Upload Image When PictureBox is Clicked
    Private Sub PictureBoxFurniture_Click(sender As Object, e As EventArgs) Handles PictureBoxFurniture.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Select Furniture Image"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedImagePath = openFileDialog.FileName

            ' ✅ Dispose of previous image to free memory
            If PictureBoxFurniture.Image IsNot Nothing Then
                PictureBoxFurniture.Image.Dispose()
                PictureBoxFurniture.Image = Nothing
            End If

            ' ✅ Load image safely using Bitmap (prevents file locking issues)
            Using stream As New FileStream(selectedImagePath, FileMode.Open, FileAccess.Read)
                PictureBoxFurniture.Image = New Bitmap(Image.FromStream(stream))
            End Using
        End If
    End Sub


    ' ✅ Add New Furniture Record
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If CategorySection.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(txtFurnitureName.Text) Then
                MessageBox.Show("Please fill all required fields.", "Error")
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(selectedImagePath) Then
                MessageBox.Show("Please select an image.", "Error")
                Exit Sub
            End If

            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Furniture (FurnitureName, Stock, Price, RentalPrice, Category, ImagePath) 
                                       VALUES (@FurnitureName, @Stock, @Price, @RentalPrice, @Category, @ImagePath)"
                Dim cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@FurnitureName", txtFurnitureName.Text.Trim())
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text))
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text))
                cmd.Parameters.AddWithValue("@RentalPrice", Convert.ToDecimal(txtRentalPrice.Text))
                cmd.Parameters.AddWithValue("@Category", CategorySection.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@ImagePath", selectedImagePath) ' ✅ Store file path

                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Furniture added successfully!", "Success")
            LoadFurnitureData()
        Catch ex As Exception
            MessageBox.Show("Error adding furniture: " & ex.Message)
        End Try
    End Sub

    ' ✅ Select Row and Load Image from Path
    Private Sub DataGridViewFurniture_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFurniture.CellClick
        ' ✅ Event to Populate Textboxes when a Row is Clicked

        Try
            ' Ensure a valid row is selected
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridViewFurniture.Rows(e.RowIndex)

                ' Assign values from DataGridView row to textboxes
                txtFurnitureID.Text = row.Cells("FurnitureID").Value.ToString()
                txtFurnitureName.Text = row.Cells("FurnitureName").Value.ToString()
                txtStock.Text = row.Cells("Stock").Value.ToString()
                txtPrice.Text = row.Cells("Price").Value.ToString()
                txtRentalPrice.Text = row.Cells("RentalPrice").Value.ToString()
                CategorySection.SelectedItem = row.Cells("Category").Value.ToString()

                ' Handle Image Loading
                Dim imagePath As String = row.Cells("ImagePath").Value.ToString()
                If File.Exists(imagePath) Then
                    PictureBoxFurniture.Image = Image.FromFile(imagePath)
                Else
                    PictureBoxFurniture.Image = Image.FromFile("C:\Images\DefaultImage.jpg") ' Default image
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridViewFurniture.Rows(e.RowIndex)
                txtFurnitureID.Text = row.Cells("FurnitureID").Value.ToString()
                txtFurnitureName.Text = row.Cells("FurnitureName").Value.ToString()
                txtStock.Text = row.Cells("Stock").Value.ToString()
                txtPrice.Text = row.Cells("Price").Value.ToString()
                txtRentalPrice.Text = row.Cells("RentalPrice").Value.ToString()
                CategorySection.SelectedItem = row.Cells("Category").Value.ToString()

                ' Load Image if the Path Exists
                Dim imagePath As String = row.Cells("ImagePath").Value.ToString()

                If File.Exists(imagePath) Then
                    ' Dispose of previous image to prevent memory leak
                    If PictureBoxFurniture.Image IsNot Nothing Then
                        PictureBoxFurniture.Image.Dispose()
                        PictureBoxFurniture.Image = Nothing
                    End If

                    ' Load new image
                    Using imgTemp As Image = Image.FromFile(imagePath)
                        PictureBoxFurniture.Image = New Bitmap(imgTemp)
                    End Using
                Else
                    ' If the image path is invalid, clear the PictureBox instead of showing an error
                    If PictureBoxFurniture.Image IsNot Nothing Then
                        PictureBoxFurniture.Image.Dispose()
                        PictureBoxFurniture.Image = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try

    End Sub

    ' ✅ Update Furniture Record
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If String.IsNullOrEmpty(txtFurnitureID.Text) Then
                MessageBox.Show("Please select a furniture item to update.", "Error")
                Return
            End If

            If String.IsNullOrWhiteSpace(selectedImagePath) Then
                MessageBox.Show("Please select an image.", "Error")
                Exit Sub
            End If

            Using con As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Furniture SET FurnitureName=@FurnitureName, Stock=@Stock, Price=@Price, 
                                       RentalPrice=@RentalPrice, Category=@Category, ImagePath=@ImagePath 
                                       WHERE FurnitureID=@FurnitureID"
                Dim cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@FurnitureID", Convert.ToInt32(txtFurnitureID.Text))
                cmd.Parameters.AddWithValue("@FurnitureName", txtFurnitureName.Text)
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text))
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text))
                cmd.Parameters.AddWithValue("@RentalPrice", Convert.ToDecimal(txtRentalPrice.Text))
                cmd.Parameters.AddWithValue("@Category", CategorySection.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@ImagePath", selectedImagePath) ' ✅ Store file path

                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Furniture updated successfully!", "Success")
            LoadFurnitureData()
        Catch ex As Exception
            MessageBox.Show("Error updating furniture: " & ex.Message)
        End Try
    End Sub

    ' 🔍 Search Furniture by Name
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchQuery As String = "SELECT * FROM Furniture WHERE FurnitureName LIKE @FurnitureName"
            Dim dt As New DataTable()

            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(searchQuery, con)
                    cmd.Parameters.AddWithValue("@FurnitureName", "%" & txtSearch.Text.Trim() & "%")
                    con.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            ' Display the search results
            DataGridViewFurniture.DataSource = dt

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No furniture found with the given name.", "Search Result")
            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching: " & ex.Message)
        End Try
    End Sub

    ' 🗑 Delete Selected Furniture Record
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If String.IsNullOrWhiteSpace(txtFurnitureID.Text) Then
                MessageBox.Show("Please select a furniture item to delete.", "Error")
                Return
            End If

            ' Confirm before deleting
            Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this furniture item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmDelete = DialogResult.No Then Exit Sub

            ' Delete Query
            Dim deleteQuery As String = "DELETE FROM Furniture WHERE FurnitureID = @FurnitureID"

            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(deleteQuery, con)
                    cmd.Parameters.AddWithValue("@FurnitureID", Convert.ToInt32(txtFurnitureID.Text))
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Furniture deleted successfully!", "Success")
            LoadFurnitureData() ' Refresh DataGridView

        Catch ex As Exception
            MessageBox.Show("Error while deleting: " & ex.Message)
        End Try
    End Sub

End Class