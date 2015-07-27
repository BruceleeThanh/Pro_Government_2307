namespace RoomManager.FormTask {
    partial class frmTsk_BookingForRoomByType {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTsk_BookingForRoomByType));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labStandard = new DevExpress.XtraEditors.LabelControl();
            this.labSuperior = new DevExpress.XtraEditors.LabelControl();
            this.labSuite = new DevExpress.XtraEditors.LabelControl();
            this.dtpFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtpTo = new DevExpress.XtraEditors.DateEdit();
            this.btnBooking = new DevExpress.XtraEditors.SimpleButton();
            this.txtStandardBooking = new DevExpress.XtraEditors.TextEdit();
            this.txtSuperiorBooking = new DevExpress.XtraEditors.TextEdit();
            this.txtSuiteBooking = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameCustomer = new DevExpress.XtraEditors.TextEdit();
            this.lueIDCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListBookingRoom = new DevExpress.XtraGrid.GridControl();
            this.viewListBookingRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FromDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuiteType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SuperiorType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StandardType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardBooking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuperiorBooking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuiteBooking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueIDCustomer.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBookingRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListBookingRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.labStandard);
            this.groupBox1.Controls.Add(this.labSuperior);
            this.groupBox1.Controls.Add(this.labSuite);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.btnBooking);
            this.groupBox1.Controls.Add(this.txtStandardBooking);
            this.groupBox1.Controls.Add(this.txtSuperiorBooking);
            this.groupBox1.Controls.Add(this.txtSuiteBooking);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtNameCustomer);
            this.groupBox1.Controls.Add(this.lueIDCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt phòng";
            // 
            // labStandard
            // 
            this.labStandard.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labStandard.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labStandard.Location = new System.Drawing.Point(416, 137);
            this.labStandard.Name = "labStandard";
            this.labStandard.Size = new System.Drawing.Size(69, 13);
            this.labStandard.TabIndex = 30;
            this.labStandard.Text = "labelControl10";
            // 
            // labSuperior
            // 
            this.labSuperior.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labSuperior.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labSuperior.Location = new System.Drawing.Point(292, 137);
            this.labSuperior.Name = "labSuperior";
            this.labSuperior.Size = new System.Drawing.Size(63, 13);
            this.labSuperior.TabIndex = 29;
            this.labSuperior.Text = "labelControl9";
            // 
            // labSuite
            // 
            this.labSuite.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labSuite.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labSuite.Location = new System.Drawing.Point(165, 137);
            this.labSuite.Name = "labSuite";
            this.labSuite.Size = new System.Drawing.Size(63, 13);
            this.labSuite.TabIndex = 28;
            this.labSuite.Text = "labelControl8";
            // 
            // dtpFrom
            // 
            this.dtpFrom.EditValue = null;
            this.dtpFrom.Location = new System.Drawing.Point(77, 79);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFrom.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtpFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFrom.Properties.Mask.EditMask = "([012]?[1-9]|[123]0|31)/(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9] (0?\\d|1\\d|2[0-3]" +
    "):[0-5]\\d";
            this.dtpFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.dtpFrom.Size = new System.Drawing.Size(143, 20);
            this.dtpFrom.TabIndex = 24;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(247, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Đến ngày";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(25, 82);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "Từ ngày";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Appearance.Options.UseTextOptions = true;
            this.btnSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(496, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Tìm phòng";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.EditValue = null;
            this.dtpTo.Location = new System.Drawing.Point(304, 79);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTo.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.dtpTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpTo.Properties.Mask.EditMask = "([012]?[1-9]|[123]0|31)/(0?[1-9]|1[012])/([123][0-9])?[0-9][0-9] (0?\\d|1\\d|2[0-3]" +
    "):[0-5]\\d";
            this.dtpTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.dtpTo.Size = new System.Drawing.Size(165, 20);
            this.dtpTo.TabIndex = 26;
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBooking.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBooking.Appearance.Options.UseFont = true;
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.Location = new System.Drawing.Point(495, 137);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(100, 39);
            this.btnBooking.TabIndex = 22;
            this.btnBooking.Text = "Đặt phòng";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // txtStandardBooking
            // 
            this.txtStandardBooking.Location = new System.Drawing.Point(368, 160);
            this.txtStandardBooking.Name = "txtStandardBooking";
            this.txtStandardBooking.Properties.Appearance.Options.UseTextOptions = true;
            this.txtStandardBooking.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtStandardBooking.Size = new System.Drawing.Size(100, 20);
            this.txtStandardBooking.TabIndex = 21;
            // 
            // txtSuperiorBooking
            // 
            this.txtSuperiorBooking.Location = new System.Drawing.Point(246, 160);
            this.txtSuperiorBooking.Name = "txtSuperiorBooking";
            this.txtSuperiorBooking.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSuperiorBooking.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSuperiorBooking.Size = new System.Drawing.Size(100, 20);
            this.txtSuperiorBooking.TabIndex = 20;
            // 
            // txtSuiteBooking
            // 
            this.txtSuiteBooking.Location = new System.Drawing.Point(119, 160);
            this.txtSuiteBooking.Name = "txtSuiteBooking";
            this.txtSuiteBooking.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSuiteBooking.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSuiteBooking.Size = new System.Drawing.Size(100, 20);
            this.txtSuiteBooking.TabIndex = 19;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(398, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Standard";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(268, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Superior";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(154, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Suite";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(25, 163);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Phòng đặt";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(25, 137);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Phòng trống";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(247, 34);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Properties.MaxLength = 50;
            this.txtNameCustomer.Properties.NullValuePrompt = "Thêm mới người đại diện";
            this.txtNameCustomer.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNameCustomer.Size = new System.Drawing.Size(222, 20);
            this.txtNameCustomer.TabIndex = 10;
            this.txtNameCustomer.EditValueChanged += new System.EventHandler(this.txtNameCustomer_EditValueChanged);
            // 
            // lueIDCustomer
            // 
            this.lueIDCustomer.Location = new System.Drawing.Point(25, 34);
            this.lueIDCustomer.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.lueIDCustomer.Name = "lueIDCustomer";
            this.lueIDCustomer.Properties.Appearance.Options.UseTextOptions = true;
            this.lueIDCustomer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lueIDCustomer.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lueIDCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueIDCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 70, "Tên người đại diện"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Identifier1", 30, "CMTND/GTK")});
            this.lueIDCustomer.Properties.NullText = "";
            this.lueIDCustomer.Properties.NullValuePrompt = "Chọn người đại diện";
            this.lueIDCustomer.Properties.NullValuePromptShowForEmptyValue = true;
            this.lueIDCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueIDCustomer.Size = new System.Drawing.Size(195, 20);
            this.lueIDCustomer.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dgvListBookingRoom);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(6, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đặt phòng";
            // 
            // dgvListBookingRoom
            // 
            this.dgvListBookingRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListBookingRoom.Location = new System.Drawing.Point(6, 20);
            this.dgvListBookingRoom.MainView = this.viewListBookingRoom;
            this.dgvListBookingRoom.Name = "dgvListBookingRoom";
            this.dgvListBookingRoom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete,
            this.btnEdit});
            this.dgvListBookingRoom.Size = new System.Drawing.Size(750, 264);
            this.dgvListBookingRoom.TabIndex = 0;
            this.dgvListBookingRoom.UseEmbeddedNavigator = true;
            this.dgvListBookingRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewListBookingRoom});
            // 
            // viewListBookingRoom
            // 
            this.viewListBookingRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerName,
            this.FromDate,
            this.ToDate,
            this.SuiteType,
            this.SuperiorType,
            this.StandardType,
            this.Edit,
            this.Delete});
            this.viewListBookingRoom.GridControl = this.dgvListBookingRoom;
            this.viewListBookingRoom.Name = "viewListBookingRoom";
            this.viewListBookingRoom.OptionsFind.AlwaysVisible = true;
            this.viewListBookingRoom.OptionsView.EnableAppearanceEvenRow = true;
            this.viewListBookingRoom.OptionsView.ShowGroupPanel = false;
            this.viewListBookingRoom.OptionsView.ShowIndicator = false;
            // 
            // CustomerName
            // 
            this.CustomerName.AppearanceCell.Options.UseTextOptions = true;
            this.CustomerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustomerName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.CustomerName.AppearanceHeader.Options.UseFont = true;
            this.CustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.CustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CustomerName.Caption = "Tên khách";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.OptionsColumn.AllowEdit = false;
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 0;
            this.CustomerName.Width = 195;
            // 
            // FromDate
            // 
            this.FromDate.AppearanceCell.Options.UseTextOptions = true;
            this.FromDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FromDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.FromDate.AppearanceHeader.Options.UseFont = true;
            this.FromDate.AppearanceHeader.Options.UseTextOptions = true;
            this.FromDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FromDate.Caption = "Ngày đến";
            this.FromDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.FromDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.FromDate.FieldName = "FromDate";
            this.FromDate.GroupFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.FromDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.FromDate.Name = "FromDate";
            this.FromDate.OptionsColumn.AllowEdit = false;
            this.FromDate.Visible = true;
            this.FromDate.VisibleIndex = 1;
            this.FromDate.Width = 142;
            // 
            // ToDate
            // 
            this.ToDate.AppearanceCell.Options.UseTextOptions = true;
            this.ToDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ToDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ToDate.AppearanceHeader.Options.UseFont = true;
            this.ToDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ToDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ToDate.Caption = "Ngày đi";
            this.ToDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.ToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ToDate.FieldName = "ToDate";
            this.ToDate.GroupFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.ToDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ToDate.Name = "ToDate";
            this.ToDate.OptionsColumn.AllowEdit = false;
            this.ToDate.Visible = true;
            this.ToDate.VisibleIndex = 2;
            this.ToDate.Width = 134;
            // 
            // SuiteType
            // 
            this.SuiteType.AppearanceCell.Options.UseTextOptions = true;
            this.SuiteType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SuiteType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuiteType.AppearanceHeader.Options.UseFont = true;
            this.SuiteType.AppearanceHeader.Options.UseTextOptions = true;
            this.SuiteType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SuiteType.Caption = "Suite";
            this.SuiteType.FieldName = "Suite";
            this.SuiteType.Name = "SuiteType";
            this.SuiteType.OptionsColumn.AllowEdit = false;
            this.SuiteType.Visible = true;
            this.SuiteType.VisibleIndex = 3;
            this.SuiteType.Width = 58;
            // 
            // SuperiorType
            // 
            this.SuperiorType.AppearanceCell.Options.UseTextOptions = true;
            this.SuperiorType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SuperiorType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuperiorType.AppearanceHeader.Options.UseFont = true;
            this.SuperiorType.AppearanceHeader.Options.UseTextOptions = true;
            this.SuperiorType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SuperiorType.Caption = "Superior";
            this.SuperiorType.FieldName = "Superior";
            this.SuperiorType.Name = "SuperiorType";
            this.SuperiorType.OptionsColumn.AllowEdit = false;
            this.SuperiorType.Visible = true;
            this.SuperiorType.VisibleIndex = 4;
            this.SuperiorType.Width = 63;
            // 
            // StandardType
            // 
            this.StandardType.AppearanceCell.Options.UseTextOptions = true;
            this.StandardType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StandardType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.StandardType.AppearanceHeader.Options.UseFont = true;
            this.StandardType.AppearanceHeader.Options.UseTextOptions = true;
            this.StandardType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StandardType.Caption = "Standard";
            this.StandardType.FieldName = "Standard";
            this.StandardType.Name = "StandardType";
            this.StandardType.OptionsColumn.AllowEdit = false;
            this.StandardType.Visible = true;
            this.StandardType.VisibleIndex = 5;
            this.StandardType.Width = 65;
            // 
            // Edit
            // 
            this.Edit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Edit.AppearanceHeader.Options.UseFont = true;
            this.Edit.AppearanceHeader.Options.UseTextOptions = true;
            this.Edit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit.Caption = "Sửa";
            this.Edit.ColumnEdit = this.btnEdit;
            this.Edit.Name = "Edit";
            this.Edit.Visible = true;
            this.Edit.VisibleIndex = 6;
            this.Edit.Width = 46;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_ButtonClick);
            // 
            // Delete
            // 
            this.Delete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Delete.AppearanceHeader.Options.UseFont = true;
            this.Delete.AppearanceHeader.Options.UseTextOptions = true;
            this.Delete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Delete.Caption = "Xóa";
            this.Delete.ColumnEdit = this.btnDelete;
            this.Delete.Name = "Delete";
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 7;
            this.Delete.Width = 45;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // frmTsk_BookingForRoomByType
            // 
            this.Appearance.Image = global::RoomManager.Properties.Resources.Picker;
            this.Appearance.Options.UseImage = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(777, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTsk_BookingForRoomByType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng theo loại";
            this.Load += new System.EventHandler(this.frmTsk_BookingForRoomByType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStandardBooking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuperiorBooking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuiteBooking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueIDCustomer.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBookingRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListBookingRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl dgvListBookingRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView viewListBookingRoom;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn FromDate;
        private DevExpress.XtraGrid.Columns.GridColumn ToDate;
        private DevExpress.XtraGrid.Columns.GridColumn SuiteType;
        private DevExpress.XtraGrid.Columns.GridColumn SuperiorType;
        private DevExpress.XtraGrid.Columns.GridColumn StandardType;
        private DevExpress.XtraEditors.SimpleButton btnBooking;
        private DevExpress.XtraEditors.TextEdit txtStandardBooking;
        private DevExpress.XtraEditors.TextEdit txtSuperiorBooking;
        private DevExpress.XtraEditors.TextEdit txtSuiteBooking;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNameCustomer;
        private DevExpress.XtraEditors.LookUpEdit lueIDCustomer;
        private DevExpress.XtraEditors.DateEdit dtpFrom;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit dtpTo;
        private DevExpress.XtraEditors.LabelControl labSuite;
        private DevExpress.XtraEditors.LabelControl labStandard;
        private DevExpress.XtraEditors.LabelControl labSuperior;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraGrid.Columns.GridColumn Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;

    }
}