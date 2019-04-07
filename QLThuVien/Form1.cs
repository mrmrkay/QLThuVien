using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.UserControlls;

namespace QLThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddControlsToPanel(UserControl c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucBook ucbook = new ucBook();
            AddControlsToPanel(ucbook);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucBorrow ucborrow = new ucBorrow();
            AddControlsToPanel(ucborrow);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucSearch ucsearch = new ucSearch();
            AddControlsToPanel(ucsearch);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucAccount ucac = new ucAccount();
            AddControlsToPanel(ucac);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucHelp uchelp = new ucHelp();
            AddControlsToPanel(uchelp);
        }
        
    }
}
