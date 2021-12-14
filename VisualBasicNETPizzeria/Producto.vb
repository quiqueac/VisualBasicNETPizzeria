Public MustInherit Class Producto
    Protected c_nombre As String
    Protected c_precio As Decimal

    Public MustOverride Property Nombre

    Public Overridable Property Precio() As Decimal
        Get
            Return c_precio
        End Get
        Set(value As Decimal)
            c_precio = value
        End Set
    End Property
End Class
