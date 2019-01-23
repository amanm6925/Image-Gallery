Imports System.IO

Public Class Form1
    Dim directoryName As String
    Dim rowImage, colImage As Integer

    Private Sub GetImage_Click(sender As Object, e As EventArgs) Handles GetImage.Click
        directoryName = DirectoryTextBox.Text
        ImageListBox.Enabled = False
        ImageListBox.Visible = False
        ImagePictureBox.Visible = False

        If (Not Directory.Exists(directoryName)) Then
            MessageBox.Show("Enter a valid Directory", "Error")
            Exit Sub
        End If

        Dim files() As String = Directory.GetFiles(directoryName)
        If (ListRadioButton.Checked = True) Then
            populate_list(files)
        Else
            populate_thumbnails(files)
        End If
    End Sub

    Private Sub populate_list(ByVal files() As String)
        RemoveThumbnails()
        ImageListBox.Enabled = True
        ImageListBox.Visible = True
        ImagePictureBox.Visible = True
        ImagePictureBox.Image = Nothing
        ImageListBox.Items.Clear()

        Dim extension As String
        For Each file As String In files
            extension = Path.GetExtension(file)
            If (extension = ".jpg" Or extension = ".jpeg" Or extension = ".png" Or extension = ".gif") Then
                'MessageBox.Show(file)
                ImageListBox.Items.Add(Path.GetFileName(file))
            End If
        Next
    End Sub

    Private Sub populate_thumbnails(ByVal files() As String)
        ImagePictureBox.Visible = True
        ImagePictureBox.Image = Nothing
        RemoveThumbnails()
        rowImage = 1
        colImage = 1
        Dim extension As String
        For Each file As String In files
            extension = Path.GetExtension(file)
            If (extension = ".jpg" Or extension = ".jpeg" Or extension = ".png" Or extension = ".gif") Then
                'MessageBox.Show(file)
                addImage(file)
            End If
        Next

    End Sub

    Private Sub addImage(ByVal file As String)
        Dim width, height, Xloc, Yloc As Decimal
        width = (ImagePictureBox.Width) / 3
        width -= 10
        height = (width * 9) / 16

        Xloc = (colImage - 1) * (width + 10) + 5
        Yloc = (rowImage - 1) * (height + 10) + 5

        Dim newPic As New PictureBox
        newPic.Location = New System.Drawing.Point(Xloc, Yloc)
        newPic.Size = New System.Drawing.Size(width, height)
        newPic.BorderStyle = BorderStyle.FixedSingle
        newPic.Image = Image.FromFile(file)
        newPic.SizeMode = PictureBoxSizeMode.Zoom
        ImagePictureBox.Controls.Add(newPic)

        colImage = colImage + 1
        If (colImage = 4) Then
            colImage = 1
            rowImage = rowImage + 1
        End If

    End Sub

    Private Sub RemoveThumbnails()
Again:  For Each ctrl In ImagePictureBox.Controls
            ImagePictureBox.Controls.Remove(ctrl)
        Next
        If ImagePictureBox.Controls.Count > 0 Then
            GoTo Again
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImageListBox.HorizontalScrollbar = True

        ImagePictureBox.Visible = False
        ImagePictureBox.BorderStyle = BorderStyle.FixedSingle

        Panel1.AutoScroll = False
        Panel1.HorizontalScroll.Enabled = False
        Panel1.HorizontalScroll.Visible = False
        Panel1.HorizontalScroll.Maximum = 0
        Panel1.AutoScroll = False
    End Sub

    Private Sub ImageListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ImageListBox.SelectedIndexChanged
        'MessageBox.Show(file)
        Try
            Dim file As String = directoryName & "/" & ImageListBox.SelectedItem.ToString
            Dim img As Image
            img = Image.FromFile(File)
            ImagePictureBox.Image = img
            ImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BrowserButton_Click(sender As Object, e As EventArgs) Handles BrowserButton.Click
        If (FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            DirectoryTextBox.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class
