Namespace Clases
    Public Class Producto
        Protected c_nombre As String
        Protected c_precio As Decimal

        Sub New(
               ByVal c_nombre As String,
               ByVal c_precio As Decimal
               )
            Me.c_nombre = c_nombre
            Me.c_precio = c_precio
        End Sub

        Public Property Nombre As String
            Get
                Return c_nombre
            End Get
            Set(ByVal value As String)
                c_nombre = value
            End Set
        End Property

        Public Overridable Property Precio As Decimal
            Get
                Return c_precio
            End Get
            Set(ByVal value As Decimal)
                c_precio = value
            End Set
        End Property
    End Class
End Namespace

