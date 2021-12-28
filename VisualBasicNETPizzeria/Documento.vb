Namespace Clases
    Public MustInherit Class Documento
        Implements IDocumento

        Protected ReadOnly c_numero As UInteger
        Protected ReadOnly c_fecha_hora_emision As Date

        Public Sub New()
            c_numero = 0
            c_fecha_hora_emision = Date.Now
        End Sub

        Public ReadOnly Property Numero() As UInteger
            Get
                Return c_numero
            End Get
        End Property

        Public ReadOnly Property FechaHoraEmision() As Date
            Get
                Return c_fecha_hora_emision
            End Get
        End Property

        Public MustOverride Sub CalcularTotal() Implements IDocumento.CalcularTotal
        Public MustOverride Sub EsGenerado() Implements IDocumento.EsGenerado
        Public MustOverride Sub EsPendienteFacturacion() Implements IDocumento.EsPendienteFacturacion
    End Class
End Namespace
