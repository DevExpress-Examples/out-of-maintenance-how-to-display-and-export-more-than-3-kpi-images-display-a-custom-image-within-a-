Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports System.ComponentModel
Imports DevExpress.XtraPrinting

Namespace WindowsApplication53

    'The attribute that points to the registration method
    <UserRepositoryItem("RegisterCustomButtonEdit")>
    Public Class RepositoryItemCustomButtonEdit
        Inherits RepositoryItemButtonEdit

        'The static constructor which calls the registration method
        Shared Sub New()
            Call RegisterCustomEdit()
        End Sub

        'The unique name for the custom editor
        Public Const CustomEditName As String = "CustomButtonEdit"

        'Return the unique name
        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return CustomEditName
            End Get
        End Property

        'Register the editor
        Public Shared Sub RegisterCustomEdit()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomButtonEdit), GetType(RepositoryItemCustomButtonEdit), GetType(ButtonEditViewInfo), New ButtonEditPainter(), True))
        End Sub

        'Return custom brick to print image within the cells
        Public Overrides Function GetBrick(ByVal info As PrintCellHelperInfo) As IVisualBrick
            Dim baseBrick As TextBrick = TryCast(MyBase.GetBrick(info), TextBrick)
            If baseBrick Is Nothing Then Return MyBase.GetBrick(info)
            Dim panelBrick As IPanelBrick = info.PS.CreatePanelBrick()
            Dim imageBrick As IImageBrick = info.PS.CreateImageBrick()
            panelBrick.Bricks.Add(baseBrick)
            panelBrick.Bricks.Add(imageBrick)
            imageBrick.Padding = New PaddingInfo(2, 2, 5, 5)
            imageBrick.Image = Buttons(0).Image
            imageBrick.Sides = BorderSide.None
            baseBrick.Sides = BorderSide.None
            baseBrick.Rect = New System.Drawing.RectangleF(info.Rectangle.Height - 6, 0, info.Rectangle.Width - info.Rectangle.Height + 6, info.Rectangle.Height)
            imageBrick.Rect = New System.Drawing.RectangleF(0, 0, info.Rectangle.Height - 6, info.Rectangle.Height)
            Return panelBrick
        End Function
    End Class

    Public Class CustomButtonEdit
        Inherits ButtonEdit

        'The static constructor which calls the registration method
        Shared Sub New()
            RepositoryItemCustomButtonEdit.RegisterCustomEdit()
        End Sub

        'Initialize the new instance
        Public Sub New()
        End Sub

        'Return the unique name
        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemCustomButtonEdit.CustomEditName
            End Get
        End Property

        'Override the Properties property
        'Simply type-cast the object to the custom repository item type
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemCustomButtonEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomButtonEdit)
            End Get
        End Property
    End Class
End Namespace
