Imports System
Imports System.Security.Principal

Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base.Security
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class Updater
    Inherits ModuleUpdater
    Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
        MyBase.New(session, currentDBVersion)
    End Sub
    Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()

        Dim sampleProduct As Product = Session.FindObject(Of Product)(CriteriaOperator.Parse("Name == 'Geitost'"))
        If sampleProduct Is Nothing Then
            sampleProduct = New Product(Session)
            sampleProduct.Name = "Geitost"
            sampleProduct.Price = 2
            sampleProduct.Quantity = 25
            sampleProduct.Save()
        End If

        Dim sampleProduct2 As Product = Session.FindObject(Of Product)(CriteriaOperator.Parse("Name == 'Maxilaku'"))
        If sampleProduct2 Is Nothing Then
            sampleProduct2 = New Product(Session)
            sampleProduct2.Name = "Maxilaku"
            sampleProduct2.Price = 16
            sampleProduct2.Quantity = 40
            sampleProduct2.Save()
        End If

        Dim sampleProduct3 As Product = Session.FindObject(Of Product)(CriteriaOperator.Parse("Name == 'Queso Cabrales'"))
        If sampleProduct3 Is Nothing Then
            sampleProduct3 = New Product(Session)
            sampleProduct3.Name = "Queso Cabrales"
            sampleProduct3.Price = 14
            sampleProduct3.Quantity = 12
            sampleProduct3.Save()
        End If

        Dim sampleProduct4 As Product = Session.FindObject(Of Product)(CriteriaOperator.Parse("Name == 'Ravioli Angelo'"))
        If sampleProduct4 Is Nothing Then
            sampleProduct4 = New Product(Session)
            sampleProduct4.Name = "Ravioli Angelo"
            sampleProduct4.Price = 15.6
            sampleProduct4.Quantity = 15
            sampleProduct4.Save()
        End If

        Dim sampleProduct5 As Product = Session.FindObject(Of Product)(CriteriaOperator.Parse("Name == 'Tofu'"))
        If sampleProduct5 Is Nothing Then
            sampleProduct5 = New Product(Session)
            sampleProduct5.Name = "Tofu"
            sampleProduct5.Price = 18.6
            sampleProduct5.Quantity = 9
            sampleProduct5.Save()
        End If

        Dim sampleCriterion As FilteringCriterion = Session.FindObject(Of FilteringCriterion)(CriteriaOperator.Parse("Description == 'Low on stock'"))
        If sampleCriterion Is Nothing Then
            sampleCriterion = New FilteringCriterion(Session)
            sampleCriterion.Description = "Low on stock"
            sampleCriterion.Criterion = "[Quantity] < 10"
            sampleCriterion.Save()
        End If

        Dim sampleCriterion2 As FilteringCriterion = Session.FindObject(Of FilteringCriterion)(CriteriaOperator.Parse("Description == 'Cheap'"))
        If sampleCriterion2 Is Nothing Then
            sampleCriterion2 = New FilteringCriterion(Session)
            sampleCriterion2.Description = "Cheap"
            sampleCriterion2.Criterion = "[Price] < 5.0"
            sampleCriterion2.Save()
        End If

        Dim sampleCriterion3 As FilteringCriterion = Session.FindObject(Of FilteringCriterion)(CriteriaOperator.Parse("Description == 'Expensive'"))
        If sampleCriterion3 Is Nothing Then
            sampleCriterion3 = New FilteringCriterion(Session)
            sampleCriterion3.Description = "Expensive"
            sampleCriterion3.Criterion = "[Price] > 15.0"
            sampleCriterion3.Save()
        End If

        Dim sampleCriterion4 As FilteringCriterion = Session.FindObject(Of FilteringCriterion)(CriteriaOperator.Parse("Description == 'Overstocked'"))
        If sampleCriterion4 Is Nothing Then
            sampleCriterion4 = New FilteringCriterion(Session)
            sampleCriterion4.Description = "Overstocked"
            sampleCriterion4.Criterion = "[Quantity] > 30"
            sampleCriterion4.Save()
        End If
    End Sub
End Class

