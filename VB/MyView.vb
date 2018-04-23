Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace CustomView

	Public Class MyViewInfoRegistrator
		Inherits DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyView"
			End Get
		End Property

		Private groupHeight_Renamed As Integer = 0
		Public Property GroupHeight() As Integer
			Get
				Return groupHeight_Renamed
			End Get
			Set(ByVal value As Integer)
				groupHeight_Renamed = value
			End Set
		End Property
		Public Overrides Function CreateGroupPainter(ByVal navBar As NavBarControl) As BaseNavGroupPainter
			Return New MyViewNavBarGroupPainter(navBar)
		End Function
	End Class

	Public Class MyViewNavBarGroupPainter
		Inherits DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneGroupPainter
		Public Sub New(ByVal navBar As NavBarControl)
			MyBase.New(navBar)
		End Sub

		Public Overrides Overloads Function CalcObjectMinBounds(ByVal e As ObjectInfoArgs) As Rectangle
			Dim rect As Rectangle = MyBase.CalcObjectMinBounds(e)
			Dim view As MyViewInfoRegistrator = TryCast(NavBar.View, MyViewInfoRegistrator)
			rect.Height = view.GroupHeight
			Return rect
		End Function
	End Class
End Namespace
