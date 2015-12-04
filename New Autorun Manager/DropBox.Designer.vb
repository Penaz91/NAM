<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DropBox
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChiudiLaDropboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CosèstaRobaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("LcdD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X:\"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CosèstaRobaToolStripMenuItem, Me.ChiudiLaDropboxToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 70)
        '
        'ChiudiLaDropboxToolStripMenuItem
        '
        Me.ChiudiLaDropboxToolStripMenuItem.Name = "ChiudiLaDropboxToolStripMenuItem"
        Me.ChiudiLaDropboxToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChiudiLaDropboxToolStripMenuItem.Text = "Chiudi la dropbox"
        '
        'CosèstaRobaToolStripMenuItem
        '
        Me.CosèstaRobaToolStripMenuItem.Name = "CosèstaRobaToolStripMenuItem"
        Me.CosèstaRobaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CosèstaRobaToolStripMenuItem.Text = "Cos'è 'sta roba?"
        '
        'DropBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(64, 64)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DropBox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DropBox"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChiudiLaDropboxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CosèstaRobaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
