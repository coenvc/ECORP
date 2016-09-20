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
        MedewerkerLogic mwl = new MedewerkerLogic();
        public MedewerkerOverzicht()
        {
            InitializeComponent();
            Update();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Medewerker m = lbMedewerkers.SelectedItem as Medewerker;
            mwl.RemoveMedewerker(m);
            MessageBox.Show("De medewerker is verwijderd");
            Update();
        }

        private void Update()
        {
            lbMedewerkers.Items.Clear();
            foreach (Medewerker m in mwl.GetAllMedewerkers())
            {
                lbMedewerkers.Items.Add(m);
            }
        }
    }
}
