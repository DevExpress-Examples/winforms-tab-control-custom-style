Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.Drawing

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            Call PaintStyleCollection.DefaultPaintStyles.Add(New MyRegistrator())
            xtraTabControl1.PaintStyleName = "MyStyle"
        End Sub
    End Class
End Namespace
