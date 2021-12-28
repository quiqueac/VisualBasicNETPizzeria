Namespace Clases
    Public Class Pedido
        Inherits Documento
        Implements IPedido

        Protected c_fecha_hora_entrega As Date
        Protected c_nombre_cliente As String
        Protected c_precio_total As Decimal
        Protected c_precio_subtotal As Decimal
        Protected c_productos As ArrayList

        Public Sub New(
                      ByVal c_fecha_hora_entrega As Date,
                      ByVal c_nombre_cliente As String,
                      ByVal ParamArray array_productos As Producto()
                      )
            MyBase.New()
            Me.c_fecha_hora_entrega = c_fecha_hora_entrega
            Me.c_nombre_cliente = c_nombre_cliente
            c_precio_total = 0@
            Utilitaria.ConvertirArrayDeObjetosHaciaArrayList(array_productos, c_productos)
        End Sub

        Public Property FechaHoraEntrega As Date
            Get
                Return c_fecha_hora_entrega
            End Get
            Set(ByVal value As Date)
                c_fecha_hora_entrega = value
            End Set
        End Property

        Public Property NombreCliente As String
            Get
                Return c_nombre_cliente
            End Get
            Set(ByVal value As String)
                c_nombre_cliente = value
            End Set
        End Property

        Public Property PrecioTotal As Decimal
            Get
                Return c_precio_total
            End Get
            Set(ByVal value As Decimal)
                c_precio_total = value@
            End Set
        End Property

        Public Property PrecioSubTotal As Decimal
            Get
                Return c_precio_subtotal
            End Get
            Set(ByVal value As Decimal)
                c_precio_subtotal = value@
            End Set
        End Property

        Public Property Productos As ArrayList
            Get
                Return c_productos
            End Get
            Set(ByVal value As ArrayList)
                c_productos = value
            End Set
        End Property

        Public ReadOnly Property IVA As Decimal Implements IPedido.IVA
            Get
                Return 0.16
            End Get
        End Property

        ''' <summary>
        ''' Retornar la suma total de los precios individuales de los productos
        ''' </summary>
        Public Sub CalcularTotalItems() Implements IPedido.CalcularTotalItems
            For Each iterador As Producto In c_productos
                c_precio_subtotal += iterador.Precio@
            Next
        End Sub

        ''' <summary>
        ''' Cancelar el pedido y no guardarlo en la base de datos
        ''' </summary>
        Public Sub Cancelar() Implements IPedido.Cancelar
            Throw New NotImplementedException()
        End Sub

        ''' <summary>
        ''' Confirmar el pedido y guardarlo en la base de datos
        ''' </summary>
        Public Sub Confirmar() Implements IPedido.Confirmar
            Throw New NotImplementedException()
        End Sub

        ''' <summary>
        ''' Facturar
        ''' </summary>
        Public Sub Facturar() Implements IPedido.Facturar
            Throw New NotImplementedException()
        End Sub

        ''' <summary>
        ''' Pedido listo para cobrar
        ''' </summary>
        Public Sub Terminar(ByVal c_fecha_entrega As Date) Implements IPedido.Terminar
            c_fecha_hora_entrega = c_fecha_hora_entrega
        End Sub

        ''' <summary>
        ''' Precio con IVA incluido
        ''' </summary>
        Public Overrides Sub CalcularTotal()
            c_precio_total = c_precio_subtotal@ + c_precio_subtotal@ * IVA@
        End Sub

        ''' <summary>
        ''' Saber si se va a guardar el documento en la computadora
        ''' </summary>
        Public Overrides Sub EsGenerado()
            Throw New NotImplementedException()
        End Sub

        ''' <summary>
        ''' Saber si ya esta facturado o no el documento
        ''' </summary>
        Public Overrides Sub EsPendienteFacturacion()
            Throw New NotImplementedException()
        End Sub

        ''' <summary>
        ''' Imprimir el pedido
        ''' </summary>
        ''' <returns>String</returns>
        Public Overrides Function ToString() As String
            Dim iterador As Object
            Dim productos As String = ""

            If Not IsNothing(c_productos) Then
                For Each iterador In c_productos
                    productos &= iterador.ToString()
                Next
            End If

            Return (
                "Numero: " & c_numero & vbCrLf &
                "Emision: " & c_fecha_hora_emision & vbCrLf &
                "Entrega: " & c_fecha_hora_entrega & vbCrLf &
                "Cliente: " & c_nombre_cliente & vbCrLf &
                "Precio total: " & c_precio_total & vbCrLf &
                "Productos: " & productos
                )
        End Function
    End Class
End Namespace
