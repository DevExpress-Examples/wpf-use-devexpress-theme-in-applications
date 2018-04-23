Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DevExpress.Examples.ThemeSwitcher

	Public Enum Priority
		Important
		NotImportant
	End Enum

	Public Class Task
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property

		Private privateStartDate As DateTime
		Public Property StartDate() As DateTime
			Get
				Return privateStartDate
			End Get
			Set(ByVal value As DateTime)
				privateStartDate = value
			End Set
		End Property

		Private privateFinishDate As DateTime
		Public Property FinishDate() As DateTime
			Get
				Return privateFinishDate
			End Get
			Set(ByVal value As DateTime)
				privateFinishDate = value
			End Set
		End Property

		Private privateIsComplete As Boolean
		Public Property IsComplete() As Boolean
			Get
				Return privateIsComplete
			End Get
			Set(ByVal value As Boolean)
				privateIsComplete = value
			End Set
		End Property

		Private privatePriority As Priority
		Public Property Priority() As Priority
			Get
				Return privatePriority
			End Get
			Set(ByVal value As Priority)
				privatePriority = value
			End Set
		End Property
	End Class
End Namespace
