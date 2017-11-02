<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Help.txt", 35)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "after-effects.png")
        Me.ImageList1.Images.SetKeyName(1, "ai.png")
        Me.ImageList1.Images.SetKeyName(2, "audition.png")
        Me.ImageList1.Images.SetKeyName(3, "avi.png")
        Me.ImageList1.Images.SetKeyName(4, "bridge.png")
        Me.ImageList1.Images.SetKeyName(5, "css.png")
        Me.ImageList1.Images.SetKeyName(6, "csv.png")
        Me.ImageList1.Images.SetKeyName(7, "dbf.png")
        Me.ImageList1.Images.SetKeyName(8, "doc.png")
        Me.ImageList1.Images.SetKeyName(9, "dreamweaver.png")
        Me.ImageList1.Images.SetKeyName(10, "dwg.png")
        Me.ImageList1.Images.SetKeyName(11, "exe.png")
        Me.ImageList1.Images.SetKeyName(12, "file.png")
        Me.ImageList1.Images.SetKeyName(13, "fireworks.png")
        Me.ImageList1.Images.SetKeyName(14, "fla.png")
        Me.ImageList1.Images.SetKeyName(15, "flash.png")
        Me.ImageList1.Images.SetKeyName(16, "html.png")
        Me.ImageList1.Images.SetKeyName(17, "illustrator.png")
        Me.ImageList1.Images.SetKeyName(18, "indesign.png")
        Me.ImageList1.Images.SetKeyName(19, "iso.png")
        Me.ImageList1.Images.SetKeyName(20, "javascript.png")
        Me.ImageList1.Images.SetKeyName(21, "jpg.png")
        Me.ImageList1.Images.SetKeyName(22, "json-file.png")
        Me.ImageList1.Images.SetKeyName(23, "mp3.png")
        Me.ImageList1.Images.SetKeyName(24, "mp4.png")
        Me.ImageList1.Images.SetKeyName(25, "pdf.png")
        Me.ImageList1.Images.SetKeyName(26, "photoshop.png")
        Me.ImageList1.Images.SetKeyName(27, "png.png")
        Me.ImageList1.Images.SetKeyName(28, "ppt.png")
        Me.ImageList1.Images.SetKeyName(29, "prelude.png")
        Me.ImageList1.Images.SetKeyName(30, "premiere.png")
        Me.ImageList1.Images.SetKeyName(31, "psd.png")
        Me.ImageList1.Images.SetKeyName(32, "rtf.png")
        Me.ImageList1.Images.SetKeyName(33, "search.png")
        Me.ImageList1.Images.SetKeyName(34, "svg.png")
        Me.ImageList1.Images.SetKeyName(35, "txt.png")
        Me.ImageList1.Images.SetKeyName(36, "xls.png")
        Me.ImageList1.Images.SetKeyName(37, "xml.png")
        Me.ImageList1.Images.SetKeyName(38, "zip.png")
        Me.ImageList1.Images.SetKeyName(39, "zip-1.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(1184, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Exit"
        '
        'ListView1
        '
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(-2, 10)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1214, 475)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1212, 478)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form11"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
End Class
