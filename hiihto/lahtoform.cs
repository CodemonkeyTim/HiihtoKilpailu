using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using perusluokat;

namespace hiihto
{
    public partial class lahtoform : Form
    {

        Hiihtokilpailu kilpailu = new Hiihtokilpailu("Supermieskisat", "Lahti");
        List<int> kielletytnumerot = new List<int>();

        public lahtoform()
        {
            InitializeComponent();

            kisatiedot_label.Text = kilpailu.kilpailunimi + ", " + kilpailu.tapahtumapaikka;

            kilpailu.lisaaSarja("Sarja 1 miehet 15-17", 1, 15, 17); //testaussarjat
            kilpailu.lisaaSarja("Sarja 2 naiset 15-17", 0, 15, 17);

            kilpailu.lisaaKilpailija(new Kilpailija("Mies 1", "Jokuseura", 15, 1), 0); //testauskilpailijat
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 2", "Jokuseura", 16, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 3", "Jokuseura", 17, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 4", "Jokuseura", 15, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 5", "Jokuseura", 16, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 6", "Jokuseura", 17, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 7", "Jokuseura", 15, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 8", "Jokuseura", 16, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 9", "Jokuseura", 17, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 10", "Jokuseura", 15, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 11", "Jokuseura", 16, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 12", "Jokuseura", 17, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 13", "Jokuseura", 15, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 14", "Jokuseura", 16, 1), 0);
            kilpailu.lisaaKilpailija(new Kilpailija("Mies 15", "Jokuseura", 17, 1), 0);

            kilpailu.lisaaKilpailija(new Kilpailija("Nainen 1", "Jokuseura", 15, 0), 1);
            kilpailu.lisaaKilpailija(new Kilpailija("Nainen 2", "Jokuseura", 16, 0), 1);
            kilpailu.lisaaKilpailija(new Kilpailija("Nainen 3", "Jokuseura", 17, 0), 1);
            kilpailu.lisaaKilpailija(new Kilpailija("Nainen 4", "Jokuseura", 15, 0), 1);
            kilpailu.lisaaKilpailija(new Kilpailija("Nainen 5", "Jokuseura", 16, 0), 1);
            kilpailu.lisaaKilpailija(new Kilpailija("Nainen 6", "Jokuseura", 17, 0), 1);

            laht_sarjat_listBox.DataSource = kilpailu.annaSarjat();
            kielletyt_listBox.DataSource = kielletytnumerot;
        }

        private void kielletyt_lisaa_Button_Click(object sender, EventArgs e)
        {
            if (kielletyt_textBox.Text.Length > 0)
            {
                if (!(kielletytnumerot.Contains(Convert.ToInt32(kielletyt_textBox.Text))))
                {
                    kielletyt_listBox.DataSource = null;
                    kielletytnumerot.Add(Convert.ToInt32(kielletyt_textBox.Text));
                    kielletyt_listBox.Items.Clear();
                    kielletyt_listBox.DataSource = kielletytnumerot;
                }
                kielletyt_textBox.Clear();
            }
        }

        private void kielletyt_poista_Button_Click(object sender, EventArgs e)
        {
            if (kielletyt_listBox.SelectedIndex > -1)
            {
                int poistetava = kielletyt_listBox.SelectedIndex;
                kielletyt_listBox.DataSource = null;
                kielletytnumerot.RemoveAt(poistetava);
                kielletyt_listBox.Items.Clear();
                kielletyt_listBox.DataSource = kielletytnumerot;
            }
        }

        private void laht_sarjat_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (laht_sarjat_listBox.SelectedIndex > -1)
            {
                laht_kilpailijat_listBox.DataSource = null;
                laht_kilpailijat_listBox.Items.Clear();
                laht_kilpailijat_listBox.DataSource = kilpailu.annaKilpailijat(laht_sarjat_listBox.SelectedIndex);

                kilpailijoita_kpl_Label.Text = "Kilpailijoita sarjassa " + laht_kilpailijat_listBox.Items.Count + " kpl";
            }
        }

