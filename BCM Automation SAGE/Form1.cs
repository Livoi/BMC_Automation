using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BCM_Automation_SAGE.MODULES.CommonFunctions;

namespace BCM_Automation_SAGE
{
    public partial class Form1 : Form
    {
        public static Form1 Self;
        public String SQL = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQL = "SELECT TOP 10 * FROM WIZ_KENS_Order";
            LoadDataGrid(dgItems,SQL,"","");

        }
    }
}
