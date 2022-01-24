Namespace Clases
    Public NotInheritable Class Pizza
        Inherits Producto

        Public ReadOnly Property Tamanio() As String
        Public ReadOnly Property Tipo() As String
        Public ReadOnly Property Ingredientes() As ArrayList

        ''' <summary>
        ''' Constructor para una pizza que no recibe ingredientes
        ''' </summary>
        ''' <param name="c_nombre"></param>
        ''' <param name="c_precio"></param>
        ''' <param name="tamanio"></param>
        ''' <param name="tipo"></param>
        Sub New(
               ByVal c_nombre As String,
               ByVal c_precio As Decimal,
               ByVal tamanio As Byte,
               ByVal tipo As Byte
               )
            MyBase.New(c_nombre, c_precio)

            Me.Tamanio = tamanio
            Me.Tipo = "A la " & tipo
            Ingredientes = Nothing
        End Sub

        ''' <summary>
        ''' Constructor para una pizza que recibe ingredientes
        ''' </summary>
        ''' <param name="c_nombre"></param>
        ''' <param name="c_precio"></param>
        ''' <param name="tamanio"></param>
        ''' <param name="tipo"></param>
        ''' <param name="ingredientes"></param>
        Sub New(
               ByVal c_nombre As String,
               ByVal c_precio As Decimal,
               ByVal tamanio As Byte,
               ByVal tipo As Byte,
               ByVal ParamArray ingredientes As String()
               )
            MyBase.New(c_nombre, c_precio)

            Me.Tamanio = tamanio
            Me.Tipo = "A la " & tipo
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

