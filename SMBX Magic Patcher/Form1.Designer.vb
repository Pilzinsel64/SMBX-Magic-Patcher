<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CircularProgress_Apply = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.Button_ApplyPatch = New System.Windows.Forms.Button()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_PatchFileApply = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_OriginalLevelApply = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CircularProgress_Create = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SwitchButton_Liquids = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.SwitchButton_Layers = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.SwitchButton_Scripts = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.SwitchButton_Variables = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.SwitchButton_Events = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.SwitchButton_BlocksEtc = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.SwitchButton_Configs = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.SwitchButton_Graphics = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Button_CreatePatch = New System.Windows.Forms.Button()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_ModifiedLevel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_PatchFileCreate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX_OriginalLevelCreate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(352, 118)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CircularProgress_Apply)
        Me.TabPage1.Controls.Add(Me.LabelX14)
        Me.TabPage1.Controls.Add(Me.Button_ApplyPatch)
        Me.TabPage1.Controls.Add(Me.LabelX4)
        Me.TabPage1.Controls.Add(Me.LabelX6)
        Me.TabPage1.Controls.Add(Me.ButtonX4)
        Me.TabPage1.Controls.Add(Me.TextBoxX_PatchFileApply)
        Me.TabPage1.Controls.Add(Me.ButtonX6)
        Me.TabPage1.Controls.Add(Me.TextBoxX_OriginalLevelApply)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(344, 92)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Apply Patch"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CircularProgress_Apply
        '
        '
        '
        '
        Me.CircularProgress_Apply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress_Apply.Location = New System.Drawing.Point(6, 63)
        Me.CircularProgress_Apply.Name = "CircularProgress_Apply"
        Me.CircularProgress_Apply.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress_Apply.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgress_Apply.Size = New System.Drawing.Size(23, 23)
        Me.CircularProgress_Apply.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress_Apply.TabIndex = 41
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(35, 63)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(196, 23)
        Me.LabelX14.TabIndex = 1
        Me.LabelX14.Text = "<font color=""#2F3699"">Patching level. Please wait ...</font>"
        Me.LabelX14.Visible = False
        '
        'Button_ApplyPatch
        '
        Me.Button_ApplyPatch.Location = New System.Drawing.Point(237, 63)
        Me.Button_ApplyPatch.Name = "Button_ApplyPatch"
        Me.Button_ApplyPatch.Size = New System.Drawing.Size(101, 23)
        Me.Button_ApplyPatch.TabIndex = 40
        Me.Button_ApplyPatch.Text = "Apply Patch!"
        Me.Button_ApplyPatch.UseVisualStyleBackColor = True
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 34)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(72, 23)
        Me.LabelX4.TabIndex = 39
        Me.LabelX4.Text = "<font color=""#000000"">Patch file:</font>"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(6, 5)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(72, 23)
        Me.LabelX6.TabIndex = 37
        Me.LabelX6.Text = "<font color=""#000000"">Original level:</font>"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(305, 34)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX4.Symbol = "58055"
        Me.ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX4.SymbolSize = 15.0!
        Me.ButtonX4.TabIndex = 36
        '
        'TextBoxX_PatchFileApply
        '
        '
        '
        '
        Me.TextBoxX_PatchFileApply.Border.Class = "TextBoxBorder"
        Me.TextBoxX_PatchFileApply.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_PatchFileApply.Location = New System.Drawing.Point(84, 36)
        Me.TextBoxX_PatchFileApply.Name = "TextBoxX_PatchFileApply"
        Me.TextBoxX_PatchFileApply.PreventEnterBeep = True
        Me.TextBoxX_PatchFileApply.ReadOnly = True
        Me.TextBoxX_PatchFileApply.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxX_PatchFileApply.TabIndex = 35
        Me.TextBoxX_PatchFileApply.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_PatchFileApply.WatermarkText = "No file loaded!"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Location = New System.Drawing.Point(305, 5)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX6.Symbol = "58055"
        Me.ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX6.SymbolSize = 15.0!
        Me.ButtonX6.TabIndex = 33
        '
        'TextBoxX_OriginalLevelApply
        '
        '
        '
        '
        Me.TextBoxX_OriginalLevelApply.Border.Class = "TextBoxBorder"
        Me.TextBoxX_OriginalLevelApply.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_OriginalLevelApply.Location = New System.Drawing.Point(84, 7)
        Me.TextBoxX_OriginalLevelApply.Name = "TextBoxX_OriginalLevelApply"
        Me.TextBoxX_OriginalLevelApply.PreventEnterBeep = True
        Me.TextBoxX_OriginalLevelApply.ReadOnly = True
        Me.TextBoxX_OriginalLevelApply.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxX_OriginalLevelApply.TabIndex = 31
        Me.TextBoxX_OriginalLevelApply.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_OriginalLevelApply.WatermarkText = "No file loaded!"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CircularProgress_Create)
        Me.TabPage2.Controls.Add(Me.LabelX15)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.CheckBoxX2)
        Me.TabPage2.Controls.Add(Me.CheckBoxX1)
        Me.TabPage2.Controls.Add(Me.Button_CreatePatch)
        Me.TabPage2.Controls.Add(Me.LabelX3)
        Me.TabPage2.Controls.Add(Me.LabelX2)
        Me.TabPage2.Controls.Add(Me.LabelX1)
        Me.TabPage2.Controls.Add(Me.ButtonX3)
        Me.TabPage2.Controls.Add(Me.TextBoxX_ModifiedLevel)
        Me.TabPage2.Controls.Add(Me.ButtonX2)
        Me.TabPage2.Controls.Add(Me.ButtonX1)
        Me.TabPage2.Controls.Add(Me.TextBoxX_PatchFileCreate)
        Me.TabPage2.Controls.Add(Me.TextBoxX_OriginalLevelCreate)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(344, 92)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Create Patch"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CircularProgress_Create
        '
        '
        '
        '
        Me.CircularProgress_Create.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress_Create.Location = New System.Drawing.Point(6, 260)
        Me.CircularProgress_Create.Name = "CircularProgress_Create"
        Me.CircularProgress_Create.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress_Create.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgress_Create.Size = New System.Drawing.Size(23, 23)
        Me.CircularProgress_Create.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress_Create.TabIndex = 42
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(35, 260)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(196, 23)
        Me.LabelX15.TabIndex = 33
        Me.LabelX15.Text = "<font color=""#2F3699"">Creating patch. Please wait ...</font>"
        Me.LabelX15.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SwitchButton_Liquids)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.SwitchButton_Layers)
        Me.GroupBox1.Controls.Add(Me.SwitchButton_Scripts)
        Me.GroupBox1.Controls.Add(Me.LabelX11)
        Me.GroupBox1.Controls.Add(Me.LabelX12)
        Me.GroupBox1.Controls.Add(Me.SwitchButton_Variables)
        Me.GroupBox1.Controls.Add(Me.SwitchButton_Events)
        Me.GroupBox1.Controls.Add(Me.LabelX13)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.SwitchButton_BlocksEtc)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.SwitchButton_Configs)
        Me.GroupBox1.Controls.Add(Me.SwitchButton_Graphics)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 136)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'SwitchButton_Liquids
        '
        '
        '
        '
        Me.SwitchButton_Liquids.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_Liquids.FocusCuesEnabled = False
        Me.SwitchButton_Liquids.Location = New System.Drawing.Point(103, 48)
        Me.SwitchButton_Liquids.Name = "SwitchButton_Liquids"
        Me.SwitchButton_Liquids.OffText = "No"
        Me.SwitchButton_Liquids.OnText = "Yes"
        Me.SwitchButton_Liquids.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Liquids.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_Liquids.TabIndex = 49
        Me.SwitchButton_Liquids.Value = True
        Me.SwitchButton_Liquids.ValueObject = "Y"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(6, 48)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(91, 23)
        Me.LabelX8.TabIndex = 50
        Me.LabelX8.Text = "<font color=""#000000"">Liquids:</font>"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(170, 19)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(91, 23)
        Me.LabelX10.TabIndex = 41
        Me.LabelX10.Text = "<font color=""#000000"">Scripts:</font>"
        '
        'SwitchButton_Layers
        '
        '
        '
        '
        Me.SwitchButton_Layers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_Layers.FocusCuesEnabled = False
        Me.SwitchButton_Layers.Location = New System.Drawing.Point(267, 106)
        Me.SwitchButton_Layers.Name = "SwitchButton_Layers"
        Me.SwitchButton_Layers.OffText = "No"
        Me.SwitchButton_Layers.OnText = "Yes"
        Me.SwitchButton_Layers.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Layers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_Layers.TabIndex = 48
        Me.SwitchButton_Layers.Value = True
        Me.SwitchButton_Layers.ValueObject = "Y"
        '
        'SwitchButton_Scripts
        '
        '
        '
        '
        Me.SwitchButton_Scripts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_Scripts.FocusCuesEnabled = False
        Me.SwitchButton_Scripts.Location = New System.Drawing.Point(267, 19)
        Me.SwitchButton_Scripts.Name = "SwitchButton_Scripts"
        Me.SwitchButton_Scripts.OffText = "No"
        Me.SwitchButton_Scripts.OnText = "Yes"
        Me.SwitchButton_Scripts.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Scripts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_Scripts.TabIndex = 42
        Me.SwitchButton_Scripts.Value = True
        Me.SwitchButton_Scripts.ValueObject = "Y"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(170, 106)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(91, 23)
        Me.LabelX11.TabIndex = 47
        Me.LabelX11.Text = "<font color=""#000000"">Layers:</font>"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(170, 48)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(91, 23)
        Me.LabelX12.TabIndex = 43
        Me.LabelX12.Text = "<font color=""#000000"">Events:</font>"
        '
        'SwitchButton_Variables
        '
        '
        '
        '
        Me.SwitchButton_Variables.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_Variables.FocusCuesEnabled = False
        Me.SwitchButton_Variables.Location = New System.Drawing.Point(267, 77)
        Me.SwitchButton_Variables.Name = "SwitchButton_Variables"
        Me.SwitchButton_Variables.OffText = "No"
        Me.SwitchButton_Variables.OnText = "Yes"
        Me.SwitchButton_Variables.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Variables.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_Variables.TabIndex = 46
        Me.SwitchButton_Variables.Value = True
        Me.SwitchButton_Variables.ValueObject = "Y"
        '
        'SwitchButton_Events
        '
        '
        '
        '
        Me.SwitchButton_Events.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_Events.FocusCuesEnabled = False
        Me.SwitchButton_Events.Location = New System.Drawing.Point(267, 48)
        Me.SwitchButton_Events.Name = "SwitchButton_Events"
        Me.SwitchButton_Events.OffText = "No"
        Me.SwitchButton_Events.OnText = "Yes"
        Me.SwitchButton_Events.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Events.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_Events.TabIndex = 44
        Me.SwitchButton_Events.Value = True
        Me.SwitchButton_Events.ValueObject = "Y"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(170, 77)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(91, 23)
        Me.LabelX13.TabIndex = 45
        Me.LabelX13.Text = "<font color=""#000000"">Variables:</font>"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(6, 77)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(91, 23)
        Me.LabelX5.TabIndex = 33
        Me.LabelX5.Text = "<font color=""#000000"">Graphics:</font>"
        '
        'SwitchButton_BlocksEtc
        '
        '
        '
        '
        Me.SwitchButton_BlocksEtc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_BlocksEtc.FocusCuesEnabled = False
        Me.SwitchButton_BlocksEtc.Location = New System.Drawing.Point(103, 19)
        Me.SwitchButton_BlocksEtc.Name = "SwitchButton_BlocksEtc"
        Me.SwitchButton_BlocksEtc.OffText = "No"
        Me.SwitchButton_BlocksEtc.OnText = "Yes"
        Me.SwitchButton_BlocksEtc.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_BlocksEtc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_BlocksEtc.TabIndex = 34
        Me.SwitchButton_BlocksEtc.Value = True
        Me.SwitchButton_BlocksEtc.ValueObject = "Y"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(6, 19)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(91, 23)
        Me.LabelX9.TabIndex = 39
        Me.LabelX9.Text = "<font color=""#000000"">Blocks/NPCs/etc.:</font>"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(6, 106)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(91, 23)
        Me.LabelX7.TabIndex = 35
        Me.LabelX7.Text = "<font color=""#000000"">Configurations:</font>"
        '
        'SwitchButton_Configs
        '
        '
        '
        '
        Me.SwitchButton_Configs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_Configs.FocusCuesEnabled = False
        Me.SwitchButton_Configs.Location = New System.Drawing.Point(103, 106)
        Me.SwitchButton_Configs.Name = "SwitchButton_Configs"
        Me.SwitchButton_Configs.OffText = "No"
        Me.SwitchButton_Configs.OnText = "Yes"
        Me.SwitchButton_Configs.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Configs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_Configs.TabIndex = 38
        Me.SwitchButton_Configs.Value = True
        Me.SwitchButton_Configs.ValueObject = "Y"
        '
        'SwitchButton_Graphics
        '
        '
        '
        '
        Me.SwitchButton_Graphics.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton_Graphics.FocusCuesEnabled = False
        Me.SwitchButton_Graphics.Location = New System.Drawing.Point(103, 77)
        Me.SwitchButton_Graphics.Name = "SwitchButton_Graphics"
        Me.SwitchButton_Graphics.OffText = "No"
        Me.SwitchButton_Graphics.OnText = "Yes"
        Me.SwitchButton_Graphics.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Graphics.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton_Graphics.TabIndex = 36
        Me.SwitchButton_Graphics.Value = True
        Me.SwitchButton_Graphics.ValueObject = "Y"
        '
        'CheckBoxX2
        '
        '
        '
        '
        Me.CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX2.FocusCuesEnabled = False
        Me.CheckBoxX2.Location = New System.Drawing.Point(199, 33)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.CheckBoxX2.TabIndex = 32
        Me.CheckBoxX2.Text = "use custom level"
        '
        'CheckBoxX1
        '
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX1.Checked = True
        Me.CheckBoxX1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxX1.CheckValue = "Y"
        Me.CheckBoxX1.FocusCuesEnabled = False
        Me.CheckBoxX1.Location = New System.Drawing.Point(84, 33)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.CheckBoxX1.TabIndex = 31
        Me.CheckBoxX1.Text = "use empty level"
        '
        'Button_CreatePatch
        '
        Me.Button_CreatePatch.Location = New System.Drawing.Point(237, 260)
        Me.Button_CreatePatch.Name = "Button_CreatePatch"
        Me.Button_CreatePatch.Size = New System.Drawing.Size(101, 23)
        Me.Button_CreatePatch.TabIndex = 30
        Me.Button_CreatePatch.Text = "Create Patch!"
        Me.Button_CreatePatch.UseVisualStyleBackColor = True
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(6, 89)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(72, 23)
        Me.LabelX3.TabIndex = 29
        Me.LabelX3.Text = "<font color=""#000000"">Patch file:</font>"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(6, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 23)
        Me.LabelX2.TabIndex = 28
        Me.LabelX2.Text = "<font color=""#000000"">Modified level:</font>"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 23)
        Me.LabelX1.TabIndex = 27
        Me.LabelX1.Text = "<font color=""#000000"">Original level:</font>"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(305, 60)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX3.Symbol = "58055"
        Me.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX3.SymbolSize = 15.0!
        Me.ButtonX3.TabIndex = 26
        '
        'TextBoxX_ModifiedLevel
        '
        '
        '
        '
        Me.TextBoxX_ModifiedLevel.Border.Class = "TextBoxBorder"
        Me.TextBoxX_ModifiedLevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_ModifiedLevel.Location = New System.Drawing.Point(84, 62)
        Me.TextBoxX_ModifiedLevel.Name = "TextBoxX_ModifiedLevel"
        Me.TextBoxX_ModifiedLevel.PreventEnterBeep = True
        Me.TextBoxX_ModifiedLevel.ReadOnly = True
        Me.TextBoxX_ModifiedLevel.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxX_ModifiedLevel.TabIndex = 25
        Me.TextBoxX_ModifiedLevel.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_ModifiedLevel.WatermarkText = "No file loaded!"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(305, 89)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX2.Symbol = "57697"
        Me.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX2.SymbolSize = 15.0!
        Me.ButtonX2.TabIndex = 24
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Location = New System.Drawing.Point(305, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX1.Symbol = "58055"
        Me.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX1.SymbolSize = 15.0!
        Me.ButtonX1.TabIndex = 23
        '
        'TextBoxX_PatchFileCreate
        '
        '
        '
        '
        Me.TextBoxX_PatchFileCreate.Border.Class = "TextBoxBorder"
        Me.TextBoxX_PatchFileCreate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_PatchFileCreate.Location = New System.Drawing.Point(84, 91)
        Me.TextBoxX_PatchFileCreate.Name = "TextBoxX_PatchFileCreate"
        Me.TextBoxX_PatchFileCreate.PreventEnterBeep = True
        Me.TextBoxX_PatchFileCreate.ReadOnly = True
        Me.TextBoxX_PatchFileCreate.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxX_PatchFileCreate.TabIndex = 22
        Me.TextBoxX_PatchFileCreate.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_PatchFileCreate.WatermarkText = "No file loaded!"
        '
        'TextBoxX_OriginalLevelCreate
        '
        '
        '
        '
        Me.TextBoxX_OriginalLevelCreate.Border.Class = "TextBoxBorder"
        Me.TextBoxX_OriginalLevelCreate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_OriginalLevelCreate.Enabled = False
        Me.TextBoxX_OriginalLevelCreate.Location = New System.Drawing.Point(84, 7)
        Me.TextBoxX_OriginalLevelCreate.Name = "TextBoxX_OriginalLevelCreate"
        Me.TextBoxX_OriginalLevelCreate.PreventEnterBeep = True
        Me.TextBoxX_OriginalLevelCreate.ReadOnly = True
        Me.TextBoxX_OriginalLevelCreate.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxX_OriginalLevelCreate.TabIndex = 21
        Me.TextBoxX_OriginalLevelCreate.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_OriginalLevelCreate.WatermarkText = "No file loaded!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 118)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMBX Magic Patcher"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button_ApplyPatch As Button
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_PatchFileApply As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_OriginalLevelApply As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Button_CreatePatch As Button
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_ModifiedLevel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_PatchFileCreate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX_OriginalLevelCreate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton_Configs As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents SwitchButton_Graphics As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton_BlocksEtc As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton_Layers As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents SwitchButton_Scripts As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton_Variables As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents SwitchButton_Events As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton_Liquids As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CircularProgress_Apply As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents CircularProgress_Create As DevComponents.DotNetBar.Controls.CircularProgress
End Class
