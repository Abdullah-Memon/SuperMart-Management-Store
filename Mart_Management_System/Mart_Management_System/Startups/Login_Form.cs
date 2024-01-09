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
using System.IO;

namespace Mart_Management_System
{
    public partial class Login_Form : Form
    {
        // Global variables;
        int token = 0;
        SqlCommand cmd;
        public static DataTable shopinfo, userinfo;

        // Private Function (Shop Verification)
        private bool shopVerification()
        {
            try
            {
                // Shop Verification:
                cmd = new SqlCommand("Registration_Verification", DB.con) { CommandType = CommandType.StoredProcedure };
                shopinfo = new DataTable();
                if (DB.con.State == ConnectionState.Closed)
                    DB.con.Open();

                shopinfo.Load(cmd.ExecuteReader());

                DB.con.Close();

            } // end of try
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message.ToString());
            }

            // When shop not registered
            if (shopinfo.Rows.Count == 0)
                return false;
            else
            {
                // Verifying for any admin account that exist
                try
                {
                    cmd = new SqlCommand("Validate_Users", DB.con) { CommandType = CommandType.StoredProcedure };
                    DataTable dt = new DataTable();

                    if (DB.con.State == ConnectionState.Closed)
                        DB.con.Open();

                    dt.Load(cmd.ExecuteReader());

                    DB.con.Close();

                    if (dt.Rows.Count == 0)
                    {
                        signup_btn.Show();
                    }
                    else
                    {
                        signup_btn.Hide();
                    }

                }
                catch (Exception ex)
                { MessageBox.Show("Erro in Signup!: \n"+ex.Message.ToString()); }

                return true;
            }
        }
        
        // Constructor
        public Login_Form()
        {
            DB.Connection();
            InitializeComponent();
        }

        
        private void Login_Form_Load(object sender, EventArgs e)
        {

            if (!shopVerification())
            {
                Registration_Form rf = new Registration_Form();
                rf.ShowDialog();

                if (!shopVerification())
                    Application.Exit();
            }
                // Shop Details:
            else
            {
                byte[] logo = (byte[])shopinfo.Rows[0][1];
                MemoryStream ms = new MemoryStream(logo);
                shop_logo.Image = Image.FromStream(ms);
            }

                // Cleaning Form: 
                userName_box.Text = String.Empty;
                password_box.Text = String.Empty;

                // Hidden details
                warning1_txt.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            token = 0;

            if (string.IsNullOrEmpty(userName_box.Text) || string.IsNullOrWhiteSpace(userName_box.Text))
            {
                userName_box.Focus();
                userName_box.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(password_box.Text) || string.IsNullOrWhiteSpace(password_box.Text))
            {
                password_box.Focus();
                password_box.FocusedState.BorderColor = Color.Red;
                token = 2;
            }
            else
            {
                try {
                    cmd = new SqlCommand("User_Verification", DB.con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.Add(new SqlParameter("@username",userName_box.Text));
                    cmd.Parameters.Add(new SqlParameter("@password", password_box.Text));

                    shopinfo = new DataTable();

                    if(DB.con.State == ConnectionState.Closed);
                    DB.con.Open();

                    shopinfo.Load(cmd.ExecuteReader());

                    DB.con.Close();

                    if(shopinfo.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfull");
                    }
                    else
                    {  
                        token = 3;
                    };
                    

                }
                catch (Exception ex)
                { MessageBox.Show("Error in Login: \n" + ex.Message.ToString());  }
            }

            if (token != 0)
            {
                if (token == 1)
                    warning1_txt.Text = "Please enter valid username";
                else if (token == 2)
                    warning1_txt.Text = "Please enter valid password";
                else if (token == 3)
                    warning1_txt.Text = "Invalid username or password. Please Try again";

                warning1_txt.Show();
            }
            else
                warning1_txt.Hide();
        }

        private void showPassword_box_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword_box.Checked)
                password_box.UseSystemPasswordChar = false;
            else
                password_box.UseSystemPasswordChar = true;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void shop_logo_Click(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Signup_Form sf = new Signup_Form();
            sf.ShowDialog();

            object a = new object();
            EventArgs b = new EventArgs();

            Login_Form_Load(a, b);
            this.Show();
        }
    }
}
