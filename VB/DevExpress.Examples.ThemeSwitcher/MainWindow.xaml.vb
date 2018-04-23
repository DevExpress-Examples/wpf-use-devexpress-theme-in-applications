Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Utils.Themes
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace DevExpress.Examples.ThemeSwitcher
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXWindow

		Public Sub New()
			InitializeComponent()
			Me.dxGrid.ItemsSource = Me.Tasks
		End Sub

		#Region "Data"

		Protected _Tasks As List(Of Task)

		Public ReadOnly Property Tasks() As List(Of Task)
			Get
				If Me._Tasks Is Nothing Then
					Me._Tasks = New List(Of Task)()
					Dim r As New Random()
					Dim i As Integer = 0
					Do While i < 100
						Me._Tasks.Add(New Task() With {.Name = String.Format("Task {0}", i), .Priority = If(r.Next(2) > 0, Priority.Important, Priority.NotImportant), .StartDate = DateTime.Today.AddDays(-r.Next(20)), .FinishDate = DateTime.Today.AddDays(r.Next(20)), .IsComplete = r.Next(2) > 0})
						i += 1
					Loop
				End If

				Return Me._Tasks
			End Get
		End Property

		#End Region ' Data

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			ThemeManager.ApplicationThemeName = Theme.DefaultThemeName
		End Sub

		Private Sub cbTheme_EditValueChanged(ByVal sender As Object, ByVal e As Xpf.Editors.EditValueChangedEventArgs)
			ThemeManager.ApplicationThemeName = (TryCast(Me.cbTheme.SelectedItem, Theme)).Name
		End Sub

	End Class
End Namespace
