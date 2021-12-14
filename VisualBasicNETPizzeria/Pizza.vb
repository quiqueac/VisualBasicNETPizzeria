Public NotInheritable Class Pizza
    Private ReadOnly c_descripcion As String
    Private ReadOnly c_ingredientes As ArrayList
    Private ReadOnly c_cantidad_porciones As Byte

    Public ReadOnly Property Descripcion() As String
        Get
            Return c_descripcion
        End Get
    End Property
    Public ReadOnly Property Ingredientes() As ArrayList
        Get
            Return c_ingredientes
        End Get
    End Property
    Public ReadOnly Property CantidadPorciones() As Byte
        Get
            Return c_cantidad_porciones
        End Get
    End Property
End Class
