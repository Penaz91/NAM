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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Notifica = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DisattivaAutorunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VisualizzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VisualizzaOpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VisualizzaLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConversioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InformazioniSuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CryptTXT = New System.Windows.Forms.TextBox
        Me.EditorTXT = New System.Windows.Forms.TextBox
        Me.Button2 = New CloudToolkitN6.CloudButton
        Me.Button4 = New CloudToolkitN6.CloudButton
        Me.Button3 = New CloudToolkitN6.CloudButton
        Me.Conv = New CloudToolkitN6.CloudButton
        Me.Decode = New CloudToolkitN6.CloudButton
        Me.Crypt = New CloudToolkitN6.CloudButton
        Me.CloudButton1 = New CloudToolkitN6.CloudButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Color_Select = New CloudToolkitN6.CloudButton
        Me.TxtColor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.UseBalloon = New System.Windows.Forms.CheckBox
        Me.ShowNotify = New System.Windows.Forms.CheckBox
        Me.Log = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Ask2 = New System.Windows.Forms.RadioButton
        Me.DoNothing2 = New System.Windows.Forms.RadioButton
        Me.OpenDriveRoot2 = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ConvertRadio = New System.Windows.Forms.RadioButton
        Me.Editor = New System.Windows.Forms.RadioButton
        Me.Options = New System.Windows.Forms.RadioButton
        Me.EnableDisable = New System.Windows.Forms.RadioButton
        Me.NoAction = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ShiftDeactivator = New System.Windows.Forms.CheckBox
        Me.ToTray = New System.Windows.Forms.CheckBox
        Me.ProcessFixed = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AskForAction = New System.Windows.Forms.RadioButton
        Me.OpenDrive = New System.Windows.Forms.RadioButton
        Me.SystemAutorun = New System.Windows.Forms.RadioButton
        Me.DoNothing = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Spazio = New System.Windows.Forms.RadioButton
        Me.Lett = New System.Windows.Forms.RadioButton
        Me.NoAvv = New System.Windows.Forms.RadioButton
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.noLog = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.UPD_Log = New CloudToolkitN6.CloudButton
        Me.Del_log = New CloudToolkitN6.CloudButton
        Me.Snippets = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApriIlDriveInseritoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApriUnaCartellaSulPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotifyStrip.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.Snippets.SuspendLayout()
        Me.SuspendLayout()
        '
        'Notifica
        '
        Me.Notifica.ContextMenuStrip = Me.NotifyStrip
        Me.Notifica.Icon = CType(resources.GetObject("Notifica.Icon"), System.Drawing.Icon)
        Me.Notifica.Text = "New Autorun Manager"
        Me.Notifica.Visible = True
        '
        'NotifyStrip
        '
        Me.NotifyStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisattivaAutorunToolStripMenuItem, Me.VisualizzaToolStripMenuItem, Me.VisualizzaOpzioniToolStripMenuItem, Me.VisualizzaLogToolStripMenuItem, Me.ConversioneToolStripMenuItem, Me.InformazioniSuToolStripMenuItem, Me.EsciToolStripMenuItem})
        Me.NotifyStrip.Name = "NotifyStrip"
        Me.NotifyStrip.Size = New System.Drawing.Size(172, 158)
        '
        'DisattivaAutorunToolStripMenuItem
        '
        Me.DisattivaAutorunToolStripMenuItem.Name = "DisattivaAutorunToolStripMenuItem"
        Me.DisattivaAutorunToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DisattivaAutorunToolStripMenuItem.Text = "Disattiva Autorun"
        '
        'VisualizzaToolStripMenuItem
        '
        Me.VisualizzaToolStripMenuItem.Name = "VisualizzaToolStripMenuItem"
        Me.VisualizzaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.VisualizzaToolStripMenuItem.Text = "Visualizza Editor"
        '
        'VisualizzaOpzioniToolStripMenuItem
        '
        Me.VisualizzaOpzioniToolStripMenuItem.Name = "VisualizzaOpzioniToolStripMenuItem"
        Me.VisualizzaOpzioniToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.VisualizzaOpzioniToolStripMenuItem.Text = "Visualizza Opzioni"
        '
        'VisualizzaLogToolStripMenuItem
        '
        Me.VisualizzaLogToolStripMenuItem.Name = "VisualizzaLogToolStripMenuItem"
        Me.VisualizzaLogToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.VisualizzaLogToolStripMenuItem.Text = "Visualizza Log"
        '
        'ConversioneToolStripMenuItem
        '
        Me.ConversioneToolStripMenuItem.Name = "ConversioneToolStripMenuItem"
        Me.ConversioneToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ConversioneToolStripMenuItem.Text = "Conversione"
        '
        'InformazioniSuToolStripMenuItem
        '
        Me.InformazioniSuToolStripMenuItem.Name = "InformazioniSuToolStripMenuItem"
        Me.InformazioniSuToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.InformazioniSuToolStripMenuItem.Text = "Informazioni Su..."
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(601, 437)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(593, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CryptTXT)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EditorTXT)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Conv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Decode)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Crypt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CloudButton1)
        Me.SplitContainer1.Size = New System.Drawing.Size(584, 399)
        Me.SplitContainer1.SplitterDistance = 428
        Me.SplitContainer1.TabIndex = 1
        '
        'CryptTXT
        '
        Me.CryptTXT.Location = New System.Drawing.Point(3, 200)
        Me.CryptTXT.Multiline = True
        Me.CryptTXT.Name = "CryptTXT"
        Me.CryptTXT.Size = New System.Drawing.Size(422, 196)
        Me.CryptTXT.TabIndex = 1
        '
        'EditorTXT
        '
        Me.EditorTXT.Location = New System.Drawing.Point(3, 3)
        Me.EditorTXT.Multiline = True
        Me.EditorTXT.Name = "EditorTXT"
        Me.EditorTXT.Size = New System.Drawing.Size(422, 191)
        Me.EditorTXT.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ButtonText = "Esci da N.A.M."
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Button2.Icon = Nothing
        Me.Button2.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Button2.IconSpacingX = 5
        Me.Button2.IconSpacingY = 5
        Me.Button2.IconTransparency = 0.0!
        Me.Button2.Location = New System.Drawing.Point(3, 357)
        Me.Button2.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Button2.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Button2.Name = "Button2"
        Me.Button2.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Button2.Size = New System.Drawing.Size(146, 39)
        Me.Button2.TabIndex = 12
        Me.Button2.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Button2.TextSpacingX = 5
        Me.Button2.TextSpacingY = 5
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.ButtonText = "Apri la Dropbox"
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Button4.Icon = Nothing
        Me.Button4.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Button4.IconSpacingX = 5
        Me.Button4.IconSpacingY = 5
        Me.Button4.IconTransparency = 0.0!
        Me.Button4.Location = New System.Drawing.Point(3, 187)
        Me.Button4.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Button4.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Button4.Name = "Button4"
        Me.Button4.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Button4.Size = New System.Drawing.Size(146, 39)
        Me.Button4.TabIndex = 11
        Me.Button4.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Button4.TextSpacingX = 5
        Me.Button4.TextSpacingY = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.ButtonText = "Informazioni su N.A.M."
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Button3.Icon = Nothing
        Me.Button3.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Button3.IconSpacingX = 5
        Me.Button3.IconSpacingY = 5
        Me.Button3.IconTransparency = 0.0!
        Me.Button3.Location = New System.Drawing.Point(3, 312)
        Me.Button3.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Button3.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Button3.Name = "Button3"
        Me.Button3.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Button3.Size = New System.Drawing.Size(146, 39)
        Me.Button3.TabIndex = 10
        Me.Button3.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Button3.TextSpacingX = 5
        Me.Button3.TextSpacingY = 5
        '
        'Conv
        '
        Me.Conv.BackColor = System.Drawing.Color.Transparent
        Me.Conv.ButtonText = "Converti"
        Me.Conv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Conv.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Conv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Conv.Icon = Nothing
        Me.Conv.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Conv.IconSpacingX = 5
        Me.Conv.IconSpacingY = 5
        Me.Conv.IconTransparency = 0.0!
        Me.Conv.Location = New System.Drawing.Point(3, 141)
        Me.Conv.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Conv.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Conv.Name = "Conv"
        Me.Conv.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Conv.Size = New System.Drawing.Size(146, 40)
        Me.Conv.TabIndex = 9
        Me.Conv.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Conv.TextSpacingX = 5
        Me.Conv.TextSpacingY = 5
        '
        'Decode
        '
        Me.Decode.BackColor = System.Drawing.Color.Transparent
        Me.Decode.ButtonText = "Apri e modifica"
        Me.Decode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Decode.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Decode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Decode.Icon = Nothing
        Me.Decode.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Decode.IconSpacingX = 5
        Me.Decode.IconSpacingY = 5
        Me.Decode.IconTransparency = 0.0!
        Me.Decode.Location = New System.Drawing.Point(3, 95)
        Me.Decode.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Decode.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Decode.Name = "Decode"
        Me.Decode.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Decode.Size = New System.Drawing.Size(146, 40)
        Me.Decode.TabIndex = 8
        Me.Decode.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Decode.TextSpacingX = 5
        Me.Decode.TextSpacingY = 5
        '
        'Crypt
        '
        Me.Crypt.BackColor = System.Drawing.Color.Transparent
        Me.Crypt.ButtonText = "Codifica e salva"
        Me.Crypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Crypt.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Crypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Crypt.Icon = Nothing
        Me.Crypt.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Crypt.IconSpacingX = 5
        Me.Crypt.IconSpacingY = 5
        Me.Crypt.IconTransparency = 0.0!
        Me.Crypt.Location = New System.Drawing.Point(3, 49)
        Me.Crypt.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Crypt.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Crypt.Name = "Crypt"
        Me.Crypt.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Crypt.Size = New System.Drawing.Size(146, 40)
        Me.Crypt.TabIndex = 7
        Me.Crypt.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Crypt.TextSpacingX = 5
        Me.Crypt.TextSpacingY = 5
        '
        'CloudButton1
        '
        Me.CloudButton1.BackColor = System.Drawing.Color.Transparent
        Me.CloudButton1.ButtonText = "Inserisci Code-Snippets"
        Me.CloudButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudButton1.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CloudButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CloudButton1.Icon = Nothing
        Me.CloudButton1.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.CloudButton1.IconSpacingX = 5
        Me.CloudButton1.IconSpacingY = 5
        Me.CloudButton1.IconTransparency = 0.0!
        Me.CloudButton1.Location = New System.Drawing.Point(3, 3)
        Me.CloudButton1.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CloudButton1.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CloudButton1.Name = "CloudButton1"
        Me.CloudButton1.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CloudButton1.Size = New System.Drawing.Size(146, 40)
        Me.CloudButton1.TabIndex = 6
        Me.CloudButton1.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.CloudButton1.TextSpacingX = 5
        Me.CloudButton1.TextSpacingY = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(593, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Opzioni"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Color_Select)
        Me.GroupBox7.Controls.Add(Me.TxtColor)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 331)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(579, 75)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Skin DropBox"
        '
        'Color_Select
        '
        Me.Color_Select.BackColor = System.Drawing.Color.Transparent
        Me.Color_Select.ButtonText = "Seleziona Colore"
        Me.Color_Select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Color_Select.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Color_Select.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Color_Select.Icon = Nothing
        Me.Color_Select.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Color_Select.IconSpacingX = 5
        Me.Color_Select.IconSpacingY = 5
        Me.Color_Select.IconTransparency = 0.0!
        Me.Color_Select.Location = New System.Drawing.Point(457, 46)
        Me.Color_Select.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Color_Select.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Color_Select.Name = "Color_Select"
        Me.Color_Select.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Color_Select.Size = New System.Drawing.Size(116, 20)
        Me.Color_Select.TabIndex = 3
        Me.Color_Select.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Color_Select.TextSpacingX = 5
        Me.Color_Select.TextSpacingY = 5
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(82, 46)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(369, 20)
        Me.TxtColor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Colore Testo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(567, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.UseBalloon)
        Me.GroupBox6.Controls.Add(Me.ShowNotify)
        Me.GroupBox6.Controls.Add(Me.Log)
        Me.GroupBox6.Location = New System.Drawing.Point(332, 231)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(255, 94)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Debug && Errori"
        '
        'UseBalloon
        '
        Me.UseBalloon.AutoSize = True
        Me.UseBalloon.Location = New System.Drawing.Point(21, 42)
        Me.UseBalloon.Name = "UseBalloon"
        Me.UseBalloon.Size = New System.Drawing.Size(211, 17)
        Me.UseBalloon.TabIndex = 2
        Me.UseBalloon.Text = "Usa un balloon invece di un messaggio"
        Me.UseBalloon.UseVisualStyleBackColor = True
        '
        'ShowNotify
        '
        Me.ShowNotify.AutoSize = True
        Me.ShowNotify.Location = New System.Drawing.Point(6, 19)
        Me.ShowNotify.Name = "ShowNotify"
        Me.ShowNotify.Size = New System.Drawing.Size(208, 17)
        Me.ShowNotify.TabIndex = 1
        Me.ShowNotify.Text = "Visualizza una notifica in caso di errore"
        Me.ShowNotify.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.AutoSize = True
        Me.Log.Location = New System.Drawing.Point(6, 65)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(143, 17)
        Me.Log.TabIndex = 0
        Me.Log.Text = "Scrivi un LOG degli errori"
        Me.Log.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Ask2)
        Me.GroupBox5.Controls.Add(Me.DoNothing2)
        Me.GroupBox5.Controls.Add(Me.OpenDriveRoot2)
        Me.GroupBox5.Location = New System.Drawing.Point(229, 122)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(358, 103)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Se non viene trovato nessun file autorun.inf"
        '
        'Ask2
        '
        Me.Ask2.AutoSize = True
        Me.Ask2.Location = New System.Drawing.Point(6, 71)
        Me.Ask2.Name = "Ask2"
        Me.Ask2.Size = New System.Drawing.Size(54, 17)
        Me.Ask2.TabIndex = 0
        Me.Ask2.TabStop = True
        Me.Ask2.Text = "Chiedi"
        Me.Ask2.UseVisualStyleBackColor = True
        '
        'DoNothing2
        '
        Me.DoNothing2.AutoSize = True
        Me.DoNothing2.Location = New System.Drawing.Point(6, 25)
        Me.DoNothing2.Name = "DoNothing2"
        Me.DoNothing2.Size = New System.Drawing.Size(91, 17)
        Me.DoNothing2.TabIndex = 0
        Me.DoNothing2.TabStop = True
        Me.DoNothing2.Text = "Non fare nulla"
        Me.DoNothing2.UseVisualStyleBackColor = True
        '
        'OpenDriveRoot2
        '
        Me.OpenDriveRoot2.AutoSize = True
        Me.OpenDriveRoot2.Location = New System.Drawing.Point(6, 48)
        Me.OpenDriveRoot2.Name = "OpenDriveRoot2"
        Me.OpenDriveRoot2.Size = New System.Drawing.Size(112, 17)
        Me.OpenDriveRoot2.TabIndex = 0
        Me.OpenDriveRoot2.TabStop = True
        Me.OpenDriveRoot2.Text = "Apri il drive inserito"
        Me.OpenDriveRoot2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ConvertRadio)
        Me.GroupBox4.Controls.Add(Me.Editor)
        Me.GroupBox4.Controls.Add(Me.Options)
        Me.GroupBox4.Controls.Add(Me.EnableDisable)
        Me.GroupBox4.Controls.Add(Me.NoAction)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 231)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(323, 94)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Doppio Click sull'icona di notifica"
        '
        'ConvertRadio
        '
        Me.ConvertRadio.AutoSize = True
        Me.ConvertRadio.Location = New System.Drawing.Point(155, 42)
        Me.ConvertRadio.Name = "ConvertRadio"
        Me.ConvertRadio.Size = New System.Drawing.Size(124, 17)
        Me.ConvertRadio.TabIndex = 0
        Me.ConvertRadio.TabStop = True
        Me.ConvertRadio.Text = "Attiva la conversione"
        Me.ConvertRadio.UseVisualStyleBackColor = True
        '
        'Editor
        '
        Me.Editor.AutoSize = True
        Me.Editor.Location = New System.Drawing.Point(155, 19)
        Me.Editor.Name = "Editor"
        Me.Editor.Size = New System.Drawing.Size(159, 17)
        Me.Editor.TabIndex = 0
        Me.Editor.TabStop = True
        Me.Editor.Text = "Visualizza L'Editor di autorun"
        Me.Editor.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.AutoSize = True
        Me.Options.Location = New System.Drawing.Point(6, 65)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(120, 17)
        Me.Options.TabIndex = 0
        Me.Options.TabStop = True
        Me.Options.Text = "Visualizza le Opzioni"
        Me.Options.UseVisualStyleBackColor = True
        '
        'EnableDisable
        '
        Me.EnableDisable.AutoSize = True
        Me.EnableDisable.Location = New System.Drawing.Point(6, 42)
        Me.EnableDisable.Name = "EnableDisable"
        Me.EnableDisable.Size = New System.Drawing.Size(138, 17)
        Me.EnableDisable.TabIndex = 0
        Me.EnableDisable.TabStop = True
        Me.EnableDisable.Text = "Attiva/Disattiva Autorun"
        Me.EnableDisable.UseVisualStyleBackColor = True
        '
        'NoAction
        '
        Me.NoAction.AutoSize = True
        Me.NoAction.Location = New System.Drawing.Point(6, 19)
        Me.NoAction.Name = "NoAction"
        Me.NoAction.Size = New System.Drawing.Size(102, 17)
        Me.NoAction.TabIndex = 0
        Me.NoAction.TabStop = True
        Me.NoAction.Text = "Nessuna Azione"
        Me.NoAction.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ShiftDeactivator)
        Me.GroupBox3.Controls.Add(Me.ToTray)
        Me.GroupBox3.Controls.Add(Me.ProcessFixed)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 103)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opzioni Generali"
        '
        'ShiftDeactivator
        '
        Me.ShiftDeactivator.AutoSize = True
        Me.ShiftDeactivator.Location = New System.Drawing.Point(6, 65)
        Me.ShiftDeactivator.Name = "ShiftDeactivator"
        Me.ShiftDeactivator.Size = New System.Drawing.Size(189, 30)
        Me.ShiftDeactivator.TabIndex = 6
        Me.ShiftDeactivator.Text = "Se si tiene premuto SHIFT durante" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l'autorun, l'autorun verrà fermato"
        Me.ShiftDeactivator.UseVisualStyleBackColor = True
        '
        'ToTray
        '
        Me.ToTray.AutoSize = True
        Me.ToTray.Location = New System.Drawing.Point(6, 42)
        Me.ToTray.Name = "ToTray"
        Me.ToTray.Size = New System.Drawing.Size(203, 17)
        Me.ToTray.TabIndex = 3
        Me.ToTray.Text = "Invece di chiudere manda alla traybar"
        Me.ToTray.UseVisualStyleBackColor = True
        '
        'ProcessFixed
        '
        Me.ProcessFixed.AutoSize = True
        Me.ProcessFixed.Location = New System.Drawing.Point(6, 19)
        Me.ProcessFixed.Name = "ProcessFixed"
        Me.ProcessFixed.Size = New System.Drawing.Size(160, 17)
        Me.ProcessFixed.TabIndex = 2
        Me.ProcessFixed.Text = "Processa Hard Disks Esterni"
        Me.ProcessFixed.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AskForAction)
        Me.GroupBox2.Controls.Add(Me.OpenDrive)
        Me.GroupBox2.Controls.Add(Me.SystemAutorun)
        Me.GroupBox2.Controls.Add(Me.DoNothing)
        Me.GroupBox2.Location = New System.Drawing.Point(229, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Se non viene trovato un autorun sicuro"
        '
        'AskForAction
        '
        Me.AskForAction.AutoSize = True
        Me.AskForAction.Location = New System.Drawing.Point(6, 87)
        Me.AskForAction.Name = "AskForAction"
        Me.AskForAction.Size = New System.Drawing.Size(54, 17)
        Me.AskForAction.TabIndex = 0
        Me.AskForAction.TabStop = True
        Me.AskForAction.Text = "Chiedi"
        Me.AskForAction.UseVisualStyleBackColor = True
        '
        'OpenDrive
        '
        Me.OpenDrive.AutoSize = True
        Me.OpenDrive.Location = New System.Drawing.Point(6, 65)
        Me.OpenDrive.Name = "OpenDrive"
        Me.OpenDrive.Size = New System.Drawing.Size(112, 17)
        Me.OpenDrive.TabIndex = 0
        Me.OpenDrive.TabStop = True
        Me.OpenDrive.Text = "Apri il drive inserito"
        Me.OpenDrive.UseVisualStyleBackColor = True
        '
        'SystemAutorun
        '
        Me.SystemAutorun.AutoSize = True
        Me.SystemAutorun.Location = New System.Drawing.Point(6, 42)
        Me.SystemAutorun.Name = "SystemAutorun"
        Me.SystemAutorun.Size = New System.Drawing.Size(283, 17)
        Me.SystemAutorun.TabIndex = 0
        Me.SystemAutorun.TabStop = True
        Me.SystemAutorun.Text = "Avvia l'autorun.inf di sistema (con conferma dell'utente)"
        Me.SystemAutorun.UseVisualStyleBackColor = True
        '
        'DoNothing
        '
        Me.DoNothing.AutoSize = True
        Me.DoNothing.Location = New System.Drawing.Point(6, 19)
        Me.DoNothing.Name = "DoNothing"
        Me.DoNothing.Size = New System.Drawing.Size(91, 17)
        Me.DoNothing.TabIndex = 0
        Me.DoNothing.TabStop = True
        Me.DoNothing.Text = "Non fare nulla"
        Me.DoNothing.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Spazio)
        Me.GroupBox1.Controls.Add(Me.Lett)
        Me.GroupBox1.Controls.Add(Me.NoAvv)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avvisi all'inserimento"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 87)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Usa il nome del volume"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Spazio
        '
        Me.Spazio.AutoSize = True
        Me.Spazio.Location = New System.Drawing.Point(6, 65)
        Me.Spazio.Name = "Spazio"
        Me.Spazio.Size = New System.Drawing.Size(167, 17)
        Me.Spazio.TabIndex = 1
        Me.Spazio.TabStop = True
        Me.Spazio.Text = "Notifica Lettera e spazio libero"
        Me.Spazio.UseVisualStyleBackColor = True
        '
        'Lett
        '
        Me.Lett.AutoSize = True
        Me.Lett.Location = New System.Drawing.Point(6, 42)
        Me.Lett.Name = "Lett"
        Me.Lett.Size = New System.Drawing.Size(117, 17)
        Me.Lett.TabIndex = 1
        Me.Lett.TabStop = True
        Me.Lett.Text = "Solo Notifica lettera"
        Me.Lett.UseVisualStyleBackColor = True
        '
        'NoAvv
        '
        Me.NoAvv.AutoSize = True
        Me.NoAvv.Location = New System.Drawing.Point(6, 19)
        Me.NoAvv.Name = "NoAvv"
        Me.NoAvv.Size = New System.Drawing.Size(96, 17)
        Me.NoAvv.TabIndex = 1
        Me.NoAvv.TabStop = True
        Me.NoAvv.Text = "Nessun Avviso"
        Me.NoAvv.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.noLog)
        Me.TabPage3.Controls.Add(Me.SplitContainer2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(593, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Log Degli Errori"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'noLog
        '
        Me.noLog.AutoSize = True
        Me.noLog.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noLog.Location = New System.Drawing.Point(92, 185)
        Me.noLog.Name = "noLog"
        Me.noLog.Size = New System.Drawing.Size(409, 40)
        Me.noLog.TabIndex = 3
        Me.noLog.Text = "Log Degli Errori Disattivato"
        Me.noLog.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(6, 6)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(581, 399)
        Me.SplitContainer2.SplitterDistance = 341
        Me.SplitContainer2.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(575, 329)
        Me.ListBox1.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.UPD_Log)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Del_log)
        Me.SplitContainer3.Size = New System.Drawing.Size(581, 54)
        Me.SplitContainer3.SplitterDistance = 290
        Me.SplitContainer3.TabIndex = 0
        '
        'UPD_Log
        '
        Me.UPD_Log.BackColor = System.Drawing.Color.Transparent
        Me.UPD_Log.ButtonText = "Aggiorna Log"
        Me.UPD_Log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UPD_Log.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.UPD_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPD_Log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.UPD_Log.Icon = Nothing
        Me.UPD_Log.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.UPD_Log.IconSpacingX = 5
        Me.UPD_Log.IconSpacingY = 5
        Me.UPD_Log.IconTransparency = 0.0!
        Me.UPD_Log.Location = New System.Drawing.Point(0, 0)
        Me.UPD_Log.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.UPD_Log.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.UPD_Log.Name = "UPD_Log"
        Me.UPD_Log.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.UPD_Log.Size = New System.Drawing.Size(290, 54)
        Me.UPD_Log.TabIndex = 0
        Me.UPD_Log.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.UPD_Log.TextSpacingX = 5
        Me.UPD_Log.TextSpacingY = 5
        '
        'Del_log
        '
        Me.Del_log.BackColor = System.Drawing.Color.Transparent
        Me.Del_log.ButtonText = "Cancella Log"
        Me.Del_log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Del_log.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.Del_log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Del_log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Del_log.Icon = Nothing
        Me.Del_log.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.Del_log.IconSpacingX = 5
        Me.Del_log.IconSpacingY = 5
        Me.Del_log.IconTransparency = 0.0!
        Me.Del_log.Location = New System.Drawing.Point(0, 0)
        Me.Del_log.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.Del_log.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.Del_log.Name = "Del_log"
        Me.Del_log.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.Del_log.Size = New System.Drawing.Size(287, 54)
        Me.Del_log.TabIndex = 0
        Me.Del_log.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.Del_log.TextSpacingX = 5
        Me.Del_log.TextSpacingY = 5
        '
        'Snippets
        '
        Me.Snippets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApriIlDriveInseritoToolStripMenuItem, Me.ApriUnaCartellaSulPCToolStripMenuItem, Me.ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem})
        Me.Snippets.Name = "Snippets"
        Me.Snippets.Size = New System.Drawing.Size(286, 70)
        '
        'ApriIlDriveInseritoToolStripMenuItem
        '
        Me.ApriIlDriveInseritoToolStripMenuItem.Name = "ApriIlDriveInseritoToolStripMenuItem"
        Me.ApriIlDriveInseritoToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.ApriIlDriveInseritoToolStripMenuItem.Text = "Apri il drive inserito"
        '
        'ApriUnaCartellaSulPCToolStripMenuItem
        '
        Me.ApriUnaCartellaSulPCToolStripMenuItem.Name = "ApriUnaCartellaSulPCToolStripMenuItem"
        Me.ApriUnaCartellaSulPCToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.ApriUnaCartellaSulPCToolStripMenuItem.Text = "Apri un file o una cartella sul PC"
        '
        'ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem
        '
        Me.ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem.Name = "ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem"
        Me.ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem.Text = "Apri un file o una cartella sul drive inserito"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 455)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Autorun Manager"
        Me.NotifyStrip.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.Snippets.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Notifica As System.Windows.Forms.NotifyIcon
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Spazio As System.Windows.Forms.RadioButton
    Friend WithEvents Lett As System.Windows.Forms.RadioButton
    Friend WithEvents NoAvv As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CryptTXT As System.Windows.Forms.TextBox
    Friend WithEvents EditorTXT As System.Windows.Forms.TextBox
    Friend WithEvents Snippets As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ApriIlDriveInseritoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriUnaCartellaSulPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenDrive As System.Windows.Forms.RadioButton
    Friend WithEvents SystemAutorun As System.Windows.Forms.RadioButton
    Friend WithEvents DoNothing As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ProcessFixed As System.Windows.Forms.CheckBox
    Friend WithEvents NotifyStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VisualizzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToTray As System.Windows.Forms.CheckBox
    Friend WithEvents VisualizzaOpzioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisattivaAutorunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ConvertRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Editor As System.Windows.Forms.RadioButton
    Friend WithEvents Options As System.Windows.Forms.RadioButton
    Friend WithEvents EnableDisable As System.Windows.Forms.RadioButton
    Friend WithEvents NoAction As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents AskForAction As System.Windows.Forms.RadioButton
    Friend WithEvents DoNothing2 As System.Windows.Forms.RadioButton
    Friend WithEvents OpenDriveRoot2 As System.Windows.Forms.RadioButton
    Friend WithEvents Ask2 As System.Windows.Forms.RadioButton
    Friend WithEvents ShiftDeactivator As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Log As System.Windows.Forms.CheckBox
    Friend WithEvents ShowNotify As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TxtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UseBalloon As System.Windows.Forms.CheckBox
    Friend WithEvents CloudButton1 As CloudToolkitN6.CloudButton
    Friend WithEvents Decode As CloudToolkitN6.CloudButton
    Friend WithEvents Crypt As CloudToolkitN6.CloudButton
    Friend WithEvents Button2 As CloudToolkitN6.CloudButton
    Friend WithEvents Button4 As CloudToolkitN6.CloudButton
    Friend WithEvents Button3 As CloudToolkitN6.CloudButton
    Friend WithEvents Conv As CloudToolkitN6.CloudButton
    Friend WithEvents Color_Select As CloudToolkitN6.CloudButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents noLog As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents UPD_Log As CloudToolkitN6.CloudButton
    Friend WithEvents Del_log As CloudToolkitN6.CloudButton
    Friend WithEvents VisualizzaLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniSuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
