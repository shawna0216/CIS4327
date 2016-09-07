Imports System.Data.Entity

Public Class Drinks
    Public Property ID() As Integer
    Public Property CustomerName As String
    Public Property DrinkName() As String
    Public Property Price() As Decimal
    End Class

    Public Class DrinksDBContext
        Inherits DbContext
    Public Property Drinks() As DbSet(Of Drinks)
    Public Property Menus As System.Data.Entity.DbSet(Of Menu)
End Class