Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace FolderBrowserDialogServiceSample.ViewModel

    Public Class FolderBrowserDialogViewModel
        Inherits ViewModelBase

        Public Property Description As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property ShowNewFolderButton As Boolean
            Get
                Return GetValue(Of Boolean)()
            End Get

            Set(ByVal value As Boolean)
                SetValue(value)
            End Set
        End Property

        Public Property ResultPath As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public ReadOnly Property FolderBrowserDialogService As IFolderBrowserDialogService
            Get
                Return GetService(Of IFolderBrowserDialogService)()
            End Get
        End Property

        Public Sub New()
            ShowNewFolderButton = True
        End Sub

        <Command>
        Public Sub ShowDialog()
            If FolderBrowserDialogService.ShowDialog() Then ResultPath = FolderBrowserDialogService.ResultPath
        End Sub
    End Class
End Namespace
