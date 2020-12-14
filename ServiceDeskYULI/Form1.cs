using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceDeskYULI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProductListForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frms.FrmProductList frm = new Frms.FrmProductList();
            frm.MdiParent = this;
            frm.Show();








        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frms.FrmNewProduct frm = new Frms.FrmNewProduct();
            //frm.MdiParent = this;
            frm.Show();

        }
    }
}
