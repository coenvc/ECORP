using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECORP.GUI_s.Medewerker;
using ECORP;

namespace ECORP.GUI_s.Medewerker
{
    public partial class UpdateMedewerker : Form
    {
        private ECORP.Medewerker mw;
        MedewerkerLogic mwl = new MedewerkerLogic(new MedewerkerRepository());
        public UpdateMedewerker(ECORP.Medewerker m)
        {
            this.mw = m;
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Afdeling));
            tbNaam.Text = m.Naam;
            tbAchternaam.Text = m.Achternaam;
            tbEmail.Text = m.Email;
            tbAchternaam.Text = m.Email;
            tbHuisnummer.Text = m.Adddres.Huisnummer.ToString();
            tbPostcode.Text = m.Adddres.Postcode;
            tbWoonplaats.Text = m.Adddres.Woonplaats;
            tbTelefoonnummer.Text = m.Telefoonnummer.ToString();
            tbSalaris.Text = m.Salaris.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Afdeling afdeling = (Afdeling)Enum.Parse(typeof(Afdeling), comboBox1.SelectedValue.ToString());
            Address a = new Address(tbStraatNaam.Text, tbWoonplaats.Text, tbPostcode.Text, Convert.ToInt32(tbHuisnummer.Text));
            ECORP.Medewerker nm = new ECORP.Medewerker(tbRol.Text, dateTimePicker1.Value, Convert.ToDecimal(tbSalaris.Text),tbNaam.Text, tbAchternaam.Text, tbEmail.Text, Convert.ToInt32(tbTelefoonnummer.Text), afdeling, a);
            mwl.UpdateMedewerker(mw,nm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
