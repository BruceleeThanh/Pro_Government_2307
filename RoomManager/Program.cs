using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CORESYSTEM;
using DevExpress.LookAndFeel;
using System.Configuration;
using Entity;
using DataAccess;
using BussinessLogic;

namespace RoomManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. </summary>


        //----------THONG TIN NGUOI DANG NHAP HIEN TAI---------------

        //public CORE.CORE CORE = new CORE.CORE();
        //------------------------
        public static SystemUsers sys_CurrentUser = new SystemUsers();
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");


            CORE.INIT(ConfigurationManager.AppSettings["SystemKey"].ToString());
            

            //Application.Run(new Form1());
            Application.Run(new frmLogin());
            
        }



    }
}