Imports VisualBasicNETPizzeria.Clases

Module Module1
    Sub Main()
        Dim pizza As New Pizza("Pizza planeta", 100.45, "Mediana", "Cosmica", "Pinia", "Cereza", "Jamon")
        Console.Write(pizza.ToString())
        Console.WriteLine()
        Console.Read()
    End Sub
End Module
