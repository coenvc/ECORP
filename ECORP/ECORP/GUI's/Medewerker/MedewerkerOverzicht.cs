using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ECORP.GUI_s
{
    public partial class MedewerkerOverzicht : Form
    {

        MedewerkerLogic mwl = new MedewerkerLogic(new MedewerkerRepository());
        public MedewerkerOverzicht()
        {
           
            InitializeComponent();
            Update();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            ECORP.Medewerker m = lbMedewerkers.SelectedItem as ECORP.Medewerker;
            mwl.RemoveMedewerker(m);
            MessageBox.Show("De medewerker is verwijderd");
            Update();
        }

        private void Update()
        {
            lbMedewerkers.Items.Clear();
            foreach (ECORP.Medewerker m in mwl.GetAllMedewerkers())
            {
                lbMedewerkers.Items.Add(m);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Hide();
        }
    }
}
