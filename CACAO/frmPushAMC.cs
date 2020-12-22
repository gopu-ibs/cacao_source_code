using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CACAO.Model;
using System.IO;
using Newtonsoft.Json;

namespace CACAO
{
    public partial class frmPushAMC : Form
    {
        public frmPushAMC()
        {            
            InitializeComponent();
            LoadGrid();
            
        }
        private void LoadGrid()
        {
            try
            {
                AMC objAMC = new AMC();
                dataGridView1.DataSource = objAMC.GetData(@"C:\amc.json");
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 250;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
                label1.ForeColor = Color.Red;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            label1.Text = AMC.Push();
            label1.ForeColor = Color.Yellow;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }       

        private void button3_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void frmPushAMC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            button2.Focus();
        }

        private void frmPushAMC_Leave(object sender, EventArgs e)
        {
            button2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = AMC.Pull();
            label1.ForeColor = Color.Green;
        }
    }
}
