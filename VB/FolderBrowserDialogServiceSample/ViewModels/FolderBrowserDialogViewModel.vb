Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace FolderBrowserDialogServiceSample.ViewModels

    <POCOViewModel>
    Public Class FolderBrowserDialogViewModel

        Public Overridable Property Description As String

        Public Overridable Property ShowNewFolderButton As Boolean

        Public Overridable Property ResultPath As String

        Protected Overridable ReadOnly Property FolderBrowserDialogService As IFolderBrowserDialogService
            Get
                Return GetService(Of IFolderBrowserDialogService)()
            End Get
        End Property

        Public Sub New()
            ShowNewFolderButton = True
        End Sub

        Public Sub ShowDialog()
            If FolderBrowserDialogService.ShowDialog() Then ResultPath = FolderBrowserDialogService.ResultPath
        End Sub
    End Class
End Namespace
