using System;
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
                aNavBarGroup.GroupClientHeight = 140;
                aNavBarGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
                aNavBarGroup.Expanded = true;
                AddFloor(aNavBarGroup, i, aListRoom);
            }
        }


        private void AddFloor (NavBarGroup aNavBarGroup, int LevelSku, uc_RoomStatusItem[] aListRoom) {

            NavBarGroupControlContainer aNavBarGroupControlContainer = new NavBarGroupControlContainer();
            aNavBarGroupControlContainer.Name = "navBarGroupControlContainer" + LevelSku;
            aNavBarGroupControlContainer.Size = new System.Drawing.Size(865, 267);
            aNavBarGroupControlContainer.TabIndex = 0;
            aNavBarGroup.ControlContainer = aNavBarGroupControlContainer;

            aNavBarGroupControlContainer.Controls.Add(aListFlowLayoutPanel[LevelSku - 1]);

            this.navBarControl1.Controls.Add(aNavBarGroupControlContainer);
            this.navBarControl1.Groups.Add(aNavBarGroup);

            this.AddRoom(aListFlowLayoutPanel[LevelSku - 1], LevelSku, aListRoom);
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
    }

}
