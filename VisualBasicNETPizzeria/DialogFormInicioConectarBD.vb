Imports VisualBasicNETPizzeria.Clases

Public Class DialogFormInicioConectarBD
    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        BD.Connect(
            TextBoxHost.Text,
            TextBoxNombreBD.Text,
            TextBoxNombreUsuario.Text,
            TextBoxContrasena.Text,
            TextBoxPuerto.Text
            )
        LabelInformacion.Text = BD.Mensaje

        If BD.SePuedeConectarBD Then
            TextBoxNombreUsuario.Enabled = False
            TextBoxContrasena.Enabled = False
            TextBoxHost.Enabled = False
            TextBoxPuerto.Enabled = False
            TextBoxNombreBD.Enabled = False
            ButtonConectar.Enabled = False
            ComboBoxElegirBD.Enabled = False

            LabelConexion.Text = "CONECTADO"
            LabelConexion.ForeColor = Drawing.Color.Green
        End If
    End Sub
End Class
