Imports System
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace CompositeCommandBehaviorExample.ViewModel

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Overridable Property Text As String

        Public Overridable Property SavedText As String

        Private ReadOnly Property IsSaved As Boolean
            Get
                Return Equals(SavedText, Text)
            End Get
        End Property

        Protected ReadOnly Property MessageService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property

        <Command>
        Public Sub Save()
            SavedText = Text
        End Sub

        Public Function CanSave() As Boolean
            Return Not IsSaved
        End Function

        <Command>
        Public Sub Close()
            If Not IsSaved AndAlso MessageService.ShowMessage("Do you want to close the document and lost unsaved changes?", "Warning", MessageButton.YesNo) Is MessageResult.No Then Return
            Text = [String].Empty
            SavedText = [String].Empty
        End Sub

        Public Function CanClose() As Boolean
            Return Not [String].IsNullOrEmpty(Text)
        End Function
    End Class
End Namespace
