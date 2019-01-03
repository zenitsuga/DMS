using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using D_M_S.Classes;
namespace D_M_S
{
    public partial class frmSplashLogin : Form
    {
        bool isTerminate = false;

        public frmSplashLogin()
        {
            InitializeComponent();
        }

        private void frmSplashLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckFileAndFolders()
        {
            Recheck:
            clsStarter cs = new clsStarter();
            if(!cs.CheckMyAppConfig())
            {
                isTerminate = true;
                tmrLoading.Stop();
                DialogResult dr = MessageBox.Show("Warning: Application Setting file is Missing.\nPress 'Yes' to configure,'No' to exit.", "Configuratio File is Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Config.frmConfiguration fc = new Config.frmConfiguration();
                    fc.ShowDialog();
                    goto Recheck;
                }
                return;
            }
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
           
            if(progressBar1.Value == 100)
            {
                tmrLoading.Enabled = false;
                this.Height = 290;
                lblLoadStatus.Text = "Please enter username and password to login";
            }
            else if (progressBar1.Value == 10)
            {
                CheckFileAndFolders();
                if(isTerminate)
                {
                    tmrLoading.Stop();
                    Application.Exit();
                }
            }
        }

        private void frmSplashLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isTerminate)
            {
                DialogResult drExit = MessageBox.Show("Are you sure you want to exit program?", "Confirm to exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drExit == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }else
            {
                MessageBox.Show("Error: The system detects a problem in loading the setting.\nPlease check your error logs.", "Error Loading Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbUsername.Text = tbPassword.Text = string.Empty;
        }
    }
}