        private void kilpailija_ylospain_Button_Click(object sender, EventArgs e)
        {
            if (laht_kilpailijat_listBox.SelectedIndex > 0)
            {
                int selected = laht_kilpailijat_listBox.SelectedIndex;
                kilpailu.swapKilpailijat(laht_sarjat_listBox.SelectedIndex, laht_kilpailijat_listBox.SelectedIndex, (laht_kilpailijat_listBox.SelectedIndex - 1));
                laht_kilpailijat_listBox.DataSource = null;
                laht_kilpailijat_listBox.Items.Clear();
                laht_kilpailijat_listBox.DataSource = kilpailu.annaKilpailijat(laht_sarjat_listBox.SelectedIndex);
                laht_kilpailijat_listBox.SelectedIndex = selected - 1;
            }
        }

        private void kilpailja_alaspain_Button_Click(object sender, EventArgs e)
        {
            if (laht_kilpailijat_listBox.SelectedIndex < (kilpailu.annaKilpailijat(laht_sarjat_listBox.SelectedIndex).Count -1))
            {
                int selected = laht_kilpailijat_listBox.SelectedIndex;
                kilpailu.swapKilpailijat(laht_sarjat_listBox.SelectedIndex, laht_kilpailijat_listBox.SelectedIndex, (laht_kilpailijat_listBox.SelectedIndex + 1));
                laht_kilpailijat_listBox.DataSource = null;
                laht_kilpailijat_listBox.Items.Clear();
                laht_kilpailijat_listBox.DataSource = kilpailu.annaKilpailijat(laht_sarjat_listBox.SelectedIndex);
                laht_kilpailijat_listBox.SelectedIndex = selected + 1;
            }
        }

        private void kilpailija_jaa_numerot_Button_Click(object sender, EventArgs e)
        {
            if(laht_sarjat_listBox.SelectedIndex > -1)
            {
                int alkunumero = 0;
                if(textBox_kilpailijanumerotalkaen.Text.Length > 0)
                {
                    alkunumero = Convert.ToInt32(textBox_kilpailijanumerotalkaen.Text);
                }
                else
                {
                    alkunumero = 1;
                }
                kilpailu.jaaNumerot(laht_sarjat_listBox.SelectedIndex, kielletytnumerot, alkunumero);
                laht_kilpailijat_listBox.DataSource = null;
                laht_kilpailijat_listBox.Items.Clear();
                laht_kilpailijat_listBox.DataSource = kilpailu.annaKilpailijat(laht_sarjat_listBox.SelectedIndex);
            }
        }

        private void aloita_sarja_Button_Click(object sender, EventArgs e)
        {
            if (laht_sarjat_listBox.SelectedIndex > -1)
            {
                kilpailu.asetaLahtoajat(laht_sarjat_listBox.SelectedIndex);
            }
        }

        private void kilpailja_jaa_ryhmat_Button_Click(object sender, EventArgs e)
        {
            int lahtovali;
            int ryhmakoko;
            if (laht_sarjat_listBox.SelectedIndex > -1)
            {
                if (textBox_ryhmakoko.Text.Length > 0)
                {
                    ryhmakoko = Convert.ToInt32(textBox_ryhmakoko.Text);
                }
                else
                {
                    ryhmakoko = laht_kilpailijat_listBox.Items.Count;
                }
                    if (textBox_lahtovali.Text.Length > 0)
                    {
                        lahtovali = Convert.ToInt32(textBox_lahtovali.Text);
                    }
                    else
                    {
                        lahtovali = 30;
                    }

                    kilpailu.jaaRyhmat(laht_sarjat_listBox.SelectedIndex, ryhmakoko, lahtovali);
                    laht_kilpailijat_listBox.DataSource = null;
                    laht_kilpailijat_listBox.Items.Clear();
                    laht_kilpailijat_listBox.DataSource = kilpailu.annaKilpailijat(laht_sarjat_listBox.SelectedIndex);
                if (laht_sarjat_listBox.SelectedIndex > -1)
                {
                    int alkunumero;
                    if (textBox_kilpailijanumerotalkaen.Text.Length > 0)
                    {
                        alkunumero = Convert.ToInt32(textBox_kilpailijanumerotalkaen.Text);
                    }
                    else
                    {
                        alkunumero = 1;
                    }
                    kilpailu.jaaNumerot(laht_sarjat_listBox.SelectedIndex, kielletytnumerot, alkunumero);
                    laht_kilpailijat_listBox.DataSource = null;
                    laht_kilpailijat_listBox.Items.Clear();
                    laht_kilpailijat_listBox.DataSource = kilpailu.annaKilpailijat(laht_sarjat_listBox.SelectedIndex);
                }
            }
        }
    }
}
