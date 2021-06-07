''	This is a tool for searching and replacing.
''	a)For searching↓
''	①Click the tab
''	②Browse the file
''	③Type word in "Search for/Word for replacing" for searching.
''	④Search.
''	⑤Wait until the result display.
''	⑥You can save the result into a text file or any other file.Just press "Save Searched Result"
''	
''	b)For replacing↓
''	①Click the tab
''	②Browse the file
''	③Type word in "Search for/Word for replacing" for searching.
''	④Browse the file in "Replace To" This will be the file to save the replaced file.
''	⑤Type any word you want to replace in "Replace With"
''	⑥Search and Replace All
''	⑦Wait until the result display.
''	
''	
''	Comments and feedback:
''	metalkapil






Imports System.IO
Imports System.Threading
Public Class Form1
    Public appName As String
    Public str As String
    Public globalCount As Long 'Double
    Public srcFile As String
    Dim chkArray As Long 'for more than, 10000 data found it's index
    Dim totalLines As Long
    Public gstrFoundOnly(10000) As String ' for more than 10000*10000 data found
    Dim resultTocopy As String
    Public saveFile As String
    Public saveSARFile As String
    Public gLines As Long
    Public globalSARCount As Long

    Public srcFileExt As String
    Public trdSearch As Thread
    Public trdSAR As Thread
    Public trdRead As Thread

    Dim divisor
    Public prgbrmaxval As Integer



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        btnGo.Enabled = True
        disbtn()
        appName = "search and replace"
        lblSearch.Text = "Search for " & vbCrLf & "/Word for replacing"
        Dim srlblstr = "Search for/Word for replacing"
        Dim strAbout As String
        llblCopyResult.Enabled = False





        strAbout = "This is a tool for searching and replacing." & vbCrLf &
        "a)For searching↓" & vbCrLf &
        "①Click the tab" & vbCrLf &
        "②Browse the file" & vbCrLf &
        "③Type word in " & Chr(34) & srlblstr & Chr(34) & " for searching." & vbCrLf &
        "④Search." & vbCrLf &
        "⑤Wait until the result display." & vbCrLf &
        "⑥You can save the result into a text file or any other file.Just press " & Chr(34) & btnSaveSrc.Text & Chr(34) & vbCrLf &
        "" & vbCrLf &
        "b)For replacing↓" & vbCrLf &
        "①Click the tab" & vbCrLf &
        "②Browse the file" & vbCrLf &
        "③Type word in " & Chr(34) & srlblstr & Chr(34) & " for searching." & vbCrLf &
        "④Browse the file in " & Chr(34) & lblSAR.Text & Chr(34) & " This will be the file to save the replaced file." & vbCrLf &
        "⑤Type any word you want to replace in " & Chr(34) & lblReplace.Text & Chr(34) & vbCrLf &
        "⑥" & btnGo.Text & vbCrLf &
        "⑦Wait until the result display." & vbCrLf &
        "" & vbCrLf &
        "" & vbCrLf &
        "Comments and feedback:" & vbCrLf &
        "metalkapil" & vbCrLf
        rtxtAbout.Text = strAbout

    End Sub
    Private Sub rtxtAbout_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles rtxtAbout.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub
    Private Sub srfilename()
        Dim strdate As String
        strdate = Now.Year.ToString + "-" + Now.Month.ToString + "-" + Now.Day.ToString + "-" + Now.Hour.ToString + "_" + Now.Minute.ToString + "_" + Now.Second.ToString
        saveFile = strdate + ".txt"
        saveSARFile = strdate + ".txt"
    End Sub
    Private Sub disbtn()
        btnSearch.Enabled = False
        btnSaveSrc.Enabled = False
        btnSAR.Enabled = False
        btnGo.Enabled = False
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim ans As Integer
        If saveSARFile = "" Then
            ans = MsgBox("Are you sure you want to make filename with today's time?", MsgBoxStyle.YesNo, appName)
            If ans = MsgBoxResult.Yes Then
                srfilename()
            Else
                btnSAR.Focus()
                Exit Sub
            End If
        End If
        trdSearch = New Thread(AddressOf threadSAR)
        trdSearch.IsBackground = True
        trdSearch.Start()
        ProgressBar1.Value = 0
        Timer2.Interval = 1
        Timer2.Start()
    End Sub
    Private Sub threadSAR()
        txtResult.Text = "Please wait..."
        TabControl1.Enabled = False
        Dim sr As StreamReader = New StreamReader(srcFile)
        Dim sw As StreamWriter = New StreamWriter(saveSARFile)
        Dim strRead As String
        Dim strRead1 As String
        globalCount = 0
        globalSARCount = 0
        strRead1 = ""
        Dim src As String
        Dim rep As String
        src = txtSearch.Text
        rep = txtReplace.Text
        Do While sr.Peek() >= 0
            strRead = sr.ReadLine
            strRead1 = Replace(strRead, src, rep)
            If strRead <> strRead1 Then
                sw.WriteLine(strRead1)
                globalCount = globalCount + 1
            Else
                sw.WriteLine(strRead)
                globalSARCount = globalSARCount + 1
            End If
        Loop
        sw.Close()
        sw = Nothing
        sr.Close()
        sr = Nothing
        Dim strResult4disp As String
        Timer2.Enabled = False 'for displaying in txtresult.text the final result to user
        strResult4disp = globalCount & " lines containing " & Chr(34) & src & Chr(34) & " are replaced with " & Chr(34) & rep & Chr(34) & "."
        txtResult.Text = strResult4disp

        ProgressBar1.Value = prgbrmaxval
        If globalCount <> 0 Then
            MsgBox(globalCount & " lines replacement done" & vbCrLf & "Saved to " & saveSARFile & vbCrLf & "", 64, appName)
        Else
            MsgBox("No string found." & vbCrLf & "", 64, appName)
        End If
        TabControl1.Enabled = True
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'On Error Resume Next
        trdSearch = New Thread(AddressOf threadSearch)
        trdSearch.IsBackground = True
        trdSearch.Start()
        ProgressBar1.Value = 0
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub threadSearch()
        txtResult.Text = "Please wait..."
        TabControl1.Enabled = False
        Dim sr As StreamReader = New StreamReader(srcFile)
        Dim strRead As String
        Dim strResult(10000) As String 'for more than 10000 data found all are written in next string
        globalCount = 0
        strResult(0) = ""
        'txtReplace.Text = ""
        txtAllResult.Text = ""
        resultTocopy = ""
        gstrFoundOnly(0) = ""
        Dim src As String
        Dim rep As String
        Dim foundFlag As Long
        Dim flagArray(10000) As Long
        chkArray = 0
        foundFlag = 0
        src = txtSearch.Text
        rep = txtReplace.Text
        Do While sr.Peek() >= 0
            strRead = sr.ReadLine
            globalCount = globalCount + 1
            If strRead.Contains(src) = True Then
                If foundFlag > 9999 Then
                    chkArray = chkArray + 1
                    foundFlag = 0
                End If
                flagArray(foundFlag) = globalCount
                gstrFoundOnly(chkArray) = gstrFoundOnly(chkArray) + strRead + vbCrLf
                strResult(chkArray) = strResult(chkArray) + "Found in line No. " + flagArray(foundFlag).ToString + ": " + strRead + vbCrLf
                foundFlag = foundFlag + 1
            End If
        Loop
        sr.Close()
        sr = Nothing
        Dim i As Integer
        Dim finalShowresult As String
        finalShowresult = ""

        totalLines = chkArray * 10000 + foundFlag
        For i = 0 To chkArray
            finalShowresult = finalShowresult + strResult(i)
        Next
        txtAllResult.Text = finalShowresult
        Dim strResult4disp As String
        Timer1.Enabled = False 'for displaying in txtresult.text the final result to user
        strResult4disp = totalLines & " lines are found with " & Chr(34) & src & Chr(34) & "."
        txtResult.Text = strResult4disp
        If globalCount <> 0 Then
            MsgBox(strResult4disp & vbCrLf & "", 64, appName)
        Else
            MsgBox("No string found." & vbCrLf & "", 64, appName)
        End If
        TabControl1.Enabled = True
    End Sub
    Sub copyResult()
        Dim i
        If resultTocopy = "" Then
            For i = 0 To chkArray
                resultTocopy = resultTocopy + gstrFoundOnly(i) '+ vbCrLf
            Next
            Clipboard.SetText(resultTocopy)
        Else
            Clipboard.SetText(resultTocopy)
        End If
    End Sub

    Sub saveSrcResult()
        Dim i
        If resultTocopy = "" Then
            For i = 0 To chkArray
                resultTocopy = resultTocopy + gstrFoundOnly(i) '+ vbCrLf
            Next
        Else
        End If
    End Sub
    Private Sub llblCopyResult_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblCopyResult.LinkClicked
        copyResult()
        MsgBox("Copied to clipboard." & vbCrLf & "Use Ctrl + V." & vbCrLf & "", 64, appName)
    End Sub

    Private Sub txtAllResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAllResult.TextChanged
        If txtAllResult.Text <> "" Then
            llblCopyResult.Enabled = True
            btnSaveSrc.Enabled = True
        Else
            llblCopyResult.Enabled = False
            btnSaveSrc.Enabled = False
        End If
    End Sub

    Private Sub btnSaveSrc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSrc.Click
        SaveFileDialog1.Filter = "Text (*.txt) |*.txt|Dictionary (*.dic) |*.dic|html file (*.html,*.htm) |*.html;*.htm|Log (*.log) |*.log|All Files(*.*) |*.*"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MsgBox("Saved to " & saveFile & vbCrLf & "", 64, appName)
        End If
    End Sub
    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        saveSrcResult()
        saveFile = SaveFileDialog1.FileName
        Dim sw As StreamWriter = New StreamWriter(saveFile)
        sw.Write(resultTocopy)
        sw.Close()
    End Sub
    Sub readFile()
        globalCount = 0
        Dim sr As StreamReader = New StreamReader(srcFile)
        While sr.Peek > 0
            Dim str = sr.ReadLine()
            globalCount = globalCount + 1
        End While
        forProgMaxVal(globalCount)
        gLines = globalCount 'if glines >0 then search btn active
        sr.Close()
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        srcFile = OpenFileDialog1.FileName
        readFile()

        ProgressBar1.Value = 0
        Timer1.Interval = 10
        Timer1.Start()

        Timer1.Enabled = False 'for displaying in txtresult.text the final result to user
        txtResult.Text = "Reading Done.No. Lines: " & globalCount.ToString
        ProgressBar1.Value = prgbrmaxval
        srcFileExt = IO.Path.GetExtension(srcFile)
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "All Files(*.*)|*.*|Text (*.txt) |*.txt|Dictionary (*.dic) |*.dic|html file (*.html,*.htm) |*.html;*.htm|Log (*.log) |*.log"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BackgroundWorker1.WorkerReportsProgress = True
            BackgroundWorker1.RunWorkerAsync()
            txtFile.Text = srcFile
        End If
    End Sub
    Private Sub forProgMaxVal(ByVal num As Long) 'this function is call by readFile only for divisor soln
        divisor = 0
        'btnSearch.Enabled = True
        If num / 1000000000 > 1 Then '1 billion
            divisor = 10000000
            prgbrmaxval = num / divisor
        ElseIf num / 100000000 > 1 Then
            divisor = 1000000
            prgbrmaxval = num / divisor
        ElseIf num / 10000000 > 1 Then
            divisor = 100000
            prgbrmaxval = num / divisor
        ElseIf num / 1000000 > 1 Then
            divisor = 10000
            prgbrmaxval = num / divisor
        ElseIf num / 100000 > 1 Then
            divisor = 1000
            prgbrmaxval = num / divisor
        ElseIf num / 10000 > 1 Then
            divisor = 100
            prgbrmaxval = num / divisor
        ElseIf num / 1000 > 1 Then
            divisor = 10
            prgbrmaxval = num / divisor
        ElseIf num / 100 > 1 Then
            divisor = 1
            prgbrmaxval = num / divisor
        ElseIf num / 10 > 1 Then
            divisor = 0.1
            prgbrmaxval = num / divisor
        ElseIf num / 1 > 1 Then
            divisor = 0.01
            prgbrmaxval = num / divisor
        End If
        ProgressBar1.Maximum = prgbrmaxval
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum Then
            ProgressBar1.Value = globalCount / divisor
            txtResult.Text = "Please wait... " & ((globalCount / gLines) * 100).ToString(0) & "% Done"
        Else
            txtResult.Text = "Reading Done.No. Lines: " & globalCount.ToString
            Timer1.Stop()
        End If
        ProgressBar1.PerformStep()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum Then
            ProgressBar1.Value = (globalCount + globalSARCount) / divisor
            txtResult.Text = "Please wait... " & (((globalCount + globalSARCount) / gLines) * 100).ToString(0) & "% Done"
        Else
            txtResult.Text = "Reading Done.No. Lines: " & globalCount.ToString
            Timer1.Stop()
        End If
        ProgressBar1.PerformStep()
    End Sub

    Private Sub SaveFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog2.FileOk
        saveSARFile = SaveFileDialog2.FileName
    End Sub

    Private Sub btnSAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSAR.Click
        SaveFileDialog2.Filter = Mid(srcFileExt, 2, Len(srcFileExt) - 1) & " File Type |*" & srcFileExt
        If SaveFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSAR.Text = saveSARFile
            BackgroundWorker1.WorkerReportsProgress = True
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'If globalCount > 0 Then
        If gLines <> 0 Then
            btnSearch.Enabled = True
            btnSAR.Enabled = True
        Else
            btnSearch.Enabled = False
            btnSAR.Enabled = False
        End If
        If saveSARFile <> "" Then
            btnGo.Enabled = True
        Else
            btnGo.Enabled = False
        End If
    End Sub
End Class
