Namespace Clases
    Public NotInheritable Class Factura
        Inherits Pedido
        Implements IFactura

        Public Sub New(c_fecha_hora_entrega As Date, c_nombre_cliente As String, ParamArray c_productos() As Producto)
            MyBase.New(c_fecha_hora_entrega, c_nombre_cliente, c_productos)
        End Sub

        Public Sub BuscarItemsFacturar() Implements IFactura.BuscarItemsFacturar
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace
