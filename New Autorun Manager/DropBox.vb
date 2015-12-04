Public Class DropBox
    Public Shared lettera As String
    Public Shared Textcolor As Color
    Dim skin As String = My.Settings.DropBoxSkin
    Private Sub DropBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
        If Textcolor <> Nothing Then
            Label1.ForeColor = Textcolor
        Else
            Label1.ForeColor = Color.Black
        End If
        Label1.Text = lettera
        If skin <> "none" Then
            Me.BackgroundImage = Image.FromFile(skin)
        End If
        Me.Size = New Size(64, 64)
        Dim width As Integer = Screen.GetWorkingArea(New Point(0, 0)).Width
        Dim height As Integer = Screen.GetWorkingArea(New Point(0, 0)).Height
        Me.Location = New Point(width - 84, height - 84)
    End Sub
    Private Sub Drag(ByVal sender As System.Object, ByVal e As DragEventArgs) Handles Me.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub Drop(ByVal sender As System.Object, ByVal e As DragEventArgs) Handles Me.DragDrop
        Dim s() As String = e.Data.GetData("FileDrop", False)
        Dim i As Integer
        For i = 0 To s.Length - 1
            Dim x() As String = Split(s(i), "\")
            Dim file As String = x(x.Length - 1)
            Try
                My.Computer.FileSystem.CopyFile(CStr(s(i)), lettera & file, True)
                Dim exist As Boolean = My.Computer.FileSystem.FileExists(lettera & file)
                If exist = False Then
                    MsgBox("Errore durante la copia dei files", MsgBoxStyle.Critical, "New Autorun Manager")
                End If
            Catch ex As Exception
                My.Computer.FileSystem.CopyDirectory(CStr(s(i)), lettera & file, True)
                Dim exist As Boolean = My.Computer.FileSystem.DirectoryExists(lettera & file)
                If exist = False Then
                    MsgBox("Errore durante la copia delle directory", MsgBoxStyle.Critical, "New Autorun Manager")
                End If
            End Try
        Next i
        s = Nothing
        i = Nothing
    End Sub
    Private Sub ChiudiLaDropboxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChiudiLaDropboxToolStripMenuItem.Click
        Me.Finalize()
    End Sub
    Private Sub CosèstaRobaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CosèstaRobaToolStripMenuItem.Click
        MsgBox("Questa è la dropbox, se si tiene premuto ALT durante l'inserimento di un drive usb si abilita e permette" & vbNewLine & "la copiatura sul drive di piccoli documenti e file senza dover necessariamente accedere alla root" & vbNewLine & "del drive stesso. La dropbox si chiude automaticamente alla disconnessione del drive", MsgBoxStyle.Information, "New Autorun Manager")
    End Sub
End Class