<!-- default file list -->
*Files to look at*:

* [CustomButtonEdit.cs](./CS/WindowsApplication53/CustomButtonEdit.cs) (VB: [CustomButtonEdit.vb](./VB/WindowsApplication53/CustomButtonEdit.vb))
* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->
# How to display and export more than 3 KPI images ( Display a custom image within a cell )


<p>The easiest way to accomplish this task is to use few different ButonEdits to represent data. You need to hide the editor default button and add an image button instead. Then you can choose which editor to show via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellEdittopic">PivotGridControl.CustomCellEdit</a> event. Finally set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldOptionsEx_ShowButtonModetopic">PivotGridFieldOptionsEx.ShowButtonMode</a> property to <i>ShowAlways</i> to show all buttons by default. </p><p>By default ButtonEdit is not printed with buttons. It is necessary to create a custom ButtonEdit descendant to export a button image.</p>

<br/>


