using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using BussinessLogic;
using Entity;

namespace RoomManager.FormTask {
    public partial class frmTsk_BookingForRoomByType : DevExpress.XtraEditors.XtraForm {
        private BookingRoomByTypeEN aBookingRoomByTypeEN = new BookingRoomByTypeEN();
        private CountAvailableRoomEN aCountAvailableRoomEN = new CountAvailableRoomEN();
        private List<BookingRoomByTypeEN> aListBookingRoomType = new List<BookingRoomByTypeEN>();
        private BookingRoomByTypeBO aBookingRoomByTypeBO = new BookingRoomByTypeBO();
        private int? availableSuite = 0;
        private int? availableSuperior = 0;
        private int? availableStandard = 0;
        
        private int? bookingSuite = 0;
        private int? bookingSuperior = 0;
        private int? bookingStandard = 0;

        public frmTsk_BookingForRoomByType () {
            InitializeComponent();
        }

        public List<Customers> LoadAllListCustomers () {
            try {
                CustomersBO aCustomersBO = new CustomersBO();
                return aCustomersBO.Select_All();
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.LoadAllListCustomers()\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void LoadListBookingRoomType () {
            CustomersBO aCustomersBO = new CustomersBO();
            aListBookingRoomType.Clear();
            foreach (var temp in aBookingRoomByTypeBO.Select_ByStatus(true)) {
                BookingRoomByTypeEN aBookingRoomByTypeEN = new BookingRoomByTypeEN();
                aBookingRoomByTypeEN.SetValue(temp);
                aBookingRoomByTypeEN.CustomerName = aCustomersBO.Select_ByID(aBookingRoomByTypeEN.IDCustomer).Name;
                aListBookingRoomType.Add(aBookingRoomByTypeEN);
            }
        }

        private void LoadLabelCountAvailableRoom () {
            labSuite.Text = availableSuite.ToString();
            labStandard.Text = availableStandard.ToString();
            labSuperior.Text = availableSuperior.ToString();
        }

        private bool CheckData () {
            try {
                if (dtpFrom.EditValue == null) {
                    dtpFrom.Focus();
                    MessageBox.Show("Vui lòng nhập ngày đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (dtpTo.EditValue == null) {
                    dtpTo.Focus();
                    MessageBox.Show("Vui lòng nhập ngày trả phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else {
                    if (dtpFrom.DateTime > dtpTo.DateTime) {
                        dtpTo.Focus();
                        MessageBox.Show("Vui lòng nhập đặt phòng phải nhỏ hơn hoặc bằng ngày trả phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.CheckData\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckDataBeforeCheckIn () {
            try {
                if (lueIDCustomer.EditValue == null && String.IsNullOrEmpty(txtNameCustomer.Text)) {
                    lueIDCustomer.Focus();
                    MessageBox.Show("Vui lòng chọn tên khách hàng hoặc thêm mới tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else {
                    if (txtSuiteBooking.Text == null && txtSuperiorBooking.Text == null && txtStandardBooking.Text == null) {
                        MessageBox.Show("Vui lòng nhập số phòng cần đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else {
                        bookingSuite = int.Parse(txtSuiteBooking.Text);
                        bookingSuperior = int.Parse(txtSuperiorBooking.Text);
                        bookingStandard = int.Parse(txtStandardBooking.Text);
                        if (bookingSuite == null) {
                            bookingSuite = 0;
                        }
                        if (bookingSuperior == null) {
                            bookingSuperior = 0;
                        }
                        if (bookingStandard == null) {
                            bookingStandard = 0;
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.CheckDataBeforeCheckIn()\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmTsk_BookingForRoomByType_Load (object sender, EventArgs e) {
            try {
                
                dtpFrom.DateTime = DateTime.Now;
                dtpTo.DateTime = DateTime.Now.AddDays(1);
                aCountAvailableRoomEN.SetValue(aBookingRoomByTypeBO.Select_CountAvailableRoomType(dtpFrom.DateTime, dtpTo.DateTime, 1));
                if (aCountAvailableRoomEN.Suite != null) {
                    availableSuite = aCountAvailableRoomEN.Suite;
                }
                if (aCountAvailableRoomEN.Superior != null) {
                    availableSuperior = aCountAvailableRoomEN.Superior;
                }
                if (aCountAvailableRoomEN.Standard != null) {
                    availableStandard = aCountAvailableRoomEN.Standard;
                }
                this.LoadLabelCountAvailableRoom();

                this.LoadListBookingRoomType();
                dgvListBookingRoom.DataSource = this.aListBookingRoomType;
                dgvListBookingRoom.Show();

                lueIDCustomer.Properties.DataSource = this.LoadAllListCustomers();
                lueIDCustomer.Properties.ValueMember = "ID";
                lueIDCustomer.Properties.DisplayMember = "Name";
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoomByType.frmTsk_BookingForRoomByType_Load\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click (object sender, EventArgs e) {
            try {
                if (this.CheckData()) {
                    aCountAvailableRoomEN.SetValue(aBookingRoomByTypeBO.Select_CountAvailableRoomType(dtpFrom.DateTime, dtpTo.DateTime, 1));
                    if (aCountAvailableRoomEN.Suite != null) {
                        availableSuite = aCountAvailableRoomEN.Suite;
                    }
                    if (aCountAvailableRoomEN.Superior != null) {
                        availableSuperior = aCountAvailableRoomEN.Superior;
                    }
                    if (aCountAvailableRoomEN.Standard != null) {
                        availableStandard = aCountAvailableRoomEN.Standard;
                    }
                    this.LoadLabelCountAvailableRoom();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoomByType.btnSearch_Click\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //private void chkCustomerType_CheckedChanged (object sender, EventArgs e) {
        //    try {
        //        if (chkCustomerType.Checked == true) {
        //            this.customerType = 5; // Khach thuoc bo ngoai giao
        //        }
        //    }
        //    catch (Exception ex) {
        //        MessageBox.Show("frmTsk_BookingForRoom.chkCustomerType_CheckedChanged()\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void txtNameCustomer_EditValueChanged (object sender, EventArgs e) {
            try {
                if (String.IsNullOrEmpty(txtNameCustomer.Text)) {
                    lueIDCustomer.Enabled = true;
                }
                else {
                    lueIDCustomer.Enabled = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.txtNameCustomer_EditValueChanged()\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSuiteBooking_EditValueChanged (object sender, EventArgs e) {
            try {
                if (!String.IsNullOrEmpty(txtSuiteBooking.Text)) {
                    if (int.Parse(txtSuiteBooking.Text) <= availableSuite) {
                        bookingSuite = int.Parse(txtSuiteBooking.Text);
                    }
                    else {
                        MessageBox.Show("Vui lòng nhập số phòng nhỏ hơn số phòng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSuiteBooking.Text = "";
                        txtSuiteBooking.Show();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.txtSuiteBooking_EditValueChanged()\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSuperiorBooking_EditValueChanged (object sender, EventArgs e) {
            try {
                if (!String.IsNullOrEmpty(txtSuperiorBooking.Text)) {
                    if (int.Parse(txtSuperiorBooking.Text) <= availableSuperior) {
                        bookingSuperior = int.Parse(txtSuperiorBooking.Text);
                    }
                    else {
                        MessageBox.Show("Vui lòng nhập số phòng nhỏ hơn số phòng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSuperiorBooking.Text = "";
                        txtSuperiorBooking.Show();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.txtSuperiorBooking_EditValueChanged()\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStandardBooking_EditValueChanged (object sender, EventArgs e) {
            try {
                if (!String.IsNullOrEmpty(txtStandardBooking.Text)) {
                    if (int.Parse(txtStandardBooking.Text) <= availableStandard) {
                        bookingStandard = int.Parse(txtStandardBooking.Text);
                    }
                    else {
                        MessageBox.Show("Vui lòng nhập số phòng nhỏ hơn số phòng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtStandardBooking.Text = "";
                        txtStandardBooking.Show();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.txtStandardBooking_EditValueChanged\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnBooking_Click (object sender, EventArgs e) {
            try{
                if(this.CheckDataBeforeCheckIn()){
                    if (String.IsNullOrEmpty(txtNameCustomer.Text)) {
                        this.aBookingRoomByTypeEN.IDCustomer = Convert.ToInt32(lueIDCustomer.EditValue);
                        this.aBookingRoomByTypeEN.CustomerName = lueIDCustomer.Text;
                    }
                    else {
                        this.aBookingRoomByTypeEN.IDCustomer = 0;
                        this.aBookingRoomByTypeEN.CustomerName = txtNameCustomer.Text;
                    }

                    this.aBookingRoomByTypeEN.FromDate = dtpFrom.DateTime;
                    this.aBookingRoomByTypeEN.ToDate = dtpTo.DateTime;
                    this.aBookingRoomByTypeEN.Suite = int.Parse(bookingSuite.ToString());
                    this.aBookingRoomByTypeEN.Superior = int.Parse(bookingSuperior.ToString());
                    this.aBookingRoomByTypeEN.Standard = int.Parse(bookingStandard.ToString());
                    this.aBookingRoomByTypeEN.BookingStatus = true;

                    if (aBookingRoomByTypeBO.NewBookingRoomByType(this.aBookingRoomByTypeEN) == true) {
                        MessageBox.Show("Thực hiện đặt phòng thành công .", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Đặt phòng thất bại vui lòng thực hiện lại.", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.btnBooking_Click\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            try {
                int ID = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("ID").ToString());
                DialogResult result = MessageBox.Show("Bạn có chắc chắn khách hàng này đã Checkin?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    if (aBookingRoomByTypeBO.Delete(ID)) {
                        MessageBox.Show("Xóa thành công.", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadListBookingRoomType();
                        dgvListBookingRoom.DataSource = this.aListBookingRoomType;
                        dgvListBookingRoom.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.btnDelete_ButtonClick\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            try {
                int ID = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("ID").ToString());
                int IDCustomer = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("IDCustomer").ToString());
                DateTime editFromDate = DateTime.Parse(viewListBookingRoom.GetFocusedRowCellValue("FromDate").ToString());
                DateTime editToDate = DateTime.Parse(viewListBookingRoom.GetFocusedRowCellValue("ToDate").ToString());
                int editSuite = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("Suite").ToString());
                int editSuperior = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("Superior").ToString());
                int editStandard = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("Standard").ToString());

                if (this.CheckData()) {
                    aCountAvailableRoomEN.SetValue(aBookingRoomByTypeBO.Select_CountAvailableRoomType(dtpFrom.DateTime, dtpTo.DateTime, 1));
                    if (aCountAvailableRoomEN.Suite != null) {
                        availableSuite = aCountAvailableRoomEN.Suite;
                    }
                    if (aCountAvailableRoomEN.Superior != null) {
                        availableSuperior = aCountAvailableRoomEN.Superior;
                    }
                    if (aCountAvailableRoomEN.Standard != null) {
                        availableStandard = aCountAvailableRoomEN.Standard;
                    }
                    if (availableSuite >= editSuite && availableSuperior >= editSuperior && availableStandard >= editStandard) {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa đổi thông tin?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) {
                            BookingRoomByType aBookingRoomByType = new BookingRoomByType();
                            aBookingRoomByType.ID = ID;
                            aBookingRoomByType.IDCustomer = IDCustomer;
                            aBookingRoomByType.FromDate = editFromDate;
                            aBookingRoomByType.ToDate = editToDate;
                            aBookingRoomByType.Suite = editSuite;
                            aBookingRoomByType.Superior = editSuperior;
                            aBookingRoomByType.Standard = editStandard;
                            aBookingRoomByType.BookingStatus = true;

                            if (aBookingRoomByTypeBO.Update(aBookingRoomByType)) {
                                MessageBox.Show("Sửa thành công.", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.LoadListBookingRoomType();
                                dgvListBookingRoom.DataSource = this.aListBookingRoomType;
                                dgvListBookingRoom.RefreshDataSource();
                            }
                        }
                    }
                    else {
                        MessageBox.Show("Vui lòng nhập số phòng nhỏ hơn số phòng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.btnEdit_ButtonClick\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}