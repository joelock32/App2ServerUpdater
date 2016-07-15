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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkButton6 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton5 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton4 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dropDownButton2 = new DevExpress.XtraEditors.DropDownButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colApplicationname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicationID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.checkButton6);
            this.panelControl1.Controls.Add(this.checkButton5);
            this.panelControl1.Controls.Add(this.checkButton4);
            this.panelControl1.Controls.Add(this.checkButton3);
            this.panelControl1.Controls.Add(this.checkButton2);
            this.panelControl1.Controls.Add(this.checkButton1);
            this.panelControl1.Location = new System.Drawing.Point(3, 48);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(269, 260);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(128, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 28);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Reinsert Last App.";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(6, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 28);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Insert Application";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkButton6
            // 
            this.checkButton6.Location = new System.Drawing.Point(6, 185);
            this.checkButton6.Name = "checkButton6";
            this.checkButton6.Size = new System.Drawing.Size(47, 25);
            this.checkButton6.TabIndex = 5;
            this.checkButton6.Text = "*.XML";
            // 
            // checkButton5
            // 
            this.checkButton5.Location = new System.Drawing.Point(6, 154);
            this.checkButton5.Name = "checkButton5";
            this.checkButton5.Size = new System.Drawing.Size(47, 25);
            this.checkButton5.TabIndex = 4;
            this.checkButton5.Text = "*.INI";
            // 
            // checkButton4
            // 
            this.checkButton4.Location = new System.Drawing.Point(6, 123);
            this.checkButton4.Name = "checkButton4";
            this.checkButton4.Size = new System.Drawing.Size(47, 25);
            this.checkButton4.TabIndex = 3;
            this.checkButton4.Text = "*.FR3";
            // 
            // checkButton3
            // 
            this.checkButton3.Location = new System.Drawing.Point(6, 92);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(47, 25);
            this.checkButton3.TabIndex = 2;
            this.checkButton3.Text = "*.FRF";
            // 
            // checkButton2
            // 
            this.checkButton2.Location = new System.Drawing.Point(6, 60);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(47, 25);
            this.checkButton2.TabIndex = 1;
            this.checkButton2.Text = "*.DLL";
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(6, 29);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(47, 25);
            this.checkButton1.TabIndex = 0;
            this.checkButton1.Text = "*.EXE";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dropDownButton2);
            this.panelControl2.Controls.Add(this.dropDownButton1);
            this.panelControl2.Location = new System.Drawing.Point(297, 60);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(426, 121);
            this.panelControl2.TabIndex = 1;
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.Location = new System.Drawing.Point(5, 48);
            this.dropDownButton2.Name = "dropDownButton2";
            this.dropDownButton2.Size = new System.Drawing.Size(343, 22);
            this.dropDownButton2.TabIndex = 1;
            this.dropDownButton2.Text = "Destination Location";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton1.Location = new System.Drawing.Point(5, 6);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(343, 18);
            this.dropDownButton1.TabIndex = 0;
            this.dropDownButton1.Text = "Location Selection\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Location = new System.Drawing.Point(3, 314);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(714, 239);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(0, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(709, 219);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "etrav-hack_Images_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery5.Name = "Query";
            customSqlQuery5.Sql = "SELECT Applicationname,FileDate, ApplicationID FROM tblapplications ";
            customSqlQuery6.Name = "Query_1";
            customSqlQuery6.Sql = "SELECT Applicationname,FileDate,Applicationguid FROM tblVSapplications";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery5,
            customSqlQuery6});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colApplicationname,
            this.colFileDate,
            this.colApplicationID});
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
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 550);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Insert Application Updater";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationname;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDate;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationID;
    }
}

