<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmsgdeautorizacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmsgdeautorizacao))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnautorizo = New System.Windows.Forms.Button()
        Me.btnnaoautorizo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 110)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Atenção este aluno não se encontra autorizado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a sair da escola!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Se pretende con" & _
            "tinuar precione o " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "botão 'Autorizo a Saída', caso contrário" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "precione 'Não Auto" & _
            "rizo a Saída'."
        '
        'btnautorizo
        '
        Me.btnautorizo.BackColor = System.Drawing.Color.Green
        Me.btnautorizo.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnautorizo.ForeColor = System.Drawing.Color.White
        Me.btnautorizo.Location = New System.Drawing.Point(322, 156)
        Me.btnautorizo.Name = "btnautorizo"
        Me.btnautorizo.Size = New System.Drawing.Size(159, 50)
        Me.btnautorizo.TabIndex = 1
        Me.btnautorizo.Text = "Autorizo a Saída"
        Me.btnautorizo.UseVisualStyleBackColor = False
        '
        'btnnaoautorizo
        '
        Me.btnnaoautorizo.BackColor = System.Drawing.Color.Red
        Me.btnnaoautorizo.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnaoautorizo.ForeColor = System.Drawing.Color.White
        Me.btnnaoautorizo.Location = New System.Drawing.Point(148, 156)
        Me.btnnaoautorizo.Name = "btnnaoautorizo"
        Me.btnnaoautorizo.Size = New System.Drawing.Size(159, 50)
        Me.btnnaoautorizo.TabIndex = 2
        Me.btnnaoautorizo.Text = "Não Autorizo a Saída"
        Me.btnnaoautorizo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CISETPR_LogGest.My.Resources.Resources.aviso
        Me.PictureBox1.Location = New System.Drawing.Point(346, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmmsgdeautorizacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 218)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnnaoautorizo)
        Me.Controls.Add(Me.btnautorizo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmsgdeautorizacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atenção"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnautorizo As System.Windows.Forms.Button
    Friend WithEvents btnnaoautorizo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
