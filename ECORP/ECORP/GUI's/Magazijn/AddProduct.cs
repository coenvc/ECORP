using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECORP.Classes;
using ECORP.Logic;
using ECORP.Repositories;

namespace ECORP.GUI_s.Magazijn
{
    public partial class AddProduct : Form
    {
        private MagazijnLogic ml = new MagazijnLogic(new MagazijnRepository());
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product p = new Product(tbName.Text, Convert.ToDecimal(tbPrijs.Text),
                Convert.ToInt32(tbSerienummer.Text), Convert.ToInt32(nudStock.Value));
            ml.InsertProduct(p);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Magazijn m = new Magazijn();
            m.Show();
            this.Hide();
            
        }
    }
}
