using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Remax_Project.Business;

namespace Remax_Project.GUI
{
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }
        DataTable tbAgents, tbHouses, tbBuyers, tbSellers;
        int current;
        void fill2Buyer()
        {
            OleDbCommand cmdBuyers = new OleDbCommand("SELECT * FROM Buyer WHERE EmpId = '" + txtUserId.Text + "'", clsGlobal.myCon);
            OleDbDataReader readBuyers = cmdBuyers.ExecuteReader();
            if (readBuyers.Read())
            {
                txtBuyerId.Text = readBuyers["BuyerId"].ToString();
                txtBuyerName.Text = readBuyers["BuyerName"].ToString();
                txtBEmail.Text = readBuyers["Email"].ToString();
                txtBPhoneNumber.Text = readBuyers["PhoneNumber"].ToString();
                txtBirthdate.Text = readBuyers["Birthdate"].ToString();
            }
            readBuyers.Close();
        }
        void fill2House()
        {
            OleDbCommand cmdHouses = new OleDbCommand("SELECT * FROM House WHERE EmpId = '" + txtUserId.Text + "'", clsGlobal.myCon);
            OleDbDataReader readHouses = cmdHouses.ExecuteReader();
            if (readHouses.Read())
            {
                txtHouseId.Text = readHouses["HouseId"].ToString();
                txtAddress.Text = readHouses["Address"].ToString();
                txtLocation.Text = readHouses["Location"].ToString();
                txtPrice.Text = readHouses["Price"].ToString();
                txtSize.Text = readHouses["Size"].ToString();
            }
            readHouses.Close();
        }
        void fill2Seller()
        {
            OleDbCommand cmdSellers = new OleDbCommand("SELECT * FROM Seller WHERE EmpId = '" + txtUserId.Text + "'", clsGlobal.myCon);
            OleDbDataReader readSellers = cmdSellers.ExecuteReader();
            if (readSellers.Read())
            {
                txtSellerId.Text = readSellers["SellerId"].ToString();
                txtSellerName.Text = readSellers["SellerName"].ToString();
                txtSEmail.Text = readSellers["Email"].ToString();
                txtPhoneNumber.Text = readSellers["PhoneNumber"].ToString();
                txtSHouseId.Text = readSellers["HouseId"].ToString();
            }
            readSellers.Close();
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            clsGlobal.mySet = new DataSet();
            clsGlobal.myCon = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\jproc\Documents\LaSalle\Fourth Semester\Java\Remax_Project\Remax_Project\bin\Debug\Data\RemaxDatabaseforFinal.mdb");
            clsGlobal.myCon.Open();
            tbAgents = clsGlobal.mySet.Tables["Agent"];
            tbBuyers = clsGlobal.mySet.Tables["Buyer"];
            tbHouses = clsGlobal.mySet.Tables["House"];
            tbSellers = clsGlobal.mySet.Tables["Seller"];

            cbo2txt();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cmdText = "select Count(*) from Agent where EmpId='" + txtUserId.Text + "' and [Password]='" + txtPassword.Text + "'";
            using (OleDbCommand cmd = new OleDbCommand(cmdText, clsGlobal.myCon))
            {
                //clsGlobal.myCon.Open();
                cmd.Parameters.AddWithValue("@p1", txtUserId.Text);
                cmd.Parameters.AddWithValue("@p2", txtPassword.Text);  // <- is this a variable or a textbox?
                int result = (int)cmd.ExecuteScalar();
                if (result == 1)
                {
                    grid2txt();
                    fill2House();
                    fill2Buyer();
                    fill2Seller();
                }              
                else
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
            }
        }

        private void cboSelectHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmdHousesTxt = new OleDbCommand("SELECT HouseId, Location, Address, Price, Size FROM House WHERE EmpId = '" + cboSelectHouse.SelectedItem.ToString() + "'", clsGlobal.myCon);
          
            OleDbDataReader readHouses = cmdHousesTxt.ExecuteReader();

            if (readHouses.Read())
            {
                txtHouseId.Text = readHouses["HouseId"].ToString();
                txtAddress.Text = readHouses["Address"].ToString();
                txtLocation.Text = readHouses["Location"].ToString();
                txtPrice.Text = readHouses["Price"].ToString();
                txtSize.Text = readHouses["Size"].ToString();
            }
            readHouses.Close();
        }

        public static bool CheckLogin(string UserName, string UserPass)
        {
            string selectString =
         "SELECT EmpId, Password " +
         "FROM Agent " +
         "WHERE EmpId = '" + UserName + "' AND password = '" + UserPass + "'";
            var conn = clsGlobal.myCon;
            OleDbCommand myCmd = new OleDbCommand(selectString, conn);
            conn.Open();
            String strResult = String.Empty;
            strResult = (String)myCmd.ExecuteScalar();
            conn.Close();

            if (strResult.Length == 0)
                return false;
            else return true;
         }
        void grid2txt()
        {
            OleDbCommand cmdHouses = new OleDbCommand("SELECT * FROM House WHERE EmpId = '" + txtUserId.Text + "'", clsGlobal.myCon);
            OleDbDataReader readHouses = cmdHouses.ExecuteReader();
            DataTable tmpHouse = new DataTable();
            tmpHouse.Load(readHouses);
            gridHouses.DataSource = tmpHouse;

            OleDbCommand cmdSellers = new OleDbCommand("SELECT * FROM Seller WHERE EmpId = '" + txtUserId.Text + "'", clsGlobal.myCon);
            OleDbDataReader readSellers = cmdHouses.ExecuteReader();
            DataTable tmpSellers = new DataTable();
            tmpSellers.Load(readSellers);
            gridSellers.DataSource = tmpSellers;

            OleDbCommand cmdBuyers = new OleDbCommand("SELECT * FROM Buyer WHERE EmpId = '" + txtUserId.Text + "'", clsGlobal.myCon);
            OleDbDataReader readBuyers = cmdHouses.ExecuteReader();
            DataTable tmpBuyers = new DataTable();
            tmpBuyers.Load(readBuyers);
            gridBuyers.DataSource = tmpBuyers;
        }
        void cbo2txt()
        {
            OleDbCommand cmdFillHouses = new OleDbCommand("SELECT HouseId FROM House", clsGlobal.myCon);
            OleDbDataReader readFillHouses = cmdFillHouses.ExecuteReader();
            while (readFillHouses.Read())
            {
                cboSelectHouse.Items.Add(readFillHouses["HouseId"]);
            }
            OleDbCommand cmdFillSellers = new OleDbCommand("SELECT SellerId FROM Seller", clsGlobal.myCon);
            OleDbDataReader readFillSellers = cmdFillSellers.ExecuteReader();
            while (readFillSellers.Read())
            {
                cboSelectSeller.Items.Add(readFillSellers["SellerId"]);
            }

            OleDbCommand cmdFillBuyers = new OleDbCommand("SELECT BuyerId FROM Buyer", clsGlobal.myCon);
            OleDbDataReader readFillBuyers = cmdFillBuyers.ExecuteReader();
            while (readFillBuyers.Read())
            {
                cboSelectBuyer.Items.Add(readFillBuyers["BuyerId"]);
            }
        }
        
    }
}
