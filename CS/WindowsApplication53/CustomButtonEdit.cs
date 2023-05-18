using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.NativeBricks;

namespace WindowsApplication53
{
    //The attribute that points to the registration method
    [UserRepositoryItem("RegisterCustomButtonEdit")]
    public class RepositoryItemCustomButtonEdit : RepositoryItemButtonEdit
    {
        //The static constructor which calls the registration method
        static RepositoryItemCustomButtonEdit() { RegisterCustomEdit(); }
        //The unique name for the custom editor
        public const string CustomEditName = "CustomButtonEdit";
        //Return the unique name
        public override string EditorTypeName { get { return CustomEditName; } }
        //Register the editor
        public static void RegisterCustomEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(CustomButtonEdit), typeof(RepositoryItemCustomButtonEdit),
              typeof(ButtonEditViewInfo), new ButtonEditPainter(), true));
        }
        //Return custom brick to print image within the cells
        public override VisualBrick GetBrick(PrintCellHelperInfo info)
        {
            TextBrick baseBrick = base.GetBrick(info) as TextBrick;
            if (baseBrick == null) return base.GetBrick(info);
            PanelBrick panelBrick = info.PS.CreateBrick("PanelBrick") as PanelBrick;
            ImageBrick imageBrick = info.PS.CreateBrick("ImageBrick") as ImageBrick;
            panelBrick.Bricks.Add(baseBrick);
            panelBrick.Bricks.Add(imageBrick);
            imageBrick.Padding = new PaddingInfo(2, 2, 5, 5);                        
            imageBrick.Image = this.Buttons[0].Image;
            imageBrick.Sides = BorderSide.None ;
            baseBrick.Sides = BorderSide.None;
            baseBrick.Rect = new System.Drawing.RectangleF(info.Rectangle.Height-6, 0, info.Rectangle.Width - info.Rectangle.Height + 6, info.Rectangle.Height);
            imageBrick.Rect = new System.Drawing.RectangleF(0, 0, info.Rectangle.Height - 6, info.Rectangle.Height);
            return panelBrick;
        }
    }


    public class CustomButtonEdit : ButtonEdit
    {
        //The static constructor which calls the registration method
        static CustomButtonEdit() { RepositoryItemCustomButtonEdit.RegisterCustomEdit(); }
        //Initialize the new instance
        public CustomButtonEdit() { }
        //Return the unique name
        public override string EditorTypeName
        {
            get
            {
                return   RepositoryItemCustomButtonEdit.CustomEditName;
            }
        }
        //Override the Properties property
        //Simply type-cast the object to the custom repository item type
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemCustomButtonEdit; }
        }
        

    }

}
