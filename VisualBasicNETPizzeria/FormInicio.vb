Public Class FormInicio
    Private Sub ConectarBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarBDToolStripMenuItem.Click
        Dim conectarBD As DialogFormInicioConectarBD = New DialogFormInicioConectarBD
        conectarBD.ShowDialog()
    End Sub
End Class