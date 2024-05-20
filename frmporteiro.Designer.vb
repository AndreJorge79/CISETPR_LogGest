<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmporteiro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtlugar0 = New System.Windows.Forms.TextBox()
        Me.txtlugar1 = New System.Windows.Forms.TextBox()
        Me.txtlugar2 = New System.Windows.Forms.TextBox()
        Me.txtlugar3 = New System.Windows.Forms.TextBox()
        Me.txtlugar4 = New System.Windows.Forms.TextBox()
        Me.txtlugar5 = New System.Windows.Forms.TextBox()
        Me.txtletra1 = New System.Windows.Forms.TextBox()
        Me.txtletra2 = New System.Windows.Forms.TextBox()
        Me.lblportaserial = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lbldata = New System.Windows.Forms.Label()
        Me.txtnprocesso = New System.Windows.Forms.TextBox()
        Me.txtautorizacao = New System.Windows.Forms.TextBox()
        Me.txtturma = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerCOM = New System.Windows.Forms.Timer(Me.components)
        Me.TimerHoraData = New System.Windows.Forms.Timer(Me.components)
        Me.lbles = New System.Windows.Forms.Label()
        Me.TimerES = New System.Windows.Forms.Timer(Me.components)
        Me.listesalunos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtrfid = New System.Windows.Forms.TextBox()
        Me.picfoto5 = New System.Windows.Forms.PictureBox()
        Me.picfoto4 = New System.Windows.Forms.PictureBox()
        Me.picfoto3 = New System.Windows.Forms.PictureBox()
        Me.picfoto2 = New System.Windows.Forms.PictureBox()
        Me.piccor4 = New System.Windows.Forms.PictureBox()
        Me.piccor3 = New System.Windows.Forms.PictureBox()
        Me.piccor2 = New System.Windows.Forms.PictureBox()
        Me.piccor1 = New System.Windows.Forms.PictureBox()
        Me.picfoto = New System.Windows.Forms.PictureBox()
        Me.lugar5 = New System.Windows.Forms.PictureBox()
        Me.lugar4 = New System.Windows.Forms.PictureBox()
        Me.lugar3 = New System.Windows.Forms.PictureBox()
        Me.lugar2 = New System.Windows.Forms.PictureBox()
        Me.lugar1 = New System.Windows.Forms.PictureBox()
        Me.lugar0 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.picfoto5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picfoto4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picfoto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picfoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lugar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lugar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lugar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lugar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lugar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lugar0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lugar 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lugar 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lugar 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(224, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lugar 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(224, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lugar 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(224, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lugar 5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(243, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Lugar 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(243, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Lugar 4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(243, 457)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Lugar 3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Lugar 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Lugar 1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 458)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Lugar 0"
        '
        'txtlugar0
        '
        Me.txtlugar0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtlugar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlugar0.ForeColor = System.Drawing.Color.White
        Me.txtlugar0.Location = New System.Drawing.Point(100, 451)
        Me.txtlugar0.Name = "txtlugar0"
        Me.txtlugar0.Size = New System.Drawing.Size(100, 22)
        Me.txtlugar0.TabIndex = 18
        Me.txtlugar0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlugar1
        '
        Me.txtlugar1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtlugar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlugar1.ForeColor = System.Drawing.Color.White
        Me.txtlugar1.Location = New System.Drawing.Point(100, 407)
        Me.txtlugar1.Name = "txtlugar1"
        Me.txtlugar1.Size = New System.Drawing.Size(100, 22)
        Me.txtlugar1.TabIndex = 19
        Me.txtlugar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlugar2
        '
        Me.txtlugar2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtlugar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlugar2.ForeColor = System.Drawing.Color.White
        Me.txtlugar2.Location = New System.Drawing.Point(100, 367)
        Me.txtlugar2.Name = "txtlugar2"
        Me.txtlugar2.Size = New System.Drawing.Size(100, 22)
        Me.txtlugar2.TabIndex = 20
        Me.txtlugar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlugar3
        '
        Me.txtlugar3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtlugar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlugar3.ForeColor = System.Drawing.Color.White
        Me.txtlugar3.Location = New System.Drawing.Point(303, 451)
        Me.txtlugar3.Name = "txtlugar3"
        Me.txtlugar3.Size = New System.Drawing.Size(100, 22)
        Me.txtlugar3.TabIndex = 21
        Me.txtlugar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlugar4
        '
        Me.txtlugar4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtlugar4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlugar4.ForeColor = System.Drawing.Color.White
        Me.txtlugar4.Location = New System.Drawing.Point(303, 406)
        Me.txtlugar4.Name = "txtlugar4"
        Me.txtlugar4.Size = New System.Drawing.Size(100, 22)
        Me.txtlugar4.TabIndex = 22
        Me.txtlugar4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlugar5
        '
        Me.txtlugar5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtlugar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlugar5.ForeColor = System.Drawing.Color.White
        Me.txtlugar5.Location = New System.Drawing.Point(303, 370)
        Me.txtlugar5.Name = "txtlugar5"
        Me.txtlugar5.Size = New System.Drawing.Size(100, 22)
        Me.txtlugar5.TabIndex = 23
        Me.txtlugar5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtletra1
        '
        Me.txtletra1.Location = New System.Drawing.Point(193, 511)
        Me.txtletra1.Name = "txtletra1"
        Me.txtletra1.Size = New System.Drawing.Size(71, 20)
        Me.txtletra1.TabIndex = 24
        Me.txtletra1.Visible = False
        '
        'txtletra2
        '
        Me.txtletra2.Location = New System.Drawing.Point(193, 548)
        Me.txtletra2.Name = "txtletra2"
        Me.txtletra2.Size = New System.Drawing.Size(71, 20)
        Me.txtletra2.TabIndex = 25
        Me.txtletra2.Visible = False
        '
        'lblportaserial
        '
        Me.lblportaserial.AutoSize = True
        Me.lblportaserial.BackColor = System.Drawing.Color.Transparent
        Me.lblportaserial.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblportaserial.Location = New System.Drawing.Point(189, 571)
        Me.lblportaserial.Name = "lblportaserial"
        Me.lblportaserial.Size = New System.Drawing.Size(89, 22)
        Me.lblportaserial.TabIndex = 26
        Me.lblportaserial.Text = "Porta Serial"
        Me.lblportaserial.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(978, 614)
        Me.ShapeContainer1.TabIndex = 27
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 428
        Me.LineShape1.X2 = 428
        Me.LineShape1.Y1 = -3
        Me.LineShape1.Y2 = 707
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(452, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 22)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "N.º de Processo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(452, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 22)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Nome"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(452, 321)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 22)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Turma"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(452, 355)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 22)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Autorização de Saída"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(452, 388)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(57, 22)
        Me.lblhora.TabIndex = 33
        Me.lblhora.Text = "HORA"
        '
        'lbldata
        '
        Me.lbldata.AutoSize = True
        Me.lbldata.BackColor = System.Drawing.Color.Transparent
        Me.lbldata.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldata.Location = New System.Drawing.Point(531, 388)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(51, 22)
        Me.lbldata.TabIndex = 34
        Me.lbldata.Text = "DATA"
        '
        'txtnprocesso
        '
        Me.txtnprocesso.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtnprocesso.Location = New System.Drawing.Point(611, 254)
        Me.txtnprocesso.Name = "txtnprocesso"
        Me.txtnprocesso.Size = New System.Drawing.Size(182, 20)
        Me.txtnprocesso.TabIndex = 35
        '
        'txtautorizacao
        '
        Me.txtautorizacao.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtautorizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtautorizacao.ForeColor = System.Drawing.Color.White
        Me.txtautorizacao.Location = New System.Drawing.Point(611, 358)
        Me.txtautorizacao.Name = "txtautorizacao"
        Me.txtautorizacao.Size = New System.Drawing.Size(182, 20)
        Me.txtautorizacao.TabIndex = 36
        Me.txtautorizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtturma
        '
        Me.txtturma.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtturma.Location = New System.Drawing.Point(611, 324)
        Me.txtturma.Name = "txtturma"
        Me.txtturma.Size = New System.Drawing.Size(182, 20)
        Me.txtturma.TabIndex = 37
        '
        'txtnome
        '
        Me.txtnome.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtnome.Location = New System.Drawing.Point(611, 289)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(182, 20)
        Me.txtnome.TabIndex = 38
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'TimerCOM
        '
        Me.TimerCOM.Enabled = True
        '
        'TimerHoraData
        '
        Me.TimerHoraData.Enabled = True
        Me.TimerHoraData.Interval = 1000
        '
        'lbles
        '
        Me.lbles.AutoSize = True
        Me.lbles.Location = New System.Drawing.Point(334, 580)
        Me.lbles.Name = "lbles"
        Me.lbles.Size = New System.Drawing.Size(53, 13)
        Me.lbles.TabIndex = 48
        Me.lbles.Text = "ENTROU"
        '
        'TimerES
        '
        Me.TimerES.Enabled = True
        '
        'listesalunos
        '
        Me.listesalunos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.listesalunos.FullRowSelect = True
        Me.listesalunos.GridLines = True
        Me.listesalunos.Location = New System.Drawing.Point(456, 414)
        Me.listesalunos.Name = "listesalunos"
        Me.listesalunos.Size = New System.Drawing.Size(358, 184)
        Me.listesalunos.TabIndex = 49
        Me.listesalunos.UseCompatibleStateImageBehavior = False
        Me.listesalunos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 43
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "N.º de Processo"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nome"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Turma"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Hora de Saída"
        Me.ColumnHeader8.Width = 89
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(371, 564)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(18, 13)
        Me.lblid.TabIndex = 50
        Me.lblid.Text = "ID"
        Me.lblid.Visible = False
        '
        'txtrfid
        '
        Me.txtrfid.Location = New System.Drawing.Point(456, 472)
        Me.txtrfid.Name = "txtrfid"
        Me.txtrfid.Size = New System.Drawing.Size(100, 20)
        Me.txtrfid.TabIndex = 51
        '
        'picfoto5
        '
        Me.picfoto5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picfoto5.Location = New System.Drawing.Point(841, 472)
        Me.picfoto5.Name = "picfoto5"
        Me.picfoto5.Size = New System.Drawing.Size(112, 112)
        Me.picfoto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto5.TabIndex = 46
        Me.picfoto5.TabStop = False
        '
        'picfoto4
        '
        Me.picfoto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picfoto4.Location = New System.Drawing.Point(841, 322)
        Me.picfoto4.Name = "picfoto4"
        Me.picfoto4.Size = New System.Drawing.Size(112, 112)
        Me.picfoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto4.TabIndex = 45
        Me.picfoto4.TabStop = False
        '
        'picfoto3
        '
        Me.picfoto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picfoto3.Location = New System.Drawing.Point(841, 173)
        Me.picfoto3.Name = "picfoto3"
        Me.picfoto3.Size = New System.Drawing.Size(112, 112)
        Me.picfoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto3.TabIndex = 44
        Me.picfoto3.TabStop = False
        '
        'picfoto2
        '
        Me.picfoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picfoto2.Location = New System.Drawing.Point(841, 22)
        Me.picfoto2.Name = "picfoto2"
        Me.picfoto2.Size = New System.Drawing.Size(112, 112)
        Me.picfoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto2.TabIndex = 43
        Me.picfoto2.TabStop = False
        '
        'piccor4
        '
        Me.piccor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piccor4.Location = New System.Drawing.Point(827, 458)
        Me.piccor4.Name = "piccor4"
        Me.piccor4.Size = New System.Drawing.Size(140, 140)
        Me.piccor4.TabIndex = 42
        Me.piccor4.TabStop = False
        '
        'piccor3
        '
        Me.piccor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piccor3.Location = New System.Drawing.Point(827, 307)
        Me.piccor3.Name = "piccor3"
        Me.piccor3.Size = New System.Drawing.Size(140, 140)
        Me.piccor3.TabIndex = 41
        Me.piccor3.TabStop = False
        '
        'piccor2
        '
        Me.piccor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piccor2.Location = New System.Drawing.Point(827, 158)
        Me.piccor2.Name = "piccor2"
        Me.piccor2.Size = New System.Drawing.Size(140, 140)
        Me.piccor2.TabIndex = 40
        Me.piccor2.TabStop = False
        '
        'piccor1
        '
        Me.piccor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.piccor1.Location = New System.Drawing.Point(827, 9)
        Me.piccor1.Name = "piccor1"
        Me.piccor1.Size = New System.Drawing.Size(140, 140)
        Me.piccor1.TabIndex = 39
        Me.piccor1.TabStop = False
        '
        'picfoto
        '
        Me.picfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picfoto.Location = New System.Drawing.Point(558, 9)
        Me.picfoto.Name = "picfoto"
        Me.picfoto.Size = New System.Drawing.Size(222, 222)
        Me.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto.TabIndex = 28
        Me.picfoto.TabStop = False
        '
        'lugar5
        '
        Me.lugar5.Image = Global.CISETPR_LogGest.My.Resources.Resources.verde
        Me.lugar5.Location = New System.Drawing.Point(295, 11)
        Me.lugar5.Name = "lugar5"
        Me.lugar5.Size = New System.Drawing.Size(108, 76)
        Me.lugar5.TabIndex = 5
        Me.lugar5.TabStop = False
        '
        'lugar4
        '
        Me.lugar4.Image = Global.CISETPR_LogGest.My.Resources.Resources.verde
        Me.lugar4.Location = New System.Drawing.Point(295, 116)
        Me.lugar4.Name = "lugar4"
        Me.lugar4.Size = New System.Drawing.Size(108, 76)
        Me.lugar4.TabIndex = 4
        Me.lugar4.TabStop = False
        '
        'lugar3
        '
        Me.lugar3.Image = Global.CISETPR_LogGest.My.Resources.Resources.verde
        Me.lugar3.Location = New System.Drawing.Point(295, 221)
        Me.lugar3.Name = "lugar3"
        Me.lugar3.Size = New System.Drawing.Size(108, 76)
        Me.lugar3.TabIndex = 3
        Me.lugar3.TabStop = False
        '
        'lugar2
        '
        Me.lugar2.Image = Global.CISETPR_LogGest.My.Resources.Resources.verde
        Me.lugar2.Location = New System.Drawing.Point(74, 12)
        Me.lugar2.Name = "lugar2"
        Me.lugar2.Size = New System.Drawing.Size(108, 76)
        Me.lugar2.TabIndex = 2
        Me.lugar2.TabStop = False
        '
        'lugar1
        '
        Me.lugar1.Image = Global.CISETPR_LogGest.My.Resources.Resources.verde
        Me.lugar1.Location = New System.Drawing.Point(74, 117)
        Me.lugar1.Name = "lugar1"
        Me.lugar1.Size = New System.Drawing.Size(108, 76)
        Me.lugar1.TabIndex = 1
        Me.lugar1.TabStop = False
        '
        'lugar0
        '
        Me.lugar0.Image = Global.CISETPR_LogGest.My.Resources.Resources.verde
        Me.lugar0.Location = New System.Drawing.Point(74, 222)
        Me.lugar0.Name = "lugar0"
        Me.lugar0.Size = New System.Drawing.Size(108, 76)
        Me.lugar0.TabIndex = 0
        Me.lugar0.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(430, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Mudar Para ENTROU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(430, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 23)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Mudar Para SAIU"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmporteiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 614)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.listesalunos)
        Me.Controls.Add(Me.lbles)
        Me.Controls.Add(Me.picfoto5)
        Me.Controls.Add(Me.picfoto4)
        Me.Controls.Add(Me.picfoto3)
        Me.Controls.Add(Me.picfoto2)
        Me.Controls.Add(Me.piccor4)
        Me.Controls.Add(Me.piccor3)
        Me.Controls.Add(Me.piccor2)
        Me.Controls.Add(Me.piccor1)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtturma)
        Me.Controls.Add(Me.txtautorizacao)
        Me.Controls.Add(Me.txtnprocesso)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.picfoto)
        Me.Controls.Add(Me.lblportaserial)
        Me.Controls.Add(Me.txtletra2)
        Me.Controls.Add(Me.txtletra1)
        Me.Controls.Add(Me.txtlugar5)
        Me.Controls.Add(Me.txtlugar4)
        Me.Controls.Add(Me.txtlugar3)
        Me.Controls.Add(Me.txtlugar2)
        Me.Controls.Add(Me.txtlugar1)
        Me.Controls.Add(Me.txtlugar0)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lugar5)
        Me.Controls.Add(Me.lugar4)
        Me.Controls.Add(Me.lugar3)
        Me.Controls.Add(Me.lugar2)
        Me.Controls.Add(Me.lugar1)
        Me.Controls.Add(Me.lugar0)
        Me.Controls.Add(Me.txtrfid)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmporteiro"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.picfoto5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picfoto4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picfoto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picfoto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lugar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lugar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lugar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lugar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lugar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lugar0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lugar0 As System.Windows.Forms.PictureBox
    Friend WithEvents lugar1 As System.Windows.Forms.PictureBox
    Friend WithEvents lugar2 As System.Windows.Forms.PictureBox
    Friend WithEvents lugar3 As System.Windows.Forms.PictureBox
    Friend WithEvents lugar4 As System.Windows.Forms.PictureBox
    Friend WithEvents lugar5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtlugar0 As System.Windows.Forms.TextBox
    Friend WithEvents txtlugar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtlugar2 As System.Windows.Forms.TextBox
    Friend WithEvents txtlugar3 As System.Windows.Forms.TextBox
    Friend WithEvents txtlugar4 As System.Windows.Forms.TextBox
    Friend WithEvents txtlugar5 As System.Windows.Forms.TextBox
    Friend WithEvents txtletra1 As System.Windows.Forms.TextBox
    Friend WithEvents txtletra2 As System.Windows.Forms.TextBox
    Friend WithEvents lblportaserial As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents picfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents txtnprocesso As System.Windows.Forms.TextBox
    Friend WithEvents txtautorizacao As System.Windows.Forms.TextBox
    Friend WithEvents txtturma As System.Windows.Forms.TextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents piccor1 As System.Windows.Forms.PictureBox
    Friend WithEvents piccor2 As System.Windows.Forms.PictureBox
    Friend WithEvents piccor3 As System.Windows.Forms.PictureBox
    Friend WithEvents piccor4 As System.Windows.Forms.PictureBox
    Friend WithEvents picfoto2 As System.Windows.Forms.PictureBox
    Friend WithEvents picfoto3 As System.Windows.Forms.PictureBox
    Friend WithEvents picfoto4 As System.Windows.Forms.PictureBox
    Friend WithEvents picfoto5 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents TimerCOM As System.Windows.Forms.Timer
    Friend WithEvents TimerHoraData As System.Windows.Forms.Timer
    Friend WithEvents lbles As System.Windows.Forms.Label
    Friend WithEvents TimerES As System.Windows.Forms.Timer
    Friend WithEvents listesalunos As System.Windows.Forms.ListView
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtrfid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
