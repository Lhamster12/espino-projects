Namespace midterm_project
    Public Class CartItem
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Quantity As Integer
        Public Property Total As Decimal

        Public Sub New(ByVal Name As String, ByVal Price As Decimal, ByVal Quantity As Integer)
            Me.Name = Name
            Me.Price = Price
            Me.Quantity = Quantity
            Me.Total = Price * Quantity
        End Sub
    End Class
End Namespace
