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
    Public Class MenusController
        Inherits System.Web.Mvc.Controller

        Private db As New DrinksDBContext

        ' GET: Menus
        Function Index() As ActionResult
            Return View(db.Menus.ToList())
        End Function

        ' POST: Menus/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,DrinkName,Price")> ByVal menu As Menu) As ActionResult
            If ModelState.IsValid Then
                db.Entry(menu).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(menu)
        End Function


    End Class
End Namespace
