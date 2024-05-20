<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdefinicoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdefinicoes))
        Me.btnreporregistosalunos = New System.Windows.Forms.Button()
        Me.btnreporregistosvisitantes = New System.Windows.Forms.Button()
        Me.btnreportodos = New System.Windows.Forms.Button()
        Me.brnrepordeorigem = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnreporregistosalunos
        '
        Me.btnreporregistosalunos.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporregistosalunos.Location = New System.Drawing.Point(12, 51)
        Me.btnreporregistosalunos.Name = "btnreporregistosalunos"
        Me.btnreporregistosalunos.Size = New System.Drawing.Size(494, 42)
        Me.btnreporregistosalunos.TabIndex = 0
        Me.btnreporregistosalunos.Text = "Apagar todos os registos de entradas e saídas de alunos"
        Me.btnreporregistosalunos.UseVisualStyleBackColor = True
        '
        'btnreporregistosvisitantes
        '
        Me.btnreporregistosvisitantes.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporregistosvisitantes.Location = New System.Drawing.Point(12, 109)
        Me.btnreporregistosvisitantes.Name = "btnreporregistosvisitantes"
        Me.btnreporregistosvisitantes.Size = New System.Drawing.Size(494, 42)
        Me.btnreporregistosvisitantes.TabIndex = 1
        Me.btnreporregistosvisitantes.Text = "Apagar todos os registos dos visitantes"
        Me.btnreporregistosvisitantes.UseVisualStyleBackColor = True
        '
        'btnreportodos
        '
        Me.btnreportodos.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportodos.Location = New System.Drawing.Point(12, 167)
        Me.btnreportodos.Name = "btnreportodos"
        Me.btnreportodos.Size = New System.Drawing.Size(494, 42)
        Me.btnreportodos.TabIndex = 2
        Me.btnreportodos.Text = "Apagar todos os registos (Alunos e Visitantes)"
        Me.btnreportodos.UseVisualStyleBackColor = True
        '
        'brnrepordeorigem
        '
        Me.brnrepordeorigem.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnrepordeorigem.Location = New System.Drawing.Point(12, 224)
        Me.brnrepordeorigem.Name = "brnrepordeorigem"
        Me.brnrepordeorigem.Size = New System.Drawing.Size(494, 42)
        Me.brnrepordeorigem.TabIndex = 3
        Me.brnrepordeorigem.Text = "Repor todas as definições de origem"
        Me.brnrepordeorigem.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(455, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(192, 22)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Abrir Modo Administrador"
        '
        'btnsair
        '
        Me.btnsair.Image = Global.CISETPR_LogGest.My.Resources.Resources.sair
        Me.btnsair.Location = New System.Drawing.Point(588, 236)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(55, 55)
        Me.btnsair.TabIndex = 5
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'frmdefinicoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(655, 303)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.brnrepordeorigem)
        Me.Controls.Add(Me.btnreportodos)
        Me.Controls.Add(Me.btnreporregistosvisitantes)
        Me.Controls.Add(Me.btnreporregistosalunos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdefinicoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definições"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnreporregistosalunos As System.Windows.Forms.Button
    Friend WithEvents btnreporregistosvisitantes As System.Windows.Forms.Button
    Friend WithEvents btnreportodos As System.Windows.Forms.Button
    Friend WithEvents brnrepordeorigem As System.Windows.Forms.Button
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
