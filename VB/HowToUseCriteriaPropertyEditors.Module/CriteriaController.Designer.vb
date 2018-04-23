Imports Microsoft.VisualBasic
Imports System
Namespace HowToUseCriteriaPropertyEditors.Module
	Partial Public Class CriteriaController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.FilteringCriterionAction = New DevExpress.ExpressApp.Actions.SingleChoiceAction(Me.components)
			' 
			' FilteringCriterionAction
			' 
			Me.FilteringCriterionAction.Caption = "Filtering Criterion"
			Me.FilteringCriterionAction.Id = "FilteringCriterionAction"
'			Me.FilteringCriterionAction.Execute += New DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(Me.FilteringCriterionAction_Execute);
			' 
			' CriteriaController
			' 
			Me.TargetViewId = "Product_ListView"
'			Me.Activated += New System.EventHandler(Me.CriteriaController_Activated);

		End Sub

		#End Region

		Private WithEvents FilteringCriterionAction As DevExpress.ExpressApp.Actions.SingleChoiceAction
	End Class
End Namespace
