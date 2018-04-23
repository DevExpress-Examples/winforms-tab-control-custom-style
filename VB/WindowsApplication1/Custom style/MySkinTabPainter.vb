Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.Drawing
Imports DevExpress.XtraTab
Imports DevExpress.Utils
Imports DevExpress.XtraTab.ViewInfo

Namespace WindowsApplication1
	Public Class MySkinTabPainter
		Inherits SkinTabPainter

		Public Sub New(ByVal tabControl As DevExpress.XtraTab.IXtraTab)
			MyBase.New(tabControl)

		End Sub

		Protected Overrides Sub DrawHeader(ByVal e As TabDrawArgs)
			MyBase.DrawHeader(e)
			Dim bounds As Rectangle = e.Bounds
			Dim headerText As String = "----------------------- Custom draw header -----------------------"
			e.Graphics.DrawString(headerText, New Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Bold), Brushes.Black, bounds)
			bounds.Offset(-2, -2)
			e.Graphics.DrawString(headerText, New Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Bold), Brushes.White, bounds)
			For Each rowInfo As BaseTabRowViewInfo In e.ViewInfo.HeaderInfo.Rows
				For i As Integer = 0 To rowInfo.Pages.Count - 1
					Dim pageBounds As Rectangle = rowInfo.Pages(i).Bounds
					pageBounds.Offset(0, 20)
					e.Graphics.DrawString(Environment.NewLine & "Custom draw", AppearanceObject.DefaultFont, Brushes.Black, pageBounds)
					pageBounds.Offset(-1, -1)
					e.Graphics.DrawString(Environment.NewLine & "Custom draw", AppearanceObject.DefaultFont, Brushes.Yellow, pageBounds)
				Next i
			Next rowInfo

		End Sub

	End Class
End Namespace
