<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CircularProgress_Apply = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_PatchFileApply = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_OriginalLevelApply = New DevComponents.DotNetBar.Controls.TextBoxX()
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
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_ModifiedLevel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX_PatchFileCreate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX_OriginalLevelCreate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Button_ApplyPatch = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.CircularProgress_Create = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.Button_CreatePatch = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CircularProgress_Apply
        '
        Me.CircularProgress_Apply.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CircularProgress_Apply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress_Apply.Location = New System.Drawing.Point(4, 62)
        Me.CircularProgress_Apply.Name = "CircularProgress_Apply"
        Me.CircularProgress_Apply.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress_Apply.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgress_Apply.Size = New System.Drawing.Size(23, 23)
        Me.CircularProgress_Apply.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress_Apply.TabIndex = 41
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(33, 62)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(196, 23)
        Me.LabelX14.TabIndex = 1
        Me.LabelX14.Text = "<font color=""#2F3699"">Patching level. Please wait ...</font>"
        Me.LabelX14.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(4, 33)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(72, 23)
        Me.LabelX4.TabIndex = 39
        Me.LabelX4.Text = "<font color=""#000000"">Patch:</font>"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(4, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(72, 23)
        Me.LabelX6.TabIndex = 37
        Me.LabelX6.Text = "<font color=""#000000"">Original level:</font>"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.FocusCuesEnabled = False
        Me.ButtonX4.Location = New System.Drawing.Point(303, 33)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ButtonX4, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Select the patch here.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.ButtonX4.Symbol = "58055"
        Me.ButtonX4.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX4.SymbolSize = 12.0!
        Me.ButtonX4.TabIndex = 36
        '
        'TextBoxX_PatchFileApply
        '
        Me.TextBoxX_PatchFileApply.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_PatchFileApply.Border.Class = "TextBoxBorder"
        Me.TextBoxX_PatchFileApply.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_PatchFileApply.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_PatchFileApply.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_PatchFileApply.Location = New System.Drawing.Point(82, 35)
        Me.TextBoxX_PatchFileApply.Name = "TextBoxX_PatchFileApply"
        Me.TextBoxX_PatchFileApply.PreventEnterBeep = True
        Me.TextBoxX_PatchFileApply.ReadOnly = True
        Me.TextBoxX_PatchFileApply.Size = New System.Drawing.Size(215, 20)
        Me.SuperTooltip1.SetSuperTooltip(Me.TextBoxX_PatchFileApply, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Select the patch here.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.TextBoxX_PatchFileApply.TabIndex = 35
        Me.TextBoxX_PatchFileApply.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_PatchFileApply.WatermarkText = "No file loaded!"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.FocusCuesEnabled = False
        Me.ButtonX6.Location = New System.Drawing.Point(303, 4)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ButtonX6, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Select here your level on wich you would apply the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.ButtonX6.Symbol = "58055"
        Me.ButtonX6.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX6.SymbolSize = 12.0!
        Me.ButtonX6.TabIndex = 33
        '
        'TextBoxX_OriginalLevelApply
        '
        Me.TextBoxX_OriginalLevelApply.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_OriginalLevelApply.Border.Class = "TextBoxBorder"
        Me.TextBoxX_OriginalLevelApply.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_OriginalLevelApply.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_OriginalLevelApply.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_OriginalLevelApply.Location = New System.Drawing.Point(82, 6)
        Me.TextBoxX_OriginalLevelApply.Name = "TextBoxX_OriginalLevelApply"
        Me.TextBoxX_OriginalLevelApply.PreventEnterBeep = True
        Me.TextBoxX_OriginalLevelApply.ReadOnly = True
        Me.TextBoxX_OriginalLevelApply.Size = New System.Drawing.Size(215, 20)
        Me.SuperTooltip1.SetSuperTooltip(Me.TextBoxX_OriginalLevelApply, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Select here your level on wich you would apply the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.TextBoxX_OriginalLevelApply.TabIndex = 31
        Me.TextBoxX_OriginalLevelApply.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_OriginalLevelApply.WatermarkText = "No file loaded!"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(33, 259)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(196, 23)
        Me.LabelX15.TabIndex = 33
        Me.LabelX15.Text = "<font color=""#2F3699"">Creating patch. Please wait ...</font>"
        Me.LabelX15.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 136)
        Me.SuperTooltip1.SetSuperTooltip(Me.GroupBox1, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Check which things you would include in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
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
        Me.SwitchButton_Liquids.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_Liquids.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_Liquids.OnText = "Yes"
        Me.SwitchButton_Liquids.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_Liquids.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Liquids.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_Liquids, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all Liquids will include in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_Liquids.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_Liquids.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_Liquids.SwitchWidth = 16
        Me.SwitchButton_Liquids.TabIndex = 49
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
        Me.SwitchButton_Layers.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_Layers.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_Layers.OnText = "Yes"
        Me.SwitchButton_Layers.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_Layers.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Layers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_Layers, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all Layers will include in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_Layers.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_Layers.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_Layers.SwitchWidth = 16
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
        Me.SwitchButton_Scripts.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_Scripts.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_Scripts.OnText = "Yes"
        Me.SwitchButton_Scripts.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_Scripts.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Scripts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_Scripts, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all Scripts will include in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_Scripts.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_Scripts.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_Scripts.SwitchWidth = 16
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
        Me.SwitchButton_Variables.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_Variables.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_Variables.OnText = "Yes"
        Me.SwitchButton_Variables.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_Variables.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Variables.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_Variables, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all Local Variables will include in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_Variables.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_Variables.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_Variables.SwitchWidth = 16
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
        Me.SwitchButton_Events.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_Events.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_Events.OnText = "Yes"
        Me.SwitchButton_Events.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_Events.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Events.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_Events, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all Events will include in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_Events.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_Events.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_Events.SwitchWidth = 16
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
        Me.SwitchButton_BlocksEtc.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_BlocksEtc.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_BlocksEtc.OnText = "Yes"
        Me.SwitchButton_BlocksEtc.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_BlocksEtc.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_BlocksEtc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_BlocksEtc, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all Blocks, NPC's and Backgrounds will include in the patch" &
            ".", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_BlocksEtc.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_BlocksEtc.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_BlocksEtc.SwitchWidth = 16
        Me.SwitchButton_BlocksEtc.TabIndex = 34
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
        Me.SwitchButton_Configs.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_Configs.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_Configs.OnText = "Yes"
        Me.SwitchButton_Configs.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_Configs.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Configs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_Configs, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all custom configrations (like Custom NPC Configs) will inc" &
            "lude in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_Configs.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_Configs.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_Configs.SwitchWidth = 16
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
        Me.SwitchButton_Graphics.OffTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchButton_Graphics.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwitchButton_Graphics.OnText = "Yes"
        Me.SwitchButton_Graphics.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SwitchButton_Graphics.Size = New System.Drawing.Size(57, 23)
        Me.SwitchButton_Graphics.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.SwitchButton_Graphics, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "If this is ""Yes"" then all custom graphics will include in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.SwitchButton_Graphics.SwitchBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SwitchButton_Graphics.SwitchBorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.SwitchButton_Graphics.SwitchWidth = 16
        Me.SwitchButton_Graphics.TabIndex = 36
        Me.SwitchButton_Graphics.Value = True
        Me.SwitchButton_Graphics.ValueObject = "Y"
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX2.FocusCuesEnabled = False
        Me.CheckBoxX2.Location = New System.Drawing.Point(197, 32)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.SuperTooltip1.SetSuperTooltip(Me.CheckBoxX2, New DevComponents.DotNetBar.SuperTooltipInfo("", "", resources.GetString("CheckBoxX2.SuperTooltip"), Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.CheckBoxX2.TabIndex = 32
        Me.CheckBoxX2.Text = "use custom level"
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX1.Checked = True
        Me.CheckBoxX1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxX1.CheckValue = "Y"
        Me.CheckBoxX1.FocusCuesEnabled = False
        Me.CheckBoxX1.Location = New System.Drawing.Point(82, 32)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(100, 23)
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.SuperTooltip1.SetSuperTooltip(Me.CheckBoxX1, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Use this option, if you would like to create a patch of your whole level.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.CheckBoxX1.TabIndex = 31
        Me.CheckBoxX1.Text = "use empty level"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(4, 88)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(72, 23)
        Me.LabelX3.TabIndex = 29
        Me.LabelX3.Text = "<font color=""#000000"">Save as:</font>"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 59)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 23)
        Me.LabelX2.TabIndex = 28
        Me.LabelX2.Text = "<font color=""#000000"">Modified level:</font>"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 23)
        Me.LabelX1.TabIndex = 27
        Me.LabelX1.Text = "<font color=""#000000"">Original level:</font>"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.FocusCuesEnabled = False
        Me.ButtonX3.Location = New System.Drawing.Point(303, 59)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ButtonX3, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Open here your level with the feautures wich should be in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.ButtonX3.Symbol = "58055"
        Me.ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX3.SymbolSize = 12.0!
        Me.ButtonX3.TabIndex = 26
        '
        'TextBoxX_ModifiedLevel
        '
        Me.TextBoxX_ModifiedLevel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_ModifiedLevel.Border.Class = "TextBoxBorder"
        Me.TextBoxX_ModifiedLevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_ModifiedLevel.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_ModifiedLevel.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_ModifiedLevel.Location = New System.Drawing.Point(82, 61)
        Me.TextBoxX_ModifiedLevel.Name = "TextBoxX_ModifiedLevel"
        Me.TextBoxX_ModifiedLevel.PreventEnterBeep = True
        Me.TextBoxX_ModifiedLevel.ReadOnly = True
        Me.TextBoxX_ModifiedLevel.Size = New System.Drawing.Size(215, 20)
        Me.SuperTooltip1.SetSuperTooltip(Me.TextBoxX_ModifiedLevel, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Open here your level with the feautures wich should be in the patch.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.TextBoxX_ModifiedLevel.TabIndex = 25
        Me.TextBoxX_ModifiedLevel.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_ModifiedLevel.WatermarkText = "No file loaded!"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Location = New System.Drawing.Point(303, 88)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ButtonX2, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Select here where the patch file should be saved.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.ButtonX2.Symbol = "57697"
        Me.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX2.SymbolSize = 12.0!
        Me.ButtonX2.TabIndex = 24
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Location = New System.Drawing.Point(303, 4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(33, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.ButtonX1, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Open the ""without feauture"" level here.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.ButtonX1.Symbol = "58055"
        Me.ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonX1.SymbolSize = 12.0!
        Me.ButtonX1.TabIndex = 23
        '
        'TextBoxX_PatchFileCreate
        '
        Me.TextBoxX_PatchFileCreate.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_PatchFileCreate.Border.Class = "TextBoxBorder"
        Me.TextBoxX_PatchFileCreate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_PatchFileCreate.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_PatchFileCreate.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_PatchFileCreate.Location = New System.Drawing.Point(82, 90)
        Me.TextBoxX_PatchFileCreate.Name = "TextBoxX_PatchFileCreate"
        Me.TextBoxX_PatchFileCreate.PreventEnterBeep = True
        Me.TextBoxX_PatchFileCreate.ReadOnly = True
        Me.TextBoxX_PatchFileCreate.Size = New System.Drawing.Size(215, 20)
        Me.SuperTooltip1.SetSuperTooltip(Me.TextBoxX_PatchFileCreate, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Select here where the patch file should be saved.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.TextBoxX_PatchFileCreate.TabIndex = 22
        Me.TextBoxX_PatchFileCreate.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_PatchFileCreate.WatermarkText = "No file loaded!"
        '
        'TextBoxX_OriginalLevelCreate
        '
        Me.TextBoxX_OriginalLevelCreate.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX_OriginalLevelCreate.Border.Class = "TextBoxBorder"
        Me.TextBoxX_OriginalLevelCreate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX_OriginalLevelCreate.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX_OriginalLevelCreate.Enabled = False
        Me.TextBoxX_OriginalLevelCreate.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX_OriginalLevelCreate.Location = New System.Drawing.Point(82, 6)
        Me.TextBoxX_OriginalLevelCreate.Name = "TextBoxX_OriginalLevelCreate"
        Me.TextBoxX_OriginalLevelCreate.PreventEnterBeep = True
        Me.TextBoxX_OriginalLevelCreate.ReadOnly = True
        Me.TextBoxX_OriginalLevelCreate.Size = New System.Drawing.Size(215, 20)
        Me.SuperTooltip1.SetSuperTooltip(Me.TextBoxX_OriginalLevelCreate, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Open the ""without feauture"" level here.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.System, False, False, New System.Drawing.Size(0, 0)))
        Me.TextBoxX_OriginalLevelCreate.TabIndex = 21
        Me.TextBoxX_OriginalLevelCreate.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TextBoxX_OriginalLevelCreate.WatermarkText = "No file loaded!"
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        Me.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.White
        Me.TabControl2.CanReorderTabs = True
        Me.TabControl2.Controls.Add(Me.TabControlPanel1)
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ForeColor = System.Drawing.Color.Black
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(342, 118)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.TabControl2.TabIndex = 1
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem1)
        Me.TabControl2.Tabs.Add(Me.TabItem2)
        Me.TabControl2.Text = "TabControl2"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.CircularProgress_Apply)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX6)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX4)
        Me.TabControlPanel1.Controls.Add(Me.LabelX6)
        Me.TabControlPanel1.Controls.Add(Me.LabelX4)
        Me.TabControlPanel1.Controls.Add(Me.LabelX14)
        Me.TabControlPanel1.Controls.Add(Me.TextBoxX_PatchFileApply)
        Me.TabControlPanel1.Controls.Add(Me.TextBoxX_OriginalLevelApply)
        Me.TabControlPanel1.Controls.Add(Me.Button_ApplyPatch)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(342, 91)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'Button_ApplyPatch
        '
        Me.Button_ApplyPatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button_ApplyPatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Button_ApplyPatch.FocusCuesEnabled = False
        Me.Button_ApplyPatch.Location = New System.Drawing.Point(235, 62)
        Me.Button_ApplyPatch.Name = "Button_ApplyPatch"
        Me.Button_ApplyPatch.Size = New System.Drawing.Size(101, 23)
        Me.Button_ApplyPatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button_ApplyPatch.TabIndex = 42
        Me.Button_ApplyPatch.Text = "Apply Patch!"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Apply Patch"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.CircularProgress_Create)
        Me.TabControlPanel2.Controls.Add(Me.LabelX15)
        Me.TabControlPanel2.Controls.Add(Me.GroupBox1)
        Me.TabControlPanel2.Controls.Add(Me.LabelX1)
        Me.TabControlPanel2.Controls.Add(Me.CheckBoxX2)
        Me.TabControlPanel2.Controls.Add(Me.TextBoxX_OriginalLevelCreate)
        Me.TabControlPanel2.Controls.Add(Me.CheckBoxX1)
        Me.TabControlPanel2.Controls.Add(Me.TextBoxX_PatchFileCreate)
        Me.TabControlPanel2.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel2.Controls.Add(Me.LabelX3)
        Me.TabControlPanel2.Controls.Add(Me.ButtonX2)
        Me.TabControlPanel2.Controls.Add(Me.LabelX2)
        Me.TabControlPanel2.Controls.Add(Me.TextBoxX_ModifiedLevel)
        Me.TabControlPanel2.Controls.Add(Me.ButtonX3)
        Me.TabControlPanel2.Controls.Add(Me.Button_CreatePatch)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(342, 91)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 5
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'CircularProgress_Create
        '
        Me.CircularProgress_Create.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CircularProgress_Create.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress_Create.Location = New System.Drawing.Point(4, 259)
        Me.CircularProgress_Create.Name = "CircularProgress_Create"
        Me.CircularProgress_Create.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress_Create.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgress_Create.Size = New System.Drawing.Size(23, 23)
        Me.CircularProgress_Create.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress_Create.TabIndex = 42
        '
        'Button_CreatePatch
        '
        Me.Button_CreatePatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button_CreatePatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Button_CreatePatch.FocusCuesEnabled = False
        Me.Button_CreatePatch.Location = New System.Drawing.Point(233, 259)
        Me.Button_CreatePatch.Name = "Button_CreatePatch"
        Me.Button_CreatePatch.Size = New System.Drawing.Size(101, 23)
        Me.Button_CreatePatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button_CreatePatch.TabIndex = 43
        Me.Button_CreatePatch.Text = "Create Patch!"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Create Patch"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 118)
        Me.Controls.Add(Me.TabControl2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "SMBX Magic Patcher (v1.1)"
        Me.TopLeftCornerSize = 0
        Me.TopRightCornerSize = 0
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_PatchFileApply As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX_OriginalLevelApply As DevComponents.DotNetBar.Controls.TextBoxX
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
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents CircularProgress_Create As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Button_CreatePatch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button_ApplyPatch As DevComponents.DotNetBar.ButtonX
End Class
