Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Imports DevExpress.ExpressApp.Editors

Public Class CriteriaController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

	End Sub

    Private Sub FilteringCriterionAction_Execute(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventArgs) Handles FilteringCriterionAction.Execute
        TryCast(View, ListView).CollectionSource.Criteria.Clear()
        TryCast(View, ListView).CollectionSource.Criteria(e.SelectedChoiceActionItem.Caption) = _
           CriteriaEditorHelper.GetCriteriaOperator(TryCast(e.SelectedChoiceActionItem.Data, String), GetType(Product), View.ObjectSpace)
    End Sub

    Private Sub CriteriaController_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FilteringCriterionAction.Items.Clear()
        FilteringCriterionAction.Items.Add(New ChoiceActionItem("All the products", Nothing))
        For Each criterion As FilteringCriterion In (TryCast(View, ListView)).ObjectSpace.GetObjects(Of FilteringCriterion)(Nothing)
            FilteringCriterionAction.Items.Add(New ChoiceActionItem(criterion.Description, criterion.Criterion))
        Next criterion
        FilteringCriterionAction.SelectedIndex = 0
    End Sub

End Class
