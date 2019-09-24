using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remax_Project.Business;
using System.Data.OleDb;

namespace Remax_Project.GUI
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        DataTable tbHouses, tbAgents;

        private void frmUser_Load(object sender, EventArgs e)
        {
            

            clsGlobal.mySet = new DataSet();
            clsGlobal.myCon = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\jproc\Documents\LaSalle\Fourth Semester\Java\Remax_Project\Remax_Project\bin\Debug\Data\RemaxDatabaseforFinal.mdb");
            clsGlobal.myCon.Open();        

            //tbAgents = clsGlobal.mySet.Tables["Agent"];
            //tbHouses = clsGlobal.mySet.Tables["House"];

            OleDbCommand cmdHouses = new OleDbCommand("SELECT * FROM House", clsGlobal.myCon);
            OleDbDataReader readHouses = cmdHouses.ExecuteReader();
            DataTable tmp = new DataTable();
            tmp.Load(readHouses);
            gridHouses.DataSource = tmp;

            OleDbCommand myCmd = new OleDbCommand("SELECT EmpId FROM Agent", clsGlobal.myCon);
            OleDbDataReader myReader = myCmd.ExecuteReader();
            while (myReader.Read())
            {
                cboAgent.Items.Add(myReader["EmpId"]);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (radEmployeeId.Checked)
            {
                //OleDbCommand cmdFilterEmp = new OleDbCommand("SELECT * FROM House WHERE EmpId = '" + Convert.ToInt32(cboAgent.SelectedItem) + "'", clsGlobal.myCon);
                //OleDbDataReader readFilterEmp = cmdFilterEmp.ExecuteReader();
                DataRow[] Results = tbHouses.Select("EmpId =" + Convert.ToInt32(cboAgent.SelectedValue));
                gridHouses.DataSource = Results.CopyToDataTable();
            }
            if (radRefNumber.Checked)
            {
                DataRow[] Results = tbHouses.Select("HouseId" + Convert.ToSingle(txtRefNumber.Text));
                gridHouses.DataSource = Results.CopyToDataTable();
            }
        }
    }
}
