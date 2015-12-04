Imports System.Math
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Public Class Form1
    Public myprocess As Process = Process.GetCurrentProcess
    Private Const WM_DEVICECHANGE As Integer = &H219&
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000&
    Private Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004&
    Private Const DBT_DEVTYP_VOLUME As Integer = &H2&
    Private Const WM_QUERYENDSESSION As Integer = &H11
    Private Shared SystemShutdown As Boolean = False
    Private Const Titolo As String = "New Autorun Manager"
    '---------------------------------------------------------
    Dim Avvisi As Integer
    Public Shared lettera As String
    Dim NoARunAction As Integer
    Dim Driveinfo As IO.DriveInfo
    Dim ProcessFixedOpt As Integer
    Dim ToTrayOPT As Integer
    Dim NotifyAction As Integer
    Dim AutorunEnabled As Boolean = True
    Dim NosystemAutorun As Integer
    Dim StopARunOnShift As Boolean
    Public autorunstatus As Integer = 1
    Dim WriteLog As Boolean
    Dim ex As Exception
    Dim NotifyOnError As Boolean
    Dim DropBoxSkin As String
    Dim MessaggioErrore As String
    Dim UseBalloonOnError As Boolean
    Dim UseVolName As Boolean
    Protected Const internalkey As String = "A^r£45#@ù§()5*F(23e{O=sè1é5[e>?0-_.2,9'n]f;in!2}%/N"
    Private Structure DEV_BROADCAST_HDR
        Public dbch_size As Int32
        Public dbch_devicetype As Int32
        Public dbch_reserved As Int32
    End Structure
    Private Structure DEV_BROADCAST_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure
    Dim c As DEV_BROADCAST_VOLUME
    Dim b As DEV_BROADCAST_HDR
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_DEVICECHANGE
                Select Case m.WParam.ToInt32
                    Case DBT_DEVICEARRIVAL
                        myprocess.PriorityClass = ProcessPriorityClass.High
                        b = Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR))
                        If b.dbch_devicetype = DBT_DEVTYP_VOLUME Then
                            c = Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_VOLUME))
                            lettera = firstdrivefrommask(c.dbcv_unitmask)
                            Driveinfo = My.Computer.FileSystem.GetDriveInfo(lettera & ":")
                            If (Driveinfo.DriveType = IO.DriveType.Removable) Or (Driveinfo.DriveType = IO.DriveType.Fixed And ProcessFixed.Checked = True) Then
                                DropBox.lettera = lettera & ":\"
                                If My.Computer.Keyboard.ShiftKeyDown = True And StopARunOnShift = True And My.Computer.Keyboard.AltKeyDown = False Then
                                    autorunstatus = 0
                                Else
                                    If My.Computer.Keyboard.AltKeyDown = True And My.Computer.Keyboard.CtrlKeyDown = False Then
                                        DropBox.Show()
                                    Else
                                        If (My.Computer.Keyboard.ShiftKeyDown = True And StopARunOnShift = True) And My.Computer.Keyboard.AltKeyDown = True Then
                                            DropBox.Show()
                                            autorunstatus = 0
                                        Else
                                            Dim autorunExist As Boolean = My.Computer.FileSystem.FileExists(lettera & ":\autorun.uam")
                                            If autorunExist = True Then
                                                Try
                                                    Autorun()
                                                Catch ex As Exception
                                                    If NotifyOnError = True Then
                                                        If UseBalloonOnError = True Then
                                                            Notifica.ShowBalloonTip(5000, Titolo & ": errore", ex.Message, ToolTipIcon.Warning)
                                                        Else
                                                            MsgBox("Errore: " & ex.Message, MsgBoxStyle.Exclamation, Titolo)
                                                        End If
                                                    End If
                                                        If WriteLog = True Then
                                                            MessaggioErrore = ex.Message
                                                            AddLog()
                                                        End If
                                                End Try
                                            Else
                                                Try
                                                    Noautorun()
                                                Catch ex As Exception
                                                    If NotifyOnError = True Then
                                                        If UseBalloonOnError = True Then
                                                            Notifica.ShowBalloonTip(5000, Titolo & ": errore", ex.Message, ToolTipIcon.Warning)
                                                        Else
                                                            MsgBox("Errore: " & ex.Message, MsgBoxStyle.Exclamation, Titolo)
                                                        End If
                                                    End If
                                                        If WriteLog = True Then
                                                            MessaggioErrore = ex.Message
                                                            AddLog()
                                                        End If
                                                End Try
                                            End If
                                        End If
                                    End If
                                End If
                                Select Case Avvisi
                                    Case 0
                                        'niente
                                    Case 1
                                        avvisolettera()
                                    Case 2
                                        AvvisoSpazio()
                                End Select
                            End If
                            End If
                    Case DBT_DEVICEREMOVECOMPLETE
                        myprocess.PriorityClass = ProcessPriorityClass.High
                        b = Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR))
                        If b.dbch_devicetype = DBT_DEVTYP_VOLUME Then
                            If DropBox.Visible = True Then
                                DropBox.Hide()
                                DropBox.Dispose()
                            End If
                        End If
                End Select
            Case WM_QUERYENDSESSION
                End
        End Select
        myprocess.PriorityClass = ProcessPriorityClass.Idle
        MyBase.WndProc(m)
    End Sub
    Function firstdrivefrommask(ByVal unit As Int32) As String
        Const A As Integer = 65
        Dim i As Integer
        For i = 0 To 25
            If unit And 1 Then Exit For
            unit = unit >> 1
        Next
        Return Char.ConvertFromUtf32(i + A)
    End Function
    Private Sub SistemaSpegni(ByVal sender As System.Object, ByVal e As SessionEndingEventArgs)
        MyBase.Close()
    End Sub
    Private Sub MyBaseLoading(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Minimized
        MyBase.Hide()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    End Sub
    Private Sub MyBase_formClosing(ByVal sender As System.Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ToTrayOPT = 1 Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            Me.Hide()
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Titolo & " " & My.Application.Info.Version.ToString
        myprocess.PriorityClass = ProcessPriorityClass.Idle
        AddHandler SystemEvents.SessionEnding, AddressOf SistemaSpegni
        Newkey(internalkey)
        Avvisi = My.Settings.Avvisi
        If Avvisi = 0 Then
            NoAvv.Checked = True
        ElseIf Avvisi = 1 Then
            Lett.Checked = True
        ElseIf Avvisi = 2 Then
            Spazio.Checked = True
        Else
            ResetImpostazioni()
        End If
        NoARunAction = My.Settings.NoAutorunAction
        If NoARunAction = 0 Then
            DoNothing.Checked = True
            GroupBox5.Enabled = False
        ElseIf NoARunAction = 1 Then
            SystemAutorun.Checked = True
            GroupBox5.Enabled = True
        ElseIf NoARunAction = 2 Then
            OpenDrive.Checked = True
            GroupBox5.Enabled = False
        ElseIf NoARunAction = 3 Then
            AskForAction.Checked = True
            GroupBox5.Enabled = True
        Else
            ResetImpostazioni()
        End If
        ProcessFixedOpt = My.Settings.ProcessFixed
        Select Case ProcessFixedOpt
            Case 0
                ProcessFixed.Checked = False
            Case 1
                ProcessFixed.Checked = True
            Case Else
                ResetImpostazioni()
        End Select
        ToTrayOPT = My.Settings.ToTray
        Select Case ToTrayOPT
            Case 0
                ToTray.Checked = False
            Case 1
                ToTray.Checked = True
            Case Else
                ResetImpostazioni()
        End Select
        NotifyAction = My.Settings.NotifyAction
        Select Case NotifyAction
            Case 0
                NoAction.Checked = True
            Case 1
                EnableDisable.Checked = True
            Case 2
                Options.Checked = True
            Case 3
                Editor.Checked = True
            Case 4
                ConvertRadio.Checked = True
            Case Else
                ResetImpostazioni()
        End Select
        NosystemAutorun = My.Settings.NoSystemAutorun
        Select Case NosystemAutorun
            Case 0
                DoNothing2.Checked = True
            Case 1
                OpenDriveRoot2.Checked = True
            Case 2
                Ask2.Checked = True
            Case Else
                ResetImpostazioni()
        End Select
        StopARunOnShift = My.Settings.StopARunOnShift
        Select Case StopARunOnShift
            Case True
                ShiftDeactivator.Checked = True
            Case False
                ShiftDeactivator.Checked = False
            Case Else
                ResetImpostazioni()
        End Select
        WriteLog = My.Settings.WriteLog
        Select Case WriteLog
            Case True
                Log.Checked = True
            Case False
                Log.Checked = False
            Case Else
                ResetImpostazioni()
        End Select
        NotifyOnError = My.Settings.NotifyOnError
        Select Case NotifyOnError
            Case True
                ShowNotify.Checked = True
            Case False
                ShowNotify.Checked = False
            Case Else
                ResetImpostazioni()
        End Select
        If My.Computer.FileSystem.DirectoryExists("Skins") = True Then
            Dim files() As String = My.Computer.FileSystem.GetFiles("Skins").ToArray
            For i = 0 To files.Length - 1
                If files(i).Contains(".png") Or files(i).Contains(".jpg") Then
                    ComboBox1.Items.Add(files(i))
                End If
            Next i
        End If
        DropBoxSkin = My.Settings.DropBoxSkin
        Select Case My.Computer.FileSystem.FileExists(DropBoxSkin)
            Case True
                ComboBox1.SelectedItem = DropBoxSkin
            Case False
                MsgBox("Nessuna skin per la dropbox selezionata, selezionarne una...", MsgBoxStyle.Information, Titolo)
        End Select
        DropBox.Textcolor = My.Settings.TextColor
        TxtColor.Text = My.Settings.TextColor.ToString
        UseBalloonOnError = My.Settings.UseBalloonOnError
        Select Case UseBalloonOnError
            Case True
                UseBalloon.Checked = True
            Case False
                UseBalloon.Checked = False
            Case Else
                ResetImpostazioni()
        End Select
        UseVolName = My.Settings.UseVolumeName
        Select Case UseVolName
            Case True
                CheckBox1.Checked = True
            Case False
                CheckBox1.Checked = False
            Case Else
                ResetImpostazioni()
        End Select
        If WriteLog = False Then
            ListBox1.Hide()
            noLog.Show()
        ElseIf WriteLog = True Then
            ListBox1.Show()
            noLog.Hide()
        End If
    End Sub
    Function ResetImpostazioni() As Object
        MsgBox("Errore nel caricamento delle impostazioni, reset delle impostazioni in corso...Avviare nuovamente New Autorun Manager.", MsgBoxStyle.Critical, Titolo)
        My.Settings.NoAutorunAction = 0
        My.Settings.Avvisi = 0
        My.Settings.ProcessFixed = 0
        My.Settings.ToTray = 0
        My.Settings.WriteLog = False
        My.Settings.NotifyOnError = False
        My.Settings.UseBalloonOnError = False
        My.Settings.UseVolumeName = False
        My.Settings.Save()
        MyBase.Close()
        Return Nothing
    End Function
    Private Sub NoAvv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoAvv.CheckedChanged
        If NoAvv.Checked = True Then
            Avvisi = 0
            My.Settings.Avvisi = Avvisi
        End If
        My.Settings.Save()
    End Sub
    Private Sub Lett_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lett.CheckedChanged
        If Lett.Checked = True Then
            Avvisi = 1
            My.Settings.Avvisi = Avvisi
        End If
        My.Settings.Save()
    End Sub
    Private Sub Spazio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spazio.CheckedChanged
        If Spazio.Checked = True Then
            Avvisi = 2
            My.Settings.Avvisi = Avvisi
        End If
        My.Settings.Save()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton1.Click
        Snippets.Show(MousePosition)
    End Sub
    Private Sub ApriIlDriveInseritoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriIlDriveInseritoToolStripMenuItem.Click
        If EditorTXT.Text = "" Then
            EditorTXT.Text = "OpenDrive"
        Else
            Dim ultimo As String
            ultimo = LSet(StrReverse(EditorTXT.Text), 1)
            If ultimo = ";" Then
                EditorTXT.AppendText("OpenDrive")
            Else
                EditorTXT.AppendText(";OpenDrive")
            End If
            ultimo = Nothing
        End If
    End Sub
    Private Sub ApriUnaCartellaSulPCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriUnaCartellaSulPCToolStripMenuItem.Click
        If EditorTXT.Text = "" Then
            EditorTXT.Text = "Open=[Percorso]"
        Else
            Dim ultimo As String
            ultimo = LSet(StrReverse(EditorTXT.Text), 1)
            If ultimo = ";" Then
                EditorTXT.AppendText("Open=[Percorso]")
            Else
                EditorTXT.AppendText(";Open=[Percorso]")
            End If
            ultimo = Nothing
        End If
        SelezionaPercorso()
    End Sub
    Function SelezionaPercorso() As Object
        EditorTXT.Focus()
        EditorTXT.SelectionStart = (EditorTXT.Text.Length - 10)
        EditorTXT.SelectionLength = 10
        Return Nothing
    End Function
    Private Sub ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriUnFileOUnaCartellaSulDriveInseritoToolStripMenuItem.Click
        If EditorTXT.Text = "" Then
            EditorTXT.Text = "Open=Drive\[Percorso]"
        Else
            Dim ultimo As String
            ultimo = LSet(StrReverse(EditorTXT.Text), 1)
            If ultimo = ";" Then
                EditorTXT.AppendText("Open=Drive\[Percorso]")
            Else
                EditorTXT.AppendText(";Open=Drive\[Percorso]")
            End If
            ultimo = Nothing
        End If
        SelezionaPercorso()
    End Sub
    Function avvisolettera() As Object
        If autorunstatus = 1 Then
            If UseVolName = False Then
                Notifica.ShowBalloonTip(5000, Titolo, "Periferica inserita in " & lettera & ":\ ", ToolTipIcon.Info)
            ElseIf UseVolName = True Then
                Dim nome As String
                nome = Driveinfo.VolumeLabel
                Notifica.ShowBalloonTip(5000, Titolo, nome & " inserita in " & lettera & ":\ ", ToolTipIcon.Info)
                GC.Collect()
            End If
        Else
            If UseVolName = False Then
                Notifica.ShowBalloonTip(5000, Titolo, "Periferica inserita in " & lettera & ":\ " & vbNewLine & "Autorun bloccato dall'utente", ToolTipIcon.Info)
            ElseIf UseVolName = True Then
                Dim nome As String
                nome = Driveinfo.VolumeLabel
                Notifica.ShowBalloonTip(5000, Titolo, nome & " inserita in " & lettera & ":\ " & vbNewLine & "Autorun bloccato dall'utente", ToolTipIcon.Info)
            End If
            GC.Collect()
            End If
        autorunstatus = 1
            Return Nothing
    End Function
    Function AvvisoSpazio() As Object
        Dim spazio As Double
        Dim spazios As String
        Dim totale As Double
        Dim totales As String
        Dim perc As Single
        Try
            spazio = Driveinfo.AvailableFreeSpace
            totale = Driveinfo.TotalSize
            If spazio >= 1024 ^ 3 Then
                spazios = Round(spazio / (1024 ^ 3), 2) & " GB"
            ElseIf spazio >= 1024 ^ 2 Then
                spazios = Round(spazio / (1024 ^ 2), 2) & " MB"
            ElseIf spazio >= 1024 Then
                spazios = Round(spazio / 1024, 2) & " KB"
            Else
                spazios = spazio & "bytes"
            End If
            If totale >= 1024 ^ 3 Then
                totales = Round(totale / (1024 ^ 3), 2) & " GB"
            ElseIf totale >= 1024 ^ 2 Then
                totales = Round(totale / (1024 ^ 2), 2) & " MB"
            ElseIf totale >= 1024 Then
                totales = Round(totale / 1024, 2) & " KB"
            Else
                totales = totale & "bytes"
            End If
            perc = Round((spazio / totale) * 100, 2)
            If autorunstatus = 1 Then
                If UseVolName = False Then
                    Notifica.ShowBalloonTip(5000, Titolo, "Periferica inserita in " & lettera & ":\ " & vbNewLine & spazios & " / " & totales & " disponibili (" & perc & "%)", ToolTipIcon.Info)
                ElseIf UseVolName = True Then
                    Dim Nome As String
                    Nome = Driveinfo.VolumeLabel
                    Notifica.ShowBalloonTip(5000, Titolo, Nome & " inserita in " & lettera & ":\ " & vbNewLine & spazios & " / " & totales & " disponibili (" & perc & "%)", ToolTipIcon.Info)
                End If
            ElseIf autorunstatus = 0 Then
                If UseVolName = False Then
                    Notifica.ShowBalloonTip(5000, Titolo, "Periferica inserita in " & lettera & ":\ " & vbNewLine & spazios & " / " & totales & " disponibili (" & perc & "%)" & vbNewLine & "Autorun bloccato dall'utente", ToolTipIcon.Info)
                ElseIf UseVolName = True Then
                    Dim Nome As String
                    Nome = Driveinfo.VolumeLabel
                    Notifica.ShowBalloonTip(5000, Titolo, Nome & " inserita in " & lettera & ":\ " & vbNewLine & spazios & " / " & totales & " disponibili (" & perc & "%)" & vbNewLine & "Autorun bloccato dall'utente", ToolTipIcon.Info)
                End If
            End If
        Catch ex As Exception
            If NotifyOnError = True Then
                If UseBalloonOnError = True Then
                    Notifica.ShowBalloonTip(5000, Titolo & ": errore", ex.Message, ToolTipIcon.Warning)
                Else
                    MsgBox("Errore: " & ex.Message, MsgBoxStyle.Exclamation, Titolo)
                End If
            End If
                If WriteLog = True Then
                    MessaggioErrore = ex.Message
                    AddLog()
                End If
        End Try
        Driveinfo = Nothing
        spazio = Nothing
        spazios = Nothing
        totale = Nothing
        totales = Nothing
        perc = Nothing
        autorunstatus = 1
        GC.Collect()
        Return Nothing
    End Function
    Function Noautorun() As Object
        Select Case NoARunAction
            Case 0
                Notifica.ShowBalloonTip(5000, Titolo, "Nessun autorun sicuro rilevato, nessuna azione intrapresa", ToolTipIcon.Warning)
            Case 1
                Notifica.ShowBalloonTip(5000, Titolo, "Nessun autorun sicuro rilevato, avvio del controllo autorun di sistema", ToolTipIcon.Warning)
                UseSystemAutorun()
            Case 2
                Notifica.ShowBalloonTip(5000, Titolo, "Nessun autorun sicuro rilevato, aperta la root del drive inserito", ToolTipIcon.Warning)
                Process.Start(lettera & ":")
            Case 3
                AskDialog.ShowDialog()
                If AskDialog.DialogResult = Windows.Forms.DialogResult.OK Then
                    UseSystemAutorun()
                ElseIf AskDialog.DialogResult = Windows.Forms.DialogResult.Cancel Then
                    'niente
                ElseIf AskDialog.DialogResult = Windows.Forms.DialogResult.Ignore Then
                    Process.Start(lettera & ":")
                End If
        End Select
        Return Nothing
    End Function
    Function Autorun() As Object
        Dim testo As String = My.Computer.FileSystem.ReadAllText(lettera & ":\autorun.uam")
        Dim decrypt As String = DecryptData(testo)
        Dim decryptpasses() As String = Split(decrypt, ";")
        Dim i As Integer = 0
        For i = 0 To decryptpasses.Count
            Try
                If decryptpasses(i).Contains("Open=Drive\") Then
                    'ApriCartellaDrive
                    Dim splitted() As String = Split(decryptpasses(i), "=")
                    Dim resplitted() As String = Split(splitted(1), "\")
                    resplitted(0) = lettera & ":"
                    Dim avvio As String = ""
                    Dim count As Integer = resplitted.Count()
                    For j = 0 To count - 1
                        Select Case j
                            Case 0
                                avvio = resplitted(0)
                            Case Else
                                avvio = avvio & "\" & resplitted(j)
                        End Select
                    Next j
                    Process.Start(avvio)
                    avvio = Nothing
                    splitted = Nothing
                    resplitted = Nothing
                    count = Nothing
                    GC.Collect()
                ElseIf decryptpasses(i).Contains("OpenDrive") Then
                    'ApriDrive
                    Process.Start(lettera & ":\")
                ElseIf decryptpasses(i).Contains("Open=") Then
                    Dim splitted() As String = Split(decryptpasses(i), "=")
                    Process.Start(splitted(1))
                    splitted = Nothing
                End If
            Catch ex As IndexOutOfRangeException
                Exit For
            Catch ex As Exception
                If NotifyOnError = True Then
                    If UseBalloonOnError = True Then
                        Notifica.ShowBalloonTip(5000, Titolo & ": errore", ex.Message, ToolTipIcon.Warning)
                    Else
                        MsgBox("Errore: " & ex.Message, MsgBoxStyle.Exclamation, Titolo)
                    End If
                End If
                    If WriteLog = True Then
                        MessaggioErrore = ex.Message
                        AddLog()
                    End If
            End Try
        Next i
        Return Nothing
    End Function
    Private Sub DoNothing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoNothing.CheckedChanged
        If DoNothing.Checked = True Then
            My.Settings.NoAutorunAction = 0
            NoARunAction = 0
            GroupBox5.Enabled = False
        End If
        My.Settings.Save()
    End Sub
    Private Sub SystemAutorun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemAutorun.CheckedChanged
        If SystemAutorun.Checked = True Then
            My.Settings.NoAutorunAction = 1
            NoARunAction = 1
            GroupBox5.Enabled = True
        End If
        My.Settings.Save()
    End Sub
    Private Sub OpenDrive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDrive.CheckedChanged
        If OpenDrive.Checked = True Then
            My.Settings.NoAutorunAction = 2
            NoARunAction = 2
            GroupBox5.Enabled = False
        End If
        My.Settings.Save()
    End Sub
    Function UseSystemAutorun() As Object
        Dim autorunexists As Boolean = My.Computer.FileSystem.FileExists(lettera & ":\autorun.inf")
        Dim rows() As String
        If autorunexists = True Then
            Dim autorun As String = My.Computer.FileSystem.ReadAllText(lettera & ":\autorun.inf")
            rows = Split(autorun, vbNewLine)
            Dim i As Integer
            For i = 1 To 10
                Try
                    If rows(i).Contains("open=") Then
                        Dim avvio() As String
                        Dim avvio2 As String
                        Dim risposta As Integer
                        avvio = Split(CStr(rows(i)), "=")
                        avvio2 = lettera & ":\" & avvio(1)
                        risposta = MsgBox("L'autorun di sistema sta tentando di avviare il file " & avvio(1) & ", avviarlo?", MsgBoxStyle.YesNo, Titolo)
                        If risposta = 6 Then
                            Process.Start(avvio2)
                        ElseIf risposta = 7 Then
                            Exit Try
                        End If
                    End If
                Catch ex As IndexOutOfRangeException
                    Exit For
                End Try
            Next i
        Else
            Select Case NosystemAutorun
                Case 0
                    Notifica.ShowBalloonTip(5000, Titolo, "Nessun autorun di sistema rilevato, nessuna azione intrapresa", ToolTipIcon.Warning)
                Case 1
                    Process.Start(lettera & ":")
                Case 2
                    AskDialog2.ShowDialog()
                    If AskDialog2.DialogResult = Windows.Forms.DialogResult.OK Then
                        Process.Start(lettera & ":")
                    ElseIf AskDialog2.DialogResult = Windows.Forms.DialogResult.Cancel Then
                        'niente
                    End If
            End Select
        End If
        Return Nothing
    End Function
    Private Sub ProcessFixed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessFixed.CheckedChanged
        If ProcessFixed.Checked = True Then
            My.Settings.ProcessFixed = 1
            ProcessFixedOpt = 1
        Else
            My.Settings.ProcessFixed = 0
            ProcessFixedOpt = 0
        End If
        My.Settings.Save()
    End Sub
    Private Sub Crypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crypt.Click
        CryptTXT.Text = EncryptData(EditorTXT.Text)
        Dim fold As New SaveFileDialog
        fold.AddExtension = True
        fold.Filter() = "File di autorun (*.uam)|*.uam"
        fold.FileName = "Autorun"
        If fold.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(fold.FileName, CryptTXT.Text, False)
        Else
            'niente
        End If
        fold = Nothing
        CryptTXT.Text = ""
        EditorTXT.Text = ""
    End Sub
    Private Sub Decode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Decode.Click
        Dim fold As New OpenFileDialog
        fold.Filter = "File di autorun (*.uyam)|*.uam"
        fold.FileName = "Autorun"
        If fold.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CryptTXT.Text = My.Computer.FileSystem.ReadAllText(fold.FileName)
            EditorTXT.Text = DecryptData(CryptTXT.Text)
        End If
    End Sub
    Private Sub VisualizzaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizzaToolStripMenuItem.Click
        VisEditor()
    End Sub
    Private Sub ToTray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToTray.CheckedChanged
        If ToTray.Checked = True Then
            ToTrayOPT = 1
            My.Settings.ToTray = 1
        Else
            ToTrayOPT = 0
            My.Settings.ToTray = 0
        End If
        My.Settings.Save()
    End Sub
    Private Sub Conv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Conv.Click
        Convert()
    End Sub
    Function Convert() As Object
        Dim fold As New OpenFileDialog
        fold.Filter = "File inf (*.inf)|*.inf"
        fold.FileName = "Autorun"
        Dim autorun As String
        If fold.ShowDialog() = Windows.Forms.DialogResult.OK Then
            autorun = My.Computer.FileSystem.ReadAllText(fold.FileName)
        Else
            Return Nothing
            Exit Function
        End If
        Dim rows() As String
        rows = Split(autorun, vbNewLine)
        Dim i As Integer
        For i = 1 To 10
            Try
                If rows(i).Contains("open=") Then
                    Dim avvio() As String
                    Dim avvio2 As String
                    avvio = Split(CStr(rows(i)), "=")
                    avvio2 = "Open=Drive\" & avvio(1)
                    Dim ultimo As String
                    ultimo = LSet(StrReverse(EditorTXT.Text), 1)
                    If EditorTXT.Text = "" Then
                        EditorTXT.Text = avvio2
                    ElseIf ultimo = ";" Then
                        EditorTXT.AppendText(avvio2)
                    Else
                        EditorTXT.AppendText(";" & avvio2)
                    End If
                End If
            Catch ex As IndexOutOfRangeException
                Exit For
            End Try
        Next i
        Return Nothing
    End Function
    Private Sub VisualizzaOpzioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizzaOpzioniToolStripMenuItem.Click
        VisOpzioni()
    End Sub
    Private Sub ConversioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConversioneToolStripMenuItem.Click
        Convert()
    End Sub
    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        End
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub NoAction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoAction.CheckedChanged
        If NoAction.Checked = True Then
            My.Settings.NotifyAction = 0
            NotifyAction = 0
        End If
        My.Settings.Save()
    End Sub
    Private Sub EnableDisable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableDisable.CheckedChanged
        If EnableDisable.Checked = True Then
            My.Settings.NotifyAction = 1
            NotifyAction = 1
        End If
        My.Settings.Save()
    End Sub
    Private Sub Options_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options.CheckedChanged
        If Options.Checked = True Then
            My.Settings.NotifyAction = 2
            NotifyAction = 2
        End If
        My.Settings.Save()
    End Sub
    Private Sub Editor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editor.CheckedChanged
        If Editor.Checked = True Then
            My.Settings.NotifyAction = 3
            NotifyAction = 3
        End If
        My.Settings.Save()
    End Sub
    Private Sub ConvertRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertRadio.CheckedChanged
        If ConvertRadio.Checked = True Then
            My.Settings.NotifyAction = 4
            NotifyAction = 4
        End If
        My.Settings.Save()
    End Sub
    Private Sub Notifica_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Notifica.MouseDoubleClick
        Select Case NotifyAction
            Case 0
                'niente
            Case 1
                AttivaDisattiva()
            Case 2
                VisOpzioni()
            Case 3
                VisEditor()
            Case 4
                Convert()
        End Select
    End Sub
    Function VisOpzioni() As Object
        MyBase.Show()
        Me.WindowState = FormWindowState.Normal
        TabControl1.SelectTab(1)
        Return Nothing
    End Function
    Function VisEditor() As Object
        MyBase.Show()
        Me.WindowState = FormWindowState.Normal
        TabControl1.SelectTab(0)
        Return Nothing
    End Function
    Private Sub AskForAction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AskForAction.CheckedChanged
        If AskForAction.Checked = True Then
            My.Settings.NoAutorunAction = 3
            NoARunAction = 3
            GroupBox5.Enabled = True
        End If
        My.Settings.Save()
    End Sub
    Private Sub DoNothing2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoNothing2.CheckedChanged
        If DoNothing2.Checked = True Then
            My.Settings.NoSystemAutorun = 0
            NosystemAutorun = 0
        End If
        My.Settings.Save()
    End Sub
    Private Sub OpenDriveRoot2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDriveRoot2.CheckedChanged
        If OpenDriveRoot2.Checked = True Then
            My.Settings.NoSystemAutorun = 1
            NosystemAutorun = 1
        End If
        My.Settings.Save()
    End Sub
    Private Sub Ask2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ask2.CheckedChanged
        If Ask2.Checked = True Then
            My.Settings.NoSystemAutorun = 2
            NosystemAutorun = 2
        End If
        My.Settings.Save()
    End Sub
    Private Sub DisattivaAutorunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisattivaAutorunToolStripMenuItem.Click
        AttivaDisattiva()
    End Sub
    Function AttivaDisattiva() As Object
        Select Case AutorunEnabled
            Case True
                AutorunEnabled = False
                Notifica.Icon = My.Resources._16x16disabled
                DisattivaAutorunToolStripMenuItem.Checked = True
            Case False
                AutorunEnabled = True
                Notifica.Icon = My.Resources._16x16Enabled
                DisattivaAutorunToolStripMenuItem.Checked = False
        End Select
        Return Nothing
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AboutBox.Show()
    End Sub
    Private Sub ShiftDeactivator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftDeactivator.CheckedChanged
        If ShiftDeactivator.Checked = True Then
            StopARunOnShift = True
            My.Settings.StopARunOnShift = True
        Else
            StopARunOnShift = False
            My.Settings.StopARunOnShift = False
        End If
        My.Settings.Save()
    End Sub
    Private Sub Log_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log.CheckedChanged
        If Log.Checked = True Then
            WriteLog = True
            My.Settings.WriteLog = True
            ListBox1.Show()
            noLog.Hide()
        Else
            WriteLog = False
            My.Settings.WriteLog = False
            ListBox1.Hide()
            noLog.Show()
        End If
        My.Settings.Save()
    End Sub
    Function AddLog() As Object
        Dim data As Date = Today
        Dim datafull As String
        Dim errore As String
        datafull = data & " - " & DateAndTime.TimeOfDay & " - "
        errore = datafull & MessaggioErrore '& vbNewLine
        My.Computer.FileSystem.WriteAllText("Error.log", errore, True)
        data = Nothing
        datafull = Nothing
        errore = Nothing
        ex = Nothing
        MessaggioErrore = Nothing
        GC.Collect()
        Return Nothing
    End Function
    Private Sub ShowNotify_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowNotify.CheckedChanged
        If ShowNotify.Checked = True Then
            NotifyOnError = True
            My.Settings.NotifyOnError = True
        Else
            NotifyOnError = False
            My.Settings.NotifyOnError = False
        End If
        My.Settings.Save()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DropBox.Show()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        DropBoxSkin = ComboBox1.Text
        My.Settings.DropBoxSkin = ComboBox1.Text
        My.Settings.Save()
    End Sub
    Private Sub Color_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color_Select.Click
        Dim col As New ColorDialog
        col.AllowFullOpen = True
        col.FullOpen = True
        col.ShowDialog()
        TxtColor.Text = col.Color.ToString
        DropBox.Textcolor = col.Color
        My.Settings.TextColor = col.Color
        My.Settings.Save()
    End Sub
    Private Sub UseBalloon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseBalloon.CheckedChanged
        If UseBalloon.Checked = True Then
            UseBalloonOnError = True
            My.Settings.UseBalloonOnError = True
        Else
            UseBalloonOnError = False
            My.Settings.UseBalloonOnError = False
        End If
        My.Settings.Save()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.UseVolumeName = True
            UseVolName = True
        Else
            My.Settings.UseVolumeName = False
            UseVolName = False
        End If
        My.Settings.Save()
    End Sub
    Private Sub UPD_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPD_Log.Click
        AggiornaLog()
    End Sub
    Private Sub Del_log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del_log.Click
        CancellaLog()
        AggiornaLog()
    End Sub
    Function AggiornaLog() As Object
        ListBox1.Items.Clear()
        Dim Lista() As String
        Dim testo As String
        testo = My.Computer.FileSystem.ReadAllText("Error.log")
        If testo = "" Then
            ListBox1.Items.Add("Log Vuoto...")
        End If
        Lista = Split(testo, vbNewLine)
        ListBox1.Items.AddRange(Lista)
        Lista = Nothing
        testo = Nothing
        Return Nothing
    End Function
    Function CancellaLog() As Object
        If MsgBox("Vuoi veramente cancellare tutti gli elementi del Log?", MsgBoxStyle.YesNo, Titolo) = MsgBoxResult.Yes Then
            My.Computer.FileSystem.WriteAllText("Error.log", "", False)
            ListBox1.Items.Clear()
        Else
            'Ignora
        End If
        Return Nothing
    End Function
    Private Sub VisualizzaLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizzaLogToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        TabControl1.SelectTab(2)
        AggiornaLog()
    End Sub
    Private Sub AttivaLog(ByVal sender As Object, ByVal e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 2 Then
            AggiornaLog()
        End If
    End Sub
    Private Sub InformazioniSuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformazioniSuToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
End Class
