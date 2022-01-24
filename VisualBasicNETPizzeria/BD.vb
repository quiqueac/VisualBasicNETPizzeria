Imports MySql.Data.MySqlClient

Namespace Clases
    Public Class BD
        Private Shared conn As MySqlConnection
        Public Shared Property Mensaje As String
        Public Shared Property SePuedeConectarBD As Boolean

        Shared Sub Connect(
                          ByVal server As String,
                          ByVal database As String,
                          ByVal user As String,
                          ByVal password As String,
                          ByVal port As String
                          )

            Dim connString As String = String.Format("server={0};port={1};user id={2}; password={3}; database={4};", server, port, user, password, database)

            conn = New MySqlConnection(connString)

            Try
                conn.Open()
                Mensaje = "Conexion exitosa"
                SePuedeConectarBD = True
                conn.Close()
            Catch e As MySqlException
                Mensaje = e.Message
            End Try
        End Sub
    End Class
End Namespace
