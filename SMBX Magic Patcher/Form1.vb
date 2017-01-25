Imports System.IO
Imports DevComponents.DotNetBar

Public Class Form1

    Public TempDir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\SMBX Magic Patcher"

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
            If .ShowDialog = Not DialogResult.OK Then
                Exit Sub
            End If
            TextBoxX_OriginalLevelApply.Text = .FileName
        End With
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        With New OpenFileDialog
            .Filter = "All supported files (*.plx, *.slp)|*.plx;*.slp"
            If .ShowDialog = Not DialogResult.OK Then
                Exit Sub
            End If
            TextBoxX_PatchFileApply.Text = .FileName
        End With
    End Sub

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
                                        SwitchButton_Scripts.Value)

            Case 1 : MessageBoxEx.Show("Done", "Patch succesfully created!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else : MessageBoxEx.Show("Done", "Patch succesfully created!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        Button_CreatePatch.Enabled = True
        LabelX15.Visible = False
        CircularProgress_Create.IsRunning = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_ApplyPatch.Click
        SMBXPFX.ApplyPatch(TextBoxX_OriginalLevelApply.Text, TextBoxX_PatchFileApply.Text)
    End Sub

    Private Sub CheckBoxX2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxX2.CheckedChanged
        ButtonX1.Enabled = CheckBoxX2.Checked
        TextBoxX_OriginalLevelCreate.Enabled = CheckBoxX2.Checked
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 : Me.Size = New Point(368, 157)
            Case 1 : Me.Size = New Point(368, 354)
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(TempDir) Then Directory.CreateDirectory(TempDir)
    End Sub
End Class

Public Class SMBXPFX

    Shared Function CreatePatch(OriginalLevel As String, PatchedLevel As String, PatchFile As String, Optional UseCustomOriginalLevelFile As Boolean = False, Optional CopyBlocksEtc As Boolean = True, Optional CopyGraphics As Boolean = True, Optional CopyConfigurations As Boolean = True, Optional CopyEvents As Boolean = True, Optional CopyLayers As Boolean = True, Optional CopyVariables As Boolean = True, Optional CopyScripts As Boolean = True) As Integer
        If Not UseCustomOriginalLevelFile Then
            OriginalLevel = Application.StartupPath & "\emptylevel.dat"
            CopyGraphics = False
        End If

        Dim OLevel() As String = File.ReadAllLines(OriginalLevel)
        Dim PLevel() As String = File.ReadAllLines(PatchedLevel)
        Dim PFile As New List(Of String)
        Dim UsedThings As New List(Of String)

        'Add differences to patch:
        For Each l As String In PLevel
            If Not OLevel.Contains(l) Then
                If l.StartsWith("P1|") Or l.StartsWith("P2|") Or l.StartsWith("M|") Then GoTo SkipCheck
                If l.StartsWith("B|") And Not Form1.SwitchButton_BlocksEtc.Value Then GoTo SkipCheck 'Blcks
                If l.StartsWith("N|") And Not Form1.SwitchButton_BlocksEtc.Value Then GoTo SkipCheck 'NPCs
                If l.StartsWith("T|") And Not Form1.SwitchButton_BlocksEtc.Value Then GoTo SkipCheck 'Backgrounds
                If l.StartsWith("Q|") And Not Form1.SwitchButton_Liquids.Value Then GoTo SkipCheck 'Liquids
                If l.StartsWith("CB|") And Not Form1.SwitchButton_Configs.Value Then GoTo SkipCheck 'Custom Block Configurations
                If l.StartsWith("CT|") And Not Form1.SwitchButton_Configs.Value Then GoTo SkipCheck 'Custom Backgrounds Configurations
                If l.StartsWith("L|") And Not Form1.SwitchButton_Layers.Value Then GoTo SkipCheck 'Layer
                If l.StartsWith("E|") And Not Form1.SwitchButton_Events.Value Then GoTo SkipCheck 'Events
                If l.StartsWith("V|") And Not Form1.SwitchButton_Variables.Value Then GoTo SkipCheck 'Variables
                If l.StartsWith("S|") And Not Form1.SwitchButton_Scripts.Value Then GoTo SkipCheck 'Scripts
                If l.StartsWith("Su|") And Not Form1.SwitchButton_Scripts.Value Then GoTo SkipCheck 'Scripts
                PFile.Add(l) 'Finaly add line to patch
SkipCheck:  End If
        Next

        'Check for custom graphics:
        Dim OLeveldir As String = Path.GetDirectoryName(PatchedLevel) : Dim OLevelfiledir As String = OLeveldir & Path.GetFileNameWithoutExtension(PatchedLevel)
        Dim PLeveldir As String = Path.GetDirectoryName(PatchedLevel) : Dim PLevelfiledir As String = PLeveldir & Path.GetFileNameWithoutExtension(PatchedLevel)
        Dim OFilesInLeveldir() As String = Directory.GetFiles(OLeveldir) : Dim OFilesInLevelfiledir() As String = {""} : If Directory.Exists(OLevelfiledir) Then OFilesInLevelfiledir = Directory.GetFiles(OLevelfiledir)
        Dim PFilesInLeveldir() As String = Directory.GetFiles(PLeveldir) : Dim PFilesInLevelfiledir() As String = {""} : If Directory.Exists(PLevelfiledir) Then PFilesInLevelfiledir = Directory.GetFiles(PLevelfiledir)
        Dim FilesToCopyInLeveldir As New List(Of String) : Dim FilesToCopyInLevelfiledir As New List(Of String)
        Dim UsedNPCs As New List(Of String)

        If Form1.SwitchButton_Graphics.Value Then
            For Each l As String In PFile
                If l.StartsWith("B|") Then
                    Dim lid As String = l.Replace("B|", "").Split("|")(1)
                    Dim lFileInLeveldir As String = String.Format(PLeveldir & "\block-{0}.png", lid)
                    Dim lFileInLevelfiledir As String = String.Format(PLevelfiledir & "\block-{0}.png", lid)
                    If FilesToCopyInLeveldir.Contains(lFileInLeveldir) Or FilesToCopyInLevelfiledir.Contains(lFileInLevelfiledir) Then GoTo Skip1
                    If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                        If File.Exists(lFileInLevelfiledir) And Not File.Exists(lFileInLevelfiledir) Then
                            FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip1
                        End If
                    ElseIf Directory.Exists(PLevelfiledir) Then
                        FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip1
                    End If
                    If File.Exists(lFileInLeveldir) And Not File.Exists(lFileInLeveldir) Then
                        FilesToCopyInLeveldir.Add(lFileInLeveldir)
                    End If
Skip1:              Application.DoEvents()
                ElseIf l.StartsWith("N|") Then
                    Dim lid As String = l.Replace("N|", "").Split("|")(1) : UsedNPCs.Add(lid)
                    Dim lFileInLeveldir As String = String.Format(PLeveldir & "\npc-{0}.png", lid)
                    Dim lFileInLevelfiledir As String = String.Format(PLevelfiledir & "\npc-{0}.png", lid)
                    If FilesToCopyInLeveldir.Contains(lFileInLeveldir) Or FilesToCopyInLevelfiledir.Contains(lFileInLevelfiledir) Then GoTo Skip2
                    If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                        If File.Exists(lFileInLevelfiledir) And Not File.Exists(lFileInLevelfiledir) Then
                            FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip2
                        End If
                    ElseIf Directory.Exists(PLevelfiledir) Then
                        FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip2
                    End If
                    If File.Exists(lFileInLeveldir) And Not File.Exists(lFileInLeveldir) Then
                        FilesToCopyInLeveldir.Add(lFileInLeveldir)
                    End If
Skip2:              Application.DoEvents()
                ElseIf l.StartsWith("T|") Then
                    Dim lid As String = l.Replace("T|", "").Split("|")(1)
                    Dim lFileInLeveldir As String = String.Format(PLeveldir & "\background-{0}.png", lid)
                    Dim lFileInLevelfiledir As String = String.Format(PLevelfiledir & "\background-{0}.png", lid)
                    If FilesToCopyInLeveldir.Contains(lFileInLeveldir) Or FilesToCopyInLevelfiledir.Contains(lFileInLevelfiledir) Then GoTo Skip4
                    If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                        If File.Exists(lFileInLevelfiledir) And Not File.Exists(lFileInLevelfiledir) Then
                            FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip4
                        End If
                    ElseIf Directory.Exists(PLevelfiledir) Then
                        FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip4
                    End If
                    If File.Exists(lFileInLeveldir) And Not File.Exists(lFileInLeveldir) Then
                        FilesToCopyInLeveldir.Add(lFileInLeveldir)
                    End If
Skip4:              Application.DoEvents()
                End If
            Next

            For i As Integer = 1 To 172
                Dim lFileInLeveldir As String = String.Format(PLeveldir & "\effect-{0}.png", i)
                Dim lFileInLevelfiledir As String = String.Format(PLevelfiledir & "\effect-{0}.png", i)
                If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                    If File.Exists(lFileInLevelfiledir) And Not File.Exists(lFileInLevelfiledir) Then
                        FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip5
                    End If
                ElseIf Directory.Exists(PLevelfiledir) Then
                    FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip5
                End If
                If File.Exists(lFileInLeveldir) And Not File.Exists(lFileInLeveldir) Then
                    FilesToCopyInLeveldir.Add(lFileInLeveldir)
                End If
Skip5:          Application.DoEvents()
            Next

            For Each p As String In {"mario", "luigi", "toad", "peach", "link"}
                For i As Integer = 1 To 12
                    Dim lFileInLeveldir As String = String.Format(PLeveldir & "\{1}-{0}.png", i, p)
                    Dim lFileInLevelfiledir As String = String.Format(PLevelfiledir & "\{1}-{0}.png", i, p)
                    If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                        If File.Exists(lFileInLevelfiledir) And Not File.Exists(lFileInLevelfiledir) Then
                            FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip6
                        End If
                    ElseIf Directory.Exists(PLevelfiledir) Then
                        FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip6
                    End If
                    If File.Exists(lFileInLeveldir) And Not File.Exists(lFileInLeveldir) Then
                        FilesToCopyInLeveldir.Add(lFileInLeveldir)
                    End If
Skip6:              Application.DoEvents()
                Next
            Next

            For Each p As String In {"yoshib", "yoshit"}
                For i As Integer = 1 To 8
                    Dim lFileInLeveldir As String = String.Format(PLeveldir & "\{1}-{0}.png", i, p)
                    Dim lFileInLevelfiledir As String = String.Format(PLevelfiledir & "\{1}-{0}.png", i, p)
                    If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                        If File.Exists(lFileInLevelfiledir) And Not File.Exists(lFileInLevelfiledir) Then
                            FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip7
                        End If
                    ElseIf Directory.Exists(PLevelfiledir) Then
                        FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip7
                    End If
                    If File.Exists(lFileInLeveldir) And Not File.Exists(lFileInLeveldir) Then
                        FilesToCopyInLeveldir.Add(lFileInLeveldir)
                    End If
Skip7:              Application.DoEvents()
                Next
            Next

            If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                If File.Exists(PLevelfiledir & "\yoshi-0.png") And Not File.Exists(PLevelfiledir & "\yoshi-0.png") Then
                    FilesToCopyInLevelfiledir.Add(PLevelfiledir & "\yoshi-0.png") : GoTo Skip8
                End If
            ElseIf Directory.Exists(PLevelfiledir) Then
                FilesToCopyInLevelfiledir.Add(PLevelfiledir & "\yoshi-0.png") : GoTo Skip8
            End If
            If File.Exists(PLeveldir & "\yoshi-0.png") And Not File.Exists(PLeveldir & "\yoshi-0.png") Then
                FilesToCopyInLeveldir.Add(PLeveldir & "ßyoshi-0.png")
            End If
Skip8:      Application.DoEvents()

            If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                If File.Exists(PLevelfiledir & "\scflash.png") And Not File.Exists(PLevelfiledir & "\scflash.png") Then
                    FilesToCopyInLevelfiledir.Add(PLevelfiledir & "\scflash.png") : GoTo Skip15
                End If
            ElseIf Directory.Exists(PLevelfiledir) Then
                FilesToCopyInLevelfiledir.Add(PLevelfiledir & "\scflash.png") : GoTo Skip15
            End If
            If File.Exists(PLeveldir & "\scflash.png") And Not File.Exists(PLeveldir & "\scflash.png") Then
                FilesToCopyInLeveldir.Add(PLeveldir & "\scflash.png")
            End If
Skip15:     Application.DoEvents()
        End If

        If CopyConfigurations Then
            For Each lid As String In UsedNPCs
                Dim lFileInLeveldir As String = String.Format(PLeveldir & "\npc-{0}.png", lid)
                Dim lFileInLevelfiledir As String = String.Format(PLevelfiledir & "\npc-{0}.png", lid)
                If FilesToCopyInLeveldir.Contains(lFileInLeveldir) Or FilesToCopyInLevelfiledir.Contains(lFileInLevelfiledir) Then GoTo Skip9
                If Directory.Exists(PLevelfiledir) And Directory.Exists(OLevelfiledir) Then
                    If File.Exists(lFileInLevelfiledir) And Not File.Exists(lFileInLevelfiledir) Then
                        FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip9
                    End If
                ElseIf Directory.Exists(PLevelfiledir) Then
                    FilesToCopyInLevelfiledir.Add(lFileInLevelfiledir) : GoTo Skip9
                End If
                If File.Exists(lFileInLeveldir) And Not File.Exists(lFileInLeveldir) Then
                    FilesToCopyInLeveldir.Add(lFileInLeveldir)
                End If
Skip9:          Application.DoEvents()
            Next
        End If

        'Copy files and directories to the temp-dir:
        Dim TempLeveldir As String = Form1.TempDir & "\TempLevel"
        Dim TempLevelfiledir As String = TempLeveldir & "\data"
        If Directory.Exists(TempLeveldir) Then Directory.Delete(TempLeveldir, True)
        Directory.CreateDirectory(TempLeveldir)
        If FilesToCopyInLevelfiledir.Count > 0 Then Directory.CreateDirectory(TempLevelfiledir)
        For Each f As String In FilesToCopyInLeveldir
            Try : File.Copy(f, TempLeveldir & "\" & Path.GetFileName(f)) : Catch ex As Exception : End Try
            Application.DoEvents() : Next
        For Each f As String In FilesToCopyInLevelfiledir
            Try : File.Copy(f, TempLevelfiledir & "\" & Path.GetFileName(f)) : Catch ex As Exception : End Try
            Application.DoEvents() : Next

        'Write level:
        File.WriteAllLines(TempLeveldir & "\data.lvl", PFile.ToArray)

        'Pack with 7-zip:
        Dim sevenzip As New Process
        sevenzip.StartInfo.CreateNoWindow = True

        If Environment.Is64BitOperatingSystem Then
            sevenzip.StartInfo.FileName = Application.StartupPath & "\7-Zip\x64\7z.exe"
        Else : sevenzip.StartInfo.FileName = Application.StartupPath & "\7-Zip\x86\7z.exe"
        End If
        Dim password As String = "SMBX Magic Patcher"
        sevenzip.StartInfo.Arguments = String.Format("a -t7z ""{1}"" -p{0} -mx9 ""{2}""", password, Form1.TextBoxX_PatchFileCreate.Text, TempLeveldir & "\*")
        sevenzip.StartInfo.UseShellExecute = False
        sevenzip.StartInfo.CreateNoWindow = True
        sevenzip.Start()
        Do Until sevenzip.HasExited = True : Application.DoEvents() : Loop
        If sevenzip.ExitCode <> 0 Then
            Return 2 'Error at packing
        End If

        Return 1
    End Function

    Shared Function ApplyPatch(OriginalLevel As String, PatchFile As String) As Integer
        Dim OLevel() As String = File.ReadAllLines(OriginalLevel)
        Dim PLevel As List(Of String) = OLevel.ToList

        'Extract with 7-zip

        Dim PFile() As String = File.ReadAllLines("<extracted file>")

        For Each l As String In PFile
            If Not PLevel.Contains(l) Then
                PLevel.Add(l)
            End If
        Next

        'Copy and replace files

        'Wirte new level file

        Return 1
    End Function

    Shared Function GetHelp() As String
        Return "Not aviable yet!"
    End Function
End Class

Public Class PatchSettings

    Private _CopyBlocksEtc As Boolean = True
    Private _CopyGraphics As Boolean = True
    Private _CopyConfigs As Boolean = True
    Private _CopyEvents As Boolean = True
    Private _CopyLayers As Boolean = True
    Private _CopyScripts As Boolean = True
    Private _CopyVariables As Boolean = True

    Public Property CopyBlocksEtc As Boolean
        Get
            Return _CopyBlocksEtc
        End Get
        Set(value As Boolean)
            _CopyBlocksEtc = value
        End Set
    End Property

    Public Property CopyGraphics As Boolean
        Get
            Return _CopyGraphics
        End Get
        Set(value As Boolean)
            _CopyGraphics = value
        End Set
    End Property

    Public Property CopyConfigs As Boolean
        Get
            Return _CopyConfigs
        End Get
        Set(value As Boolean)
            _CopyConfigs = value
        End Set
    End Property

    Public Property CopyEvents As Boolean
        Get
            Return _CopyEvents
        End Get
        Set(value As Boolean)
            _CopyEvents = value
        End Set
    End Property

    Public Property CopyLayers As Boolean
        Get
            Return _CopyLayers
        End Get
        Set(value As Boolean)
            _CopyLayers = value
        End Set
    End Property

    Public Property CopyScripts As Boolean
        Get
            Return _CopyScripts
        End Get
        Set(value As Boolean)
            _CopyScripts = value
        End Set
    End Property

    Public Property CopyVariables As Boolean
        Get
            Return _CopyVariables
        End Get
        Set(value As Boolean)
            _CopyVariables = value
        End Set
    End Property
End Class