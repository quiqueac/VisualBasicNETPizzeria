Namespace Clases
    Public NotInheritable Class Pizza
        Inherits Producto

        Private ReadOnly c_tamanio As String
        Private ReadOnly c_descripcion As String
        Private ReadOnly c_ingredientes As ArrayList

        Sub New(ByVal c_nombre As String, ByVal c_precio As Decimal)
            MyBase.New(c_nombre, c_precio)
            c_tamanio = "Unica presentacion"
            c_descripcion = "Deliciosa pizza"
            c_ingredientes = Nothing
        End Sub

        Sub New(ByVal c_nombre As String, ByVal c_precio As Decimal, ByVal c_tamanio As String)
            MyBase.New(c_nombre, c_precio)
            Me.c_tamanio = c_tamanio
            c_descripcion = "Deliciosa pizza"
            c_ingredientes = Nothing
        End Sub

        Sub New(ByVal c_nombre As String, ByVal c_precio As Decimal, ByVal c_tamanio As String, ByVal c_descripcion As String)
            MyBase.New(c_nombre, c_precio)
            Me.c_tamanio = c_tamanio
            Me.c_descripcion = c_descripcion
            c_ingredientes = Nothing
        End Sub

        Sub New(ByVal c_nombre As String, ByVal c_precio As Decimal, ByVal c_tamanio As String, ByVal c_descripcion As String, ByVal ParamArray ingredientes As String())
            MyBase.New(c_nombre, c_precio)
            Me.c_tamanio = c_tamanio
            Me.c_descripcion = c_descripcion
            LlenarListaDeIngredientes(ingredientes, c_ingredientes)
        End Sub

        ''' <summary>
        ''' Agrega los ingredientes en un ArrayList
        ''' <param name="ingredientes"></param>
        ''' <param name="c_ingredientes"></param>
        ''' </summary>
        Private Sub LlenarListaDeIngredientes(ByVal ingredientes As String(), ByRef c_ingredientes As ArrayList)
            ' Funcionamiento: 1. Se calcula el tamanio del array de String 'ingredientes' y se guarda en 'numero_ingredientes'
            '                 2. Se inicializa el ArrayList 'c_ingredientes' con la dimension calculada en 'numero_ingredientes'
            '                 3. Se usa un For Each para guardar en el ArrayList los ingredientes

            Dim numero_ingredientes As Byte

            Try
                numero_ingredientes = UBound(ingredientes) + 1

                If (numero_ingredientes = -1) Then
                    Console.WriteLine("El arreglo de String 'ingredientes' no tiene elementos")
                Else
                    c_ingredientes = ArrayList.Repeat("", numero_ingredientes)

                    For index As Byte = 0 To numero_ingredientes - 1
                        c_ingredientes.Insert(index, ingredientes(index))
                    Next
                End If
            Catch ex As ArgumentNullException
                Console.WriteLine("El arreglo de String 'ingredientes' es Nothing")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Public ReadOnly Property Tamanio() As String
            Get
                Return c_tamanio
            End Get
        End Property
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

        Public Overrides Function ToString() As String
            Dim iterador As String
            Dim ingredientes As String = ""

            For Each iterador In c_ingredientes
                ingredientes &= iterador & " "
            Next

            Return "Nombre: " & c_nombre & vbCrLf & "Precio: " & c_precio & vbCrLf & "Descripcion: " & c_descripcion & vbCrLf & "Tamanio: " & c_tamanio & vbCrLf & "Ingredientes: " & ingredientes
        End Function
    End Class
End Namespace

