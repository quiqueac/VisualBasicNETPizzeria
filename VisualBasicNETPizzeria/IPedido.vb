Public Interface IPedido
    Inherits IDocumento

    ReadOnly Property IVA() As Decimal

    Sub CalcularTotalItems()
    Sub Cancelar()
    Sub Confirmar()
    Sub Facturar()
    Sub Terminar(ByVal c_fecha_entrega As Date)
End Interface
