Imports VisualBasicNETPizzeria.Clases

Module Module1
    Sub Main()
        Dim pizza1 As New Pizza("pizza planeta", 100.45, 8, 0, "pinia", "cereza", "jamon")
        Dim pizza2 As New Pizza("pizza cometa", 89.95, 12, 2)

        Dim pedido1 As New Pedido(Date.Now, "Enrique Ayala", pizza1, pizza2)
        Dim pedido2 As New Pedido("Enrique Ayala", pizza1, pizza2)

        Console.WriteLine(pedido1.ToString())

        'BD.Connect()

        Console.Read()
    End Sub
End Module
