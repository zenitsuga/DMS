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
            btnCommunications.Click += delegate(object sender, EventArgs e) {btnSidePanel_DoubleClick(btnCommunications, pnlCommunications, 204);};
            btnWorkspace.Click += delegate(object sender, EventArgs e) { btnSidePanel_DoubleClick(btnWorkspace, pnlWorkspace, 204); };
            btnSearch.Click += delegate(object sender, EventArgs e) { btnSidePanel_DoubleClick(btnSearch, pnlSearch, 204); };
            btnSettings.Click += delegate(object sender, EventArgs e) { btnSidePanel_DoubleClick(btnSettings, pnlSettings, 204); };
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            tssTodayDate.Text = "Today is " + DateTime.Now.ToString("dddd,MM-dd-yyyy HH:mm:ss");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            frmSplashLogin spl = new frmSplashLogin();
            spl.StartPosition = FormStartPosition.CenterScreen;
            spl.ShowDialog();
            Button sidePanel = new Button();
            sidePanel.Text = "LoadMain";
            ResizeMySidePanel(sidePanel);
        }

        #region UI
        private void ResizeMySidePanel(Button btn)
        {
            switch (btn.Text)
            {
                case "COMMUNICATIONS":
                    pnlCommunications.Height = panel2.Height - (btnWorkspace.Height + btnSearch.Height + btnSettings.Height);
                    pnlWorkspace.Height = btnWorkspace.Height;
                    pnlSearch.Height = btnSearch.Height;
                    pnlSettings.Height = btnSettings.Height;
                    break;
                case "WORKSPACE":
                    pnlWorkspace.Height = panel2.Height - (btnCommunications.Height + btnSearch.Height + btnSettings.Height);
                    pnlCommunications.Height = btnCommunications.Height;
                    pnlSearch.Height = btnSearch.Height;
                    pnlSettings.Height = btnSettings.Height;
                    break;
                case "SEARCH":
                    pnlSearch.Height = panel2.Height - (btnCommunications.Height + btnWorkspace.Height + btnSettings.Height);
                    pnlCommunications.Height = btnCommunications.Height;
                    pnlWorkspace.Height = btnWorkspace.Height;
                    pnlSettings.Height = btnSettings.Height;
                    break;
                case "SETTINGS":
                    pnlSettings.Height = panel2.Height - (btnCommunications.Height + btnSearch.Height + btnWorkspace.Height);
                    pnlCommunications.Height = btnCommunications.Height;
                    pnlSearch.Height = btnSearch.Height;
                    pnlWorkspace.Height = btnWorkspace.Height;
                    break;
                default:
                    pnlCommunications.Height = panel2.Height - (btnWorkspace.Height + btnSearch.Height + btnSettings.Height);
                    pnlWorkspace.Height = btnWorkspace.Height;
                    pnlSearch.Height = btnSearch.Height;
                    pnlSettings.Height = btnSettings.Height;
                    break;
            }
        }
        #endregion

        private void btnSidePanel_DoubleClick(Button sender, Panel pnl,int HeightPanel)
        {
            
                ResizeMySidePanel(sender);
            
        }

        private void tvMailNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

      
    }
}
