Namespace Clases
    Public Class Utilitaria

        ''' <summary>
        ''' Agrega los String en un ArrayList
        ''' <param name="arreglo_objetos"></param>
        ''' <param name="array_list"></param>
        ''' </summary>
        Shared Sub ConvertirArrayDeObjetosHaciaArrayList(
                                                       ByVal arreglo_objetos() As Object,
                                                       ByRef array_list As ArrayList
                                                       )
            Dim numero_objetos As Byte = UBound(arreglo_objetos) + 1

            If (Not numero_objetos = -1) Then
                array_list = ArrayList.Repeat("", 0)

                For index As Byte = 0 To numero_objetos - 1
                    array_list.Insert(index, arreglo_objetos(index))
                Next
            End If
        End Sub
    End Class
End Namespace
