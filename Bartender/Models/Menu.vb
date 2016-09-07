Imports System.Data.Entity
Public Class Menu
    Public Property ID() As Integer
    Public Property DrinkName() As String
        Public Property Price() As Decimal

    Public Class DrinksDBContext
        Inherits DbContext
        Public Property Drinks() As DbSet(Of Drinks)
    End Class
End Class
