using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess;
using BussinessLogic;
using Entity;
using DevExpress.XtraReports.UI;
using DevExpress.Utils;

using System.Globalization;
using CORESYSTEM;
using System.Drawing;
using System.IO;

namespace RoomManager
{
    public partial class frmTsk_ChoosePrintType : Form
    {
        public frmTsk_ChoosePrintType()
        {
            InitializeComponent();
        }
        private NewPaymentEN aNewPaymentEN;
        public frmTsk_ChoosePrintType(NewPaymentEN aNewPaymentEN)
        {
            this.aNewPaymentEN = aNewPaymentEN;
            InitializeComponent();
        }

        private void frmTsk_ChoosePrintType_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrintByCustomer_Click(object sender, EventArgs e)
        {
            CustomersBO aCustomersBO = new CustomersBO();
            Customers aCustomer = new Customers();
            aCustomer = aCustomersBO.Select_ByID(int.Parse(loeListCustomer.EditValue.ToString()));
            this.aNewPaymentEN = this.aNewPaymentEN.SlipPaymentByCustomer(aCustomer);

            try
            {
                if (this.aNewPaymentEN.Status_BookingR == 8 || this.aNewPaymentEN.Status_BookingR == 7)
                {

                    frmRpt_Payment_BookingRs afrmRpt_Payment_BookingRs = new frmRpt_Payment_BookingRs(this.aNewPaymentEN);
                    ReportPrintTool tool = new ReportPrintTool(afrmRpt_Payment_BookingRs);
                    tool.ShowPreview();
                }
                else
                {
                    frmRpt_Payment_BookingRsUnPay afrmRpt_Payment_BookingRs = new frmRpt_Payment_BookingRsUnPay(this.aNewPaymentEN);
                    ReportPrintTool tool = new ReportPrintTool(afrmRpt_Payment_BookingRs);
                    tool.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("frmTsk_ChoosePrintType.btnPrint_Click\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
