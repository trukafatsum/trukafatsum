using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_DataGridView_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal void RestBackColor()
        {
            foreach (var item in flowLayPanelRow.Controls.OfType<UCRow>())
            {
                item.BackColorRow = Color.ForestGreen;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearLoad();
            DataLoad();
        }
        public void DataLoad()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Fullname");
            dt.Columns.Add("Phone");
            dt.Columns.Add("City");
            dt.Columns.Add("Education");
            dt.Columns.Add("Job");

            dt.Rows.Add(new object[] { 1, "Case 1", "202_****", "Ankara", "ODTU", "A" });
            dt.Rows.Add(new object[] { 2, "Case 2", "202_****", "Ankara", "ODTU", "B" });
            dt.Rows.Add(new object[] { 3, "Case 3", "202_****", "Ankara", "ODTU", "C" });
            dt.Rows.Add(new object[] { 4, "Case 4", "202_****", "Ankara", "ODTU", "D" });
            dt.Rows.Add(new object[] { 5, "Case 5", "202_****", "Ankara", "ODTU", "E" });
            dt.Rows.Add(new object[] { 6, "Case 6", "202_****", "Ankara", "ODTU", "F" });
            dt.Rows.Add(new object[] { 7, "Case 7", "202_****", "Ankara", "ODTU", "G" });
            dt.Rows.Add(new object[] { 8, "Case 8", "202_****", "Ankara", "ODTU", "H" });
            dt.Rows.Add(new object[] { 9, "Case 9", "202_****", "Ankara", "ODTU", "I" });
            dt.Rows.Add(new object[] { 10, "Case 10", "202_****", "Ankara", "ODTU", "J" });

            for (int i = 0; i < 10; i++)
            {
                UCRow uCRow = new UCRow();
                uCRow.ID = dt.Rows[i]["ID"].ToString();
                uCRow.FullName = dt.Rows[i]["Fullname"].ToString();
                uCRow.Phone = dt.Rows[i]["Phone"].ToString();
                uCRow.City = dt.Rows[i]["City"].ToString();
                uCRow.Education = dt.Rows[i]["Education"].ToString();
                uCRow.Job = dt.Rows[i]["Job"].ToString();
                uCRow.Width = flowLayPanelRow.Width;
                flowLayPanelRow.Controls.Add(uCRow);
            }
        }
        public void ClearLoad()
        {
            flowLayPanelRow.Controls.Clear();
        }

    }
}
