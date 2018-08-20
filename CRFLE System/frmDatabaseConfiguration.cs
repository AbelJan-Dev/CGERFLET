using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRFLE_System
{
    public partial class frmDatabaseConfiguration : Form
    {
        public frmDatabaseConfiguration()
        {
            InitializeComponent();
        }


        public void dbConfig()
        {
            CRFLE_System.Properties.Settings.Default.dbCRFLEConnectionString.Remove(0);
            CRFLE_System.Properties.Settings.Default.dbCRFLEConnectionString.Insert(0, "");
            //Data Source=HPASAABELJAN;Initial Catalog=dbCRFLE;Persist Security Info=True;User ID=sa;Password=rootadmin

        }

        private void frmDatabaseConfiguration_Load(object sender, EventArgs e)
        {
            dbConfig();
        }
    }

}
