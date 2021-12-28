Namespace Clases
    Public NotInheritable Class Pizza
        Inherits Producto
        Implements IPizza

        Public ReadOnly Property Tamanio() As String
        Public ReadOnly Property Tipo() As String
        Public ReadOnly Property Ingredientes() As ArrayList

        Sub New(
               ByVal c_nombre As String,
               ByVal c_precio As Decimal,
               ByVal tamanio As Byte,
               ByVal tipo As Byte
               )
            MyBase.New(c_nombre, c_precio)

            Me.Tamanio = [Enum].GetName(GetType(IPizza.TAMANIO), tamanio).ToLowerInvariant
            Me.Tipo = "A la " & [Enum].GetName(GetType(IPizza.TIPO), tipo).ToLowerInvariant
            Ingredientes = Nothing
        End Sub

        Sub New(
               ByVal c_nombre As String,
               ByVal c_precio As Decimal,
               ByVal tamanio As Byte,
               ByVal tipo As Byte,
               ByVal ParamArray ingredientes As String()
               )
            MyBase.New(c_nombre, c_precio)

            Me.Tamanio = [Enum].GetName(GetType(IPizza.TAMANIO), tamanio).ToLowerInvariant
            Me.Tipo = "A la " & [Enum].GetName(GetType(IPizza.TIPO), tipo).ToLowerInvariant
            Utilitaria.ConvertirArrayDeObjetosHaciaArrayList(ingredientes, Me.Ingredientes)
        End Sub

        Public Overrides Function ToString() As String
            Dim iterador As String
            Dim ingredientes As String = ""

            If (Not IsNothing(Me.Ingredientes)) Then
                For Each iterador In Me.Ingredientes
                    ingredientes &= iterador & ", "
                Next
            End If

            Return (
                vbCrLf & vbCrLf & "Nombre: " & c_nombre & vbCrLf &
                "Precio: " & c_precio & vbCrLf &
                "Descripcion: " & Tipo & vbCrLf &
                "Tamanio: " & Tamanio & vbCrLf &
                "Ingredientes: " & ingredientes
                )
        End Function
    End Class
End Namespace

