<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrelatorioalunos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrelatorioalunos))
        Me.crvalunos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cralunos1 = New CISETPR_LogGest.cralunos()
        Me.SuspendLayout()
        '
        'crvalunos
        '
        Me.crvalunos.ActiveViewIndex = 0
        Me.crvalunos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.crvalunos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvalunos.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvalunos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvalunos.Location = New System.Drawing.Point(0, 0)
        Me.crvalunos.Name = "crvalunos"
        Me.crvalunos.ReportSource = Me.cralunos1
        Me.crvalunos.ShowCloseButton = False
        Me.crvalunos.ShowGroupTreeButton = False
        Me.crvalunos.ShowParameterPanelButton = False
        Me.crvalunos.ShowTextSearchButton = False
        Me.crvalunos.ShowZoomButton = False
        Me.crvalunos.Size = New System.Drawing.Size(1008, 701)
        Me.crvalunos.TabIndex = 0
        Me.crvalunos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmrelatorioalunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1008, 701)
        Me.Controls.Add(Me.crvalunos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmrelatorioalunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmrelatorioalunos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvalunos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cralunos1 As CISETPR_LogGest.cralunos
End Class
