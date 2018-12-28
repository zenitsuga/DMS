using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace D_M_S
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnWorkspace.Click += delegate(object sender, EventArgs e) { btnSidePanel_Click(sender, e, pnlWorkspace); };            
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            tssTodayDate.Text = "Today is " + DateTime.Now.ToString("dddd,MM-dd-yyyy HH:mm:ss");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSidePanel_Click(object sender, EventArgs e,Panel pnl)
        {
            if (pnl.Height != btnWorkspace.Height)
            {
                pnl.Height = btnWorkspace.Height;
            }
            else
            {
                pnl.Height = 204;
            }
        }

    }
}
