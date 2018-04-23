Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Data.Filtering

Namespace HowToUseCriteriaPropertyEditors.Module
    Partial Public Class CriteriaController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub
        Private Sub CriteriaController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            FilteringCriterionAction.Items.Clear()
            FilteringCriterionAction.Items.Add(New ChoiceActionItem("All the products", Nothing))
            For Each criterion As FilteringCriterion In (TryCast(View, ListView)).ObjectSpace.GetObjects(Of FilteringCriterion)(Nothing)
                FilteringCriterionAction.Items.Add(New ChoiceActionItem(criterion.Description, criterion.Criterion))
            Next criterion
            FilteringCriterionAction.SelectedIndex = 0
        End Sub
        Private Sub FilteringCriterionAction_Execute(ByVal sender As Object, ByVal e As SingleChoiceActionExecuteEventArgs) Handles FilteringCriterionAction.Execute
            TryCast(View, ListView).CollectionSource.Criteria.Clear()
            TryCast(View, ListView).CollectionSource.Criteria(e.SelectedChoiceActionItem.Caption) = CriteriaEditorHelper.GetCriteriaOperator(TryCast(e.SelectedChoiceActionItem.Data, String), GetType(Product), View.ObjectSpace)
        End Sub
    End Class
End Namespace
