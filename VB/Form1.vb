Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraNavBar

Namespace CustomView
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private navBarControl1 As NavBarControl
		Private navBarGroup1 As NavBarGroup
		Private navBarGroup2 As NavBarGroup
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2})
			Me.navBarControl1.Location = New System.Drawing.Point(216, 12)
			Me.navBarControl1.LookAndFeel.SkinName = "Blue"
			Me.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 190
			Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
			Me.navBarControl1.Size = New System.Drawing.Size(246, 404)
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 1
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "navBarGroup1"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "navBarGroup2"
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
			Me.ClientSize = New System.Drawing.Size(686, 446)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim viewInfoRegistrator As New MyViewInfoRegistrator()
			viewInfoRegistrator.GroupHeight = 100
			navBarControl1.View = viewInfoRegistrator
		End Sub


	End Class
End Namespace
