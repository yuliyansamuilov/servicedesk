using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceDeskYULI.Frms
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }

        DBServiceDeskEntities db = new DBServiceDeskEntities();
        void method1()
        {
            var values = from u in db.TBL_PRODUCTINFO
                         select new
                         {
                             u.ID,
                             u.NAME,
                             u.BRAND,
                            category= u.TBL_CATEGORY.NAME,
                             u.BUY,
                             u.SELL,
                             u.STOCK,

                         };

            gridControl1.DataSource = values.ToList();

        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            // Listing, ToList Add Remove
            // var values = db.TBL_PRODUCTINFO.ToList();
            //gridControl1.DataSource = values;
            method1();
            lookUpEdit2.Properties.DataSource = db.TBL_CATEGORY.ToList();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TBL_PRODUCTINFO t = new TBL_PRODUCTINFO();
            t.NAME = TxtProductName.Text;
            t.BRAND = TxtBrandName.Text;
            t.BUY = decimal.Parse(TxtBuyPrice.Text);
            t.SELL = decimal.Parse(TxtSellPrice.Text);
            t.STOCK = short.Parse(TxtStock.Text);
            t.STATUS = false;
            t.CATOGORY = byte.Parse(lookUpEdit2.EditValue.ToString());
            //Ettity comments
            db.TBL_PRODUCTINFO.Add(t);
            db.SaveChanges();
            MessageBox.Show("Product Saved Succesfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var value = db.TBL_PRODUCTINFO.Find(id);
            db.TBL_PRODUCTINFO.Remove(value);
            db.SaveChanges();
            MessageBox.Show("Product removed succesfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            method1();

            //var values = db.TBL_PRODUCTINFO.ToList();
            // Make below with Methode!
            /*var values = from u in db.TBL_PRODUCTINFO
                         select new
                         {
                             u.ID,
                             u.NAME,
                             u.BRAND,
                             u.BUY,
                             u.SELL,
                             u.STOCK,

                         };

            gridControl1.DataSource = values;
            */
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtProductName.Text = gridView1.GetFocusedRowCellValue("NAME").ToString();
            TxtBrandName.Text = gridView1.GetFocusedRowCellValue("BRAND").ToString();
            TxtBuyPrice.Text = gridView1.GetFocusedRowCellValue("BUY").ToString();
            TxtSellPrice.Text = gridView1.GetFocusedRowCellValue("SELL").ToString();
            TxtStock.Text = gridView1.GetFocusedRowCellValue("STOCK").ToString();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var value = db.TBL_PRODUCTINFO.Find(id);
            value.NAME = TxtProductName.Text;
            value.BRAND = TxtBrandName.Text;
            value.STOCK = short.Parse(TxtStock.Text);
            value.SELL = decimal.Parse(TxtSellPrice.Text);
            value.BUY = decimal.Parse(TxtBuyPrice.Text);
            value.CATOGORY = byte.Parse(lookUpEdit2.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Product refreshed succesfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
