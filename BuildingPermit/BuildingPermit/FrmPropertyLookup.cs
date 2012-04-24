using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BuildingPermit
{
    public partial class frmPropertyLookup : Form
    {
        private string conStr = @"Data Source=.\sqlexpress;Initial Catalog=AberdeenPermitting;User Id=Capstone;Password=Capstone2012;";


        public static SqlDataReader queryDatabase(string queryString, string connectionString)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            return cmd.ExecuteReader();
        }

        public frmPropertyLookup()
        {
            InitializeComponent();
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {

            FillComboBox(conStr);

        }


        private void FillComboBox(string conStr)
        {

            using (SqlConnection connection = new SqlConnection(conStr))
            {

                string query = "";

                if (txtLRK.Text.Length > -1 && txtLRK.Text != " ")
                {
                    query = "SELECT address FROM parcel WHERE lrk = '" + this.txtLRK.Text + "';";
                }
                else if (txtPropertyDescription.Text.Length > -1 && txtPropertyDescription.Text != " ")
                {
                    query = "SELECT address FROM parcel WHERE Address LIKE'%" + this.txtPropertyDescription.Text + "%';";
                }
                else if (txtPropertyOwner.Text.Length > -1 && txtPropertyOwner.Text != " ")
                {
                    query = "SELECT address FROM parcel  INNER JOIN  contact ON contact.contactID = parcel.contactid " +
                    "WHERE contact.compayname LIKE '%" + this.txtPropertyOwner.Text + "%';";
                }
                else
                {
                    MessageBox.Show("Please in the LRK number, Parcel Description or the Owner Company or personal name.");
                }

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                try
                {
                    foreach (var item in sqlReader)
                    {
                        cmbPropertyResults.Items.Add(item);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlReader.Close();
                }
            }
        }

    }
}
