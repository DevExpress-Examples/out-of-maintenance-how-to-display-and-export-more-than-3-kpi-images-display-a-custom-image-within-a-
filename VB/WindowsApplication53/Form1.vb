Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports System.Threading
Imports DevExpress.XtraPrinting.NativeBricks
Imports DevExpress.XtraPrinting

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			repositoryItemCustomButtonEdit1.Buttons(0).Image = imageCollection1.Images(0)
			repositoryItemCustomButtonEdit2.Buttons(0).Image = imageCollection1.Images(1)
			repositoryItemCustomButtonEdit3.Buttons(0).Image = imageCollection1.Images(2)
			repositoryItemCustomButtonEdit4.Buttons(0).Image = imageCollection1.Images(3)
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()

			pivotGridControl1.ShowPrintPreview()
		End Sub


		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today, 0 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(1), 1 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today, 3 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1), 50 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today, 2 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1), 10 })

			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1), 0 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 1 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddYears(1), 2 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 20 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddYears(1), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 30 })
		End Sub

		Private Sub pivotGridControl1_CustomCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomCellEditEventArgs) Handles pivotGridControl1.CustomCellEdit

			If Convert.ToDouble(e.Value) < 10 Then
				e.RepositoryItem = repositoryItemCustomButtonEdit1
			ElseIf Convert.ToDouble(e.Value) < 20 Then
				e.RepositoryItem = repositoryItemCustomButtonEdit2
			ElseIf Convert.ToDouble(e.Value) < 30 Then
				e.RepositoryItem = repositoryItemCustomButtonEdit3
			Else
				e.RepositoryItem = repositoryItemCustomButtonEdit4
			End If
		End Sub

		Private Sub pivotGridControl1_CustomExportCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomExportCellEventArgs) Handles pivotGridControl1.CustomExportCell

		End Sub



	End Class
End Namespace