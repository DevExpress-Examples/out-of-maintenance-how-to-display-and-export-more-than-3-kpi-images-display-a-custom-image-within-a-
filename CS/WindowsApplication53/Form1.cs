using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.Threading;
using DevExpress.XtraPrinting.NativeBricks;
using DevExpress.XtraPrinting;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            repositoryItemCustomButtonEdit1.Buttons[0].Image = imageCollection1.Images[0];
            repositoryItemCustomButtonEdit2.Buttons[0].Image = imageCollection1.Images[1];
            repositoryItemCustomButtonEdit3.Buttons[0].Image = imageCollection1.Images[2];
            repositoryItemCustomButtonEdit4.Buttons[0].Image = imageCollection1.Images[3];
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();

            pivotGridControl1.ShowPrintPreview();
        }


        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today, 0 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 1 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 3 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 50 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 2 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 10 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 0 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 1 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 20 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 30 });
        }

        private void pivotGridControl1_CustomCellEdit(object sender, DevExpress.XtraPivotGrid.PivotCustomCellEditEventArgs e)
        {

            if (Convert.ToDouble(e.Value) < 10)
                e.RepositoryItem = repositoryItemCustomButtonEdit1;
            else if (Convert.ToDouble(e.Value) < 20)
                e.RepositoryItem = repositoryItemCustomButtonEdit2;
            else if (Convert.ToDouble(e.Value) < 30)
                e.RepositoryItem = repositoryItemCustomButtonEdit3;
            else
                e.RepositoryItem = repositoryItemCustomButtonEdit4;
        }

        private void pivotGridControl1_CustomExportCell(object sender, DevExpress.XtraPivotGrid.CustomExportCellEventArgs e)
        {
          
        }

        

    }
}