Imports System.Globalization
Imports System.IO
Imports DevComponents.DotNetBar

Public Class Form1

    Public TempDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\SMBX Magic Patcher"
    Private SMBXPFX As New SMBXPFX
    Private ReadOnly fileSeperatorChar As String = CultureInfo.CurrentCulture.TextInfo.ListSeparator

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        With New OpenFileDialog
            .Filter = "SMBX-38A Levels (*.lvl)|*.lvl"
            If .ShowDialog = Not DialogResult.OK Then
                Exit Sub
            End If
            TextBoxX_OriginalLevelCreate.Text = .FileName
        End With
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        With New OpenFileDialog
            .Filter = "SMBX-38A Levels (*.lvl)|*.lvl"
            If .ShowDialog = Not DialogResult.OK Then
                Exit Sub
            End If
            TextBoxX_ModifiedLevel.Text = .FileName
        End With
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With New SaveFileDialog
            .Filter = "SMBX Magic Patch (*.plx)|*.plx"
            If .ShowDialog = Not DialogResult.OK Then
                Exit Sub
            End If
            TextBoxX_PatchFileCreate.Text = .FileName
        End With
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        With New OpenFileDialog
            .Filter = "SMBX-38A Levels (*.lvl)|*.lvl"
            .Multiselect = True
            If .ShowDialog = Not DialogResult.OK Then
                Exit Sub
            End If
            TextBoxX_OriginalLevelApply.Text = GetFileListAsString(.FileNames)
        End With
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        With New OpenFileDialog
            .Filter = "All supported files (*.plx, *.slp)|*.plx;*.slp"
            .Multiselect = True
            If .ShowDialog = Not DialogResult.OK Then
                Exit Sub
            End If
            TextBoxX_PatchFileApply.Text = GetFileListAsString(.FileNames)
        End With
    End Sub

    Private Function GetFileListAsString(files As String()) As String
        Dim str As String = String.Empty

        For Each file As String In files
            If Not String.IsNullOrEmpty(str) Then
                str &= fileSeperatorChar
            End If
            str &= file
        Next

        Return str
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_CreatePatch.Click
        CircularProgress_Create.IsRunning = True
        Button_CreatePatch.Enabled = False
        LabelX15.Visible = True

        Select Case SMBXPFX.CreatePatch(TextBoxX_OriginalLevelCreate.Text,
                                        TextBoxX_ModifiedLevel.Text,
                                        TextBoxX_PatchFileCreate.Text,
                                        CheckBoxX2.Checked,
                                        SwitchButton_BlocksEtc.Value,
                                        SwitchButton_Graphics.Value,
                                        SwitchButton_Configs.Value,
                                        SwitchButton_Events.Value,
                                        SwitchButton_Layers.Value,
                                        SwitchButton_Variables.Value,
                                        SwitchButton_Scripts.Value,
                                        SwitchButton_Liquids.Value)

            Case 1
                MessageBoxEx.Show("Patch succesfully created!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBoxEx.Show("There is an error at packing!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case Else
                MessageBoxEx.Show("There is an unknown error!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        Button_CreatePatch.Enabled = True
        LabelX15.Visible = False
        CircularProgress_Create.IsRunning = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_ApplyPatch.Click
        CircularProgress_Apply.IsRunning = True
        LabelX14.Visible = True
        Button_ApplyPatch.Enabled = False

        ApplyPatch(TextBoxX_PatchFileApply.Text.Split(fileSeperatorChar),
                   TextBoxX_OriginalLevelApply.Text.Split(fileSeperatorChar))

        LabelX14.Visible = False
        CircularProgress_Apply.IsRunning = False
        Button_ApplyPatch.Enabled = True
    End Sub

    Private Sub ApplyPatch(patchFiles As String(), levelFiles As String())
        Dim noErrors As Integer = 0

        For Each levelFile As String In levelFiles
            Dim msgEnd As String = "<br/><br/>Level file:<br/>" & levelFile
            Select Case SMBXPFX.ApplyPatch(levelFile, patchFiles)
                Case 1
                    noErrors += 1
                Case 2
                    MessageBoxEx.Show("There is an error at extracting files! Or maybe this isn't a valid patch file." & msgEnd, "Done", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 3
                    MessageBoxEx.Show("This isn't a valid patch file." & msgEnd, "Done", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBoxEx.Show("There is an unknown error!" & msgEnd, "Done", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        Next

        If noErrors >= levelFiles.Length Then
            MessageBoxEx.Show("All patches applied succesfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf noErrors < levelFiles.Length Then
            MessageBoxEx.Show("All patches applied, but there seems to be some errors!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBoxEx.Show("No patch applied! There are some errors.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckBoxX2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxX2.CheckedChanged
        ButtonX1.Enabled = CheckBoxX2.Checked
        TextBoxX_OriginalLevelCreate.Enabled = CheckBoxX2.Checked
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedTabChanged
        Select Case TabControl2.SelectedTabIndex
            Case 0 : Size = New Point(358, 157)
            Case 1 : Size = New Point(358, 354)
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(TempDir) Then Directory.CreateDirectory(TempDir)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CheckAndApplyCommandLinePatches()
    End Sub

    Private Sub CheckAndApplyCommandLinePatches()
        Dim cmds As String() = Environment.GetCommandLineArgs
        Dim hasCmds As Boolean = cmds.Length > 1
        Dim patchFiles As New List(Of String)
        Dim levelFiles As New List(Of String)

        If hasCmds Then
            For i = 0 To cmds.Length - 1
                Dim cmd As String = cmds(i)
                Select Case Path.GetExtension(cmd).ToLower
                    Case ".lvl"
                        levelFiles.Add(cmd)
                    Case ".plx", ".slp"
                        patchFiles.Add(cmd)
                End Select
            Next
        End If

        TextBoxX_OriginalLevelApply.Text = GetFileListAsString(levelFiles.ToArray)
        TextBoxX_PatchFileApply.Text = GetFileListAsString(patchFiles.ToArray)

        If patchFiles.Any AndAlso levelFiles.Any Then
            Button_ApplyPatch.PerformClick()
        End If
    End Sub

End Class

Public Class SMBXPFX

    Public Function CreatePatch(OriginalLevel As String, PatchedLevel As String, PatchFile As String, Optional UseCustomOriginalLevelFile As Boolean = False, Optional CopyBlocksEtc As Boolean = True, Optional CopyGraphics As Boolean = True, Optional CopyConfigurations As Boolean = True, Optional CopyEvents As Boolean = True, Optional CopyLayers As Boolean = True, Optional CopyVariables As Boolean = True, Optional CopyScripts As Boolean = True, Optional CopyLiquids As Boolean = True) As Integer
        Dim CheckIfFilesExists = True
        If Not UseCustomOriginalLevelFile Then
            OriginalLevel = Application.StartupPath & "\Data\emptylevel\emptylevel.dat"
            CheckIfFilesExists = False
        End If

        Dim OLevel() As String = File.ReadAllLines(OriginalLevel)
        Dim PLevel() As String = File.ReadAllLines(PatchedLevel)
        Dim PFile As New List(Of String)
        Dim UsedThings As New List(Of String)

        'Add differences to patch:
        For Each l As String In PLevel
            If Not l Is "" And Not OLevel.Contains(l) And Not l.StartsWith("SMBXFile") Then
                If l.StartsWith("P1|") Or l.StartsWith("P2|") Or l.StartsWith("M|") Then Continue For
                If l.StartsWith("B|") And Not CopyBlocksEtc Then Continue For 'Blcks
                If l.StartsWith("N|") And Not CopyBlocksEtc Then Continue For 'NPCs
                If l.StartsWith("T|") And Not CopyBlocksEtc Then Continue For 'Backgrounds
                If l.StartsWith("Q|") And Not CopyLiquids Then Continue For 'Liquids
                If l.StartsWith("CB|") And Not CopyConfigurations Then Continue For 'Custom Block Configurations
                If l.StartsWith("CT|") And Not CopyConfigurations Then Continue For 'Custom Backgrounds Configurations
                If l.StartsWith("L|") And Not CopyLayers Then Continue For 'Layer
                If l.StartsWith("E|") And Not CopyEvents Then Continue For 'Events
                If l.StartsWith("V|") And Not CopyVariables Then Continue For 'Variables
                If l.StartsWith("S|") And Not CopyScripts Then Continue For 'Scripts
                If l.StartsWith("Su|") And Not CopyScripts Then Continue For 'Scripts
                If Not PFile.Contains(l) Then PFile.Add(l) 'Finaly add line to patch
            End If
        Next

        'Check for custom graphics:
        Dim OLeveldir As String = Path.GetDirectoryName(OriginalLevel) : Dim OLevelfiledir As String = OLeveldir & "\" & Path.GetFileNameWithoutExtension(OriginalLevel)
        Dim PLeveldir As String = Path.GetDirectoryName(PatchedLevel) : Dim PLevelfiledir As String = PLeveldir & "\" & Path.GetFileNameWithoutExtension(PatchedLevel)
        Dim OFilesInLeveldir() As String = Directory.GetFiles(OLeveldir) : Dim OFilesInLevelfiledir() As String = {} : If Directory.Exists(OLevelfiledir) Then OFilesInLevelfiledir = Directory.GetFiles(OLevelfiledir)
        Dim PFilesInLeveldir() As String = Directory.GetFiles(PLeveldir) : Dim PFilesInLevelfiledir() As String = {} : If Directory.Exists(PLevelfiledir) Then PFilesInLevelfiledir = Directory.GetFiles(PLevelfiledir)
        Dim FilesToCopyInLeveldir As New List(Of String) : Dim FilesToCopyInLevelfiledir As New List(Of String)
        Dim UsedNPCs As New List(Of String)

        If CopyGraphics Then
            For Each f As String In PFilesInLeveldir
                If Not OFilesInLeveldir.Contains(f) And Not FilesToCopyInLeveldir.Contains(f) Then
                    If (Path.GetExtension(f) = ".png" And CopyGraphics) Or (Path.GetExtension(f) = ".txt" And CopyConfigurations) Then FilesToCopyInLeveldir.Add(f)
                End If : Application.DoEvents()
            Next
            For Each f As String In PFilesInLevelfiledir
                If Not OFilesInLevelfiledir.Contains(f) And Not FilesToCopyInLevelfiledir.Contains(f) Then
                    If (Path.GetExtension(f) = ".png" And CopyGraphics) Or (Path.GetExtension(f) = ".txt" And CopyConfigurations) Then FilesToCopyInLevelfiledir.Add(f)
                End If : Application.DoEvents()
            Next
        End If

        'Copy files and directories to the temp-dir:
        Dim TempLeveldir As String = Form1.TempDir & "\TempLevel"
        Dim TempLevelfiledir As String = TempLeveldir & "\data"
        If Directory.Exists(TempLeveldir) Then Directory.Delete(TempLeveldir, True) : Application.DoEvents()
        Directory.CreateDirectory(TempLeveldir) : Application.DoEvents()
        For Each f As String In FilesToCopyInLeveldir
            Try : File.Copy(f, TempLeveldir & "\" & Path.GetFileName(f)) : Catch ex As Exception : End Try
            Application.DoEvents() : Next
        If FilesToCopyInLevelfiledir.Count > 0 Then Directory.CreateDirectory(TempLevelfiledir)
        For Each f As String In FilesToCopyInLevelfiledir
            Try : File.Copy(f, TempLevelfiledir & "\" & Path.GetFileName(f)) : Catch ex As Exception : End Try
            Application.DoEvents() : Next

        'Write level:
        File.WriteAllLines(TempLeveldir & "\data.dat", PFile.ToArray)

        'Pack with 7-zip:
        If File.Exists(PatchFile) Then File.Delete(PatchFile)
        Dim sevenzip As New Process
        If Environment.Is64BitOperatingSystem Then
            sevenzip.StartInfo.FileName = Application.StartupPath & "\Data\7-Zip\x64\7z.exe"
        Else : sevenzip.StartInfo.FileName = Application.StartupPath & "\Data\7-Zip\x86\7z.exe"
        End If
        Dim password As String = "SMBXMagicPatcher"
        sevenzip.StartInfo.Arguments = String.Format("a -t7z ""{1}"" -p{0} -mhe -mx9 ""{2}""", password, Form1.TextBoxX_PatchFileCreate.Text, TempLeveldir & "\*")
        sevenzip.StartInfo.UseShellExecute = False
        sevenzip.StartInfo.CreateNoWindow = True
        sevenzip.Start()
        Do Until sevenzip.HasExited = True : Application.DoEvents() : Loop
        If sevenzip.ExitCode <> 0 Then
            Return 2 'Error at packing
        End If

        Directory.Delete(TempLeveldir, True)
        Return 1
    End Function

    Public Function ApplyPatch(originalLevel As String, patchFiles As String()) As Integer
        Dim PatchTyp As Integer = 0 '0 = plx | 1 = slp
        Dim PLevel As List(Of String) = File.ReadAllLines(originalLevel).ToList
        Dim TempLeveldir As String = Form1.TempDir & "\TempLevel" : Dim TempLevelfiledir As String = TempLeveldir & "\data"
        Dim oLeveldir As String = Path.GetDirectoryName(originalLevel) : Dim oLevelfiledir As String = oLeveldir & "\" & Path.GetFileNameWithoutExtension(originalLevel)
        If Directory.Exists(TempLeveldir) Then Directory.Delete(TempLeveldir, True) : Application.DoEvents()
        Directory.CreateDirectory(TempLeveldir) : Application.DoEvents()

        For Each patchFile As String In patchFiles
            'Check Patchtyp:
            Select Case Path.GetExtension(patchFile)
                Case ".slp"
                    PatchTyp = 1
                Case ".plx"
                    PatchTyp = 0
                Case Else
                    Return 3
            End Select

            'Extract with 7-zip:
            If PatchTyp = 0 Then
                Dim sevenzip As New Process
                If IntPtr.Size = 8 Then
                    sevenzip.StartInfo.FileName = Application.StartupPath & "\Data\7-Zip\x64\7z.exe"
                Else
                    sevenzip.StartInfo.FileName = Application.StartupPath & "\Data\7-Zip\x86\7z.exe"
                End If
                Dim password As String = "SMBXMagicPatcher"
                sevenzip.StartInfo.Arguments = String.Format("x ""{1}"" -p{0} -o""{2}"" -r", password, patchFile, TempLeveldir & "\")
                sevenzip.StartInfo.UseShellExecute = False
                sevenzip.StartInfo.CreateNoWindow = True
                sevenzip.Start()
                Do Until sevenzip.HasExited = True : Application.DoEvents() : Loop
                If sevenzip.ExitCode <> 0 Then
                    Return 2 'Error at packing
                End If
            End If

            'Load patchlevel:
            Dim PFile() As String = {}
            Select Case PatchTyp
                Case 0 : PFile = File.ReadAllLines(TempLeveldir & "\data.dat")
                Case 1 : PFile = File.ReadAllLines(patchFile)
            End Select

            'Apply lines in patch to the level:
            For Each l As String In PFile
                If Not PLevel.Contains(l) Then PLevel.Add(l)
            Next

            'Copy and replace files
            If PatchTyp = 0 Then
                Dim pListFilesInLeveldir() As String = Directory.GetFiles(TempLeveldir)
                Dim pListFilesInLevelfiledir() As String = {}
                If Directory.Exists(TempLevelfiledir) Then
                    pListFilesInLevelfiledir = Directory.GetFiles(TempLevelfiledir)
                End If

                Dim oListFilesInLeveldir() As String = Directory.GetFiles(oLeveldir)
                Dim oListFilesInLevelfiledir() As String = {}
                If Directory.Exists(oLevelfiledir) Then
                    oListFilesInLevelfiledir = Directory.GetFiles(oLevelfiledir)
                End If

                If Not Directory.Exists(oLevelfiledir) And oListFilesInLevelfiledir.Count > 0 Then
                    Directory.CreateDirectory(oLevelfiledir)
                End If

                For i As Integer = 0 To pListFilesInLeveldir.Count - 1
                    If Not pListFilesInLeveldir(i) = TempLeveldir & "\data.dat" Then _
                        File.Copy(pListFilesInLeveldir(i), oLeveldir & "\" & Path.GetFileName(pListFilesInLeveldir(i)), True)
                    Application.DoEvents() : Next
                For i As Integer = 0 To pListFilesInLevelfiledir.Count - 1
                    File.Copy(pListFilesInLevelfiledir(i), oLevelfiledir & "\" & Path.GetFileName(pListFilesInLevelfiledir(i)), True)
                    Application.DoEvents() : Next
            End If
        Next

        'Wirte new level file
        Do While PLevel.Contains("")
            PLevel.Remove("") : Application.DoEvents()
        Loop
        File.WriteAllLines(originalLevel, PLevel.ToArray)

        Return 1
    End Function
End Class

Public Class PatchSettings
    Public Property CopyBlocksEtc As Boolean = True
    Public Property CopyGraphics As Boolean = True
    Public Property CopyConfigs As Boolean = True
    Public Property CopyEvents As Boolean = True
    Public Property CopyLayers As Boolean = True
    Public Property CopyScripts As Boolean = True
    Public Property CopyVariables As Boolean = True
End Class