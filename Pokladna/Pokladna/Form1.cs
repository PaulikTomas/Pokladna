using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
    public partial class Form1 : Form
    {
        List<PokladniZaznam> pokladna;
        IRepos repositar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JasonRepos jasonRepos = new JasonRepos("data.Json");
            //jasonRepos.VytvorTestData();
            SqlRepos sqlRepos = new SqlRepos();
            //sqlRepos.VytvorTestData(jasonRepos.NactiVse());

            repositar = sqlRepos;

            comboBoxRok.SelectedIndex = comboBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
            comboBoxMesic.SelectedIndex = DateTime.Now.Month - 1;
            /*repositar = new SqlRepos();
            repositar = new XmlRepos();
            pokladna = repositar.NactiVse();
            foreach (var p in pokladna)
            {
                lvData.Items.Add(p.DolvItem());
            }*/
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            NactiDataAktMesic();
        }

        private void NactiDataAktMesic()
        {
            if(comboBoxRok.SelectedIndex >= 0 && comboBoxMesic.SelectedIndex >=0)
            {
                pokladna = repositar.NactiMesic(int.Parse(comboBoxRok.SelectedItem.ToString()), comboBoxMesic.SelectedIndex + 1);
                lvData.Items.Clear();
                foreach(var p in pokladna)
                {
                    lvData.Items.Add(p.DolvItem());
                }
            }
        }

        private void textBoxCislo_TextChanged(object sender, EventArgs e)
        {
            buttonUlozit.Enabled = textBoxCislo.Text != "";
        }

        private void textBoxPopis_TextChanged(object sender, EventArgs e)
        {
            buttonUlozitJako.Enabled = textBoxPopis.Text.Trim() != "" && numericUpDownCastka.Value != 0;
        }

        private void numericUpDownCastka_ValueChanged(object sender, EventArgs e)
        {
            buttonUlozitJako.Enabled = textBoxPopis.Text.Trim() != "" && numericUpDownCastka.Value != 0;
        }

        private void buttonUlozitJako_Click(object sender, EventArgs e)
        {
            PokladniZaznam novyZaznam = new PokladniZaznam(dateTimePickerDatum.Value, textBoxPopis.Text, (double)numericUpDownCastka.Value, textBoxPoznamka.Text);
            repositar.VytvorZaznam(novyZaznam);
            NactiDataAktMesic();
            textBoxPopis.Text = "";
            numericUpDownCastka.Value = 0;
            textBoxPoznamka.Text = "";
        }
    }
}
