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

namespace SaleManager.FormTask {
    public partial class frmTsk_BookingForRoomByType : DevExpress.XtraEditors.XtraForm {
        BookingRoomByTypeEN aBookingRoomByTypeEN = new BookingRoomByTypeEN();
        private CountAvailableRoomEN aCountAvailableRoomEN = new CountAvailableRoomEN();
        private List<BookingRoomByTypeEN> aListBookingRoomType = new List<BookingRoomByTypeEN>();
        private BookingRoomByTypeBO aBookingRoomByTypeBO = new BookingRoomByTypeBO();
        private int? availableSuite = 0;
        private int? availableSuperior = 0;
        private int? availableStandard = 0;
        
        private int? bookingSuite = 0;
        private int? bookingSuperior = 0;
        private int? bookingStandard = 0;

        private bool checkEdit = false;
        private int editID;

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

        private void LoadCountAvailableRoom (DateTime From, DateTime To) {
            aCountAvailableRoomEN.SetValue(aBookingRoomByTypeBO.Select_CountAvailableRoomType(From, To, 1));
            if (aCountAvailableRoomEN.Suite != null) {
                if (aCountAvailableRoomEN.Suite < 0) {
                    availableSuite = 0;
                }
                else {
                    availableSuite = aCountAvailableRoomEN.Suite;
                }
            }
            if (aCountAvailableRoomEN.Superior != null) {
                if (aCountAvailableRoomEN.Superior < 0) {
                    availableSuperior = 0;
                }
                else {
                    availableSuperior = aCountAvailableRoomEN.Superior;
                }
            }
            if (aCountAvailableRoomEN.Standard != null) {
                if (aCountAvailableRoomEN.Standard < 0) {
                    availableStandard = 0;
                }
                else {
                    availableStandard = aCountAvailableRoomEN.Standard;
                }
            }
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
                    MessageBox.Show("Vui lòng chọn tên khách hàng hoặc thêm mới tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lueIDCustomer.Focus();
                    return false;
                }
                else {
                    if (txtSuiteBooking.Text == "" && txtSuperiorBooking.Text == "" && txtStandardBooking.Text == "") {
                        MessageBox.Show("Vui lòng nhập số phòng cần đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else {
                        if (txtSuiteBooking.Text == "") {
                            bookingSuite = 0;
                        }
                        else {
                            bookingSuite = int.Parse(txtSuiteBooking.Text);
                        }
                        if (txtSuperiorBooking.Text == "") {
                            bookingSuperior = 0;
                        }
                        else {
                            bookingSuperior = int.Parse(txtSuperiorBooking.Text);
                        }
                        if (txtStandardBooking.Text == "") {
                            bookingStandard = 0;
                        }
                        else {
                            bookingStandard = int.Parse(txtStandardBooking.Text);
                        }
                        if (bookingSuite > availableSuite || bookingSuperior > availableSuperior || bookingStandard > availableStandard) {
                            MessageBox.Show("Vui lòng nhập số phòng nhỏ hơn số phòng trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else {
                            
                            return true;
                        }
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

                this.LoadCountAvailableRoom(dtpFrom.DateTime, dtpTo.DateTime);

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
                    this.LoadCountAvailableRoom(dtpFrom.DateTime, dtpTo.DateTime);
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

        private void btnBooking_Click (object sender, EventArgs e) {
            try{
                BookingRoomByTypeEN aBookingRoomByTypeEN = new BookingRoomByTypeEN();
                if(this.CheckDataBeforeCheckIn()){
                    if (checkEdit == false) {
                        if (String.IsNullOrEmpty(txtNameCustomer.Text)) {
                            aBookingRoomByTypeEN.IDCustomer = Convert.ToInt32(lueIDCustomer.EditValue);
                            aBookingRoomByTypeEN.CustomerName = lueIDCustomer.Text;
                        }
                        else {
                            aBookingRoomByTypeEN.IDCustomer = 0;
                            aBookingRoomByTypeEN.CustomerName = txtNameCustomer.Text;
                        }

                        aBookingRoomByTypeEN.FromDate = dtpFrom.DateTime;
                        aBookingRoomByTypeEN.ToDate = dtpTo.DateTime;
                        aBookingRoomByTypeEN.Suite = int.Parse(bookingSuite.ToString());
                        aBookingRoomByTypeEN.Superior = int.Parse(bookingSuperior.ToString());
                        aBookingRoomByTypeEN.Standard = int.Parse(bookingStandard.ToString());
                        aBookingRoomByTypeEN.BookingStatus = true;

                        if (aBookingRoomByTypeBO.NewOrEditBookingRoomByType(aBookingRoomByTypeEN) == true) {
                            MessageBox.Show("Thực hiện đặt phòng thành công .", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.LoadListBookingRoomType();
                            dgvListBookingRoom.DataSource = this.aListBookingRoomType;
                            dgvListBookingRoom.RefreshDataSource();
                            txtSuiteBooking.Text = "";
                            txtSuperiorBooking.Text = "";
                            txtStandardBooking.Text = "";
                            this.LoadCountAvailableRoom(dtpFrom.DateTime, dtpTo.DateTime);
                        }
                        else {
                            MessageBox.Show("Đặt phòng thất bại vui lòng thực hiện lại.", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                            checkEdit = false;
                            if (String.IsNullOrEmpty(txtNameCustomer.Text)) {
                                aBookingRoomByTypeEN.IDCustomer = Convert.ToInt32(lueIDCustomer.EditValue);
                                aBookingRoomByTypeEN.CustomerName = lueIDCustomer.Text;
                            }
                            else {
                                aBookingRoomByTypeEN.IDCustomer = 0;
                                aBookingRoomByTypeEN.CustomerName = txtNameCustomer.Text;
                            }

                            aBookingRoomByTypeEN.ID = editID;
                            aBookingRoomByTypeEN.FromDate = dtpFrom.DateTime;
                            aBookingRoomByTypeEN.ToDate = dtpTo.DateTime;
                            aBookingRoomByTypeEN.Suite = int.Parse(bookingSuite.ToString());
                            aBookingRoomByTypeEN.Superior = int.Parse(bookingSuperior.ToString());
                            aBookingRoomByTypeEN.Standard = int.Parse(bookingStandard.ToString());
                            aBookingRoomByTypeEN.BookingStatus = true;

                            if (aBookingRoomByTypeBO.NewOrEditBookingRoomByType(aBookingRoomByTypeEN) == true) {
                                MessageBox.Show("Sửa đặt phòng thành công .", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.LoadListBookingRoomType();
                                dgvListBookingRoom.DataSource = this.aListBookingRoomType;
                                dgvListBookingRoom.RefreshDataSource();
                                txtSuiteBooking.Text = "";
                                txtSuperiorBooking.Text = "";
                                txtStandardBooking.Text = "";
                                this.LoadCountAvailableRoom(dtpFrom.DateTime, dtpTo.DateTime);
                            }
                            else {
                                MessageBox.Show("Sửa thất bại vui lòng thực hiện lại.", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
                checkEdit = true;

                int ID = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("ID").ToString());
                int IDCustomer = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("IDCustomer").ToString());
                DateTime editFromDate = DateTime.Parse(viewListBookingRoom.GetFocusedRowCellValue("FromDate").ToString());
                DateTime editToDate = DateTime.Parse(viewListBookingRoom.GetFocusedRowCellValue("ToDate").ToString());
                int editSuite = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("Suite").ToString());
                int editSuperior = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("Superior").ToString());
                int editStandard = int.Parse(viewListBookingRoom.GetFocusedRowCellValue("Standard").ToString());

                editID = ID;
                lueIDCustomer.RefreshEditValue();
                int editIDCustomer = lueIDCustomer.Properties.GetDataSourceRowIndex("ID", IDCustomer);
                lueIDCustomer.EditValue = lueIDCustomer.Properties.GetDataSourceValue(lueIDCustomer.Properties.ValueMember, editIDCustomer);
                
                dtpFrom.DateTime = editFromDate;
                dtpTo.DateTime = editToDate;
                txtSuiteBooking.Text = editSuite.ToString();
                txtSuperiorBooking.Text = editSuperior.ToString();
                txtStandardBooking.Text = editStandard.ToString();

                
            }
            catch (Exception ex) {
                MessageBox.Show("frmTsk_BookingForRoom.btnEdit_ButtonClick\n" + ex.ToString(), "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}