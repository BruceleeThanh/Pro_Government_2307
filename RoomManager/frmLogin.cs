using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinessLogic;
using DataAccess;
using DevExpress.XtraSplashScreen;
using System.Threading;
using Library;
using Entity;
using CORESYSTEM;

namespace RoomManager
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        SystemUsersBO aSystemUsersBO = new SystemUsersBO();
        frmMain afrmMain;
        //public frmLogin(frmMain afrmMain)
        //{
        //    InitializeComponent();
        //    this.afrmMain = afrmMain;
        //}
        public frmLogin()
        {
            InitializeComponent();
           
        }

        private void bnLogin_Click(object sender, EventArgs e)
        {
            progressPanel1.Visible = true;
                if (CORE.Login_WinForm(txtUserName.Text, txtPassword.Text) == true)
                {
                    Program.sys_CurrentUser = (new SystemUsersBO()).Select_ByUsername(txtUserName.Text);
                    frmMain afrmMain = new frmMain(this);
                    if (CORE.CheckPermit_WinForm(afrmMain) == true)
                    {
                        afrmMain.LoadData();
                        //afrmMain.ReloadData();
                        
                        afrmMain.Show();
                        progressPanel1.Visible = false;
                        this.Visible = false;
                    }

                }
         

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.afrmMain = new frmMain(this);
            progressPanel1.Visible = false;
        }



        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                progressPanel1.Visible = true;
                if (CORE.Login_WinForm(txtUserName.Text, txtPassword.Text) == true)
                {
                    frmMain afrmMain = new frmMain(this);
                    if (CORE.CheckPermit_WinForm(afrmMain) == true)
                    {
                        afrmMain.LoadData();
                        //afrmMain.ReloadData();
                        afrmMain.Show();
                        progressPanel1.Visible = false;
                        this.Visible = false;
                    }

                }
            }  
        }


    }
}