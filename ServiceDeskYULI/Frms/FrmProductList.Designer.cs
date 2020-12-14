namespace ServiceDeskYULI.Frms
{
    partial class FrmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnList = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtStock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSellPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBuyPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBrandName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSellPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuyPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1498, 790);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Silver;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnList);
            this.groupControl1.Controls.Add(this.BtnRefresh);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.TxtStock);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtSellPrice);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtBuyPrice);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtBrandName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lookUpEdit2);
            this.groupControl1.Controls.Add(this.TxtProductName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1505, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(494, 735);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Product Operations";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(199, 63);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(150, 28);
            this.TxtId.TabIndex = 21;
            this.TxtId.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(74, 67);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 19);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Product ID";
            // 
            // BtnList
            // 
            this.BtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.ImageOptions.Image")));
            this.BtnList.Location = new System.Drawing.Point(178, 637);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(150, 78);
            this.BtnList.TabIndex = 19;
            this.BtnList.Text = "LIST";
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.ImageOptions.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(178, 542);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(150, 78);
            this.BtnRefresh.TabIndex = 18;
            this.BtnRefresh.Text = "REFRESH";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(178, 445);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(150, 78);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "DELETE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(200, 238);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(150, 28);
            this.TxtStock.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(74, 242);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 19);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Stock";
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(199, 202);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(150, 28);
            this.TxtSellPrice.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(74, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 19);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Sell Price";
            // 
            // TxtBuyPrice
            // 
            this.TxtBuyPrice.Location = new System.Drawing.Point(199, 168);
            this.TxtBuyPrice.Name = "TxtBuyPrice";
            this.TxtBuyPrice.Size = new System.Drawing.Size(150, 28);
            this.TxtBuyPrice.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(74, 172);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 19);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Buy Price";
            // 
            // TxtBrandName
            // 
            this.TxtBrandName.Location = new System.Drawing.Point(199, 134);
            this.TxtBrandName.Name = "TxtBrandName";
            this.TxtBrandName.Size = new System.Drawing.Size(150, 28);
            this.TxtBrandName.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(74, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 19);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Brand Name";
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(178, 350);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 78);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(74, 276);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Category";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(199, 272);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "NAME";
            this.lookUpEdit2.Properties.ValueMember = "ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(150, 28);
            this.lookUpEdit2.TabIndex = 6;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(199, 99);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(150, 28);
            this.TxtProductName.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(74, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Product Name";
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(2011, 750);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmProductList";
            this.Text = "FrmProductList";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSellPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuyPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProductName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.TextEdit TxtProductName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit TxtStock;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtSellPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtBuyPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtBrandName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnList;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}