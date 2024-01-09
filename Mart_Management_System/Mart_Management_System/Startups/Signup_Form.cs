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

namespace Mart_Management_System
{
    public partial class Signup_Form : Form
    {
        // Global Variables
        int token = 0;
        SqlCommand cmd;

        public Signup_Form()
        {
            InitializeComponent();
            DB.Connection();
        }

        // Private Function (Information Validation)
        private bool validateInfo() 
        {

            warning_txt.Hide();

            token = 0;


            if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrWhiteSpace(firstName.Text))
            {
                firstName.Focus();
                firstName.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrWhiteSpace(lastName.Text) || string.IsNullOrEmpty(lastName.Text))
            {
                lastName.Focus();
                lastName.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(emailAddress.Text) || string.IsNullOrWhiteSpace(emailAddress.Text))
            {
                emailAddress.Focus();
                emailAddress.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(contact.Text) || string.IsNullOrWhiteSpace(contact.Text))
            {
                contact.Focus();
                contact.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrWhiteSpace(userName.Text))
            {
                userName.Focus();
                userName.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(password.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                password.Focus();
                password.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(cPassword.Text) || string.IsNullOrWhiteSpace(cPassword.Text))
            {
                cPassword.Focus();
                cPassword.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (password.Text != cPassword.Text)
            {
                cPassword.Focus();
                cPassword.FocusedState.BorderColor = Color.Red;
                token = 2;
            }
            else
            {
                firstName.FocusedState.BorderColor = Color.RoyalBlue;
                lastName.FocusedState.BorderColor = Color.RoyalBlue;
                emailAddress.FocusedState.BorderColor = Color.RoyalBlue;
                contact.FocusedState.BorderColor = Color.RoyalBlue;
                userName.FocusedState.BorderColor = Color.RoyalBlue;
                password.FocusedState.BorderColor = Color.RoyalBlue;
                cPassword.FocusedState.BorderColor = Color.RoyalBlue;
            }


            if (token != 0)
            {
                if (token == 1)
                    warning_txt.Text = "Please Provide Complete Details.";
                else if (token == 2)
                    warning_txt.Text = "Passwords should be same!";

                warning_txt.Show();
                return false;
            }
            else
            {
                DataTable dt = new DataTable();

                // username should not be same
                try
                {
                    cmd = new SqlCommand("username_Verification", DB.con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new SqlParameter("@username", userName.Text));

                    if (DB.con.State == ConnectionState.Closed)
                        DB.con.Open();

                    dt.Load(cmd.ExecuteReader());

                    DB.con.Close();
                }
                catch (Exception ex) { MessageBox.Show("Error in Username Verification: " +ex.Message.ToString());}

                if (dt.Rows.Count == 0)
                    return true;
                else
                {
                    warning_txt.Text = "This username is not Avaiable.";
                    warning_txt.Show();
                    return false;
                }
            }

        }
        private void Signup_Form_Load(object sender, EventArgs e)
        {
            //hidden details
            warning_txt.Hide();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                password.UseSystemPasswordChar = false;
                cPassword.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                cPassword.UseSystemPasswordChar = true;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (validateInfo())
            {
                try {
                    cmd = new SqlCommand("Add_User", DB.con) { CommandType = CommandType.StoredProcedure };
                    
                    cmd.Parameters.Add(new SqlParameter("@Firstname" , firstName.Text));
                    cmd.Parameters.Add(new SqlParameter("@Lastname" , lastName.Text));
                    cmd.Parameters.Add(new SqlParameter("@Email" , emailAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("@Phone" , contact.Text));
                    cmd.Parameters.Add(new SqlParameter("@Role" , 1));
                    cmd.Parameters.Add(new SqlParameter("@Username" , userName.Text));
                    cmd.Parameters.Add(new SqlParameter("@Password" , cPassword.Text));

                    ImageConverter img = new ImageConverter();
                    byte[] converted_img = (byte[])img.ConvertTo(Profile_pic.Image, Type.GetType("System.Byte[]"));

                    cmd.Parameters.Add(new SqlParameter("@Profile" , converted_img));

                    if (DB.con.State == ConnectionState.Closed)
                        DB.con.Open();

                    int chk = cmd.ExecuteNonQuery();

                    if (chk > 0)
                    {
                        MessageBox.Show("User Successfully Added! Thank you");

                        this.Close();

                    }
                    else
                        MessageBox.Show("Error adding user");
                }
                catch (Exception ex) { MessageBox.Show("Error in Sign in: \n" + ex.Message.ToString()); }
            }
            else
            {
            
            }
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Image.File (*.jpg; *.jpeg; *.png; *.gif; *.bmp;) | *.jpg; *.jpeg; *.png; *.gif; *.bmp;";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    Profile_pic.Image = Image.FromFile(opf.FileName);
                }

            }
        }
    }
}
