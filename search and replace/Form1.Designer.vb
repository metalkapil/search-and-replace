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
        Me.components = New System.ComponentModel.Container
        Me.btnGo = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.txtReplace = New System.Windows.Forms.TextBox
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblReplace = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtAllResult = New System.Windows.Forms.TextBox
        Me.lblResult = New System.Windows.Forms.Label
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.llblCopyResult = New System.Windows.Forms.LinkLabel
        Me.btnSaveSrc = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.lblFile = New System.Windows.Forms.Label
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtSAR = New System.Windows.Forms.TextBox
        Me.lblSAR = New System.Windows.Forms.Label
        Me.btnSAR = New System.Windows.Forms.Button
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabSAR = New System.Windows.Forms.TabPage
        Me.tabAbout = New System.Windows.Forms.TabPage
        Me.rtxtAbout = New System.Windows.Forms.RichTextBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TabControl1.SuspendLayout()
        Me.tabSAR.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(196, 115)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(86, 35)
        Me.btnGo.TabIndex = 9
        Me.btnGo.Text = "Search and Replace All"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(68, 39)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(122, 20)
        Me.txtSearch.TabIndex = 3
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(68, 123)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(122, 20)
        Me.txtReplace.TabIndex = 8
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(12, 45)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(0, 13)
        Me.lblSearch.TabIndex = 3
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(-2, 130)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(72, 13)
        Me.lblReplace.TabIndex = 3
        Me.lblReplace.Text = "Replace With"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(197, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtAllResult
        '
        Me.txtAllResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAllResult.Location = New System.Drawing.Point(0, 200)
        Me.txtAllResult.Multiline = True
        Me.txtAllResult.Name = "txtAllResult"
        Me.txtAllResult.ReadOnly = True
        Me.txtAllResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAllResult.Size = New System.Drawing.Size(283, 82)
        Me.txtAllResult.TabIndex = 12
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(22, 161)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "Result"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(68, 154)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(204, 20)
        Me.txtResult.TabIndex = 10
        '
        'llblCopyResult
        '
        Me.llblCopyResult.AutoSize = True
        Me.llblCopyResult.Location = New System.Drawing.Point(65, 176)
        Me.llblCopyResult.Name = "llblCopyResult"
        Me.llblCopyResult.Size = New System.Drawing.Size(31, 13)
        Me.llblCopyResult.TabIndex = 11
        Me.llblCopyResult.TabStop = True
        Me.llblCopyResult.Text = "Copy"
        '
        'btnSaveSrc
        '
        Me.btnSaveSrc.Location = New System.Drawing.Point(160, 64)
        Me.btnSaveSrc.Name = "btnSaveSrc"
        Me.btnSaveSrc.Size = New System.Drawing.Size(122, 23)
        Me.btnSaveSrc.TabIndex = 5
        Me.btnSaveSrc.Text = "Save Searched Result"
        Me.btnSaveSrc.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 190)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(296, 10)
        Me.ProgressBar1.TabIndex = 10
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(197, 6)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(85, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(36, 20)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(23, 13)
        Me.lblFile.TabIndex = 12
        Me.lblFile.Text = "File"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(68, 13)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(122, 20)
        Me.txtFile.TabIndex = 1
        '
        'OpenFileDialog1
        '
        '
        'Timer1
        '
        '
        'txtSAR
        '
        Me.txtSAR.Location = New System.Drawing.Point(68, 93)
        Me.txtSAR.Name = "txtSAR"
        Me.txtSAR.Size = New System.Drawing.Size(122, 20)
        Me.txtSAR.TabIndex = 6
        '
        'lblSAR
        '
        Me.lblSAR.AutoSize = True
        Me.lblSAR.Location = New System.Drawing.Point(-1, 99)
        Me.lblSAR.Name = "lblSAR"
        Me.lblSAR.Size = New System.Drawing.Size(63, 13)
        Me.lblSAR.TabIndex = 15
        Me.lblSAR.Text = "Replace To"
        '
        'btnSAR
        '
        Me.btnSAR.Location = New System.Drawing.Point(196, 89)
        Me.btnSAR.Name = "btnSAR"
        Me.btnSAR.Size = New System.Drawing.Size(86, 23)
        Me.btnSAR.TabIndex = 7
        Me.btnSAR.Text = "Save As"
        Me.btnSAR.UseVisualStyleBackColor = True
        '
        'SaveFileDialog2
        '
        '
        'Timer2
        '
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabSAR)
        Me.TabControl1.Controls.Add(Me.tabAbout)
        Me.TabControl1.Location = New System.Drawing.Point(4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(291, 304)
        Me.TabControl1.TabIndex = 0
        '
        'tabSAR
        '
        Me.tabSAR.Controls.Add(Me.btnSAR)
        Me.tabSAR.Controls.Add(Me.btnBrowse)
        Me.tabSAR.Controls.Add(Me.lblSAR)
        Me.tabSAR.Controls.Add(Me.btnGo)
        Me.tabSAR.Controls.Add(Me.txtSAR)
        Me.tabSAR.Controls.Add(Me.txtSearch)
        Me.tabSAR.Controls.Add(Me.txtFile)
        Me.tabSAR.Controls.Add(Me.txtReplace)
        Me.tabSAR.Controls.Add(Me.lblFile)
        Me.tabSAR.Controls.Add(Me.lblSearch)
        Me.tabSAR.Controls.Add(Me.lblReplace)
        Me.tabSAR.Controls.Add(Me.ProgressBar1)
        Me.tabSAR.Controls.Add(Me.btnSearch)
        Me.tabSAR.Controls.Add(Me.btnSaveSrc)
        Me.tabSAR.Controls.Add(Me.txtAllResult)
        Me.tabSAR.Controls.Add(Me.llblCopyResult)
        Me.tabSAR.Controls.Add(Me.lblResult)
        Me.tabSAR.Controls.Add(Me.txtResult)
        Me.tabSAR.Location = New System.Drawing.Point(4, 22)
        Me.tabSAR.Name = "tabSAR"
        Me.tabSAR.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSAR.Size = New System.Drawing.Size(283, 278)
        Me.tabSAR.TabIndex = 0
        Me.tabSAR.Text = "Search and Replace"
        Me.tabSAR.UseVisualStyleBackColor = True
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.rtxtAbout)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(283, 278)
        Me.tabAbout.TabIndex = 1
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'rtxtAbout
        '
        Me.rtxtAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtAbout.Location = New System.Drawing.Point(0, 0)
        Me.rtxtAbout.Name = "rtxtAbout"
        Me.rtxtAbout.ReadOnly = True
        Me.rtxtAbout.Size = New System.Drawing.Size(280, 282)
        Me.rtxtAbout.TabIndex = 1
        Me.rtxtAbout.Text = ""
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 305)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "search and replace"
        Me.TabControl1.ResumeLayout(False)
        Me.tabSAR.ResumeLayout(False)
        Me.tabSAR.PerformLayout()
        Me.tabAbout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblReplace As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtAllResult As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents llblCopyResult As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSaveSrc As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtSAR As System.Windows.Forms.TextBox
    Friend WithEvents lblSAR As System.Windows.Forms.Label
    Friend WithEvents btnSAR As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents tabSAR As System.Windows.Forms.TabPage
    Friend WithEvents rtxtAbout As System.Windows.Forms.RichTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
