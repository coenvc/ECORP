﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECORP.GUI_s;

namespace ECORP
{
    public partial class Form1 : Form
    {
       
        private MedewerkerLogic mwl = new MedewerkerLogic(new MedewerkerRepository());
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Afdeling));
            DateTime d = new DateTime(1996, 08, 23);
            Address a = new Address("Guido Gezellelaan", "berkel-Enschot", "5056TK", 21);
            Medewerker m = new Medewerker("Verkoper", d, 3000, "Coen", "van Campenhout", "coenvc@gmail.com", 0683992086,
                Afdeling.Verkoop, a);
            mwl.InsertMedewerker(m);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Afdeling afdeling = (Afdeling) Enum.Parse(typeof(Afdeling), comboBox1.SelectedValue.ToString());
                Address a = new Address(tbStraatNaam.Text, tbWoonplaats.Text, tbPostcode.Text,Convert.ToInt32(tbHuisnummer.Text));
                Medewerker m = new Medewerker(tbRol.Text, dateTimePicker1.Value, Convert.ToDecimal(tbSalaris.Text),
                    tbNaam.Text, tbAchternaam.Text, tbEmail.Text, Convert.ToInt32(tbTelefoonnummer.Text),afdeling
                    , a);

                mwl.InsertMedewerker(m);
         }

        private void btnBack_Click(object sender, EventArgs e)
        {
           // mwl.Log();
            MedewerkerOverzicht overzicht = new MedewerkerOverzicht();
            overzicht.Show();
            this.Hide(); 
            
        }
    }
}
