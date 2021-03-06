﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using Entity;
using BussinessLogic;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler;
using DevExpress.XtraNavBar;

namespace RoomManager {
    public partial class uc_StatusRoomsUpdate : DevExpress.XtraEditors.XtraUserControl {

        
        public uc_StatusRoomsUpdate () {
            InitializeComponent();
        }

        public List<RoomExtStatusEN> Datasource { set; get; }
        public DateTime CheckTime { set; get; }
        public int StatusButtonPopup = 0;
        public List<FlowLayoutPanel> aListFlowLayoutPanel = new List<FlowLayoutPanel>();
        //------------------------------------------------------------------------------
        //  Gộp phòng
        //------------------------------------------------------------------------------
        public int From_IDBookingR = 0;
        public int From_IDBookingRoom = 0;
        public int From_IDCustomer = 0;

        public int To_IDBookingR = 0;
        public int To_IDBookingRoom = 0;
        public int To_IDCustomer = 0;
        //------------------------------------------------------------------------------

        public void DataBind () {
            uc_RoomStatusItem[] aListRoom;
            var maxLevelSkuTemp = Datasource.Max(b => b.LevelSku);
            int maxLevelSku = int.Parse(maxLevelSkuTemp.ToString());

            aListRoom = new uc_RoomStatusItem[Datasource.Count];
            this.FlowLayoutPanel_Load(maxLevelSku);

            for (int i = 0; i < Datasource.Count; i++) {
                //---------------------------------------------
                // Process when display in past
                if (this.StatusButtonPopup == 1) // qua khu / past
                {
                    if (this.Datasource[i].RoomStatus == 0 && this.Datasource[i].CheckInActual <= CheckTime && CheckTime <= this.Datasource[i].CheckOutActual) {
                        this.Datasource[i].RoomStatus = 3;
                    }
                }
                aListRoom[i] = new uc_RoomStatusItem(this.Datasource[i]);
                aListRoom[i].Visible = true;
                aListRoom[i].StatusButtonPopup = this.StatusButtonPopup;
            }
            for (int i = 1; i <= maxLevelSku; i++) {
                NavBarGroup aNavBarGroup = new NavBarGroup();
                aNavBarGroup.Caption = "Tầng " + i;
                aNavBarGroup.Name = "navBarGroup" + i;
           
              
                aNavBarGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
                aNavBarGroup.Expanded = true;
                AddFloor(aNavBarGroup, i, aListRoom);
     

            }
        }


        private void AddFloor (NavBarGroup aNavBarGroup, int LevelSku, uc_RoomStatusItem[] aListRoom) {

            NavBarGroupControlContainer aNavBarGroupControlContainer = new NavBarGroupControlContainer();
            aNavBarGroupControlContainer.Name = "navBarGroupControlContainer" + LevelSku;
            //aNavBarGroupControlContainer.Size =  new System.Drawing.Size(865, 300);
            aNavBarGroupControlContainer.TabIndex = 0;
            aNavBarGroupControlContainer.Height = 500;


            aNavBarGroup.ControlContainer = aNavBarGroupControlContainer;
            aNavBarGroup.GroupClientHeight = 370;

            aNavBarGroupControlContainer.Controls.Add(aListFlowLayoutPanel[LevelSku - 1]);

            this.navBarControl1.Controls.Add(aNavBarGroupControlContainer);
            this.navBarControl1.Groups.Add(aNavBarGroup);

            this.AddRoom(aListFlowLayoutPanel[LevelSku - 1], LevelSku, aListRoom);


            aNavBarGroupControlContainer.Dock = DockStyle.Fill;
            aNavBarGroupControlContainer.AutoSize = true;
            
            //aNavBarGroupControlContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            aListFlowLayoutPanel[LevelSku - 1].Dock = DockStyle.Fill;
            aListFlowLayoutPanel[LevelSku - 1].AutoSize = true;
            aListFlowLayoutPanel[LevelSku - 1].AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private void AddRoom (FlowLayoutPanel aFlowLayoutPanel, int LevelSku, uc_RoomStatusItem[] aListRoom) {
            //aFlowLayoutPanel.Controls.Clear();
            for (int i = 0; i < aListRoom.Count(); i++) {
                if (aListRoom[i].Datasource.LevelSku == LevelSku) {
                    aFlowLayoutPanel.Controls.Add(aListRoom[i]);
                }
            }

        }

        private void FlowLayoutPanel_Load(int maxLevelSku) {
            for(int i = 0; i < maxLevelSku; i++) {
                FlowLayoutPanel aFlowLayoutPanel = new FlowLayoutPanel();
                aFlowLayoutPanel.Dock = DockStyle.Fill;
                aFlowLayoutPanel.Name = "flowLayoutPanel" + i;
                aFlowLayoutPanel.TabIndex = 0;
                
                this.aListFlowLayoutPanel.Add(aFlowLayoutPanel);
            }
        }

        public void FlowLayoutPanel_Refesh(){
            uc_RoomStatusItem[] aListRoom;
            var maxLevelSkuTemp = Datasource.Max(b => b.LevelSku);
            int maxLevelSku = int.Parse(maxLevelSkuTemp.ToString());

            aListRoom = new uc_RoomStatusItem[Datasource.Count];

            for(int i = 0; i < Datasource.Count; i++) {
                //---------------------------------------------
                // Process when display in past
                if(this.StatusButtonPopup == 1) // qua khu / past
                {
                    if(this.Datasource[i].RoomStatus == 0 && this.Datasource[i].CheckInActual <= CheckTime && CheckTime <= this.Datasource[i].CheckOutActual) {
                        this.Datasource[i].RoomStatus = 3;
                    }
                }
                aListRoom[i] = new uc_RoomStatusItem(this.Datasource[i]);
                aListRoom[i].Visible = true;
                aListRoom[i].StatusButtonPopup = this.StatusButtonPopup;
            }
            for(int i = 1; i <= maxLevelSku; i++) {
                aListFlowLayoutPanel[i - 1].Controls.Clear();
                this.AddRoom(aListFlowLayoutPanel[i - 1], i, aListRoom);
            }
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
           
        }
    }

}
