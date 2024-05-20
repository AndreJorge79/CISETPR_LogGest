<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconsultas))
        Me.tcconsultas = New System.Windows.Forms.TabControl()
        Me.tpalunos = New System.Windows.Forms.TabPage()
        Me.btnsair1 = New System.Windows.Forms.Button()
        Me.btnrelatorioalunos = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnambosaluno = New System.Windows.Forms.Button()
        Me.dtdataambos = New System.Windows.Forms.DateTimePicker()
        Me.txtnomeambosaluno = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndataaluno = New System.Windows.Forms.Button()
        Me.dtdataalunos = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnnomealuno = New System.Windows.Forms.Button()
        Me.txtnomealunos = New System.Windows.Forms.TextBox()
        Me.listalunos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpvisitantes = New System.Windows.Forms.TabPage()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.btnrelatoriovisitantes = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnpesquisardataetipo = New System.Windows.Forms.Button()
        Me.cmbdataetipo = New System.Windows.Forms.ComboBox()
        Me.dtdataetipo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnpesquisardata = New System.Windows.Forms.Button()
        Me.dtdatavisitantes = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btntipopessoa = New System.Windows.Forms.Button()
        Me.cmbtipopessoa = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtnomevisitante = New System.Windows.Forms.TextBox()
        Me.btnnomevisitante = New System.Windows.Forms.Button()
        Me.listvisitantes = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tcconsultas.SuspendLayout()
        Me.tpalunos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpvisitantes.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcconsultas
        '
        Me.tcconsultas.Controls.Add(Me.tpalunos)
        Me.tcconsultas.Controls.Add(Me.tpvisitantes)
        Me.tcconsultas.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcconsultas.Location = New System.Drawing.Point(13, 13)
        Me.tcconsultas.Name = "tcconsultas"
        Me.tcconsultas.SelectedIndex = 0
        Me.tcconsultas.Size = New System.Drawing.Size(953, 565)
        Me.tcconsultas.TabIndex = 0
        '
        'tpalunos
        '
        Me.tpalunos.Controls.Add(Me.btnsair1)
        Me.tpalunos.Controls.Add(Me.btnrelatorioalunos)
        Me.tpalunos.Controls.Add(Me.GroupBox3)
        Me.tpalunos.Controls.Add(Me.GroupBox2)
        Me.tpalunos.Controls.Add(Me.GroupBox1)
        Me.tpalunos.Controls.Add(Me.listalunos)
        Me.tpalunos.Location = New System.Drawing.Point(4, 27)
        Me.tpalunos.Name = "tpalunos"
        Me.tpalunos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpalunos.Size = New System.Drawing.Size(945, 534)
        Me.tpalunos.TabIndex = 0
        Me.tpalunos.Text = "Consultas Alunos"
        Me.tpalunos.UseVisualStyleBackColor = True
        '
        'btnsair1
        '
        Me.btnsair1.Image = Global.CISETPR_LogGest.My.Resources.Resources.sair
        Me.btnsair1.Location = New System.Drawing.Point(884, 421)
        Me.btnsair1.Name = "btnsair1"
        Me.btnsair1.Size = New System.Drawing.Size(55, 55)
        Me.btnsair1.TabIndex = 7
        Me.btnsair1.UseVisualStyleBackColor = True
        '
        'btnrelatorioalunos
        '
        Me.btnrelatorioalunos.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrelatorioalunos.Location = New System.Drawing.Point(612, 421)
        Me.btnrelatorioalunos.Name = "btnrelatorioalunos"
        Me.btnrelatorioalunos.Size = New System.Drawing.Size(261, 54)
        Me.btnrelatorioalunos.TabIndex = 3
        Me.btnrelatorioalunos.Text = "Gerar Relatório de Alunos"
        Me.btnrelatorioalunos.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.btnambosaluno)
        Me.GroupBox3.Controls.Add(Me.dtdataambos)
        Me.GroupBox3.Controls.Add(Me.txtnomeambosaluno)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(625, 268)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 147)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pesquisar por Ambos:"
        '
        'btnambosaluno
        '
        Me.btnambosaluno.Location = New System.Drawing.Point(188, 104)
        Me.btnambosaluno.Name = "btnambosaluno"
        Me.btnambosaluno.Size = New System.Drawing.Size(104, 37)
        Me.btnambosaluno.TabIndex = 2
        Me.btnambosaluno.Text = "Pesquisar"
        Me.btnambosaluno.UseVisualStyleBackColor = True
        '
        'dtdataambos
        '
        Me.dtdataambos.Location = New System.Drawing.Point(16, 72)
        Me.dtdataambos.Name = "dtdataambos"
        Me.dtdataambos.Size = New System.Drawing.Size(188, 29)
        Me.dtdataambos.TabIndex = 1
        '
        'txtnomeambosaluno
        '
        Me.txtnomeambosaluno.Location = New System.Drawing.Point(16, 26)
        Me.txtnomeambosaluno.Name = "txtnomeambosaluno"
        Me.txtnomeambosaluno.Size = New System.Drawing.Size(188, 29)
        Me.txtnomeambosaluno.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.btndataaluno)
        Me.GroupBox2.Controls.Add(Me.dtdataalunos)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(625, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesquisar por Data:"
        '
        'btndataaluno
        '
        Me.btndataaluno.Location = New System.Drawing.Point(188, 57)
        Me.btndataaluno.Name = "btndataaluno"
        Me.btndataaluno.Size = New System.Drawing.Size(104, 37)
        Me.btndataaluno.TabIndex = 2
        Me.btndataaluno.Text = "Pesquisar"
        Me.btndataaluno.UseVisualStyleBackColor = True
        '
        'dtdataalunos
        '
        Me.dtdataalunos.Location = New System.Drawing.Point(16, 25)
        Me.dtdataalunos.Name = "dtdataalunos"
        Me.dtdataalunos.Size = New System.Drawing.Size(188, 29)
        Me.dtdataalunos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.btnnomealuno)
        Me.GroupBox1.Controls.Add(Me.txtnomealunos)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(625, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar por Nome:"
        '
        'btnnomealuno
        '
        Me.btnnomealuno.Location = New System.Drawing.Point(188, 57)
        Me.btnnomealuno.Name = "btnnomealuno"
        Me.btnnomealuno.Size = New System.Drawing.Size(104, 37)
        Me.btnnomealuno.TabIndex = 1
        Me.btnnomealuno.Text = "Pesquisar"
        Me.btnnomealuno.UseVisualStyleBackColor = True
        '
        'txtnomealunos
        '
        Me.txtnomealunos.Location = New System.Drawing.Point(16, 25)
        Me.txtnomealunos.Name = "txtnomealunos"
        Me.txtnomealunos.Size = New System.Drawing.Size(188, 29)
        Me.txtnomealunos.TabIndex = 0
        '
        'listalunos
        '
        Me.listalunos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader3})
        Me.listalunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listalunos.FullRowSelect = True
        Me.listalunos.GridLines = True
        Me.listalunos.Location = New System.Drawing.Point(6, 7)
        Me.listalunos.Name = "listalunos"
        Me.listalunos.Size = New System.Drawing.Size(600, 521)
        Me.listalunos.TabIndex = 0
        Me.listalunos.UseCompatibleStateImageBehavior = False
        Me.listalunos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "N.º Processo"
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome Aluno"
        Me.ColumnHeader2.Width = 162
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Turma"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Data"
        Me.ColumnHeader14.Width = 75
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Hora de Saída"
        Me.ColumnHeader15.Width = 94
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Hora de Entrada"
        Me.ColumnHeader16.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Motivo de Saída"
        '
        'tpvisitantes
        '
        Me.tpvisitantes.Controls.Add(Me.btnsair)
        Me.tpvisitantes.Controls.Add(Me.btnrelatoriovisitantes)
        Me.tpvisitantes.Controls.Add(Me.GroupBox7)
        Me.tpvisitantes.Controls.Add(Me.GroupBox6)
        Me.tpvisitantes.Controls.Add(Me.GroupBox5)
        Me.tpvisitantes.Controls.Add(Me.GroupBox4)
        Me.tpvisitantes.Controls.Add(Me.listvisitantes)
        Me.tpvisitantes.Location = New System.Drawing.Point(4, 27)
        Me.tpvisitantes.Name = "tpvisitantes"
        Me.tpvisitantes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpvisitantes.Size = New System.Drawing.Size(945, 534)
        Me.tpvisitantes.TabIndex = 1
        Me.tpvisitantes.Text = "Consultas Visitantes"
        Me.tpvisitantes.UseVisualStyleBackColor = True
        '
        'btnsair
        '
        Me.btnsair.Image = Global.CISETPR_LogGest.My.Resources.Resources.sair
        Me.btnsair.Location = New System.Drawing.Point(884, 477)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(55, 55)
        Me.btnsair.TabIndex = 6
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'btnrelatoriovisitantes
        '
        Me.btnrelatoriovisitantes.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrelatoriovisitantes.Location = New System.Drawing.Point(613, 477)
        Me.btnrelatoriovisitantes.Name = "btnrelatoriovisitantes"
        Me.btnrelatoriovisitantes.Size = New System.Drawing.Size(261, 54)
        Me.btnrelatoriovisitantes.TabIndex = 5
        Me.btnrelatoriovisitantes.Text = "Gerar Relatório de Visitantes"
        Me.btnrelatoriovisitantes.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Silver
        Me.GroupBox7.Controls.Add(Me.btnpesquisardataetipo)
        Me.GroupBox7.Controls.Add(Me.cmbdataetipo)
        Me.GroupBox7.Controls.Add(Me.dtdataetipo)
        Me.GroupBox7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(626, 325)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(298, 146)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Pesquisar por Data e Tipo de Utente"
        '
        'btnpesquisardataetipo
        '
        Me.btnpesquisardataetipo.Location = New System.Drawing.Point(188, 100)
        Me.btnpesquisardataetipo.Name = "btnpesquisardataetipo"
        Me.btnpesquisardataetipo.Size = New System.Drawing.Size(104, 37)
        Me.btnpesquisardataetipo.TabIndex = 8
        Me.btnpesquisardataetipo.Text = "Pesquisar"
        Me.btnpesquisardataetipo.UseVisualStyleBackColor = True
        '
        'cmbdataetipo
        '
        Me.cmbdataetipo.FormattingEnabled = True
        Me.cmbdataetipo.Items.AddRange(New Object() {"Enc. Educação", "Fornecedor", "Familiar de Aluno", "Outro"})
        Me.cmbdataetipo.Location = New System.Drawing.Point(16, 66)
        Me.cmbdataetipo.Name = "cmbdataetipo"
        Me.cmbdataetipo.Size = New System.Drawing.Size(188, 30)
        Me.cmbdataetipo.TabIndex = 2
        '
        'dtdataetipo
        '
        Me.dtdataetipo.Location = New System.Drawing.Point(16, 25)
        Me.dtdataetipo.Name = "dtdataetipo"
        Me.dtdataetipo.Size = New System.Drawing.Size(188, 29)
        Me.dtdataetipo.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Silver
        Me.GroupBox6.Controls.Add(Me.btnpesquisardata)
        Me.GroupBox6.Controls.Add(Me.dtdatavisitantes)
        Me.GroupBox6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(626, 219)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(298, 100)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Pesquisar por Data:"
        '
        'btnpesquisardata
        '
        Me.btnpesquisardata.Location = New System.Drawing.Point(188, 57)
        Me.btnpesquisardata.Name = "btnpesquisardata"
        Me.btnpesquisardata.Size = New System.Drawing.Size(104, 37)
        Me.btnpesquisardata.TabIndex = 7
        Me.btnpesquisardata.Text = "Pesquisar"
        Me.btnpesquisardata.UseVisualStyleBackColor = True
        '
        'dtdatavisitantes
        '
        Me.dtdatavisitantes.Location = New System.Drawing.Point(16, 26)
        Me.dtdatavisitantes.Name = "dtdatavisitantes"
        Me.dtdatavisitantes.Size = New System.Drawing.Size(188, 29)
        Me.dtdatavisitantes.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Silver
        Me.GroupBox5.Controls.Add(Me.btntipopessoa)
        Me.GroupBox5.Controls.Add(Me.cmbtipopessoa)
        Me.GroupBox5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(626, 113)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(298, 100)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pesquisar por Tipo de Utente:"
        '
        'btntipopessoa
        '
        Me.btntipopessoa.Location = New System.Drawing.Point(188, 57)
        Me.btntipopessoa.Name = "btntipopessoa"
        Me.btntipopessoa.Size = New System.Drawing.Size(104, 37)
        Me.btntipopessoa.TabIndex = 6
        Me.btntipopessoa.Text = "Pesquisar"
        Me.btntipopessoa.UseVisualStyleBackColor = True
        '
        'cmbtipopessoa
        '
        Me.cmbtipopessoa.FormattingEnabled = True
        Me.cmbtipopessoa.Items.AddRange(New Object() {"Enc. Educação", "Fornecedor", "Familiar de Aluno", "Outro"})
        Me.cmbtipopessoa.Location = New System.Drawing.Point(16, 26)
        Me.cmbtipopessoa.Name = "cmbtipopessoa"
        Me.cmbtipopessoa.Size = New System.Drawing.Size(188, 30)
        Me.cmbtipopessoa.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Silver
        Me.GroupBox4.Controls.Add(Me.txtnomevisitante)
        Me.GroupBox4.Controls.Add(Me.btnnomevisitante)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(626, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(298, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pesquisar por Nome:"
        '
        'txtnomevisitante
        '
        Me.txtnomevisitante.Location = New System.Drawing.Point(16, 25)
        Me.txtnomevisitante.Name = "txtnomevisitante"
        Me.txtnomevisitante.Size = New System.Drawing.Size(188, 29)
        Me.txtnomevisitante.TabIndex = 5
        '
        'btnnomevisitante
        '
        Me.btnnomevisitante.Location = New System.Drawing.Point(188, 57)
        Me.btnnomevisitante.Name = "btnnomevisitante"
        Me.btnnomevisitante.Size = New System.Drawing.Size(104, 37)
        Me.btnnomevisitante.TabIndex = 0
        Me.btnnomevisitante.Text = "Pesquisar"
        Me.btnnomevisitante.UseVisualStyleBackColor = True
        '
        'listvisitantes
        '
        Me.listvisitantes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.listvisitantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listvisitantes.FullRowSelect = True
        Me.listvisitantes.GridLines = True
        Me.listvisitantes.Location = New System.Drawing.Point(7, 7)
        Me.listvisitantes.Name = "listvisitantes"
        Me.listvisitantes.Size = New System.Drawing.Size(600, 521)
        Me.listvisitantes.TabIndex = 0
        Me.listvisitantes.UseCompatibleStateImageBehavior = False
        Me.listvisitantes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 31
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nome"
        Me.ColumnHeader6.Width = 78
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tipo de Utente"
        Me.ColumnHeader7.Width = 94
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Data"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Observações"
        Me.ColumnHeader9.Width = 160
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Hora Entrada"
        Me.ColumnHeader10.Width = 76
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Hora Saída"
        Me.ColumnHeader11.Width = 68
        '
        'frmconsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(978, 591)
        Me.Controls.Add(Me.tcconsultas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmconsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        Me.tcconsultas.ResumeLayout(False)
        Me.tpalunos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpvisitantes.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcconsultas As System.Windows.Forms.TabControl
    Friend WithEvents tpalunos As System.Windows.Forms.TabPage
    Friend WithEvents tpvisitantes As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnnomealuno As System.Windows.Forms.Button
    Friend WithEvents txtnomealunos As System.Windows.Forms.TextBox
    Friend WithEvents listalunos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btndataaluno As System.Windows.Forms.Button
    Friend WithEvents dtdataalunos As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnambosaluno As System.Windows.Forms.Button
    Friend WithEvents dtdataambos As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnomeambosaluno As System.Windows.Forms.TextBox
    Friend WithEvents listvisitantes As System.Windows.Forms.ListView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnnomevisitante As System.Windows.Forms.Button
    Friend WithEvents txtnomevisitante As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btntipopessoa As System.Windows.Forms.Button
    Friend WithEvents cmbtipopessoa As System.Windows.Forms.ComboBox
    Friend WithEvents btnpesquisardataetipo As System.Windows.Forms.Button
    Friend WithEvents cmbdataetipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtdataetipo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnpesquisardata As System.Windows.Forms.Button
    Friend WithEvents dtdatavisitantes As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnrelatoriovisitantes As System.Windows.Forms.Button
    Friend WithEvents btnrelatorioalunos As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents btnsair1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
