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
    public partial class UCRow : UserControl
    {
        Form1 master = (Form1)Application.OpenForms["Form1"];
        public UCRow()
        {
            InitializeComponent();
        }
        public string ID
        { 
          get { return lblID.Text; }
          set { lblID.Text = value; }
        }

        public string FullName
        { 
          get { return lblFullName.Text; } 
          set { lblFullName.Text = value; } 
        }

        public string Phone
        { 
          get { return lblPhone.Text; } 
          set { lblPhone.Text = value; } 
        }

        public string City
        { 
          get { return lblCity.Text; }
          set {lblCity.Text = value;}
        }

        public string Education
        {
            get { return lblEducation.Text;}
            set {lblEducation.Text = value;}
        }

        public string Job
        { 
            get { return lblJob.Text; }
            set { lblJob.Text = value; }
        }

        public Color BackColorRow
        {
            get 
            {
                return tabLayPanelTitle.BackColor;
            }
            set 
            { 
                tabLayPanelTitle.BackColor = value;
            }
        }

        private void panelTitle_MouseClick(object sender, MouseEventArgs e)
        {
            master.RestBackColor();
            tabLayPanelTitle.BackColor = Color.DarkSeaGreen;
        }
    }
}
