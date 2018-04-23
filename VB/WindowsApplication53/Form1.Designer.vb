Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication53
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.fieldName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.repositoryItemCustomButtonEdit1 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
			Me.fieldValue2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.repositoryItemCustomButtonEdit2 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
			Me.repositoryItemCustomButtonEdit3 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
			Me.repositoryItemCustomButtonEdit4 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCustomButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCustomButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCustomButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCustomButtonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataMember = "Data"
			Me.pivotGridControl1.DataSource = Me.dataSet1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldName, Me.fieldDate, Me.fieldValue, Me.fieldValue2, Me.fieldDate1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox2, Me.repositoryItemCustomButtonEdit1, Me.repositoryItemCustomButtonEdit2, Me.repositoryItemCustomButtonEdit3, Me.repositoryItemCustomButtonEdit4})
			Me.pivotGridControl1.Size = New System.Drawing.Size(796, 292)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomCellEdit += New System.EventHandler(Of DevExpress.XtraPivotGrid.PivotCustomCellEditEventArgs)(Me.pivotGridControl1_CustomCellEdit);
'			Me.pivotGridControl1.CustomExportCell += New System.EventHandler(Of DevExpress.XtraPivotGrid.CustomExportCellEventArgs)(Me.pivotGridControl1_CustomExportCell);
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Data"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Name"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Date"
			Me.dataColumn2.DataType = GetType(System.DateTime)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Value"
			Me.dataColumn3.DataType = GetType(Integer)
			' 
			' fieldName
			' 
			Me.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldName.AreaIndex = 0
			Me.fieldName.FieldName = "Name"
			Me.fieldName.Name = "fieldName"
			Me.fieldName.RowValueLineCount = 3
			' 
			' fieldDate
			' 
			Me.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldDate.AreaIndex = 0
			Me.fieldDate.Caption = "Year"
			Me.fieldDate.FieldName = "Date"
			Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldDate.Name = "fieldDate"
			Me.fieldDate.UnboundFieldName = "fieldDate"
			' 
			' fieldValue
			' 
			Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldValue.AreaIndex = 0
			Me.fieldValue.Caption = "Image+Text"
			Me.fieldValue.CellFormat.FormatString = "C2"
			Me.fieldValue.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldValue.FieldEdit = Me.repositoryItemCustomButtonEdit1
			Me.fieldValue.FieldName = "Value"
			Me.fieldValue.Name = "fieldValue"
			Me.fieldValue.Options.AllowEdit = False
			Me.fieldValue.Options.ShowButtonMode = DevExpress.XtraPivotGrid.PivotShowButtonModeEnum.ShowAlways
			Me.fieldValue.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
			' 
			' repositoryItemCustomButtonEdit1
			' 
			Me.repositoryItemCustomButtonEdit1.AutoHeight = False
			Me.repositoryItemCustomButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemCustomButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.repositoryItemCustomButtonEdit1.DisplayFormat.FormatString = "C2"
			Me.repositoryItemCustomButtonEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.repositoryItemCustomButtonEdit1.Name = "repositoryItemCustomButtonEdit1"
			' 
			' fieldValue2
			' 
			Me.fieldValue2.AreaIndex = 0
			Me.fieldValue2.Name = "fieldValue2"
			' 
			' fieldDate1
			' 
			Me.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldDate1.AreaIndex = 1
			Me.fieldDate1.Caption = "Date"
			Me.fieldDate1.FieldName = "Date"
			Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
			Me.fieldDate1.Name = "fieldDate1"
			Me.fieldDate1.UnboundFieldName = "fieldDate1"
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemImageComboBox2.LargeImages = Me.imageCollection1
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			Me.repositoryItemImageComboBox2.SmallImages = Me.imageCollection1
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.TransparentColor = System.Drawing.Color.Fuchsia
			Me.imageCollection1.Images.SetKeyName(0, "arrowright_green_32.bmp")
			Me.imageCollection1.Images.SetKeyName(1, "arrowright_green_32_d.bmp")
			Me.imageCollection1.Images.SetKeyName(2, "delete_x_32.bmp")
			Me.imageCollection1.Images.SetKeyName(3, "history_32.bmp")
			' 
			' repositoryItemCustomButtonEdit2
			' 
			Me.repositoryItemCustomButtonEdit2.AutoHeight = False
			Me.repositoryItemCustomButtonEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemCustomButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.repositoryItemCustomButtonEdit2.Name = "repositoryItemCustomButtonEdit2"
			' 
			' repositoryItemCustomButtonEdit3
			' 
			Me.repositoryItemCustomButtonEdit3.AutoHeight = False
			Me.repositoryItemCustomButtonEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemCustomButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
			Me.repositoryItemCustomButtonEdit3.Name = "repositoryItemCustomButtonEdit3"
			' 
			' repositoryItemCustomButtonEdit4
			' 
			Me.repositoryItemCustomButtonEdit4.AutoHeight = False
			Me.repositoryItemCustomButtonEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemCustomButtonEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
			Me.repositoryItemCustomButtonEdit4.Name = "repositoryItemCustomButtonEdit4"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(796, 292)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCustomButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCustomButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCustomButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCustomButtonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private fieldName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private repositoryItemCustomButtonEdit1 As RepositoryItemCustomButtonEdit
		Private repositoryItemCustomButtonEdit4 As RepositoryItemCustomButtonEdit
		Private repositoryItemCustomButtonEdit2 As RepositoryItemCustomButtonEdit
		Private repositoryItemCustomButtonEdit3 As RepositoryItemCustomButtonEdit
	End Class
End Namespace

