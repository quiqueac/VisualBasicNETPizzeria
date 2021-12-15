Namespace Clases
    Public MustInherit Class Documento
        Protected ReadOnly c_numero As UInteger
        Protected c_fecha_hora_emision As Date

        Public ReadOnly Property Numero() As UInteger
            Get
                Return c_numero
            End Get
        End Property
    End Class
End Namespace
