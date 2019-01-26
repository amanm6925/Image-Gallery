Imports System.IO



Public Class Form1
    Dim directoryName As String

    Dim files() As String
    Dim TempPic As New PictureBox
    Dim page As Integer = 0
    Dim rowImage, colImage As Integer
    Dim no_images As Integer = 0


    Private Sub GetImage_Click(sender As Object, e As EventArgs) Handles GetImage.Click
        directoryName = DirectoryTextBox.Text
        ImageListBox.Enabled = False
        ImageListBox.Visible = False
        ImagePictureBox.Visible = False

        If (Not Directory.Exists(directoryName)) Then
            MessageBox.Show("Enter a valid Directory", "Error")
            Exit Sub
        End If

        Dim all_files() As String
        Dim extension As String
        all_files = Directory.GetFiles(directoryName)

        no_images = 0
        Erase files

        For Each file As String In all_files
            extension = Path.GetExtension(file)
            If (extension = ".jpg" Or extension = ".jpeg" Or extension = ".png" Or extension = ".gif") Then
                ReDim Preserve files(no_images)
                files(no_images) = file
                no_images += 1
            End If
        Next
        If (ListRadioButton.Checked = True) Then
            populate_list()
        Else
            populate_thumbnails()
        End If
    End Sub

    Private Sub populate_list()
        RemoveThumbnails()
        ImageListBox.Enabled = True
        ImageListBox.Visible = True
        ImagePictureBox.Visible = True
        ImagePictureBox.Image = Nothing
        ImageListBox.Items.Clear()

        For Each file As String In files
            ImageListBox.Items.Add(Path.GetFileName(file))
            'MessageBox.Show(file)
        Next
    End Sub

    Private Sub populate_thumbnails()
        ImagePictureBox.Visible = True
        ImagePictureBox.Image = Nothing
        NextButton.Visible = True
        RemoveThumbnails()
        rowImage = 1
        colImage = 1

        Dim countpics As Integer = 0
        While (countpics < 9)
            If (page * 9 + countpics >= files.Length) Then
                NextButton.Visible = False
                Return
            End If
            addImage(files(page * 9 + countpics))
            countpics += 1
        End While

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
        AddHandler newPic.Click, AddressOf Me.newPic_Click

        colImage = colImage + 1
        If (colImage = 4) Then
            colImage = 1
            rowImage = rowImage + 1
            If (rowImage = 4) Then
                Return
            End If
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
        Previous.Visible = False
        NextButton.Visible = False
        page = 0


        BackButton.Visible = False

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
            img = Image.FromFile(file)
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




    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RemoveThumbnails()
        populate_thumbnails()
        BackButton.Visible = False
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        page += 1
        populate_thumbnails()
        Previous.Visible = True
    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        If (page < 1) Then
            MessageBox.Show("There is no preious page", "Error")
            Return
        End If
        page -= 1
        populate_thumbnails()
        If (page = 0) Then
            Previous.Visible = False
        End If
    End Sub
    Private Sub newPic_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RemoveThumbnails()
        ImagePictureBox.Image = sender.Image
        BackButton.Visible = True
    End Sub
End Class



