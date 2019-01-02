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
        public frmSplashLogin()
        {
            InitializeComponent();
        }

        private void frmSplashLogin_Load(object sender, EventArgs e)
        {
            CheckFolders();
        }

        private void CheckFolders()
        {
            clsStarter cs = new clsStarter();
            cs.CreateFolderInMyDocuments();
        }
    }
}
