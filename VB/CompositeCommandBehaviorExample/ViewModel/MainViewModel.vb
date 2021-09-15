Imports System
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports System.Collections.Generic

Namespace CompositeCommandBehaviorExample.ViewModel
	Public Class MainViewModel
		Inherits ViewModelBase

		Protected Sub New()
		End Sub
		Public Shared Function Create() As MainViewModel
			Return ViewModelSource.Create(Function() New MainViewModel())
		End Function

		Public Overridable Property Text() As String
		Public Overridable Property SavedText() As String
		Private ReadOnly Property IsSaved() As Boolean
			Get
				Return SavedText = Text
			End Get
		End Property
		Protected ReadOnly Property MessageService() As IMessageBoxService
			Get
				Return GetService(Of IMessageBoxService)()
			End Get
		End Property

		Public Sub Save()
			SavedText = Text
		End Sub
		Public Function CanSave() As Boolean
			Return Not IsSaved
		End Function
		Public Sub Close()
			If Not IsSaved AndAlso MessageService.ShowMessage("Are you sure to close unsaved document", "Warning", MessageButton.YesNo) = MessageResult.No Then
				Return
			End If
			Text = String.Empty
			SavedText = String.Empty
		End Sub
		Public Function CanClose() As Boolean
			Return Not String.IsNullOrEmpty(Text)
		End Function
	End Class
End Namespace
