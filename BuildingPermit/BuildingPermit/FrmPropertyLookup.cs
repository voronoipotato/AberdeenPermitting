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
        public string conStr;

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
                    

            if (txtLRK.Text.Length > -1 && txtLRK.Text != " ")
            {
                FillComboBoxLRK(conStr);
            }
            else if (txtPropertyDescription.Text.Length > -1 && txtPropertyDescription.Text != " ")
            {
                FillComboBoxPropertDesc(conStr);
            }
            else if (txtPropertyOwner.Text.Length > -1 && txtPropertyOwner.Text != " ")
            {
                FillComboBoxOwner(conStr);
            }
            else
            {
                MessageBox.Show("Please in the LRK number, Parcel Description or the Owner Company or personal name.");
            }

        }


        private void FillComboBoxLRK(string conStr)
        {
            string query = "SELECT address FROM parcel WHERE lrk = '" + this.txtLRK.Text + "';";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
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
        private void FillComboBoxPropertDesc(string conStr)
        {
            string query = "SELECT address FROM parcel WHERE Address LIKE'%" + this.txtPropertyDescription.Text + "%';";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
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
             private void FillComboBoxOwner(string conStr)
        {
            string query = "SELECT address FROM parcel  INNER JOIN  contact ON contact.contactID = parcel.contactid " +
                "WHERE contact.compayname LIKE '%" + this.txtPropertyOwner.Text + "%';";
            using (SqlConnection connection = new SqlConnection(conStr))
            {
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

        private void frmPropertyLookup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aberdeenPermittingDataSet.Number_Amps_Fees_Query' table. You can move, or remove it, as needed.
            // this.number_Amps_Fees_QueryTableAdapter.Fill(this.aberdeenPermittingDataSet.Number_Amps_Fees_Query);
          conStr = @"Data Source=.\sqlexpress;Initial Catalog=AberdeenPermitting;User Id=Capstone;Password=Capstone2012;";
        }
    }
}
