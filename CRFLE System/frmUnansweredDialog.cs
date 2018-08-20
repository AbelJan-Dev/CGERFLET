using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRFLE_System
{
    public partial class frmUnansweredDialog : Form
    {
        public List<String> unansweredItems;
        public frmStudentMain studMain;

        public frmUnansweredDialog(List<String> ui, frmStudentMain studMain)
        {
            InitializeComponent();
            this.unansweredItems = ui;
            this.studMain = studMain;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnansweredDialog_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < unansweredItems.Count; i++)
            {
                Button item = new Button();
                item.Width = 50;
                item.Height = 30;
                item.Text = unansweredItems[i].ToString();
                item.FlatStyle = FlatStyle.Flat;
                item.Click += item_Click;

                this.itemsList.Controls.Add(item);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            Button item = sender as Button;
            int itemNo = Convert.ToInt32(item.Text);
            int y = 0;

            for (int i = 0; i < itemNo - 1; i++)
            {
                y += studMain.flowLayoutPanel1.Controls[i].Height + 6;    
            }

            studMain.flowLayoutPanel1.AutoScrollPosition = new Point(0, y);
            frmStudentMain.flowLayoutScroll = itemNo - 1;
            this.Close();
        }
    }
}
