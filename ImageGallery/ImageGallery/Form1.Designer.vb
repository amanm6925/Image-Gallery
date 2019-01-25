<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DirectoryTextBox = New System.Windows.Forms.TextBox()
        Me.GetImage = New System.Windows.Forms.Button()
        Me.ListRadioButton = New System.Windows.Forms.RadioButton()
        Me.ThumbnailRadioButton = New System.Windows.Forms.RadioButton()
        Me.StyleGroupBox = New System.Windows.Forms.GroupBox()
        Me.ImageListBox = New System.Windows.Forms.ListBox()
        Me.DirectoryLabel = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BrowserButton = New System.Windows.Forms.Button()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Previous = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.StyleGroupBox.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DirectoryTextBox
        '
        Me.DirectoryTextBox.Location = New System.Drawing.Point(38, 41)
        Me.DirectoryTextBox.Name = "DirectoryTextBox"
        Me.DirectoryTextBox.Size = New System.Drawing.Size(554, 22)
        Me.DirectoryTextBox.TabIndex = 1
        '
        'GetImage
        '
        Me.GetImage.Location = New System.Drawing.Point(840, 41)
        Me.GetImage.Name = "GetImage"
        Me.GetImage.Size = New System.Drawing.Size(122, 31)
        Me.GetImage.TabIndex = 4
        Me.GetImage.Text = "Get Images"
        Me.GetImage.UseVisualStyleBackColor = True
        '
        'ListRadioButton
        '
        Me.ListRadioButton.AutoSize = True
        Me.ListRadioButton.Checked = True
        Me.ListRadioButton.Location = New System.Drawing.Point(6, 29)
        Me.ListRadioButton.Name = "ListRadioButton"
        Me.ListRadioButton.Size = New System.Drawing.Size(51, 21)
        Me.ListRadioButton.TabIndex = 5
        Me.ListRadioButton.TabStop = True
        Me.ListRadioButton.Text = "List"
        Me.ListRadioButton.UseVisualStyleBackColor = True
        '
        'ThumbnailRadioButton
        '
        Me.ThumbnailRadioButton.AutoSize = True
        Me.ThumbnailRadioButton.Location = New System.Drawing.Point(6, 56)
        Me.ThumbnailRadioButton.Name = "ThumbnailRadioButton"
        Me.ThumbnailRadioButton.Size = New System.Drawing.Size(95, 21)
        Me.ThumbnailRadioButton.TabIndex = 6
        Me.ThumbnailRadioButton.TabStop = True
        Me.ThumbnailRadioButton.Text = "Thumbnail"
        Me.ThumbnailRadioButton.UseVisualStyleBackColor = True
        '
        'StyleGroupBox
        '
        Me.StyleGroupBox.Controls.Add(Me.ListRadioButton)
        Me.StyleGroupBox.Controls.Add(Me.ThumbnailRadioButton)
        Me.StyleGroupBox.Location = New System.Drawing.Point(668, 13)
        Me.StyleGroupBox.Name = "StyleGroupBox"
        Me.StyleGroupBox.Size = New System.Drawing.Size(143, 86)
        Me.StyleGroupBox.TabIndex = 7
        Me.StyleGroupBox.TabStop = False
        Me.StyleGroupBox.Text = "Style"
        '
        'ImageListBox
        '
        Me.ImageListBox.Enabled = False
        Me.ImageListBox.FormattingEnabled = True
        Me.ImageListBox.ItemHeight = 16
        Me.ImageListBox.Location = New System.Drawing.Point(38, 121)
        Me.ImageListBox.Name = "ImageListBox"
        Me.ImageListBox.Size = New System.Drawing.Size(165, 388)
        Me.ImageListBox.TabIndex = 8
        Me.ImageListBox.Visible = False
        '
        'DirectoryLabel
        '
        Me.DirectoryLabel.AutoSize = True
        Me.DirectoryLabel.Location = New System.Drawing.Point(35, 21)
        Me.DirectoryLabel.Name = "DirectoryLabel"
        Me.DirectoryLabel.Size = New System.Drawing.Size(197, 17)
        Me.DirectoryLabel.TabIndex = 10
        Me.DirectoryLabel.Text = "Enter the directory name here"
        '
        'BrowserButton
        '
        Me.BrowserButton.Location = New System.Drawing.Point(598, 40)
        Me.BrowserButton.Name = "BrowserButton"
        Me.BrowserButton.Size = New System.Drawing.Size(40, 23)
        Me.BrowserButton.TabIndex = 12
        Me.BrowserButton.Text = "..."
        Me.BrowserButton.UseVisualStyleBackColor = True
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Location = New System.Drawing.Point(3, 16)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(780, 430)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagePictureBox.TabIndex = 9
        Me.ImagePictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ImagePictureBox)
        Me.Panel1.Location = New System.Drawing.Point(209, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 470)
        Me.Panel1.TabIndex = 11
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(840, 78)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(122, 23)
        Me.BackButton.TabIndex = 13
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(212, 74)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(103, 31)
        Me.Previous.TabIndex = 14
        Me.Previous.Text = "Previous"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(321, 74)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(103, 31)
        Me.NextButton.TabIndex = 15
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 653)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Previous)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.BrowserButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DirectoryLabel)
        Me.Controls.Add(Me.ImageListBox)
        Me.Controls.Add(Me.StyleGroupBox)
        Me.Controls.Add(Me.GetImage)
        Me.Controls.Add(Me.DirectoryTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StyleGroupBox.ResumeLayout(False)
        Me.StyleGroupBox.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DirectoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GetImage As System.Windows.Forms.Button
    Friend WithEvents ListRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ThumbnailRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StyleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ImageListBox As System.Windows.Forms.ListBox
    Friend WithEvents DirectoryLabel As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BrowserButton As System.Windows.Forms.Button
    Friend WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Previous As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button

End Class
