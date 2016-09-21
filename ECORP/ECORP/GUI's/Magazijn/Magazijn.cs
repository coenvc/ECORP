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
    public partial class Magazijn : Form
    {
        private MagazijnLogic ml = new MagazijnLogic(new MagazijnRepository());

        public Magazijn()
        {
            InitializeComponent();

            GetAllProducts(); 
        }

        private void GetAllProducts()
        {
            foreach (Product p in ml.GetAllProducts())
            {
                lbMagazijn.Items.Add(p);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
            this.Hide();
        }
    }
}
