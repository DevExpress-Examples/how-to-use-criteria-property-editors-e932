Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Editors

Namespace HowToUseCriteriaPropertyEditors.Module
    <DefaultClassOptions, ImageName("Action_Filter")> _
    Public Class FilteringCriterion
        Inherits BaseObject
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Description() As String
            Get
                Return GetDelayedPropertyValue(Of String)("Description")
            End Get
            Set(ByVal value As String)
                SetDelayedPropertyValue(Of String)("Description", value)
            End Set
        End Property
        Private ReadOnly Property ObjectType() As Type
            Get
                Return GetType(Product)
            End Get
        End Property
        <CriteriaObjectTypeMember("ObjectType"), Size(-1), ImmediatePostData> _
        Public Property Criterion() As String
            Get
                Return GetPropertyValue(Of String)("Criterion")
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Criterion", value)
            End Set
        End Property
        Public ReadOnly Property CriterionString() As String
            Get
                Return Criterion
            End Get
        End Property
    End Class
End Namespace
