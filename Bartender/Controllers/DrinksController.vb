Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Bartender

Namespace Controllers
    Public Class DrinksController
        Inherits System.Web.Mvc.Controller

        Private db As New DrinksDBContext

        ' GET: Drinks
        Function Index() As ActionResult
            Return View(db.Drinks.ToList())
        End Function

        ' GET: Drinks/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim drinks As Drinks = db.Drinks.Find(id)
            If IsNothing(drinks) Then
                Return HttpNotFound()
            End If
            Return View(drinks)
        End Function

        ' POST: Drinks/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim drinks As Drinks = db.Drinks.Find(id)
            db.Drinks.Remove(drinks)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function


    End Class
End Namespace
