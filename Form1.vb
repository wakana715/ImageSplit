Public Class Form1
    Const WorkFileSuffix As String = ".ImageSplit"

    Private Function RemoveExt(path As String) As String
        Dim ret As String = path
        Dim pathLen As Integer = Len(path)
        If pathLen > 4 Then
            Dim ext As String = path.Substring(pathLen - 4).ToUpper
            If ext = ".BMP" Or ext = ".PNG" Or ext = ".JPG" Then
                ret = path.Substring(0, pathLen - 4)
            End If
        End If
        Return ret
    End Function

    Private Sub SaveWork()
        Dim path As String = RemoveExt(ListBox1.SelectedItem)
        Try
            Dim x As Integer = -PictureBoxRight.Left * (100 / Val(TextBoxZoom.Text))
            Dim sw As New System.IO.StreamWriter(path & WorkFileSuffix, False, _
                                                 System.Text.Encoding.GetEncoding("shift_jis"))
            sw.WriteLine("" & x)
            sw.Close()
        Catch ex As Exception
            MsgBox(path & WorkFileSuffix & " Write Error", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplitContainer1.SplitterWidth = PictureBoxZoom.Left
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Debug.Print("Form1_KeyDown")
        SplitContainer1.Focus()
        If e.KeyCode = Keys.PageUp Then
            Panel1.AutoScrollPosition = (New Point(-Panel1.AutoScrollPosition.X, _
                                                   -Panel1.AutoScrollPosition.Y - _
                                                   Panel1.Height / 2))
        End If
        If e.KeyCode = Keys.PageDown Then
            Panel1.AutoScrollPosition = (New Point(-Panel1.AutoScrollPosition.X, _
                                                   -Panel1.AutoScrollPosition.Y + _
                                                   Panel1.Height / 2))
        End If
    End Sub

    Private Sub TextBoxIndex_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIndex.TextChanged
        Debug.Print("TextBoxIndex_TextChanged")
        Dim i As Integer = Val(TextBoxIndex.Text)
        ToolStripMenuItemSaveSplit.Enabled = True
        ToolStripMenuItemSaveSplitAndNextImage.Enabled = True
        ToolStripMenuItemSkipNextImage.Enabled = True
        PictureBoxLoad.Tag = ""
        If ListBox1.Items.Count = 0 Or i >= ListBox1.Items.Count Then
            PictureBoxLoad.Tag = "END"
            ToolStripMenuItemSaveSplit.Enabled = False
            ToolStripMenuItemSaveSplitAndNextImage.Enabled = False
            ToolStripMenuItemSkipNextImage.Enabled = False
        End If
        ToolStripMenuItemPreviousImage.Enabled = False
        If i > 0 Then
            ToolStripMenuItemPreviousImage.Enabled = True
        End If
        ToolStripMenuItemZoomIn.Enabled = False
        ToolStripMenuItemZoomOut.Enabled = False
        ToolStripMenuItemZoom400.Enabled = False
        ToolStripMenuItemZoom200.Enabled = False
        ToolStripMenuItemZoom100.Enabled = False
        ToolStripMenuItemZoom50.Enabled = False
        ToolStripMenuItemZoom25.Enabled = False
        If ListBox1.SelectedIndex >= 0 And ListBox1.SelectedIndex <= ListBox1.Items.Count Then
            ToolStripMenuItemZoomIn.Enabled = True
            ToolStripMenuItemZoomOut.Enabled = True
            ToolStripMenuItemZoom400.Enabled = True
            ToolStripMenuItemZoom200.Enabled = True
            ToolStripMenuItemZoom100.Enabled = True
            ToolStripMenuItemZoom50.Enabled = True
            ToolStripMenuItemZoom25.Enabled = True
        End If
        If PictureBoxLoad.Tag <> "" Then
            PictureBoxZoom.Refresh()
        End If
        ToolStripStatusLabel1_Click(sender, e)
    End Sub

    Private Sub TextBoxZoom_TextChanged(sender As Object, e As EventArgs) Handles TextBoxZoom.TextChanged
        Debug.Print("TextBoxZoom_TextChanged " & TextBoxZoom.Text)
        If ListBox1.SelectedIndex >= 0 And ListBox1.SelectedIndex <= ListBox1.Items.Count Then
            ToolStripMenuItemZoomIn.Enabled = True
            ToolStripMenuItemZoomOut.Enabled = True
        End If
        ToolStripMenuItemZoom400.Checked = False
        ToolStripMenuItemZoom200.Checked = False
        ToolStripMenuItemZoom100.Checked = False
        ToolStripMenuItemZoom50.Checked = False
        ToolStripMenuItemZoom25.Checked = False
        Dim z As Integer = Val(TextBoxZoom.Text)
        If z = 400 Then
            ToolStripMenuItemZoom400.Checked = True
            ToolStripMenuItemZoomIn.Enabled = False
        End If
        If z = 200 Then ToolStripMenuItemZoom200.Checked = True
        If z = 100 Then ToolStripMenuItemZoom100.Checked = True
        If z = 50 Then ToolStripMenuItemZoom50.Checked = True
        If z = 25 Then
            ToolStripMenuItemZoom25.Checked = True
            ToolStripMenuItemZoomOut.Enabled = False
        End If
        PictureBoxZoom_Click(sender, e)
        ToolStripStatusLabel1_Click(sender, e)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Debug.Print("ListBox1_SelectedIndexChanged")
        Dim i As Integer = ListBox1.SelectedIndex
        Debug.Print("SelectedIndex=" & i)
        If i >= 0 Then
            Debug.Print("SelectedItem=" & ListBox1.SelectedItem)
            PictureBoxLoad.LoadAsync(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub PictureBox1_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBoxLoad.LoadCompleted
        Debug.Print("PictureBox1_LoadCompleted")
        If e.Cancelled Then
            MsgBox(ListBox1.SelectedItem & " User Cancel", MsgBoxStyle.Information)
        ElseIf Not (e.Error Is Nothing) Then
            MsgBox(ListBox1.SelectedItem & " Read Error", MsgBoxStyle.Critical)
        Else
            PictureBoxLeft.Visible = True
            PictureBoxRight.Visible = True
            PictureBoxZoom_Click(sender, e)
        End If
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        Dim point As New Point(-Panel1.AutoScrollPosition.X, -Panel1.AutoScrollPosition.Y)
        Debug.Print("SplitContainer1_SplitterMoved SplitX=" & e.SplitX & ",AutoScrollPosition.Y=" & Panel1.AutoScrollPosition.Y)
        PictureBoxRight.Left = -e.SplitX
        ToolStripStatusLabel1_Click(sender, e)
        'System.Threading.Thread.Sleep(500)
        Panel1.AutoScrollPosition = point
    End Sub

    Private Sub PictureBoxZoom_Click(sender As Object, e As EventArgs) Handles PictureBoxZoom.Click
        Debug.Print("PictureBoxZoom_Click")
        Dim z As Integer = Val(TextBoxZoom.Text)
        If PictureBoxLoad.Tag = "" Then
            PictureBoxZoom.Width = PictureBoxLoad.Width * z / 100
            PictureBoxZoom.Height = PictureBoxLoad.Height * z / 100
            PictureBoxZoom.Image = PictureBoxLoad.Image
        Else
            PictureBoxZoom.Width = 1
            PictureBoxZoom.Height = 1
            PictureBoxZoom.Image = PictureBoxLoad.InitialImage
        End If
        SplitContainer1.Width = PictureBoxZoom.Width + PictureBoxZoom.Left
        SplitContainer1.Height = PictureBoxZoom.Height
        SplitContainer1.PerformAutoScale()
        PictureBoxLeft.Width = PictureBoxZoom.Width
        PictureBoxLeft.Height = PictureBoxZoom.Height
        PictureBoxLeft.Image = PictureBoxZoom.Image
        PictureBoxRight.Width = PictureBoxZoom.Width
        PictureBoxRight.Height = PictureBoxZoom.Height
        PictureBoxRight.Image = PictureBoxZoom.Image
        Dim rl As String = "1"
        Try
            Dim path As String = RemoveExt(ListBox1.SelectedItem)
            Dim sr As New System.IO.StreamReader(path & WorkFileSuffix, _
                                                 System.Text.Encoding.GetEncoding("shift_jis"))
            rl = sr.ReadLine
            sr.Close()
        Catch ex As Exception
        End Try
        Dim x As Integer = Val(rl)
        If x < PictureBoxLoad.Width Then
            SplitContainer1.SplitterDistance = x * z / 100
        End If
    End Sub

    Private Sub PictureBoxZoom_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxZoom.MouseEnter
        Debug.Print("PictureBoxZoom_MouseEnter")
        Panel1.Focus()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Debug.Print("ToolStripStatusLabel1_Click")
        Dim index As Integer = ListBox1.SelectedIndex
        Dim fileName As String = ""
        If index >= 0 Then
            fileName = IO.Path.GetFileName(ListBox1.SelectedItem)
        End If
        If index < 0 Then index = 0 Else index = index + 1
        Dim z As Integer = Val(TextBoxZoom.Text)
        Dim x As Integer = 0
        If z > 0 Then
            x = -PictureBoxRight.Left * 100 / z
        End If
        ToolStripStatusLabel1.Text = ListBox1.Items.Count & " / " & index & " " & fileName & " " & x
    End Sub

    Private Sub ToolStripMenuItemOpenImage_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemOpenImage.Click
        Debug.Print("ToolStripMenuItemOpenImage_Click")
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ListBox1.Items.Clear()
            For Each strFilePath As String In OpenFileDialog1.FileNames
                ListBox1.Items.Add(strFilePath)
            Next
        End If
        ToolStripMenuItemSkipNextImage_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItemSaveSplit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSaveSplit.Click
        Debug.Print("ToolStripMenuItemSaveSplit_Click")
        Dim x As Integer = -PictureBoxRight.Left * (100 / Val(TextBoxZoom.Text))
        Dim h As Integer = PictureBoxLoad.Height
        Dim w As Integer = PictureBoxLoad.Width - x
        Dim bmpLeft As New System.Drawing.Bitmap(x, h)
        Dim bmpRight As New System.Drawing.Bitmap(w, h)
        Dim graphLeft As Graphics = Graphics.FromImage(bmpLeft)
        Dim graphRight As Graphics = Graphics.FromImage(bmpRight)
        Dim srcLeft As New Rectangle(0, 0, x, h)
        Dim destLeft As New Rectangle(0, 0, x, h)
        Dim srcRight As New Rectangle(x, 0, w, h)
        Dim destRight As New Rectangle(0, 0, w, h)
        graphLeft.DrawImage(PictureBoxLoad.Image, destLeft, srcLeft, GraphicsUnit.Pixel)
        graphRight.DrawImage(PictureBoxLoad.Image, destRight, srcRight, GraphicsUnit.Pixel)
        Dim path As String = RemoveExt(ListBox1.SelectedItem)
        bmpLeft.Save(path & "_l.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        bmpRight.Save(path & "_r.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

    Private Sub ToolStripMenuItemSaveSplitAndNextImage_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSaveSplitAndNextImage.Click
        Debug.Print("ToolStripMenuItemSaveSplitAndNextImage_Click")
        ToolStripMenuItemSaveSplit_Click(sender, e)
        ToolStripMenuItemSkipNextImage_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItemSkipNextImage_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSkipNextImage.Click
        Debug.Print("ToolStripMenuItemSkipNextImage_Click")
        SaveWork()
        Dim i As Integer = Val(TextBoxIndex.Text) + 1
        If ListBox1.Items.Count > i Then
            ListBox1.SelectedIndex = i
        Else
            ListBox1.SelectedIndex = -1
        End If
        If ListBox1.Items.Count + 1 > i Then
            TextBoxIndex.Text = "" & i
        End If
    End Sub

    Private Sub ToolStripMenuItemPreviousImage_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemPreviousImage.Click
        Debug.Print("ToolStripMenuItemPreviousImage_Click")
        SaveWork()
        Dim i As Integer = Val(TextBoxIndex.Text) - 1
        If i >= 0 Then
            ListBox1.SelectedIndex = i
            TextBoxIndex.Text = "" & i
        End If
    End Sub

    Private Sub ToolStripMenuItemZoomIn_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemZoomIn.Click
        Debug.Print("ToolStripMenuItemZoomIn_Click")
        If TextBoxZoom.Text = "200" Then TextBoxZoom.Text = "400"
        If TextBoxZoom.Text = "100" Then TextBoxZoom.Text = "200"
        If TextBoxZoom.Text = "50" Then TextBoxZoom.Text = "100"
        If TextBoxZoom.Text = "25" Then TextBoxZoom.Text = "50"
    End Sub

    Private Sub ToolStripMenuItemZoomOut_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemZoomOut.Click
        Debug.Print("ToolStripMenuItemZoomOut_Click")
        If TextBoxZoom.Text = "50" Then TextBoxZoom.Text = "25"
        If TextBoxZoom.Text = "100" Then TextBoxZoom.Text = "50"
        If TextBoxZoom.Text = "200" Then TextBoxZoom.Text = "100"
        If TextBoxZoom.Text = "400" Then TextBoxZoom.Text = "200"
    End Sub

    Private Sub ToolStripMenuItemZoom400_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemZoom400.Click
        Debug.Print("ToolStripMenuItemZoom400_Click")
        TextBoxZoom.Text = "400"
    End Sub

    Private Sub ToolStripMenuItemZoom200_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemZoom200.Click
        Debug.Print("ToolStripMenuItemZoom200_Click")
        TextBoxZoom.Text = "200"
    End Sub

    Private Sub ToolStripMenuItemZoom100_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemZoom100.Click
        Debug.Print("ToolStripMenuItemZoom100_Click")
        TextBoxZoom.Text = "100"
    End Sub

    Private Sub ToolStripMenuItemZoom50_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemZoom50.Click
        Debug.Print("ToolStripMenuItemZoom50_Click")
        TextBoxZoom.Text = "50"
    End Sub

    Private Sub ToolStripMenuItemZoom25_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemZoom25.Click
        Debug.Print("ToolStripMenuItemZoom25_Click")
        TextBoxZoom.Text = "25"
    End Sub

    Private Sub ToolStripMenuItemExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemExit.Click
        Debug.Print("ToolStripMenuItemExit_Click")
        End
    End Sub

End Class
