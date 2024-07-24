<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemOpenImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSaveSplit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemSaveSplitAndNextImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSkipNextImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemPreviousImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemView = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemZoomIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemZoomOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemZoom400 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemZoom200 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemZoom100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemZoom50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemZoom25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBoxIndex = New System.Windows.Forms.TextBox()
        Me.TextBoxZoom = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBoxLoad = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBoxLeft = New System.Windows.Forms.PictureBox()
        Me.PictureBoxRight = New System.Windows.Forms.PictureBox()
        Me.PictureBoxZoom = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBoxLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBoxLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFile, Me.ToolStripMenuItemView})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItemFile
        '
        Me.ToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemOpenImage, Me.ToolStripMenuItemSaveSplit, Me.ToolStripMenuItem1, Me.ToolStripMenuItemSaveSplitAndNextImage, Me.ToolStripMenuItemSkipNextImage, Me.ToolStripMenuItemPreviousImage, Me.ToolStripMenuItem2, Me.ToolStripMenuItemExit})
        Me.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile"
        Me.ToolStripMenuItemFile.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripMenuItemFile.Text = "&File"
        '
        'ToolStripMenuItemOpenImage
        '
        Me.ToolStripMenuItemOpenImage.Name = "ToolStripMenuItemOpenImage"
        Me.ToolStripMenuItemOpenImage.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItemOpenImage.Size = New System.Drawing.Size(257, 22)
        Me.ToolStripMenuItemOpenImage.Text = "&Open Image"
        '
        'ToolStripMenuItemSaveSplit
        '
        Me.ToolStripMenuItemSaveSplit.Enabled = False
        Me.ToolStripMenuItemSaveSplit.Name = "ToolStripMenuItemSaveSplit"
        Me.ToolStripMenuItemSaveSplit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItemSaveSplit.Size = New System.Drawing.Size(257, 22)
        Me.ToolStripMenuItemSaveSplit.Text = "&Save Split"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(254, 6)
        '
        'ToolStripMenuItemSaveSplitAndNextImage
        '
        Me.ToolStripMenuItemSaveSplitAndNextImage.Enabled = False
        Me.ToolStripMenuItemSaveSplitAndNextImage.Name = "ToolStripMenuItemSaveSplitAndNextImage"
        Me.ToolStripMenuItemSaveSplitAndNextImage.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ToolStripMenuItemSaveSplitAndNextImage.Size = New System.Drawing.Size(257, 22)
        Me.ToolStripMenuItemSaveSplitAndNextImage.Text = "Save Split And &Next Image"
        '
        'ToolStripMenuItemSkipNextImage
        '
        Me.ToolStripMenuItemSkipNextImage.Enabled = False
        Me.ToolStripMenuItemSkipNextImage.Name = "ToolStripMenuItemSkipNextImage"
        Me.ToolStripMenuItemSkipNextImage.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.ToolStripMenuItemSkipNextImage.Size = New System.Drawing.Size(257, 22)
        Me.ToolStripMenuItemSkipNextImage.Text = "S&kip Next Image"
        '
        'ToolStripMenuItemPreviousImage
        '
        Me.ToolStripMenuItemPreviousImage.Enabled = False
        Me.ToolStripMenuItemPreviousImage.Name = "ToolStripMenuItemPreviousImage"
        Me.ToolStripMenuItemPreviousImage.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.ToolStripMenuItemPreviousImage.Size = New System.Drawing.Size(257, 22)
        Me.ToolStripMenuItemPreviousImage.Text = "&Previous Image"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(254, 6)
        '
        'ToolStripMenuItemExit
        '
        Me.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit"
        Me.ToolStripMenuItemExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ToolStripMenuItemExit.Size = New System.Drawing.Size(257, 22)
        Me.ToolStripMenuItemExit.Text = "&Exit"
        '
        'ToolStripMenuItemView
        '
        Me.ToolStripMenuItemView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemZoomIn, Me.ToolStripMenuItemZoomOut, Me.ToolStripMenuItem3, Me.ToolStripMenuItemZoom400, Me.ToolStripMenuItemZoom200, Me.ToolStripMenuItemZoom100, Me.ToolStripMenuItemZoom50, Me.ToolStripMenuItemZoom25})
        Me.ToolStripMenuItemView.Name = "ToolStripMenuItemView"
        Me.ToolStripMenuItemView.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripMenuItemView.Text = "&View"
        '
        'ToolStripMenuItemZoomIn
        '
        Me.ToolStripMenuItemZoomIn.Enabled = False
        Me.ToolStripMenuItemZoomIn.Name = "ToolStripMenuItemZoomIn"
        Me.ToolStripMenuItemZoomIn.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.ToolStripMenuItemZoomIn.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItemZoomIn.Text = "Zoom In"
        '
        'ToolStripMenuItemZoomOut
        '
        Me.ToolStripMenuItemZoomOut.Enabled = False
        Me.ToolStripMenuItemZoomOut.Name = "ToolStripMenuItemZoomOut"
        Me.ToolStripMenuItemZoomOut.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.ToolStripMenuItemZoomOut.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItemZoomOut.Text = "Zoom Out"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripMenuItemZoom400
        '
        Me.ToolStripMenuItemZoom400.Enabled = False
        Me.ToolStripMenuItemZoom400.Name = "ToolStripMenuItemZoom400"
        Me.ToolStripMenuItemZoom400.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItemZoom400.Text = "400%"
        '
        'ToolStripMenuItemZoom200
        '
        Me.ToolStripMenuItemZoom200.Enabled = False
        Me.ToolStripMenuItemZoom200.Name = "ToolStripMenuItemZoom200"
        Me.ToolStripMenuItemZoom200.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItemZoom200.Text = "200%"
        '
        'ToolStripMenuItemZoom100
        '
        Me.ToolStripMenuItemZoom100.Checked = True
        Me.ToolStripMenuItemZoom100.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItemZoom100.Enabled = False
        Me.ToolStripMenuItemZoom100.Name = "ToolStripMenuItemZoom100"
        Me.ToolStripMenuItemZoom100.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.ToolStripMenuItemZoom100.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItemZoom100.Text = "100%"
        '
        'ToolStripMenuItemZoom50
        '
        Me.ToolStripMenuItemZoom50.Enabled = False
        Me.ToolStripMenuItemZoom50.Name = "ToolStripMenuItemZoom50"
        Me.ToolStripMenuItemZoom50.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItemZoom50.Text = "50%"
        '
        'ToolStripMenuItemZoom25
        '
        Me.ToolStripMenuItemZoom25.Enabled = False
        Me.ToolStripMenuItemZoom25.Name = "ToolStripMenuItemZoom25"
        Me.ToolStripMenuItemZoom25.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItemZoom25.Text = "25%"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 23)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(12, 18)
        Me.ToolStripStatusLabel1.Text = " "
        '
        'TextBoxIndex
        '
        Me.TextBoxIndex.Location = New System.Drawing.Point(0, 29)
        Me.TextBoxIndex.Name = "TextBoxIndex"
        Me.TextBoxIndex.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxIndex.TabIndex = 2
        Me.TextBoxIndex.Text = "-1"
        Me.TextBoxIndex.Visible = False
        '
        'TextBoxZoom
        '
        Me.TextBoxZoom.Location = New System.Drawing.Point(0, 54)
        Me.TextBoxZoom.Name = "TextBoxZoom"
        Me.TextBoxZoom.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxZoom.TabIndex = 3
        Me.TextBoxZoom.Text = "100"
        Me.TextBoxZoom.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(0, 79)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 88)
        Me.ListBox1.TabIndex = 4
        Me.ListBox1.Visible = False
        '
        'PictureBoxLoad
        '
        Me.PictureBoxLoad.InitialImage = Global.ImageSplit.My.Resources.Resources._11
        Me.PictureBoxLoad.Location = New System.Drawing.Point(0, 173)
        Me.PictureBoxLoad.Name = "PictureBoxLoad"
        Me.PictureBoxLoad.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxLoad.TabIndex = 5
        Me.PictureBoxLoad.TabStop = False
        Me.PictureBoxLoad.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.PictureBoxZoom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 213)
        Me.Panel1.TabIndex = 6
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBoxLeft)
        Me.SplitContainer1.Panel1MinSize = 1
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBoxRight)
        Me.SplitContainer1.Panel2MinSize = 1
        Me.SplitContainer1.Size = New System.Drawing.Size(275, 213)
        Me.SplitContainer1.SplitterDistance = 110
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 3
        '
        'PictureBoxLeft
        '
        Me.PictureBoxLeft.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxLeft.Name = "PictureBoxLeft"
        Me.PictureBoxLeft.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLeft.TabIndex = 1
        Me.PictureBoxLeft.TabStop = False
        Me.PictureBoxLeft.Visible = False
        '
        'PictureBoxRight
        '
        Me.PictureBoxRight.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxRight.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxRight.Name = "PictureBoxRight"
        Me.PictureBoxRight.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRight.TabIndex = 3
        Me.PictureBoxRight.TabStop = False
        Me.PictureBoxRight.Visible = False
        '
        'PictureBoxZoom
        '
        Me.PictureBoxZoom.Location = New System.Drawing.Point(10, 0)
        Me.PictureBoxZoom.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxZoom.Name = "PictureBoxZoom"
        Me.PictureBoxZoom.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxZoom.TabIndex = 1
        Me.PictureBoxZoom.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image File|*.bmp;*.png;*.jpg"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBoxLoad)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBoxZoom)
        Me.Controls.Add(Me.TextBoxIndex)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "ImageSplit 1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBoxLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBoxLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemOpenImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSaveSplit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemSaveSplitAndNextImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSkipNextImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemPreviousImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemZoomIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemZoomOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemZoom400 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemZoom200 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemZoom100 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemZoom50 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemZoom25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TextBoxIndex As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxZoom As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBoxLoad As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxZoom As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBoxLeft As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxRight As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
