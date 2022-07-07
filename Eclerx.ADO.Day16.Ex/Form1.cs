using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Eclerx.ADO.Day16.Ex
{
    public partial class Form1 : Form
    {

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            TxtFirstName.Text = "";
            TxtLastName.Clear();
            DTPBirthDate.Text = "";
            ComboGender.Text = "";
            TxtEmailId.Text = "";
            TxtPassword.Text = "";
            TxtConfirmPassword.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Sql Connection
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString);

            //Create Sql Command - Select Query or DML Query or Stored Procedure
            cmd = new SqlCommand("Select vFirstName, vLastName, dBirthDate, cGender, vEmailId, vPassword from Registration", con);

            //Open the connection
            con.Open();

            //Execute the command and fetch datas
            reader = cmd.ExecuteReader();

            //Read the first row
            reader.Read();

            //Store into releavant TextBoxes
            TxtFirstName.Text = reader["vFirstName"].ToString();
            TxtLastName.Text = reader["vLastName"].ToString();
            DTPBirthDate.Text = reader["dBirthDate"].ToString();
            ComboGender.Text = reader["cGender"].ToString();
            TxtEmailId.Text = reader["vEmailId"].ToString();
            TxtPassword.Text = reader["vPassword"].ToString();

            //Close the reader object
            reader.Close();

            //Dispose Command Object
            cmd.Dispose();

            //Close the connection
            con.Close();
            this.ClearText();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {

                if ((TxtEmailId.Text == "") || (TxtPassword.Text == ""))
                {
                    MessageBox.Show("You cannot leave these fields blank.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                con.Open();


                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Registration WHERE vEmailId='" + TxtEmailId.Text + "' AND vPassword='" + TxtPassword.Text + "'", con);
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Email or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Welcome", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ClearText();

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_AddandSignIn", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", TxtLastName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", DTPBirthDate.Text);
                    cmd.Parameters.AddWithValue("@Gender", ComboGender.Text);
                    cmd.Parameters.AddWithValue("@EmailId", TxtEmailId.Text);
                    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);


                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("SignUp Successfull");
                this.ClearText();
            }
        }
    }
}
