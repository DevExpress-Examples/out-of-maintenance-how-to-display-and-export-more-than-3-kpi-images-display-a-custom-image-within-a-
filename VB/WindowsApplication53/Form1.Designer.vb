Namespace WindowsApplication53

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim editorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowsApplication53.Form1))
            Dim editorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim editorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim editorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.fieldName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.repositoryItemCustomButtonEdit1 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
            Me.fieldValue2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.repositoryItemCustomButtonEdit2 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
            Me.repositoryItemCustomButtonEdit3 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
            Me.repositoryItemCustomButtonEdit4 = New WindowsApplication53.RepositoryItemCustomButtonEdit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCustomButtonEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCustomButtonEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCustomButtonEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCustomButtonEdit4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldName1, Me.fieldDate2, Me.fieldValue1, Me.fieldValue2, Me.fieldDate})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox2, Me.repositoryItemCustomButtonEdit1, Me.repositoryItemCustomButtonEdit2, Me.repositoryItemCustomButtonEdit3, Me.repositoryItemCustomButtonEdit4})
            Me.pivotGridControl1.Size = New System.Drawing.Size(796, 292)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.CustomCellEdit, New System.EventHandler(Of DevExpress.XtraPivotGrid.PivotCustomCellEditEventArgs)(AddressOf Me.pivotGridControl1_CustomCellEdit)
            AddHandler Me.pivotGridControl1.CustomExportCell, New System.EventHandler(Of DevExpress.XtraPivotGrid.CustomExportCellEventArgs)(AddressOf Me.pivotGridControl1_CustomExportCell)
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
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
            ' fieldName1
            ' 
            Me.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName1.AreaIndex = 0
            dataSourceColumnBinding1.ColumnName = "Name"
            Me.fieldName1.DataBinding = dataSourceColumnBinding1
            Me.fieldName1.Name = "fieldName1"
            Me.fieldName1.RowValueLineCount = 3
            ' 
            ' fieldDate2
            ' 
            Me.fieldDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate2.AreaIndex = 0
            Me.fieldDate2.Caption = "Year"
            dataSourceColumnBinding2.ColumnName = "Date"
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldDate2.DataBinding = dataSourceColumnBinding2
            Me.fieldDate2.Name = "fieldDate2"
            ' 
            ' fieldValue1
            ' 
            Me.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue1.AreaIndex = 0
            Me.fieldValue1.Caption = "Image+Text"
            Me.fieldValue1.CellFormat.FormatString = "C2"
            Me.fieldValue1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            dataSourceColumnBinding3.ColumnName = "Value"
            Me.fieldValue1.DataBinding = dataSourceColumnBinding3
            Me.fieldValue1.FieldEdit = Me.repositoryItemCustomButtonEdit1
            Me.fieldValue1.Name = "fieldValue1"
            Me.fieldValue1.Options.AllowEdit = False
            Me.fieldValue1.Options.ShowButtonMode = DevExpress.XtraPivotGrid.PivotShowButtonModeEnum.ShowAlways
            ' 
            ' repositoryItemCustomButtonEdit1
            ' 
            Me.repositoryItemCustomButtonEdit1.AutoHeight = False
            Me.repositoryItemCustomButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemCustomButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, editorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.repositoryItemCustomButtonEdit1.DisplayFormat.FormatString = "C2"
            Me.repositoryItemCustomButtonEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemCustomButtonEdit1.Name = "repositoryItemCustomButtonEdit1"
            ' 
            ' fieldValue2
            ' 
            Me.fieldValue2.AreaIndex = 0
            Me.fieldValue2.Name = "fieldValue2"
            ' 
            ' fieldDate
            ' 
            Me.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate.AreaIndex = 1
            Me.fieldDate.Caption = "Date"
            dataSourceColumnBinding4.ColumnName = "Date"
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
            Me.fieldDate.DataBinding = dataSourceColumnBinding4
            Me.fieldDate.Name = "fieldDate"
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
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
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
            Me.repositoryItemCustomButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, editorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.repositoryItemCustomButtonEdit2.Name = "repositoryItemCustomButtonEdit2"
            ' 
            ' repositoryItemCustomButtonEdit3
            ' 
            Me.repositoryItemCustomButtonEdit3.AutoHeight = False
            Me.repositoryItemCustomButtonEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemCustomButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, editorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.repositoryItemCustomButtonEdit3.Name = "repositoryItemCustomButtonEdit3"
            ' 
            ' repositoryItemCustomButtonEdit4
            ' 
            Me.repositoryItemCustomButtonEdit4.AutoHeight = False
            Me.repositoryItemCustomButtonEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemCustomButtonEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, editorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
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
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCustomButtonEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCustomButtonEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCustomButtonEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCustomButtonEdit4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private fieldName1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDate2 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldValue2 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField

        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private repositoryItemCustomButtonEdit1 As WindowsApplication53.RepositoryItemCustomButtonEdit

        Private repositoryItemCustomButtonEdit4 As WindowsApplication53.RepositoryItemCustomButtonEdit

        Private repositoryItemCustomButtonEdit2 As WindowsApplication53.RepositoryItemCustomButtonEdit

        Private repositoryItemCustomButtonEdit3 As WindowsApplication53.RepositoryItemCustomButtonEdit
    End Class
End Namespace
