<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogFormInicioConectarBD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogFormInicioConectarBD))
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelNombreUsuario = New System.Windows.Forms.Label()
        Me.TextBoxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxContrasena = New System.Windows.Forms.TextBox()
        Me.LabelContrasena = New System.Windows.Forms.Label()
        Me.TextBoxHost = New System.Windows.Forms.TextBox()
        Me.LabelHost = New System.Windows.Forms.Label()
        Me.TextBoxPuerto = New System.Windows.Forms.TextBox()
        Me.LabelPuerto = New System.Windows.Forms.Label()
        Me.TextBoxNombreBD = New System.Windows.Forms.TextBox()
        Me.LabelNombreBD = New System.Windows.Forms.Label()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.LabelConexion = New System.Windows.Forms.Label()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.ComboBoxElegirBD = New System.Windows.Forms.ComboBox()
        Me.LabelDriver = New System.Windows.Forms.Label()
        Me.LabelInformacion = New System.Windows.Forms.Label()
        Me.PictureBoxIcono = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(389, 25)
        Me.LabelTitulo.TabIndex = 1
        Me.LabelTitulo.Text = "CONECTAR CON BASE DE DATOS:"
        '
        'LabelNombreUsuario
        '
        Me.LabelNombreUsuario.AutoSize = True
        Me.LabelNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreUsuario.Location = New System.Drawing.Point(14, 48)
        Me.LabelNombreUsuario.Name = "LabelNombreUsuario"
        Me.LabelNombreUsuario.Size = New System.Drawing.Size(99, 13)
        Me.LabelNombreUsuario.TabIndex = 2
        Me.LabelNombreUsuario.Text = "Nombre usuario:"
        '
        'TextBoxNombreUsuario
        '
        Me.TextBoxNombreUsuario.Location = New System.Drawing.Point(119, 45)
        Me.TextBoxNombreUsuario.Name = "TextBoxNombreUsuario"
        Me.TextBoxNombreUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombreUsuario.TabIndex = 3
        Me.TextBoxNombreUsuario.Text = "root"
        '
        'TextBoxContrasena
        '
        Me.TextBoxContrasena.Location = New System.Drawing.Point(119, 71)
        Me.TextBoxContrasena.Name = "TextBoxContrasena"
        Me.TextBoxContrasena.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxContrasena.TabIndex = 5
        Me.TextBoxContrasena.UseSystemPasswordChar = True
        '
        'LabelContrasena
        '
        Me.LabelContrasena.AutoSize = True
        Me.LabelContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContrasena.Location = New System.Drawing.Point(14, 74)
        Me.LabelContrasena.Name = "LabelContrasena"
        Me.LabelContrasena.Size = New System.Drawing.Size(75, 13)
        Me.LabelContrasena.TabIndex = 4
        Me.LabelContrasena.Text = "Contraseña:"
        '
        'TextBoxHost
        '
        Me.TextBoxHost.Location = New System.Drawing.Point(119, 97)
        Me.TextBoxHost.Name = "TextBoxHost"
        Me.TextBoxHost.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHost.TabIndex = 7
        Me.TextBoxHost.Text = "localhost"
        '
        'LabelHost
        '
        Me.LabelHost.AutoSize = True
        Me.LabelHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHost.Location = New System.Drawing.Point(14, 100)
        Me.LabelHost.Name = "LabelHost"
        Me.LabelHost.Size = New System.Drawing.Size(37, 13)
        Me.LabelHost.TabIndex = 6
        Me.LabelHost.Text = "Host:"
        '
        'TextBoxPuerto
        '
        Me.TextBoxPuerto.Location = New System.Drawing.Point(119, 123)
        Me.TextBoxPuerto.Name = "TextBoxPuerto"
        Me.TextBoxPuerto.Size = New System.Drawing.Size(39, 20)
        Me.TextBoxPuerto.TabIndex = 9
        Me.TextBoxPuerto.Text = "3306"
        '
        'LabelPuerto
        '
        Me.LabelPuerto.AutoSize = True
        Me.LabelPuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPuerto.Location = New System.Drawing.Point(14, 126)
        Me.LabelPuerto.Name = "LabelPuerto"
        Me.LabelPuerto.Size = New System.Drawing.Size(48, 13)
        Me.LabelPuerto.TabIndex = 8
        Me.LabelPuerto.Text = "Puerto:"
        '
        'TextBoxNombreBD
        '
        Me.TextBoxNombreBD.Location = New System.Drawing.Point(119, 149)
        Me.TextBoxNombreBD.Name = "TextBoxNombreBD"
        Me.TextBoxNombreBD.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombreBD.TabIndex = 11
        Me.TextBoxNombreBD.Text = "pizzeria"
        '
        'LabelNombreBD
        '
        Me.LabelNombreBD.AutoSize = True
        Me.LabelNombreBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreBD.Location = New System.Drawing.Point(14, 152)
        Me.LabelNombreBD.Name = "LabelNombreBD"
        Me.LabelNombreBD.Size = New System.Drawing.Size(76, 13)
        Me.LabelNombreBD.TabIndex = 10
        Me.LabelNombreBD.Text = "Base Datos:"
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelEstado.Location = New System.Drawing.Point(236, 153)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(74, 16)
        Me.LabelEstado.TabIndex = 12
        Me.LabelEstado.Text = "ESTADO:"
        '
        'LabelConexion
        '
        Me.LabelConexion.AutoSize = True
        Me.LabelConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConexion.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelConexion.Location = New System.Drawing.Point(316, 153)
        Me.LabelConexion.Name = "LabelConexion"
        Me.LabelConexion.Size = New System.Drawing.Size(133, 16)
        Me.LabelConexion.TabIndex = 13
        Me.LabelConexion.Text = "DESCONECTADO"
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConectar.Location = New System.Drawing.Point(239, 45)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(162, 31)
        Me.ButtonConectar.TabIndex = 14
        Me.ButtonConectar.Text = "Conectar"
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'ComboBoxElegirBD
        '
        Me.ComboBoxElegirBD.FormattingEnabled = True
        Me.ComboBoxElegirBD.Items.AddRange(New Object() {"MySQL"})
        Me.ComboBoxElegirBD.Location = New System.Drawing.Point(337, 82)
        Me.ComboBoxElegirBD.Name = "ComboBoxElegirBD"
        Me.ComboBoxElegirBD.Size = New System.Drawing.Size(64, 21)
        Me.ComboBoxElegirBD.TabIndex = 15
        Me.ComboBoxElegirBD.Text = "MySQL"
        '
        'LabelDriver
        '
        Me.LabelDriver.AutoSize = True
        Me.LabelDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDriver.Location = New System.Drawing.Point(236, 85)
        Me.LabelDriver.Name = "LabelDriver"
        Me.LabelDriver.Size = New System.Drawing.Size(45, 13)
        Me.LabelDriver.TabIndex = 16
        Me.LabelDriver.Text = "Driver:"
        '
        'LabelInformacion
        '
        Me.LabelInformacion.AutoSize = True
        Me.LabelInformacion.Location = New System.Drawing.Point(63, 189)
        Me.LabelInformacion.Name = "LabelInformacion"
        Me.LabelInformacion.Size = New System.Drawing.Size(0, 13)
        Me.LabelInformacion.TabIndex = 18
        '
        'PictureBoxIcono
        '
        Me.PictureBoxIcono.Image = CType(resources.GetObject("PictureBoxIcono.Image"), System.Drawing.Image)
        Me.PictureBoxIcono.Location = New System.Drawing.Point(17, 181)
        Me.PictureBoxIcono.Name = "PictureBoxIcono"
        Me.PictureBoxIcono.Size = New System.Drawing.Size(39, 30)
        Me.PictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxIcono.TabIndex = 17
        Me.PictureBoxIcono.TabStop = False
        '
        'DialogFormInicioConectarBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 220)
        Me.Controls.Add(Me.LabelInformacion)
        Me.Controls.Add(Me.PictureBoxIcono)
        Me.Controls.Add(Me.LabelDriver)
        Me.Controls.Add(Me.ComboBoxElegirBD)
        Me.Controls.Add(Me.ButtonConectar)
        Me.Controls.Add(Me.LabelConexion)
        Me.Controls.Add(Me.LabelEstado)
        Me.Controls.Add(Me.TextBoxNombreBD)
        Me.Controls.Add(Me.LabelNombreBD)
        Me.Controls.Add(Me.TextBoxPuerto)
        Me.Controls.Add(Me.LabelPuerto)
        Me.Controls.Add(Me.TextBoxHost)
        Me.Controls.Add(Me.LabelHost)
        Me.Controls.Add(Me.TextBoxContrasena)
        Me.Controls.Add(Me.LabelContrasena)
        Me.Controls.Add(Me.TextBoxNombreUsuario)
        Me.Controls.Add(Me.LabelNombreUsuario)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogFormInicioConectarBD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Conectar con BD"
        CType(Me.PictureBoxIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitulo As Windows.Forms.Label
    Friend WithEvents LabelNombreUsuario As Windows.Forms.Label
    Friend WithEvents TextBoxNombreUsuario As Windows.Forms.TextBox
    Friend WithEvents TextBoxContrasena As Windows.Forms.TextBox
    Friend WithEvents LabelContrasena As Windows.Forms.Label
    Friend WithEvents TextBoxHost As Windows.Forms.TextBox
    Friend WithEvents LabelHost As Windows.Forms.Label
    Friend WithEvents TextBoxPuerto As Windows.Forms.TextBox
    Friend WithEvents LabelPuerto As Windows.Forms.Label
    Friend WithEvents TextBoxNombreBD As Windows.Forms.TextBox
    Friend WithEvents LabelNombreBD As Windows.Forms.Label
    Friend WithEvents LabelEstado As Windows.Forms.Label
    Friend WithEvents LabelConexion As Windows.Forms.Label
    Friend WithEvents ButtonConectar As Windows.Forms.Button
    Friend WithEvents ComboBoxElegirBD As Windows.Forms.ComboBox
    Friend WithEvents LabelDriver As Windows.Forms.Label
    Friend WithEvents LabelInformacion As Windows.Forms.Label
    Friend WithEvents PictureBoxIcono As Windows.Forms.PictureBox
End Class
