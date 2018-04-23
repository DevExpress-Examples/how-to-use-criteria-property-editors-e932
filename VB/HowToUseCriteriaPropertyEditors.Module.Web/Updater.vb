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
	End Sub

End Class
