<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
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
        Me.MenuStripInicio = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarBDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesconectarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PizzeriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripInicio
        '
        Me.MenuStripInicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PizzeriaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStripInicio.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripInicio.Name = "MenuStripInicio"
        Me.MenuStripInicio.Size = New System.Drawing.Size(800, 24)
        Me.MenuStripInicio.TabIndex = 0
        Me.MenuStripInicio.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarBDToolStripMenuItem, Me.ConsultasSQLToolStripMenuItem, Me.DesconectarToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ConectarBDToolStripMenuItem
        '
        Me.ConectarBDToolStripMenuItem.Name = "ConectarBDToolStripMenuItem"
        Me.ConectarBDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConectarBDToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ConectarBDToolStripMenuItem.Text = "Conectar BD"
        '
        'ConsultasSQLToolStripMenuItem
        '
        Me.ConsultasSQLToolStripMenuItem.Name = "ConsultasSQLToolStripMenuItem"
        Me.ConsultasSQLToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ConsultasSQLToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ConsultasSQLToolStripMenuItem.Text = "Consultas SQL"
        '
        'DesconectarToolStripMenuItem
        '
        Me.DesconectarToolStripMenuItem.Name = "DesconectarToolStripMenuItem"
        Me.DesconectarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DesconectarToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DesconectarToolStripMenuItem.Text = "Desconectar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'PizzeriaToolStripMenuItem
        '
        Me.PizzeriaToolStripMenuItem.Enabled = False
        Me.PizzeriaToolStripMenuItem.Name = "PizzeriaToolStripMenuItem"
        Me.PizzeriaToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.PizzeriaToolStripMenuItem.Text = "Pizzeria"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStripInicio)
        Me.MainMenuStrip = Me.MenuStripInicio
        Me.Name = "FormInicio"
        Me.Text = "Pizzeria"
        Me.MenuStripInicio.ResumeLayout(False)
        Me.MenuStripInicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripInicio As Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarBDToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasSQLToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesconectarToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PizzeriaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
