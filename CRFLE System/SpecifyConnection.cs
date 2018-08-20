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
using System.Data.SqlClient;
using System.Configuration;

namespace CRFLE_System
{
    public partial class SpecifyConnection : DevExpress.XtraEditors.XtraForm
    {
        //private string appPath;

        public SpecifyConnection()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application without saving the database connection?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string svname = this.txtsvname.Text.Trim();
            string dbname = this.txtdbname.Text.Trim();
            string uname = this.txtuname.Text.Trim();
            string pword = this.txtpword.Text.Trim();

            if (svname == "" || dbname == "" || uname == "" || pword == "")
            {
                this.promptText.Text = "Please fill out all fields.";
                this.panelPrompt.Show();
                return;
            }
            else
            {
                if (this.CheckServerConnection(svname, dbname, uname, pword) == true)
                {
                    string newConnectionString = "Data Source=" + svname + ";Initial Catalog=" + dbname + ";Persist Security Info=True;User ID=" + uname + ";Password=" + pword + "";

                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

                    connectionStringsSection.ConnectionStrings["CRFLE_System.Properties.Settings.dbCRFLEConnectionString"].ConnectionString = newConnectionString;

                    config.AppSettings.SectionInformation.ForceSave = true;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");

                    waitTime(2000);

                    this.Hide();
                    new frmLogin().Show();
                }
                else
                {
                    this.promptText.Text = "Configuration specified cannot establish connection to the server.";
                    this.panelPrompt.Show();
                }
            }


            

            //MessageBox.Show(connectionStringsSection.ConnectionStrings["CRFLE_System.Properties.Settings.dbCRFLEConnectionString"].ConnectionString);


            ///////USING .TXT CONFIG FILE/////////

            //string[] configlines = new string[] { svname, dbname, uname, pword };

            //if (svname == "" || dbname == "" || uname == "" || pword == "")
            //{
            //    this.promptText.Text = "Please fill out all fields.";
            //    this.panelPrompt.Show();
            //    return;
            //}
            //else
            //{
            
            //    appPath = System.IO.Path.GetDirectoryName(new System.IO.DirectoryInfo(Environment.CurrentDirectory).Parent.FullName) + "/ServerConfig";

            //    if (this.CheckServerConnection(svname, dbname, uname, pword) == true)
            //    {
            //        if (System.IO.File.Exists(appPath + "/Connection.txt") == true)
            //        {
            //            System.IO.File.WriteAllLines(appPath + "/Connection.txt", configlines);

            //            dbModule.serverName = svname;
            //            dbModule.databaseName = dbname;
            //            dbModule.userName = uname;
            //            dbModule.passWord = pword;

            //            this.panelPrompt.BackColor = Color.Green;
            //            this.promptText.Text = "Successfully established server connection.";
            //            this.panelPrompt.Show();

            //            waitTime(1000);

            //            this.Hide();
            //            new frmLogin().Show();

            //        }
            //        else
            //        {
            //            CheckFileAndDirectory();
            //        }
            //    }
            //    else
            //    {
            //        this.promptText.Text = "Configuration specified cannot establish connection to the server.";
            //        this.panelPrompt.Show();
            //    }

            //}
            
        }


        private async void waitTime(int time)
        {
            await Task.Delay(time);
        }

        //private void CheckFileAndDirectory()
        //{
        //    if (System.IO.Directory.Exists(appPath) == false)
        //    {
        //        System.IO.Directory.CreateDirectory(appPath);
        //    }
        //    if (System.IO.File.Exists(appPath + "/Connection.txt") == false)
        //    {
        //        System.IO.File.Create(appPath + "/Connection.txt");
        //    }
        //}

        private bool CheckServerConnection(string svname, string dbname, string uname, string pword)
        {
            string connectionString = connectionString = "Data Source= " + svname + ";Initial Catalog=" + dbname + ";Persist Security Info=True;User ID=" + uname + ";Password= " + pword + "";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                return false;
            }
        }

        private void txtsvname_TextChanged(object sender, EventArgs e)
        {
            this.panelPrompt.Hide();
        }
    }
}