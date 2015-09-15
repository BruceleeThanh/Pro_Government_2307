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

using DevExpress.XtraReports.UI;
using System.IO;

namespace SaleManager.FormReport {
    public partial class frmRpt_ListCompanies : DevExpress.XtraReports.UI.XtraReport {

        private List<Companies> aListCompanies;
        public frmRpt_ListCompanies (List<Companies> aListCompanies) {
            InitializeComponent();
            var aAlphabetListCompanies = aListCompanies.OrderBy(x => x.Name).ToList();
            this.aListCompanies = aAlphabetListCompanies;
            try {
                this.DataSource = this.aListCompanies;
                colCompaniesName.DataBindings.Add("Text", this.DataSource, "Name");
                colAddress.DataBindings.Add("Text", this.DataSource, "Address");
                colTaxNumberCode.DataBindings.Add("Text", this.DataSource, "TaxNumberCode");
                colType.DataBindings.Add("Text", this.DataSource, "Type");
            }
            catch (Exception ex) {
                MessageBox.Show("frmRpt_ListCompanies.frmRpt_ListCompanies\n" + ex.ToString());
            }
        }

    }
}
