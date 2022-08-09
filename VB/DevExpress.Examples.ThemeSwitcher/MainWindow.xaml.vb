Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace DevExpress.Examples.ThemeSwitcher

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
            Me.dxGrid.ItemsSource = Tasks
        End Sub

#Region "Data"
        Protected _Tasks As List(Of Task)

        Public ReadOnly Property Tasks As List(Of Task)
            Get
                If _Tasks Is Nothing Then
                    _Tasks = New List(Of Task)()
                    Dim r As Random = New Random()
                    Dim i As Integer = 0
                    While i < 100
                        _Tasks.Add(New Task() With {.Name = String.Format("Task {0}", i), .Priority = If(r.Next(2) > 0, Priority.Important, Priority.NotImportant), .StartDate = Date.Today.AddDays(-r.Next(20)), .FinishDate = Date.Today.AddDays(r.Next(20)), .IsComplete = r.Next(2) > 0})
                        i += 1
                    End While
                End If

                Return _Tasks
            End Get
        End Property

#End Region  ' Data
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ThemeManager.ApplicationThemeName = Theme.DefaultThemeName
        End Sub

        Private Sub cbTheme_EditValueChanged(ByVal sender As Object, ByVal e As Xpf.Editors.EditValueChangedEventArgs)
            ThemeManager.ApplicationThemeName = TryCast(Me.cbTheme.SelectedItem, Theme).Name
        End Sub
    End Class
End Namespace
