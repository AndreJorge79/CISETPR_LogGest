<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprincipaladmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprincipaladmin))
        Me.listalunos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbescola = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbautorização = New System.Windows.Forms.CheckBox()
        Me.txtturma = New System.Windows.Forms.TextBox()
        Me.txtnturma = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtnprocesso = New System.Windows.Forms.TextBox()
        Me.cmbturma = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnadicionar = New System.Windows.Forms.Button()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listalunos
        '
        Me.listalunos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.listalunos.FullRowSelect = True
        Me.listalunos.GridLines = True
        Me.listalunos.Location = New System.Drawing.Point(12, 12)
        Me.listalunos.Name = "listalunos"
        Me.listalunos.Size = New System.Drawing.Size(533, 419)
        Me.listalunos.TabIndex = 0
        Me.listalunos.UseCompatibleStateImageBehavior = False
        Me.listalunos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "N.º de Processo"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome"
        Me.ColumnHeader2.Width = 168
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "N.º na Turma"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Turma"
        Me.ColumnHeader4.Width = 53
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Escola"
        Me.ColumnHeader5.Width = 50
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Autorização"
        Me.ColumnHeader6.Width = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbescola)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbautorização)
        Me.GroupBox1.Controls.Add(Me.txtturma)
        Me.GroupBox1.Controls.Add(Me.txtnturma)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.txtnprocesso)
        Me.GroupBox1.Location = New System.Drawing.Point(571, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 177)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmbescola
        '
        Me.cmbescola.FormattingEnabled = True
        Me.cmbescola.Location = New System.Drawing.Point(101, 125)
        Me.cmbescola.Name = "cmbescola"
        Me.cmbescola.Size = New System.Drawing.Size(121, 21)
        Me.cmbescola.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Autorização"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Escola"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Turma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "N.º na Turma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "N.º de Processo"
        '
        'cbautorização
        '
        Me.cbautorização.AutoSize = True
        Me.cbautorização.Location = New System.Drawing.Point(101, 151)
        Me.cbautorização.Name = "cbautorização"
        Me.cbautorização.Size = New System.Drawing.Size(143, 17)
        Me.cbautorização.TabIndex = 5
        Me.cbautorização.Text = "(Vazio é Não Autorizado)"
        Me.cbautorização.UseVisualStyleBackColor = True
        '
        'txtturma
        '
        Me.txtturma.Location = New System.Drawing.Point(101, 99)
        Me.txtturma.Name = "txtturma"
        Me.txtturma.Size = New System.Drawing.Size(257, 20)
        Me.txtturma.TabIndex = 3
        '
        'txtnturma
        '
        Me.txtnturma.Location = New System.Drawing.Point(101, 73)
        Me.txtnturma.Name = "txtnturma"
        Me.txtnturma.Size = New System.Drawing.Size(257, 20)
        Me.txtnturma.TabIndex = 2
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(101, 47)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(257, 20)
        Me.txtnome.TabIndex = 1
        '
        'txtnprocesso
        '
        Me.txtnprocesso.Location = New System.Drawing.Point(101, 21)
        Me.txtnprocesso.Name = "txtnprocesso"
        Me.txtnprocesso.Size = New System.Drawing.Size(257, 20)
        Me.txtnprocesso.TabIndex = 0
        '
        'cmbturma
        '
        Me.cmbturma.FormattingEnabled = True
        Me.cmbturma.Items.AddRange(New Object() {"Todas", "5.ºA", "5.ºB", "5.ºC", "5.ºD", "6.ºA", "6.ºB", "6.ºC", "6.ºD", "7.ºA", "7.ºB", "7.ºC", "7.ºD", "8.ºA", "8.ºB", "8.ºC", "8.ºD", "9.ºA", "9.ºB", "9.ºC", "1.ºTAI", "2.ºTAI", "3.ºTAI", "1.ºTAL", "2.ºTAL", "3.ºTAL", "1.ºTC", "2.ºTC", "3.ºTC", "1.ºTE", "2.ºTE", "3.ºTE", "1.ºTGEI", "2.ºTGEI", "3.ºTGEI"})
        Me.cmbturma.Location = New System.Drawing.Point(611, 19)
        Me.cmbturma.Name = "cmbturma"
        Me.cmbturma.Size = New System.Drawing.Size(121, 21)
        Me.cmbturma.TabIndex = 2
        Me.cmbturma.Text = "Todas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(568, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Turma"
        '
        'btnadicionar
        '
        Me.btnadicionar.Location = New System.Drawing.Point(571, 255)
        Me.btnadicionar.Name = "btnadicionar"
        Me.btnadicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnadicionar.TabIndex = 4
        Me.btnadicionar.Text = "Adicionar"
        Me.btnadicionar.UseVisualStyleBackColor = True
        Me.btnadicionar.Visible = False
        '
        'btnremover
        '
        Me.btnremover.Enabled = False
        Me.btnremover.Location = New System.Drawing.Point(720, 255)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(95, 56)
        Me.btnremover.TabIndex = 5
        Me.btnremover.Text = "Remover"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Enabled = False
        Me.btneditar.Location = New System.Drawing.Point(873, 255)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(95, 56)
        Me.btneditar.TabIndex = 6
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnovo
        '
        Me.btnnovo.Location = New System.Drawing.Point(571, 255)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(95, 56)
        Me.btnnovo.TabIndex = 7
        Me.btnnovo.Text = "Novo Aluno"
        Me.btnnovo.UseVisualStyleBackColor = True
        Me.btnnovo.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(688, 393)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(219, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Mudar palavra-chave do Modo Administrador"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(609, 418)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(298, 13)
        Me.LinkLabel2.TabIndex = 9
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Mudar palavra-chave para a saída de alunos não autorizados"
        '
        'btnsair
        '
        Me.btnsair.Image = Global.CISETPR_LogGest.My.Resources.Resources.sair
        Me.btnsair.Location = New System.Drawing.Point(913, 376)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(55, 55)
        Me.btnsair.TabIndex = 10
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'frmprincipaladmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 443)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnnovo)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.btnadicionar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbturma)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.listalunos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmprincipaladmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CIS/ETPR LogGest - Modo Administrador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listalunos As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbescola As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbautorização As System.Windows.Forms.CheckBox
    Friend WithEvents txtturma As System.Windows.Forms.TextBox
    Friend WithEvents txtnturma As System.Windows.Forms.TextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtnprocesso As System.Windows.Forms.TextBox
    Friend WithEvents cmbturma As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnadicionar As System.Windows.Forms.Button
    Friend WithEvents btnremover As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnnovo As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnsair As System.Windows.Forms.Button
End Class
