Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Partial Public Class HowToUseCriteriaPropertyEditorsAspNetApplication
	Inherits WebApplication
	Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
	Private module3 As HowToUseCriteriaPropertyEditors.Module.HowToUseCriteriaPropertyEditorsModule
	Private module4 As HowToUseCriteriaPropertyEditors.Module.Web.HowToUseCriteriaPropertyEditorsAspNetModule
	Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
    Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
	Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule

	Private securitySimple1 As DevExpress.ExpressApp.Security.SecuritySimple
	Private authenticationActiveDirectory1 As DevExpress.ExpressApp.Security.AuthenticationActiveDirectory
	Private sqlConnection1 As System.Data.SqlClient.SqlConnection

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub HowToUseCriteriaPropertyEditorsAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
        If System.Diagnostics.Debugger.IsAttached Then
            e.Updater.Update()
            e.Handled = True
        Else
            Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & _
                "The automatical update is disabled, because the application was started without debugging." & Constants.vbCrLf & _
                "You should start the application under Visual Studio, or modify the source code of the " & _
                "'DatabaseVersionMismatch' event handler to enable automatic database update, " & _
                "or manually create a database with the help of the 'DBUpdater' tool.")
        End If
    End Sub

	Private Sub InitializeComponent()
		Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
		Me.module3 = New HowToUseCriteriaPropertyEditors.Module.HowToUseCriteriaPropertyEditorsModule()
		Me.module4 = New HowToUseCriteriaPropertyEditors.Module.Web.HowToUseCriteriaPropertyEditorsAspNetModule()
		Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
        Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
		Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
		Me.securitySimple1 = New DevExpress.ExpressApp.Security.SecuritySimple()
		Me.authenticationActiveDirectory1 = New DevExpress.ExpressApp.Security.AuthenticationActiveDirectory()
		Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' securitySimple1
		' 
		Me.securitySimple1.Authentication = Me.authenticationActiveDirectory1
		Me.securitySimple1.UserType = GetType(DevExpress.Persistent.BaseImpl.SimpleUser)
		' 
		' authenticationActiveDirectory1
		' 
		Me.authenticationActiveDirectory1.CreateUserAutomatically = True
		Me.authenticationActiveDirectory1.UserType = GetType(DevExpress.Persistent.BaseImpl.SimpleUser)
		' 
		' sqlConnection1
		' 
		Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=HowToUseCriteriaPropertyEditors;Integrated Security=SSPI;Pooling=false"
		Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
		' 
		' HowToUseCriteriaPropertyEditorsAspNetApplication
		' 
		Me.ApplicationName = "HowToUseCriteriaPropertyEditors"
		Me.Connection = Me.sqlConnection1
		Me.Modules.Add(Me.module1)
		Me.Modules.Add(Me.module2)
		Me.Modules.Add(Me.module3)
		Me.Modules.Add(Me.module4)
		Me.Modules.Add(Me.module5)
        Me.Modules.Add(Me.module6)
		Me.Modules.Add(Me.securityModule1)

		Me.Security = Me.securitySimple1
		AddHandler Me.DatabaseVersionMismatch, AddressOf HowToUseCriteriaPropertyEditorsAspNetApplication_DatabaseVersionMismatch
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
End Class

