<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.horas = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.puntos = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.config = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.start2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.temporizador = New System.Windows.Forms.Label()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.cronometro = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.config, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.Location = New System.Drawing.Point(473, 212)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(151, 108)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.Location = New System.Drawing.Point(670, 212)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(151, 108)
        Me.minutos.TabIndex = 1
        Me.minutos.Text = "00"
        '
        'puntos
        '
        Me.puntos.AutoSize = True
        Me.puntos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.puntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puntos.Location = New System.Drawing.Point(612, 212)
        Me.puntos.Name = "puntos"
        Me.puntos.Size = New System.Drawing.Size(72, 108)
        Me.puntos.TabIndex = 2
        Me.puntos.Text = ":"
        '
        'dias
        '
        Me.dias.AutoSize = True
        Me.dias.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.Location = New System.Drawing.Point(570, 340)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(156, 55)
        Me.dias.TabIndex = 3
        Me.dias.Text = "Lunes"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(474, 395)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(320, 42)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 de Marzo 2026"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, -258)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1445, 1110)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        '
        'config
        '
        Me.config.Image = CType(resources.GetObject("config.Image"), System.Drawing.Image)
        Me.config.Location = New System.Drawing.Point(773, 507)
        Me.config.Name = "config"
        Me.config.Size = New System.Drawing.Size(57, 54)
        Me.config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.config.TabIndex = 6
        Me.config.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(415, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 346)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(98, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(205, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuraciónes"
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.segundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.Location = New System.Drawing.Point(703, 161)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(78, 55)
        Me.segundos.TabIndex = 8
        Me.segundos.Text = "00"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.start2)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.temporizador)
        Me.Panel3.Location = New System.Drawing.Point(415, 155)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(415, 346)
        Me.Panel3.TabIndex = 3
        '
        'start2
        '
        Me.start2.Location = New System.Drawing.Point(232, 190)
        Me.start2.Name = "start2"
        Me.start2.Size = New System.Drawing.Size(103, 47)
        Me.start2.TabIndex = 3
        Me.start2.Text = "Start"
        Me.start2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(76, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "5 min"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temporizador"
        '
        'temporizador
        '
        Me.temporizador.AutoSize = True
        Me.temporizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temporizador.Location = New System.Drawing.Point(163, 113)
        Me.temporizador.Name = "temporizador"
        Me.temporizador.Size = New System.Drawing.Size(103, 39)
        Me.temporizador.TabIndex = 0
        Me.temporizador.Text = "00:00"
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(115, 87)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(151, 33)
        Me.tiempo.TabIndex = 3
        Me.tiempo.Text = "00:00:00.0"
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(274, 210)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(89, 44)
        Me.reset.TabIndex = 2
        Me.reset.Text = "reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(26, 210)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(89, 44)
        Me.start.TabIndex = 1
        Me.start.Text = "start"
        Me.start.UseVisualStyleBackColor = True
        '
        'cronometro
        '
        Me.cronometro.AutoSize = True
        Me.cronometro.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cronometro.Location = New System.Drawing.Point(100, 22)
        Me.cronometro.Name = "cronometro"
        Me.cronometro.Size = New System.Drawing.Size(179, 33)
        Me.cronometro.TabIndex = 0
        Me.cronometro.Text = "Cronometro"
        '
        'Timer3
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(710, 507)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.tiempo)
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.start)
        Me.Panel2.Controls.Add(Me.cronometro)
        Me.Panel2.Location = New System.Drawing.Point(415, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 346)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(647, 507)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(76, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "1 min"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(232, 247)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 47)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer4
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 766)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dias)
        Me.Controls.Add(Me.puntos)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Reloj Digital"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.config, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents horas As Label
    Friend WithEvents minutos As Label
    Friend WithEvents puntos As Label
    Friend WithEvents dias As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents config As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents segundos As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tiempo As Label
    Friend WithEvents reset As Button
    Friend WithEvents start As Button
    Friend WithEvents cronometro As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents start2 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents temporizador As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer4 As Timer
End Class
