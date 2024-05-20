<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrelatoriovisitante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrelatoriovisitante))
        Me.crvisitantes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crvisitantes1 = New CISETPR_LogGest.crvisitantes()
        Me.SuspendLayout()
        '
        'crvisitantes
        '
        Me.crvisitantes.ActiveViewIndex = 0
        Me.crvisitantes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.crvisitantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvisitantes.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvisitantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvisitantes.Location = New System.Drawing.Point(0, 0)
        Me.crvisitantes.Name = "crvisitantes"
        Me.crvisitantes.ReportSource = Me.crvisitantes1
        Me.crvisitantes.ShowCloseButton = False
        Me.crvisitantes.ShowGroupTreeButton = False
        Me.crvisitantes.ShowParameterPanelButton = False
        Me.crvisitantes.ShowTextSearchButton = False
        Me.crvisitantes.ShowZoomButton = False
        Me.crvisitantes.Size = New System.Drawing.Size(1008, 701)
        Me.crvisitantes.TabIndex = 0
        Me.crvisitantes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmrelatoriovisitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1008, 701)
        Me.Controls.Add(Me.crvisitantes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmrelatoriovisitante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Visitantes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvisitantes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvisitantes1 As CISETPR_LogGest.crvisitantes
End Class
