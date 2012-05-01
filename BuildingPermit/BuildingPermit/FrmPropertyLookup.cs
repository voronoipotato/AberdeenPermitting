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
            
            cmbPropertyResults.Items.Clear();

            if (txtLRK.Text != null || txtLRK.Text != " ")
            {
                

                using (SqlConnection con = new SqlConnection(conStr))
                {



                    try
                    {

                        con.Open();
                        SqlCommand spCmd;

                        spCmd = new SqlCommand("getParcelBasedonLRK", con);
                        spCmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter parm1 = spCmd.Parameters.Add("@in_LRK", SqlDbType.VarChar);
                        spCmd.Prepare();

                        parm1.Value = txtLRK.Text;

                        SqlDataReader RDR = spCmd.ExecuteReader();

                        cmbPropertyResults.Items.Clear();

                        int i = 0;

                        if (RDR.HasRows)
                        {
                            while (RDR.Read())
                            {
                                cmbPropertyResults.Items.Add((string)RDR[i]);
                                i++;

                            }

                           

                            cmbPropertyResults.Text = "PLease pick the parcel you are looking for.";
                        }
                        else
                        {
                            cmbPropertyResults.Text = " No results found.";
                        }





                        RDR.Close();
                        con.Close();
                    }
                    catch (SqlException MyException)
                    {

                        MessageBox.Show("Connection Error: " + MyException.Number);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                }
            }
            else if (txtPropertyDescription.Text != null || txtPropertyDescription.Text != " ")
            {
                

                using (SqlConnection con = new SqlConnection(conStr))
                {



                    try
                    {

                        con.Open();
                        SqlCommand spCmd;

                        spCmd = new SqlCommand("getParcelBPropertyDescription", con);
                        spCmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter parm1 = spCmd.Parameters.Add("@in_PropertyDescription", SqlDbType.VarChar);
                        spCmd.Prepare();

                        parm1.Value = txtLRK.Text;

                        SqlDataReader RDR = spCmd.ExecuteReader();

                        cmbPropertyResults.Items.Clear();

                        int i = 0;

                        if (RDR.HasRows)
                        {
                            while (RDR.Read())
                            {
                                cmbPropertyResults.Items.Add(RDR.GetString(i));
                                i++;

                            }

                         
                            cmbPropertyResults.Text = "PLease pick the parcel you are looking for.";
                        }
                        else
                        {
                            cmbPropertyResults.Text = " No results found.";
                        }





                        RDR.Close();
                        con.Close();
                    }
                    catch (SqlException MyException)
                    {

                        MessageBox.Show("Connection Error: " + MyException.Number);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                }



            }
            else if (txtPropertyOwner.Text != null || txtPropertyOwner.Text != " ")
            {
                
                using (SqlConnection con = new SqlConnection(conStr))
                {



                    try
                    {

                        con.Open();
                        SqlCommand spCmd;

                        spCmd = new SqlCommand("getParcelBOwner", con);
                        spCmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter parm1 = spCmd.Parameters.Add("@in_Name", SqlDbType.VarChar);
                        spCmd.Prepare();

                        parm1.Value = txtLRK.Text;

                        SqlDataReader RDR = spCmd.ExecuteReader();

                        cmbPropertyResults.Items.Clear();

                        int i = 0;

                        if (RDR.HasRows)
                        {
                            while (RDR.Read())
                            {
                                cmbPropertyResults.Items.Add(RDR.GetString(i));
                                i++;

                            }

                           
                            cmbPropertyResults.Text = "PLease pick the parcel you are looking for.";
                        }
                        else
                        {
                            cmbPropertyResults.Text = " No results found.";
                        }





                        RDR.Close();
                        con.Close();
                    }
                    catch (SqlException MyException)
                    {

                        MessageBox.Show("Connection Error: " + MyException.Number);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }







                }

            }
            else
            {
                MessageBox.Show("Please fill in the LRK number, Parcel Description or the Owner Company//personal name.");
            }

            
        }


        private void FillComboBox(string conStr, string parameter, string procedure)
        {

            using (SqlConnection con = new SqlConnection(conStr))
            {



                try
                {

                    con.Open();
                    SqlCommand spCmd;

                    spCmd = new SqlCommand(procedure, con);
                    spCmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parm1 = spCmd.Parameters.Add(parameter, SqlDbType.VarChar);
                    spCmd.Prepare();

                    parm1.Value = txtLRK.Text;

                    SqlDataReader RDR = spCmd.ExecuteReader();

                    cmbPropertyResults.Items.Clear();

                    int i = 0;

                    if (RDR.HasRows)
                    {
                        while (RDR.Read())
                        {
                            cmbPropertyResults.Items.Add(RDR.GetString(i));
                            i++;

                        }

                       
                        cmbPropertyResults.Text = "PLease pick the parcel you are looking for.";
                    }
                    else
                    {
                        cmbPropertyResults.Text = " No results found.";
                    }





                    RDR.Close();
                    con.Close();
                }
                catch (SqlException MyException)
                {

                    MessageBox.Show("Connection Error: " + MyException.Number);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }


        }

    }
}
