namespace ETravUpdater
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo2 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo6 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colApplicationname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dropDownButton2 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkButton6 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton5 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton4 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colApplicationname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicationguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtAppMoveV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtAppMoveN = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFileVerDeleete = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtAppdelete = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppMoveV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppMoveN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileVerDeleete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppdelete.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(410, 236);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "etrav-hack_Images_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT Applicationname,FileDate,ApplicationID, Version FROM tblapplications ";
            customSqlQuery2.Name = "Query_1";
            customSqlQuery2.Sql = "SELECT Applicationname,FileDate,Applicationguid, FileVersion FROM tblVSapplicatio" +
    "ns";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2});
            masterDetailInfo1.DetailQueryName = "Query_1";
            relationColumnInfo1.NestedKeyColumn = "Applicationname";
            relationColumnInfo1.ParentKeyColumn = "Applicationname";
            relationColumnInfo2.NestedKeyColumn = "Applicationguid";
            relationColumnInfo2.ParentKeyColumn = "ApplicationID";
            relationColumnInfo3.NestedKeyColumn = "FileDate";
            relationColumnInfo3.ParentKeyColumn = "FileDate";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo3);
            masterDetailInfo1.MasterQueryName = "Query";
            masterDetailInfo2.DetailQueryName = "Query";
            relationColumnInfo4.NestedKeyColumn = "Applicationname";
            relationColumnInfo4.ParentKeyColumn = "Applicationname";
            relationColumnInfo5.NestedKeyColumn = "ApplicationID";
            relationColumnInfo5.ParentKeyColumn = "Applicationguid";
            relationColumnInfo6.NestedKeyColumn = "FileDate";
            relationColumnInfo6.ParentKeyColumn = "FileDate";
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo4);
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo5);
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo6);
            masterDetailInfo2.MasterQueryName = "Query_1";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colApplicationname,
            this.colFileDate,
            this.colApplicationID,
            this.colVersion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colApplicationname
            // 
            this.colApplicationname.FieldName = "Applicationname";
            this.colApplicationname.Name = "colApplicationname";
            this.colApplicationname.Visible = true;
            this.colApplicationname.VisibleIndex = 0;
            // 
            // colFileDate
            // 
            this.colFileDate.FieldName = "FileDate";
            this.colFileDate.Name = "colFileDate";
            this.colFileDate.Visible = true;
            this.colFileDate.VisibleIndex = 1;
            // 
            // colApplicationID
            // 
            this.colApplicationID.FieldName = "ApplicationID";
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.Visible = true;
            this.colApplicationID.VisibleIndex = 2;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.Visible = true;
            this.colVersion.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.progressBarControl1);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.dropDownButton2);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.dropDownButton1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.checkButton6);
            this.panelControl1.Controls.Add(this.checkButton5);
            this.panelControl1.Controls.Add(this.checkButton4);
            this.panelControl1.Controls.Add(this.checkButton3);
            this.panelControl1.Controls.Add(this.checkButton2);
            this.panelControl1.Controls.Add(this.checkButton1);
            this.panelControl1.Location = new System.Drawing.Point(3, 48);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(428, 183);
            this.panelControl1.TabIndex = 0;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(0, 159);
            this.progressBarControl1.MenuManager = this.barManager1;
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(427, 22);
            this.progressBarControl1.TabIndex = 9;
            this.progressBarControl1.Visible = false;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1});
            this.barManager1.MaxItemId = 2;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemDateEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(871, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 525);
            this.barDockControlBottom.Size = new System.Drawing.Size(871, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 525);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(871, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 525);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemDateEdit1;
            this.barEditItem1.EditWidth = 91;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemDateEdit1.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(280, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "*Note: Default location is the New QCRR Database in U.S.";
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.AutoSize = true;
            this.dropDownButton2.AutoWidthInLayoutControl = true;
            this.dropDownButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dropDownButton2.DropDownControl = this.popupMenu2;
            this.dropDownButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton2.Location = new System.Drawing.Point(140, 117);
            this.dropDownButton2.Name = "dropDownButton2";
            this.dropDownButton2.Size = new System.Drawing.Size(124, 22);
            this.dropDownButton2.TabIndex = 1;
            this.dropDownButton2.Text = "Destination Location";
            this.dropDownButton2.Visible = false;
            this.dropDownButton2.Click += new System.EventHandler(this.dropDownButton2_Click);
            // 
            // popupMenu2
            // 
            this.popupMenu2.Manager = this.barManager1;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton2.Location = new System.Drawing.Point(164, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 36);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Reinsert Last App.";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.AutoSize = true;
            this.dropDownButton1.AutoWidthInLayoutControl = true;
            this.dropDownButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton1.Location = new System.Drawing.Point(4, 117);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(113, 22);
            this.dropDownButton1.TabIndex = 0;
            this.dropDownButton1.Text = "Location Selection\r\n";
            this.dropDownButton1.Visible = false;
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(8, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 36);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Insert Application";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkButton6
            // 
            this.checkButton6.AllowAllUnchecked = true;
            this.checkButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.checkButton6.Location = new System.Drawing.Point(270, 60);
            this.checkButton6.Name = "checkButton6";
            this.checkButton6.Size = new System.Drawing.Size(47, 25);
            this.checkButton6.TabIndex = 5;
            this.checkButton6.Text = "*.XML";
            this.checkButton6.CheckedChanged += new System.EventHandler(this.checkButton6_CheckedChanged);
            // 
            // checkButton5
            // 
            this.checkButton5.AllowAllUnchecked = true;
            this.checkButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.checkButton5.Location = new System.Drawing.Point(217, 60);
            this.checkButton5.Name = "checkButton5";
            this.checkButton5.Size = new System.Drawing.Size(47, 25);
            this.checkButton5.TabIndex = 4;
            this.checkButton5.Text = "*.INI";
            this.checkButton5.CheckedChanged += new System.EventHandler(this.checkButton5_CheckedChanged);
            // 
            // checkButton4
            // 
            this.checkButton4.AllowAllUnchecked = true;
            this.checkButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.checkButton4.Location = new System.Drawing.Point(164, 60);
            this.checkButton4.Name = "checkButton4";
            this.checkButton4.Size = new System.Drawing.Size(47, 25);
            this.checkButton4.TabIndex = 3;
            this.checkButton4.Text = "*.FR3";
            this.checkButton4.CheckedChanged += new System.EventHandler(this.checkButton4_CheckedChanged);
            // 
            // checkButton3
            // 
            this.checkButton3.AllowAllUnchecked = true;
            this.checkButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.checkButton3.Location = new System.Drawing.Point(111, 60);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(47, 25);
            this.checkButton3.TabIndex = 2;
            this.checkButton3.Text = "*.FRF";
            this.checkButton3.CheckedChanged += new System.EventHandler(this.checkButton3_CheckedChanged);
            // 
            // checkButton2
            // 
            this.checkButton2.AllowAllUnchecked = true;
            this.checkButton2.Appearance.Options.UseBackColor = true;
            this.checkButton2.Appearance.Options.UseForeColor = true;
            this.checkButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.checkButton2.Location = new System.Drawing.Point(58, 60);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(47, 25);
            this.checkButton2.TabIndex = 1;
            this.checkButton2.Text = "*.DLL";
            this.checkButton2.CheckedChanged += new System.EventHandler(this.checkButton2_CheckedChanged);
            // 
            // checkButton1
            // 
            this.checkButton1.AllowAllUnchecked = true;
            this.checkButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkButton1.Appearance.Options.UseForeColor = true;
            this.checkButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.checkButton1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.checkButton1.Location = new System.Drawing.Point(5, 60);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(47, 25);
            this.checkButton1.TabIndex = 0;
            this.checkButton1.Text = "*.EXE";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSize = true;
            this.panelControl2.Controls.Add(this.gridControl2);
            this.panelControl2.Location = new System.Drawing.Point(446, 260);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(422, 259);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Query_1";
            this.gridControl2.DataSource = this.sqlDataSource1;
            this.gridControl2.Location = new System.Drawing.Point(7, 5);
            this.gridControl2.MainView = this.gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(402, 236);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colApplicationname1,
            this.colFileDate1,
            this.colApplicationguid,
            this.colFileVersion});
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            // 
            // colApplicationname1
            // 
            this.colApplicationname1.FieldName = "Applicationname";
            this.colApplicationname1.Name = "colApplicationname1";
            this.colApplicationname1.Visible = true;
            this.colApplicationname1.VisibleIndex = 0;
            // 
            // colFileDate1
            // 
            this.colFileDate1.FieldName = "FileDate";
            this.colFileDate1.Name = "colFileDate1";
            this.colFileDate1.Visible = true;
            this.colFileDate1.VisibleIndex = 1;
            // 
            // colApplicationguid
            // 
            this.colApplicationguid.FieldName = "Applicationguid";
            this.colApplicationguid.Name = "colApplicationguid";
            this.colApplicationguid.Visible = true;
            this.colApplicationguid.VisibleIndex = 2;
            // 
            // colFileVersion
            // 
            this.colFileVersion.FieldName = "FileVersion";
            this.colFileVersion.Name = "colFileVersion";
            this.colFileVersion.Visible = true;
            this.colFileVersion.VisibleIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelControl3
            // 
            this.panelControl3.AutoSize = true;
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Location = new System.Drawing.Point(3, 260);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(428, 259);
            this.panelControl3.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(3, 235);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "OLD QCRR DB";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(3, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(142, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "INSERT OPTIONS";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(452, 235);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "NEW QCRR DB";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl8);
            this.panelControl4.Controls.Add(this.txtAppMoveV);
            this.panelControl4.Controls.Add(this.labelControl9);
            this.panelControl4.Controls.Add(this.txtAppMoveN);
            this.panelControl4.Controls.Add(this.simpleButton5);
            this.panelControl4.Controls.Add(this.hyperlinkLabelControl1);
            this.panelControl4.Controls.Add(this.labelControl7);
            this.panelControl4.Controls.Add(this.txtFileVerDeleete);
            this.panelControl4.Controls.Add(this.labelControl6);
            this.panelControl4.Controls.Add(this.txtAppdelete);
            this.panelControl4.Controls.Add(this.simpleButton4);
            this.panelControl4.Controls.Add(this.simpleButton3);
            this.panelControl4.Location = new System.Drawing.Point(446, 48);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(413, 182);
            this.panelControl4.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl8.LineVisible = true;
            this.labelControl8.Location = new System.Drawing.Point(297, 82);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "File Version";
            // 
            // txtAppMoveV
            // 
            this.txtAppMoveV.Enabled = false;
            this.txtAppMoveV.Location = new System.Drawing.Point(280, 101);
            this.txtAppMoveV.Name = "txtAppMoveV";
            this.txtAppMoveV.Size = new System.Drawing.Size(127, 20);
            this.txtAppMoveV.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl9.LineVisible = true;
            this.labelControl9.Location = new System.Drawing.Point(164, 83);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(82, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Application Name";
            // 
            // txtAppMoveN
            // 
            this.txtAppMoveN.Enabled = false;
            this.txtAppMoveN.Location = new System.Drawing.Point(147, 102);
            this.txtAppMoveN.Name = "txtAppMoveN";
            this.txtAppMoveN.Size = new System.Drawing.Size(127, 20);
            this.txtAppMoveN.TabIndex = 15;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton5.Enabled = false;
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton5.Location = new System.Drawing.Point(10, 97);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(132, 28);
            this.simpleButton5.TabIndex = 14;
            this.simpleButton5.Text = "Move To New DB";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(20, 139);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(0, 0);
            this.hyperlinkLabelControl1.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(295, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "File Version";
            // 
            // txtFileVerDeleete
            // 
            this.txtFileVerDeleete.Location = new System.Drawing.Point(278, 52);
            this.txtFileVerDeleete.Name = "txtFileVerDeleete";
            this.txtFileVerDeleete.Size = new System.Drawing.Size(127, 20);
            this.txtFileVerDeleete.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(162, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Application Name";
            // 
            // txtAppdelete
            // 
            this.txtAppdelete.Location = new System.Drawing.Point(145, 53);
            this.txtAppdelete.Name = "txtAppdelete";
            this.txtAppdelete.Size = new System.Drawing.Size(127, 20);
            this.txtAppdelete.TabIndex = 9;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton4.Location = new System.Drawing.Point(7, 48);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(132, 28);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Delete Selected";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton3.Location = new System.Drawing.Point(7, 0);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(132, 28);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Refresh DB Views";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(446, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(273, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "DATABASE MANAGEMENT TOOLS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 525);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ETravUpdater.Properties.Settings.Default, "USA", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = global::ETravUpdater.Properties.Settings.Default.USA;
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppMoveV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppMoveN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileVerDeleete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppdelete.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckButton checkButton6;
        private DevExpress.XtraEditors.CheckButton checkButton5;
        private DevExpress.XtraEditors.CheckButton checkButton4;
        private DevExpress.XtraEditors.CheckButton checkButton3;
        private DevExpress.XtraEditors.CheckButton checkButton2;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DropDownButton dropDownButton2;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationname;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationID;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationname1;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationguid;
        private DevExpress.XtraGrid.Columns.GridColumn colFileVersion;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtFileVerDeleete;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtAppdelete;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtAppMoveV;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtAppMoveN;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}

