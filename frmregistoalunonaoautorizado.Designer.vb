<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistoalunonaoautorizado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtmotivo = New System.Windows.Forms.TextBox()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.btnautorizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbldata = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblturma = New System.Windows.Forms.Label()
        Me.lblnprocesso = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Palavra-Chave:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Motivo de Saída:"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(119, 9)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 2
        '
        'txtmotivo
        '
        Me.txtmotivo.Location = New System.Drawing.Point(15, 56)
        Me.txtmotivo.Multiline = True
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(204, 52)
        Me.txtmotivo.TabIndex = 3
        '
        'btnsair
        '
        Me.btnsair.Image = Global.CISETPR_LogGest.My.Resources.Resources.sair
        Me.btnsair.Location = New System.Drawing.Point(226, 98)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(56, 60)
        Me.btnsair.TabIndex = 4
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'btnautorizar
        '
        Me.btnautorizar.BackColor = System.Drawing.Color.Green
        Me.btnautorizar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnautorizar.ForeColor = System.Drawing.Color.White
        Me.btnautorizar.Location = New System.Drawing.Point(108, 115)
        Me.btnautorizar.Name = "btnautorizar"
        Me.btnautorizar.Size = New System.Drawing.Size(111, 43)
        Me.btnautorizar.TabIndex = 5
        Me.btnautorizar.Text = "Autorizar Saída"
        Me.btnautorizar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'lbldata
        '
        Me.lbldata.AutoSize = True
        Me.lbldata.Location = New System.Drawing.Point(226, 61)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(39, 13)
        Me.lbldata.TabIndex = 16
        Me.lbldata.Text = "Label8"
        Me.lbldata.Visible = False
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(226, 48)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(39, 13)
        Me.lblhora.TabIndex = 12
        Me.lblhora.Text = "Label7"
        Me.lblhora.Visible = False
        '
        'lblturma
        '
        Me.lblturma.AutoSize = True
        Me.lblturma.Location = New System.Drawing.Point(226, 35)
        Me.lblturma.Name = "lblturma"
        Me.lblturma.Size = New System.Drawing.Size(39, 13)
        Me.lblturma.TabIndex = 11
        Me.lblturma.Text = "Label6"
        Me.lblturma.Visible = False
        '
        'lblnprocesso
        '
        Me.lblnprocesso.AutoSize = True
        Me.lblnprocesso.Location = New System.Drawing.Point(226, 9)
        Me.lblnprocesso.Name = "lblnprocesso"
        Me.lblnprocesso.Size = New System.Drawing.Size(39, 13)
        Me.lblnprocesso.TabIndex = 7
        Me.lblnprocesso.Text = "Label4"
        Me.lblnprocesso.Visible = False
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Location = New System.Drawing.Point(226, 22)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(39, 13)
        Me.lblnome.TabIndex = 9
        Me.lblnome.Text = "Label5"
        Me.lblnome.Visible = False
        '
        'frmregistoalunonaoautorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 170)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblturma)
        Me.Controls.Add(Me.lblnome)
        Me.Controls.Add(Me.lblnprocesso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnautorizar)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.txtmotivo)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmregistoalunonaoautorizado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtmotivo As System.Windows.Forms.TextBox
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents btnautorizar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lblturma As System.Windows.Forms.Label
    Friend WithEvents lblnprocesso As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
End Class
