using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace KolekcijeUnosIspis
{


    public partial class Form1 : Form
    {

        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();



        }
        class Vozilo
        {
            string marka, model, vrsta;
            string voziPo;

            public string VoziPo { get => voziPo; set => voziPo = value; }
            public string Marka { get => marka; set => marka = value; }
            public string Model { get => model; set => model = value; }
            public string Vrsta { get => vrsta; set => vrsta = value; }

            public Vozilo(string marka, string model, string vrsta)
            {
                this.marka = marka;
                this.model = model;
                this.vrsta = vrsta;

            }

            public override string ToString()
            {
                return "Marka: " + this.marka + "\nModel" + this.model + "\nVrsta: " + this.vrsta + "\nVozi po: " + this.voziPo + "\n\r";
            }




        }

        private void btnUnos_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMarka.Text == "" ||
                    txtModel.Text == "" ||
                    cmbxVrsta.Text == "")
                {

                    Vozilo vozilo = new Vozilo(txtMarka.Text, txtModel.Text, cmbxVrsta.Text);
                    voziloList.Add(vozilo);
                    txtModel.Clear();
                    txtMarka.Clear();
                }


            }

            catch
            {
                MessageBox.Show("Pogresan unos, pokusajte opet", "Pogresan Unos", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }


        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            foreach (Vozilo v in voziloList)
            {
                txtIspis.AppendText(v.ToString());
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (Vozilo v in voziloList)
            {
                if (v.Vrsta == "Avion")
                {
                    v.VoziPo = "Zrak";
                }
                else if (v.Vrsta == "Automobil")
                {
                    v.VoziPo = "Cesta";
                }
                else
                {
                    v.VoziPo = "Voda";
                }
            }
        }
























        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbxVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
