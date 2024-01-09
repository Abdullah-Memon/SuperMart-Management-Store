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
    public partial class Registration_Form : Form
    {
        // global variables token
        int token = 0;
        public Registration_Form()
        {
            InitializeComponent();
            DB.Connection();
        }

        // Private Function (Cleaning Screen)
        private void cleanScreen() {
            registrationKey.Text = String.Empty;
            ownerName.Text = String.Empty;
            shopName.Text = String.Empty;
            contact1.Text = string.Empty;
            contact2.Text = string.Empty;
            emailAddress.Text = string.Empty;
            address.Text = string.Empty;
            aggrement.Checked = false;
        }
        private bool validateInfo() {

            token = 0;
            warning_txt.Hide();

            if (string.IsNullOrEmpty(registrationKey.Text) || string.IsNullOrWhiteSpace(registrationKey.Text))
            {
                registrationKey.Focus();
                registrationKey.FocusedState.BorderColor = Color.Red;
                token = 1;
            }

            else if (string.IsNullOrEmpty(ownerName.Text) || string.IsNullOrWhiteSpace(ownerName.Text))
            {
                ownerName.Focus();
                ownerName.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(shopName.Text) || string.IsNullOrWhiteSpace(shopName.Text))
            {
                shopName.Focus();
                shopName.FocusedState.BorderColor = Color.Red;
                token = 1;
            }
            else if (string.IsNullOrEmpty(contact1.Text) || string.IsNullOrWhiteSpace(contact1.Text))
            {
                contact1.Focus();
                token = 1;
                contact1.FocusedState.BorderColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(emailAddress.Text) || string.IsNullOrWhiteSpace(emailAddress.Text))
            {
                emailAddress.Focus();
                token = 1;
                emailAddress.FocusedState.BorderColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(address.Text) || string.IsNullOrWhiteSpace(address.Text))
            {
                address.Focus();
                token = 1;
                address.FocusedState.BorderColor = Color.Red;
            }
            
            else
            {
                registrationKey.FocusedState.BorderColor = Color.RoyalBlue;
                ownerName.FocusedState.BorderColor = Color.RoyalBlue;
                shopName.FocusedState.BorderColor = Color.RoyalBlue;
                contact1.FocusedState.BorderColor = Color.RoyalBlue;
                emailAddress.FocusedState.BorderColor = Color.RoyalBlue;
                address.FocusedState.BorderColor = Color.RoyalBlue;
            }

            if (token != 0)
            {
                if(token == 1)
                    warning_txt.Text = "Please provide complete details";
                    
                warning_txt.Show();
                return false;
            }


            else
                return true;
        }
        
        private void Registration_Form_Load(object sender, EventArgs e)
        {
            // hidden warnings
            warning_txt.Hide();

            cleanScreen();

            register_btn.Enabled = false;
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Image.File (*.jpg; *.jpeg; *.png; *.gif; *.bmp;) | *.jpg; *.jpeg; *.png; *.gif; *.bmp;";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    shop_logo.Image = Image.FromFile(opf.FileName);
                }

            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            cleanScreen();
        }


        private void register_btn_Click(object sender, EventArgs e)
        {
            // validating all the information
            if (validateInfo())
            {
                try
                {
                    // storing data
                    SqlCommand cmd = new SqlCommand("Add_Shop", DB.con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new SqlParameter("@Registration_Key", registrationKey.Text));
                    cmd.Parameters.Add(new SqlParameter("@Shopname", shopName.Text));
                    cmd.Parameters.Add(new SqlParameter("@contact1", contact1.Text));
                    cmd.Parameters.Add(new SqlParameter("@contact2", contact2.Text));
                    cmd.Parameters.Add(new SqlParameter("@Address", address.Text));
                    cmd.Parameters.Add(new SqlParameter("@EmailAddress", emailAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("@Owner", ownerName.Text));
                    cmd.Parameters.Add(new SqlParameter("@current_date", DateTime.Now.Date.ToShortDateString()));

                    ImageConverter img = new ImageConverter();
                    byte[] converted_img = (byte[])img.ConvertTo(shop_logo.Image, Type.GetType("System.Byte[]"));

                    cmd.Parameters.Add(new SqlParameter("@logo", converted_img));

                    if (DB.con.State == ConnectionState.Closed)
                        DB.con.Open();

                    int chk = cmd.ExecuteNonQuery();

                    DB.con.Close();

                    if (chk > 0)
                    {
                        MessageBox.Show("Registration Successfull! Thank you. \n Lets Create new Account");

                        cmd = new SqlCommand("Validate_Users", DB.con) { CommandType = CommandType.StoredProcedure };
                        DataTable dt = new DataTable();

                        if (DB.con.State == ConnectionState.Closed)
                            DB.con.Open();

                        dt.Load(cmd.ExecuteReader());

                        DB.con.Close();

                        if (dt.Rows.Count == 0)
                        {
                            this.Hide();
                            Signup_Form sf = new Signup_Form();
                            sf.ShowDialog();
                        }
                        this.Close();
                    }
                    else
                    {
                        warning_txt.Text = "Invalid Registration Key!";
                        warning_txt.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error!: \n" + ex.Message.ToString());
                }

                
            }
            
        }

        private void aggrement_CheckedChanged(object sender, EventArgs e)
        {
            if (aggrement.Checked)
                register_btn.Enabled = true;
            else
                register_btn.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Just click on Agree for now!");
        }
    }
}
