//
//Päästäksesi käsiin sarjakohtaisiin funktioihin tulee sinun kutsua niitä Hiihtokilpailu-emo-olion kautta; esim:
//
//(Formin luodaamisen sisällä:)
//kilpailu.lisaaSarja("Sarja 1 miehet 15-17", 1, 15, 17);
//kilpailu.lisaaSarja("Sarja 2 naiset 15-17", 0, 15, 17);
//kilpailu.lisaaKilpailija(new Kilpailija("Mies 14", "Jokuseura", 16, 1), 0); //viimeisin numero on sarjan index eli monenteen sarjaan lisätään
//kilpailu.lisaaKilpailija(new Kilpailija("Mies 15", "Jokuseura", 17, 1), 0);
//kilpailu.lisaaKilpailija(new Kilpailija("Nainen 1", "Jokuseura", 15, 0), 1); //viimeisin numero on sarjan index eli monenteen sarjaan lisätään
//kilpailu.lisaaKilpailija(new Kilpailija("Nainen 2", "Jokuseura", 16, 0), 1);
//(formin loadaaminen loppuu)
//formin koodissa:
//kilpailu.jaaNumerot(laht_sarjat_listBox.SelectedIndex, kielletytnumerot, alkunumero);
//ELI: Kutsutaan hiihtokilpailu-olion funktiota jaaNumerot joka kutsuu annetun indeksin perusteella kyseisen sarjan funktiota jaaNumerot joka taas jakaa kilpailijoileen numerot
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace perusluokat
{
    [Serializable()]
    public class Kilpailija : ISerializable
    {
        public string nimi;
        public string seura;
        public int ika;
        public int sukupuoli;

        public long lahtoaika;
        public long maaliintuloaika;

        public int kilpailunumero;
        public int lahtoryhma;

        public override string ToString()
        {
            return "Nro: " + kilpailunumero + ", Ryhmä: " + lahtoryhma + ", Nimi: " + nimi + ", Seura; " + seura + ", Ikä: " + ika;
        }

        public Kilpailija(string _nimi, string _seura, int _ika, int _sukupuoli)
        {
            nimi = _nimi;
            seura = _seura;
            ika = _ika;
            sukupuoli = _sukupuoli;

            lahtoaika = -1;
            maaliintuloaika = -1;
            kilpailunumero = -1;
            lahtoryhma = -1;
        }

        public Kilpailija(SerializationInfo info, StreamingContext ctxt)
        {
            this.nimi = (string)info.GetValue("nimi", typeof(string));
            this.ika = (int)info.GetValue("ika", typeof(int));
            this.sukupuoli = (int)info.GetValue("sukupuoli", typeof(int));
            this.lahtoaika = (long)info.GetValue("lahtoaika", typeof(long));
            this.maaliintuloaika = (long)info.GetValue("maaliintuloaika", typeof(long));
            this.kilpailunumero = (int)info.GetValue("kilpailunumero", typeof(int));
            this.lahtoryhma = (int)info.GetValue("lahtoryhma", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("nimi", this.nimi);
            info.AddValue("ika", this.ika);
            info.AddValue("sukupuoli", this.sukupuoli);
            info.AddValue("lahtoaika", this.lahtoaika);
            info.AddValue("maaliintuloaika", this.maaliintuloaika);
            info.AddValue("kilpailunumero", this.kilpailunumero);
            info.AddValue("lahtoryhma", this.lahtoryhma);
        }
    }

    [Serializable()]
    public class Sarja : ISerializable
    {
        List<Kilpailija> kilpailijalista;

        public string sarjanimi;
        public int vaadittusukupuoli;
        public int ikaMin;
        public int ikaMax;

        public void swapKilpailijat(int _kilpailijaIndex1, int _kilpailijaIndex2) // vaihtaa kahden kilpailijan paikkaa listalla annettujen indeksien perusteella
        {
            if (_kilpailijaIndex1 > -1 && _kilpailijaIndex2 > -1 && _kilpailijaIndex1 <= kilpailijalista.Count && _kilpailijaIndex2 <= kilpailijalista.Count)
            {
                Kilpailija tempkisaaja;
                tempkisaaja = kilpailijalista[_kilpailijaIndex1];
                kilpailijalista[_kilpailijaIndex1] = kilpailijalista[_kilpailijaIndex2];
                kilpailijalista[_kilpailijaIndex2] = tempkisaaja;
            }
        }

        public int annaKilpailijanNumero(int _index) //palauttaa kysytyn indexin kilpailijan numeron
        {
            return kilpailijalista[_index].kilpailunumero;
        }

        public int kilpailijoidenMaara() //palauttaa sarjan kilpailijoiden määrän
        {
            return kilpailijalista.Count;
        }

        public override string ToString()
        {
            return sarjanimi;
        }

        public List<Kilpailija> annaKilpailijat() //palauttaa sarjan kilpailijalistan
        {
            return kilpailijalista;
        }

        public void asetaLahtoajat() //plussaa sarjan lähtöaikoihin pohja-aikojen(ryhmä * lähtöväli(sek) * 1000) päälle nykyhetken (dayofyear,hour,minute...) millisekunnit
        {
            int i = 0;
            long x = 0;
            DateTime nykyhetki = DateTime.Now;

            x += (long)86400000 * nykyhetki.DayOfYear;
            x += (long)3600000 * nykyhetki.Hour;
            x += (long)60000 * nykyhetki.Minute;
            x += (long)1000 * nykyhetki.Second;
            x += (long)nykyhetki.Millisecond;

            while (i < kilpailijalista.Count)
            {
                kilpailijalista[i].lahtoaika += x;
                i += 1;
            }
        }

        public void jaaRyhmat(int _ryhmakoko, long _lahtovali) //jakaa sarjan kilpailijat ryhmiin annettujen tietojen perusteella
        {
            long lahtovali;
            int i = 0;
            int ryhma = 1;
            int x = 0;

            if (_lahtovali < 1)
            {
                lahtovali = (long)30 * 1000;
            }
            else
            {
                lahtovali = (long)_lahtovali * 1000;
            }

            if (_ryhmakoko > kilpailijalista.Count) //jos ryhmäkoko on suurempi kuin kokonaismäärä, jokainen kisaaja on samassa ryhmässä
            {
                while (i < kilpailijalista.Count)
                {
                    kilpailijalista[i].lahtoryhma = 1;
                    kilpailijalista[i].lahtoaika = 0;
                    i += 1;
                }
            }
            else //jaa kisaajat lähtöryhmiin JA aseta lähtöajan pohjaksi lähtövälin suuruinen aika kerrottuna ryhmän lähtöjärjestyksellä
            {
                while (i < kilpailijalista.Count)
                {
                    x += 1;
                    kilpailijalista[i].lahtoryhma = ryhma;
                    kilpailijalista[i].lahtoaika = lahtovali * ryhma;
                    if (x == _ryhmakoko) //kun ryhmä täyttyy niin siirrytään seuraavaan ryhmään
                    {
                        x = 0;
                        ryhma += 1;
                    }
                    i += 1;
                }
            }
        }

        public void jaaNumerot(List<int> _kielletytNumerot, int _alkuNumero, List<Sarja> _sarjaLista) //jakaa numerot hypäten yli jo käytössä olevat(myös muissa sarjoissa) ja kielletyt numerot
        {
            int x = _alkuNumero;
            int i = 0;
            List<int> kaytetytNumerot = new List<int>(_kielletytNumerot);
            int sarjaIteraattori = 0;
            int kilpailijaIteraattori = 0;

            while (i < this.kilpailijalista.Count) //vapautetaan mahdollisesti varatut numerot sarjasta uudelleen numeroimista varten
            {
                kilpailijalista[i].kilpailunumero = -1;
                i += 1;
            }
            i = 0;

            while (sarjaIteraattori < _sarjaLista.Count) //tutkitaan kaikki sarjat läpi ja kerätään käytetyt numerot talteen
            {
                kilpailijaIteraattori = 0;
                while (kilpailijaIteraattori < _sarjaLista[sarjaIteraattori].kilpailijoidenMaara())
                {
                    if(_sarjaLista[sarjaIteraattori].annaKilpailijanNumero(kilpailijaIteraattori) > -1)
                    {
                        kaytetytNumerot.Add(_sarjaLista[sarjaIteraattori].annaKilpailijanNumero(kilpailijaIteraattori));
                    }
                    kilpailijaIteraattori += 1;
                }
                sarjaIteraattori += 1;
            }
            i = 0;


            i = 0;
            while (i < kilpailijalista.Count) //annetaan sarjalaisille uudet numerot ja hypätään varattujen ja kiellettyjen yli
            {
                if (!(kaytetytNumerot.Contains(x)))
                {
                    kilpailijalista[i].kilpailunumero = x;
                    i += 1;
                }
                x += 1;
            }

        }


        public bool lisaaKilpailija(Kilpailija _kilpailija) // Lisää kilpailja Hiihtokilpailun(ei sarjan/tämän avulla) lisaaKilpailija(Kilpailija _kilpailija, int sarjanIndex)-funktiolla!
        {
            bool wut = false;
            if (_kilpailija.sukupuoli == vaadittusukupuoli && _kilpailija.ika >= ikaMin && _kilpailija.ika <= ikaMax)
            {
                kilpailijalista.Add(_kilpailija);
                wut = true;
            }
            return wut;
        }

        public Sarja(Sarja _sarja)
        {
            kilpailijalista = new List<Kilpailija>(_sarja.annaKilpailijat());

            sarjanimi = _sarja.sarjanimi;
            vaadittusukupuoli = _sarja.vaadittusukupuoli;
            ikaMin = _sarja.ikaMin;
            ikaMax = _sarja.ikaMax;
        }

        public Sarja(List<Kilpailija> _kilpailijalista, string _sarjanimi, int _vaadittusukupuoli, int _ikaMin, int _ikaMax)
        {
            kilpailijalista = new List<Kilpailija>(_kilpailijalista);

            sarjanimi = _sarjanimi;
            vaadittusukupuoli = _vaadittusukupuoli;
            ikaMin = _ikaMin;
            ikaMax = _ikaMax;
        }

        public Sarja(string _sarjanimi, int _vaadittusukupuoli, int _ikaMin, int _ikaMax) 
        {
            kilpailijalista = new List<Kilpailija>();

            sarjanimi = _sarjanimi;
            vaadittusukupuoli = _vaadittusukupuoli;
            ikaMin = _ikaMin;
            ikaMax = _ikaMax;
        }

        public Sarja(SerializationInfo info, StreamingContext ctxt)
        {
            this.sarjanimi = (string)info.GetValue("sarjanimi", typeof(string));
            this.vaadittusukupuoli = (int)info.GetValue("vaadittusukupuoli", typeof(int));
            this.ikaMin = (int)info.GetValue("ikaMin", typeof(int));
            this.ikaMax = (int)info.GetValue("ikaMax", typeof(int));
            this.kilpailijalista = (List<Kilpailija>)info.GetValue("kilpailijalista", typeof(List<Kilpailija>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("sarjanimi", this.sarjanimi);
            info.AddValue("vaadittusukupuoli", this.vaadittusukupuoli);
            info.AddValue("ikaMin", this.ikaMin);
            info.AddValue("ikaMax", this.ikaMax);
            info.AddValue("kilpailijalista", this.kilpailijalista);

        }
    }

    [Serializable()]
    public class Hiihtokilpailu : ISerializable
    {
        List<Sarja> sarjalista;

        public string kilpailunimi;
        public string tapahtumapaikka;

        public void asetaLahtoajat(int _sarjanIndex) //asettaa valitun sarjan kilpailijoille lähtöajat, katso luokka-sarja!
        {
            sarjalista[_sarjanIndex].asetaLahtoajat(); //plussaa kilpailijoiden lähtöaikoihin tämänhetken millisekuntiajan (dayofyear, hour, minute, second, millisecond)
        }

        public void jaaRyhmat(int _sarjanIndex, int _ryhmamaara, int _lahtovali) //jakaa valitun sarjan kilpailijat ryhmiin ja asettaa lähtöaikojen pohjaerotuksen, katso luokka-sarja!
        {
            sarjalista[_sarjanIndex].jaaRyhmat(_ryhmamaara, _lahtovali);
        }

        public void jaaNumerot(int _sarjanIndex, List<int> _kielletytNumerot, int _alkuNumero) //jakaa määrityllen sarjan kisaajille numerot, katso luokka-sarja!
        {
            sarjalista[_sarjanIndex].jaaNumerot(_kielletytNumerot, _alkuNumero, sarjalista);
        }

        public void swapKilpailijat(int _sarja, int _kilpailijaIndex1, int _kilpailijaIndex2) //vaihtaa määritellyn sarjan kahden määritellyn kilpailijan paikkaa, katso luokka-sarja!
        {
            sarjalista[_sarja].swapKilpailijat(_kilpailijaIndex1, _kilpailijaIndex2);
        }

        public List<Kilpailija> annaKilpailijat(int sarjanIndex) //palauttaa määritellyn luokan kaikki kilpailijat
        {
            return sarjalista[sarjanIndex].annaKilpailijat();
        }

        public bool lisaaKilpailija(Kilpailija _kilpailija, int sarjanIndex) // Lisää määriteltyyn sarjaan uuden kilpailijan, palauttaa boolen true jos onnistuu
        {
            bool wut = false;
            if (sarjanIndex < sarjalista.Count && sarjanIndex > -1)
            {
                wut = sarjalista[sarjanIndex].lisaaKilpailija(_kilpailija);
            }
            return wut;
        }

        public override string ToString()
        {
            return kilpailunimi + ", " + tapahtumapaikka;
        }

        public List<Sarja> annaSarjat() //palauttaa täydellisen listan kilpailun sarjoista
        {
            return sarjalista;
        }

        public void lisaaSarja(string _sarjanimi, int _vaadittusukupuoli, int _ikaMin, int _ikaMax) //uusi sarja kilpailuun määritelltyillä tiedoilla
        {
            sarjalista.Add(new Sarja(_sarjanimi, _vaadittusukupuoli, _ikaMin, _ikaMax));
        }

        public void lisaaSarja(List<Kilpailija> _kilpailijalista, string _sarjanimi, int _vaadittusukupuoli, int _ikaMin, int _ikaMax) //uusi sarja kilpailuun määritelltyillä tiedoilla
        {
            sarjalista.Add(new Sarja(_kilpailijalista, _sarjanimi, _vaadittusukupuoli, _ikaMin, _ikaMax));
        }

        public void lisaaSarja(Sarja _sarja) //uusi sarja kilpailuun määritelltyillä tiedoilla
        {
            sarjalista.Add(new Sarja(_sarja));
        }

        public Hiihtokilpailu(string _kilpailunimi, string _tapahtumapaikka)
        {
            sarjalista = new List<Sarja>();
            kilpailunimi = _kilpailunimi;
            tapahtumapaikka = _tapahtumapaikka;
        }

        public Hiihtokilpailu(List<Sarja> _sarja, string _kilpailunimi, string _tapahtumapaikka)
        {
            sarjalista = new List<Sarja>(_sarja);
            kilpailunimi = _kilpailunimi;
            tapahtumapaikka = _tapahtumapaikka;
        }

        public Hiihtokilpailu(SerializationInfo info, StreamingContext ctxt)
        {
            this.kilpailunimi = (string)info.GetValue("kilpailunimi", typeof(string));
            this.tapahtumapaikka = (string)info.GetValue("tapahtumapaikka", typeof(string));
            this.sarjalista = (List<Sarja>)info.GetValue("sarjalista", typeof(List<Sarja>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("kilpailunimi", this.kilpailunimi);
            info.AddValue("tapahtumapaikka", this.tapahtumapaikka);
            info.AddValue("sarjalista", this.sarjalista);
        }
    }
}


