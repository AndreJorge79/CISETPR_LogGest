<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistarvisitante
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregistarvisitante))
        Me.listvisitantes = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtobservacoes = New System.Windows.Forms.TextBox()
        Me.dtdata = New System.Windows.Forms.DateTimePicker()
        Me.cmbtipopessoa = New System.Windows.Forms.ComboBox()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.lblid = New System.Windows.Forms.Label()
        Me.btnfechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listvisitantes
        '
        Me.listvisitantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listvisitantes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.listvisitantes.FullRowSelect = True
        Me.listvisitantes.GridLines = True
        Me.listvisitantes.Location = New System.Drawing.Point(455, 13)
        Me.listvisitantes.Name = "listvisitantes"
        Me.listvisitantes.Size = New System.Drawing.Size(541, 409)
        Me.listvisitantes.TabIndex = 0
        Me.listvisitantes.UseCompatibleStateImageBehavior = False
        Me.listvisitantes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 28
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo de Utente"
        Me.ColumnHeader2.Width = 91
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Observações"
        Me.ColumnHeader4.Width = 138
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hora Entrada"
        Me.ColumnHeader5.Width = 77
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Hora Saída"
        Me.ColumnHeader6.Width = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Utente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Observações (Mámixo de 25 carateres)"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(149, 41)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(272, 20)
        Me.txtnome.TabIndex = 5
        '
        'txtobservacoes
        '
        Me.txtobservacoes.Location = New System.Drawing.Point(25, 183)
        Me.txtobservacoes.MaxLength = 25
        Me.txtobservacoes.Multiline = True
        Me.txtobservacoes.Name = "txtobservacoes"
        Me.txtobservacoes.Size = New System.Drawing.Size(395, 62)
        Me.txtobservacoes.TabIndex = 7
        '
        'dtdata
        '
        Me.dtdata.Enabled = False
        Me.dtdata.Location = New System.Drawing.Point(149, 126)
        Me.dtdata.Name = "dtdata"
        Me.dtdata.Size = New System.Drawing.Size(272, 20)
        Me.dtdata.TabIndex = 8
        '
        'cmbtipopessoa
        '
        Me.cmbtipopessoa.DisplayMember = "Enc. Educação"
        Me.cmbtipopessoa.FormattingEnabled = True
        Me.cmbtipopessoa.Items.AddRange(New Object() {"Enc. Educação", "Fornecedor", "Familiar de Aluno", "Outro"})
        Me.cmbtipopessoa.Location = New System.Drawing.Point(149, 83)
        Me.cmbtipopessoa.Name = "cmbtipopessoa"
        Me.cmbtipopessoa.Size = New System.Drawing.Size(273, 21)
        Me.cmbtipopessoa.TabIndex = 9
        '
        'btnadicionar
        '
        Me.btnadicionar.Enabled = False
        Me.btnadicionar.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadicionar.Location = New System.Drawing.Point(47, 264)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(167, 64)
        Me.btnadicionar.TabIndex = 0
        Me.btnadicionar.Text = "Entrar"
        Me.btnadicionar.UseVisualStyleBackColor = True
        '
        'btnsair
        '
        Me.btnsair.Enabled = False
        Me.btnsair.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsair.Location = New System.Drawing.Point(229, 264)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(167, 64)
        Me.btnsair.TabIndex = 0
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(12, 409)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(38, 13)
        Me.lblhora.TabIndex = 13
        Me.lblhora.Text = "HORA"
        Me.lblhora.Visible = False
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        Me.TimerHora.Interval = 1000
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(56, 409)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(13, 13)
        Me.lblid.TabIndex = 14
        Me.lblid.Text = "0"
        Me.lblid.Visible = False
        '
        'btnfechar
        '
        Me.btnfechar.Image = Global.CISETPR_LogGest.My.Resources.Resources.sair
        Me.btnfechar.Location = New System.Drawing.Point(394, 367)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(55, 55)
        Me.btnfechar.TabIndex = 15
        Me.btnfechar.UseVisualStyleBackColor = True
        '
        'frmregistarvisitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1008, 432)
        Me.Controls.Add(Me.btnfechar)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.btnadicionar)
        Me.Controls.Add(Me.cmbtipopessoa)
        Me.Controls.Add(Me.dtdata)
        Me.Controls.Add(Me.txtobservacoes)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listvisitantes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmregistarvisitante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registo de Visitantes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listvisitantes As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtobservacoes As System.Windows.Forms.TextBox
    Friend WithEvents dtdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbtipopessoa As System.Windows.Forms.ComboBox
    Friend WithEvents btnadicionar As System.Windows.Forms.Button
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents TimerHora As System.Windows.Forms.Timer
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents btnfechar As System.Windows.Forms.Button
End Class
