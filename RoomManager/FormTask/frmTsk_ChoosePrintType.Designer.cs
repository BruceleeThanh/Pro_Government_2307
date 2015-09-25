namespace RoomManager
{
    partial class frmTsk_ChoosePrintType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTsk_ChoosePrintType));
            this.btnPrintByCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.loeListCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.btnPrintBookingR = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.loeListCustomer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintByCustomer
            // 
            this.btnPrintByCustomer.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Appearance.Image")));
            this.btnPrintByCustomer.Appearance.Options.UseImage = true;
            this.btnPrintByCustomer.Location = new System.Drawing.Point(199, 14);
            this.btnPrintByCustomer.Name = "btnPrintByCustomer";
            this.btnPrintByCustomer.Size = new System.Drawing.Size(187, 29);
            this.btnPrintByCustomer.TabIndex = 0;
            this.btnPrintByCustomer.Text = "In phiếu báo theo khách";
            this.btnPrintByCustomer.Click += new System.EventHandler(this.btnPrintByCustomer_Click);
            // 
            // loeListCustomer
            // 
            this.loeListCustomer.Location = new System.Drawing.Point(23, 18);
            this.loeListCustomer.Name = "loeListCustomer";
            this.loeListCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loeListCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.loeListCustomer.Properties.DisplayMember = "Name";
            this.loeListCustomer.Properties.NullText = "Chọn khách";
            this.loeListCustomer.Properties.NullValuePrompt = "Bạn chưa chọn khách";
            this.loeListCustomer.Properties.NullValuePromptShowForEmptyValue = true;
            this.loeListCustomer.Properties.ValueMember = "ID";
            this.loeListCustomer.Size = new System.Drawing.Size(170, 22);
            this.loeListCustomer.TabIndex = 1;
            // 
            // btnPrintBookingR
            // 
            this.btnPrintBookingR.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Appearance.Image1")));
            this.btnPrintBookingR.Appearance.Options.UseImage = true;
            this.btnPrintBookingR.Location = new System.Drawing.Point(199, 49);
            this.btnPrintBookingR.Name = "btnPrintBookingR";
            this.btnPrintBookingR.Size = new System.Drawing.Size(187, 29);
            this.btnPrintBookingR.TabIndex = 2;
            this.btnPrintBookingR.Text = "In phiếu báo cho phòng";
            // 
            // frmTsk_ChoosePrintType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 226);
            this.Controls.Add(this.btnPrintBookingR);
            this.Controls.Add(this.loeListCustomer);
            this.Controls.Add(this.btnPrintByCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmTsk_ChoosePrintType";
            this.ShowIcon = false;
            this.Text = "Chọn kiểu in phiếu báo thanh toán";
            this.Load += new System.EventHandler(this.frmTsk_ChoosePrintType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loeListCustomer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPrintByCustomer;
        private DevExpress.XtraEditors.LookUpEdit loeListCustomer;
        private DevExpress.XtraEditors.SimpleButton btnPrintBookingR;

    }
}