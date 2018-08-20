using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;

namespace CRFLE_System
{
    public partial class frmAddUser : DevExpress.XtraEditors.XtraForm
    {
        public static int usertype;
        public static int verified;

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsExtName.tblExtensionName' table. You can move, or remove it, as needed.
            this.tblExtensionNameTableAdapter.Fill(this.dsExtName.tblExtensionName);
            // TODO: This line of code loads data into the 'dbCRFLEDataSet1.tblExtensionName' table. You can move, or remove it, as needed.
            this.tblExtensionNameTableAdapter.Fill(this.dsExtName.tblExtensionName);
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkShowPassword.Checked == true)
            {
                this.txtpassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtpassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String userid = this.txtID1.Text.Trim() + '-' + this.txtID2.Text.Trim();
            String firstname = this.txtfname.Text.Trim();
            String middlename = this.txtmname.Text.Trim();
            String lastname = this.txtlname.Text.Trim();
            String nameext = this.cmbExtName.SelectedValue.ToString();
            String radiogender;
            //set value for radio based on male/female radio button
            if (this.radioMale.Checked == true)
            {
                radiogender = "Male";
            }
            else
            {
                radiogender = "Female";
            }

            String month;
            String day;

            if (this.dateBirthDate.DateTime.Month.ToString().Length == 1)
            {
                month = '0' + this.dateBirthDate.DateTime.Month.ToString();
            }
            else
            {
                month = this.dateBirthDate.DateTime.Month.ToString();
            }

            if (this.dateBirthDate.DateTime.Day.ToString().Length == 1)
            {
                day = '0' + this.dateBirthDate.DateTime.Day.ToString();
            }
            else
            {
                day = this.dateBirthDate.DateTime.Day.ToString();
            }

            String bdate = this.dateBirthDate.DateTime.Year.ToString().Trim() + '-' + month.Trim() + '-' + day.Trim();

            String prk = this.txtPurok.Text.Trim();
            String sitio = this.txtSitio.Text.Trim();
            String barangay = this.txtBarangay.Text.Trim();
            String municipality = this.txtMunicipality.Text.Trim();
            String province = this.txtProvince.Text.Trim();
            String zipcode = this.txtZipCode.Text.Trim();
            String username = this.txtusername.Text;
            String password = this.txtpassword.Text;

            if ((this.txtID1.Text.Trim() == "") || (this.txtID2.Text.Trim() == "") || (firstname == "") || (lastname == "") || (bdate == "1-01-01") || (barangay == "") || (municipality == "") || (province == "") || (username == "") || (password == ""))
            {
                MessageBox.Show("Please fill in necessary fields.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (bdate == "1-01-01")
                {
                    this.label14.Visible = true;
                }
                else
                {
                    this.label14.Visible = false;
                }
            }
            else
            {
                this.label14.Visible = false;
                new dbModule().createUser(userid, firstname, middlename, lastname, nameext, radiogender, usertype, bdate, prk, sitio, barangay, municipality, province, zipcode, username, password, verified);

                clearFields();
                this.Close();
                
                if (usertype == 1)
                {
                    new frmLogin().Show();
                }
            }
        }

        private void txtID1_TextChanged_1(object sender, EventArgs e)
        {
            if (this.txtID1.Text.Length == 2)
            {
                this.txtID2.Focus();
            }
        }

        private void cmbExtName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtfname.Text = textInfo.ToLower(this.txtfname.Text);
            this.txtfname.Text = textInfo.ToTitleCase(this.txtfname.Text);

            if (this.txtfname.Text == "")
            {
                this.label5.Visible = true;
            }
            else
            {
                this.label5.Visible = false;
            }
        }

        private void txtmname_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtmname.Text = textInfo.ToLower(this.txtmname.Text);
            this.txtmname.Text = textInfo.ToTitleCase(this.txtmname.Text);
        }

        private void txtlname_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtlname.Text = textInfo.ToLower(this.txtlname.Text);
            this.txtlname.Text = textInfo.ToTitleCase(this.txtlname.Text);

            if (this.txtlname.Text == "")
            {
                this.label8.Visible = true;
            }
            else
            {
                this.label8.Visible = false;
            }
        }

        private void txtSitio_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtSitio.Text = textInfo.ToLower(this.txtSitio.Text);
            this.txtSitio.Text = textInfo.ToTitleCase(this.txtSitio.Text);
        }

        private void txtBarangay_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtBarangay.Text = textInfo.ToLower(this.txtBarangay.Text);
            this.txtBarangay.Text = textInfo.ToTitleCase(this.txtBarangay.Text);

            if (this.txtBarangay.Text == "")
            {
                this.label9.Visible = true;
            }
            else
            {
                this.label9.Visible = false;
            }
        }

        private void txtMunicipality_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtMunicipality.Text = textInfo.ToLower(this.txtMunicipality.Text);
            this.txtMunicipality.Text = textInfo.ToTitleCase(this.txtMunicipality.Text);

            if (this.txtMunicipality.Text == "")
            {
                this.label10.Visible = true;
            }
            else
            {
                this.label10.Visible = false;
            }
        }

        private void txtProvince_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            this.txtProvince.Text = textInfo.ToLower(this.txtProvince.Text);
            this.txtProvince.Text = textInfo.ToTitleCase(this.txtProvince.Text);

            if (this.txtProvince.Text == "")
            {
                this.label11.Visible = true;
            }
            else
            {
                this.label11.Visible = false;
            }
        }

        private void txtID1_Leave(object sender, EventArgs e)
        {
            if ((this.txtID1.Text == "") || (this.txtID2.Text == ""))
            {
                this.label7.Visible = true;
            }
            else
            {
                this.label7.Visible = false;
            }
        }

        private void txtID2_Leave(object sender, EventArgs e)
        {
            if ((this.txtID1.Text == "") || (this.txtID2.Text == ""))
            {
                this.label7.Visible = true;
            }
            else
            {
                this.label7.Visible = false;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (this.txtusername.Text == "")
            {
                this.label12.Visible = true;
            }
            else
            {
                this.label12.Visible = false;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (this.txtpassword.Text == "")
            {
                this.label13.Visible = true;
            }
            else
            {
                this.label13.Visible = false;
            }
        }


        public void clearFields()
        {
            this.txtID1.Text = "";
            this.txtID2.Text = "";
            this.txtfname.Text = "";
            this.txtmname.Text = "";
            this.txtlname.Text = "";
            this.dateBirthDate.Reset();
            this.txtPurok.Text = "";
            this.txtSitio.Text = "";
            this.txtBarangay.Text = "";
            this.txtMunicipality.Text = "";
            this.txtProvince.Text = "";
            this.txtZipCode.Text = "";
            this.txtusername.Text = "";
            this.txtpassword.Text = "";
            this.Hide();
        }

    }
}