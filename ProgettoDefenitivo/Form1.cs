using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using System.Windows.Automation;
using ScrapySharp.Network;
using OpenQA.Selenium.Support.UI;
using ScrapySharp.Extensions;
using System.Net;
using System.Xml.Xsl;

namespace ProgettoDefenitivo
{
    public partial class Form1 : Form



    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOMOVE = 0x0002;
        const uint SWP_NOACTIVATE = 0x0010;

        Dictionary<string, string> countries = new Dictionary<string, string>();

        Dictionary<string, string> airports = new Dictionary<string, string>();
        private string partenzaAeroporto;
        private string airportCode;

        private int num = 0;

        private int budget;
        private string tipoViaggio;


        public Form1()
        {
            InitializeComponent();
                    
            PopulateAirports();
            InitializeListView();
            this.WindowState = FormWindowState.Maximized;

            // Aggiungi il gestore dell'evento SelectedIndexChanged alla ListView
            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);
            // Nascondi la ListView all'inizio
            listView1.Visible = false;

            // Associa l'evento del clic alla TextBox
            txtPaese.Click += new EventHandler(txtPaese_Click_1);


            //comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged_1);


            rbSpecifica.Visible = false;

            rbIntervallo.Visible = false;
            panelPartenza.Visible = false;

            txtPartenza.Click += new EventHandler(txtPartenza_Click);

            rbSpecifica.CheckedChanged += new EventHandler(rbSpecifica_CheckedChanged);
            rbIntervallo.CheckedChanged += new EventHandler(rbIntervallo_CheckedChanged);

            dtPartenza.Visible = false;
            dtRitorno.Visible = false;

            tabPage5.Visible = false;

            dtPartenza.Value = DateTime.Now.AddDays(2);
            dtRitorno.Value = DateTime.Now.AddDays(3);

        }

        private struct voli
        {
            public string Nome;
            public string LuogoPartenza;
            public string LuogoArrivo;
            public string NumeroVolo;
            public float Posto;
            public string Gate;
        }

        private voli[] elevoli = new voli[100];      // CREO ELE E DICHIARO NUM
        


        private void tabPage2_Resize_1(object sender, EventArgs e)
        {
            pictureVolo.Size = tabPage2.Size;
        }


        public void PopulateAirports()
        {
            // Aggiungi gli aeroporti e i relativi codici al dizionario




            ////////////////////////////////////////////////////////////////////////////////
            airports.Add("Aalborg(Danimarca)", "AAL");
            //fallo con quelli sopra tutti quasnti in una sola volta
            airports.Add("Aarhus(Danimarca)", "AAR");
            airports.Add("Aberdeen(Regno Unito)", "ABZ");
            airports.Add("Agadir(Marocco)", "AGA");
            airports.Add("Alghero(Italia)", "AHO");
            airports.Add("Alicante(Spagna)", "ALC");
            airports.Add("Almeria(Spagna)", "LEI");
            airports.Add("Amburgo(Germania)", "HAM");
            airports.Add("Amman Giordania(Giordania)", "AMM");
            airports.Add("Amsterdam(Olanda)", "AMS");
            airports.Add("Asturie(Spagna)", "OVD");
            airports.Add("Atene(Grecia)", "ATH");
            airports.Add("Banja Luka(Bosnia & Herzegovina)", "BNX");
            airports.Add("Barcellona(Girona)(Spagna)", "GRO");
            airports.Add("Barcellona(Reus)(Spagna)", "REU");
            airports.Add("Barcellona El Prat(Spagna)", "BCN");

            airports.Add("Bari(Italia)", "BRI");
            airports.Add("Basilea(Svizzera)", "BSL");
            airports.Add("Belfast International(Regno Unito)", "BFS");
            airports.Add("Beni Mellal(Marocco)", "BEM");
            airports.Add("Bergerac(Francia)", "EGC");
            airports.Add("Berlino Brandeburgo(Germania)", "BER");
            airports.Add("Beziers(Francia)", "BZR");
            airports.Add("Biarritz(Francia)", "BIQ");
            airports.Add("Billund(Danimarca)", "BLL");
            airports.Add("Birmingham(Regno Unito)", "BHX");
            airports.Add("Bodrum(Turchia)", "BJV");
            airports.Add("Bologna(Italia)", "BLQ");
            airports.Add("Bordeaux(Francia)", "BOD");
            airports.Add("Bournemouth(Regno Unito)", "BOH");
            airports.Add("Bratislava(Slovacchia)", "BTS");
            airports.Add("Brema(Germania)", "BRE");
            airports.Add("Breslavia(Polonia)", "WRO");
            airports.Add("Brindisi(Italia)", "BDS");
            airports.Add("Bristol(Regno Unito)", "BRS");
            airports.Add("Brive(Francia)", "BVE");
            airports.Add("Brno(Repubblica Ceca)", "BRQ");
            airports.Add("Bruxelles(Charleroi)(Belgio)", "CRL");
            airports.Add("Bruxelles Zaventem(Belgio)", "BRU");
            airports.Add("Bucharest(Otopeni)(Romania)", "OTP");
            airports.Add("Budapest(Ungheria)", "BUD");
            airports.Add("Burgas(Bulgaria)", "BOJ");
            airports.Add("Bydgoszcz(Polonia)", "BZG");
            airports.Add("Cagliari(Italia)", "CAG");
            airports.Add("Carcassonne(Francia)", "CCF");
            airports.Add("Cardiff(Regno Unito)", "CWL");
            airports.Add("Castellon(Valencia)(Spagna)", "CDT");
            airports.Add("Catania(Italia)", "CTA");
            airports.Add("Cefalonia(Grecia)", "EFL");
            airports.Add("Chania(Creta)(Grecia)", "CHQ");
            airports.Add("Clermont Ferrand(Francia)", "CFE");
            airports.Add("Cluj(Romania)", "CLJ");
            airports.Add("Colonia(Germania)", "CGN");
            airports.Add("Copenaghen(Danimarca)", "CPH");
            airports.Add("Corfù(Grecia)", "CFU");
            airports.Add("Cork(Irlanda)", "ORK");
            airports.Add("Cracovia(Polonia)", "KRK");
            airports.Add("Crotone(Italia)", "CRV");
            airports.Add("Cuneo(Italia)", "CUF");
            airports.Add("Dalaman(Turchia)", "DLM");
            airports.Add("Danzica(Polonia)", "GDN");
            airports.Add("Derry(Regno Unito)", "LDY");
            airports.Add("Dole(Francia)", "DLE");
            airports.Add("Dortmund(Germania)", "DTM");
            airports.Add("Dresden(Germania)", "DRS");
            airports.Add("Dublino(Irlanda)", "DUB");
            airports.Add("Dubrovnik(Croazia)", "DBV");
            airports.Add("Düsseldorf(Weeze)(Germania)", "NRN");
            airports.Add("East Midlands(Regno Unito)", "EMA");
            airports.Add("Edimburgo(Regno Unito)", "EDI");
            airports.Add("Eindhoven(Olanda)", "EIN");
            airports.Add("Errachidia(Marocco)", "ERH");
            airports.Add("Essaouira(Marocco)", "ESU");
            airports.Add("Exeter(Regno Unito)", "EXT");
            airports.Add("Faro(Portogallo)", "FAO");
            airports.Add("Fez(Marocco)", "FEZ");
            airports.Add("Figari(Francia)", "FSC");
            airports.Add("Fiume(Croazia)", "RJK");
            airports.Add("Forlì(Italia)", "FRL");
            airports.Add("Francoforte(Hahn)(Germania)", "HHN");
            airports.Add("Fuerteventura(Spagna)", "FUE");
            airports.Add("Genova(Italia)", "GOA");
            airports.Add("Glasgow(Regno Unito)", "GLA");
            airports.Add("Glasgow(Prestwick)(Regno Unito)", "PIK");
            airports.Add("Gran Canaria(Spagna)", "LPA");
            airports.Add("Grenoble(Francia)", "GNB");
            airports.Add("Göteborg Landvetter(Svezia)", "GOT");
            airports.Add("Helsinki(Finlandia)", "HEL");
            airports.Add("Heraklion Creta(Grecia)", "HER");
            airports.Add("Iasi(Romania)", "IAS");
            airports.Add("Ibiza(Spagna)", "IBZ");
            airports.Add("Jerez(Spagna)", "XRY");
            airports.Add("Kalamata(Grecia)", "KLX");
            airports.Add("Karlsruhe / Baden - Baden(Germania)", "FKB");
            airports.Add("Katowice(Polonia)", "KTW");
            airports.Add("Kaunas(Lituania)", "KUN");
            airports.Add("Kerry(Irlanda)", "KIR");
            airports.Add("Klagenfurt(Austria)", "KLU");

            airports.Add("Knock - Irlanda dell'ovest (Irlanda)", "NOC");
            airports.Add("Kos(Grecia)", "KGS");
            airports.Add("Kosice(Slovacchia)", "KSC");
            airports.Add("La Rochelle(Francia)", "LRH");
            airports.Add("Lamezia(Italia)", "SUF");
            airports.Add("Lanzarote(Spagna)", "ACE");
            airports.Add("Lappeenranta(Finlandia)", "LPP");
            airports.Add("Larnaca(Cipro)", "LCA");
            airports.Add("Leeds Bradford(Regno Unito)", "LBA");
            airports.Add("Lille(Francia)", "LIL");
            airports.Add("Limoges(Francia)", "LIG");
            airports.Add("Lipsia(Germania)", "LEJ");
            airports.Add("Lisbona(Portogallo)", "LIS");
            airports.Add("Liverpool (Regno Unito)", "LPL");
            airports.Add("Lodz (Polonia)", "LCJ");
            airports.Add("Londra (Gatwick) (Regno Unito)", "LGW");
            airports.Add("Londra (Luton) (Regno Unito)", "LTN");
            airports.Add("Londra (Stansted) (Regno Unito)", "STN");
            airports.Add("Lourdes (Francia)", "LDE");
            airports.Add("Lublino (Polonia)", "LUZ");
            airports.Add("Lussemburgo (Lussemburgo)", "LUX");
            airports.Add("Maastricht (Olanda)", "MST");
            airports.Add("Madeira Funchal (Portogallo)", "FNC");
            airports.Add("Madrid (Spagna)", "MAD");
            airports.Add("Malaga (Spagna)", "AGP");
            airports.Add("Malmö (Svezia)", "MMX");
            airports.Add("Malta (Malta)", "MLA");
            airports.Add("Manchester (Regno Unito)", "MAN");
            airports.Add("Marrakech (Marocco)", "RAK");
            airports.Add("Marsiglia (Francia)", "MRS");
            airports.Add("Memmingen (Germania)", "FMM");
            airports.Add("Milano Bergamo (Italia)", "BGY");
            airports.Add("Milano Malpensa (Italia)", "MXP");
            airports.Add("Minorca (Spagna)", "MAH");
            airports.Add("Murcia International (Spagna)", "RMU");
            airports.Add("Mykonos (Grecia)", "JMK");
            airports.Add("Münster (Germania)", "FMO");
            airports.Add("Nador (Marocco)", "NDR");
            airports.Add("Nantes (Francia)", "NTE");
            airports.Add("Napoli (Italia)", "NAP");
            airports.Add("Newcastle (Regno Unito)", "NCL");
            airports.Add("Newquay Cornovaglia (Regno Unito)", "NQY");
            airports.Add("Nimes (Francia)", "FNI");
            airports.Add("Nis (Serbia)", "INI");
            airports.Add("Nizza (Francia)", "NCE");
            airports.Add("Norimberga (Germania)", "NUE");
            airports.Add("Norwich (Regno Unito)", "NWI");
            airports.Add("Olbia (Italia)", "OLB");
            airports.Add("Olsztyn - Mazury (Polonia)", "SZY");
            airports.Add("Osijek (Croazia)", "OSI");
            airports.Add("Oslo (Norvegia)", "OSL");
            airports.Add("Oslo (Torp) (Norvegia)", "TRF");
            airports.Add("Bromma (Svezia)", "BMA");
            airports.Add("Ostrava (Repubblica Ceca)", "OSR");
            airports.Add("Ouarzazate (Marocco)", "OZZ");
            airports.Add("Oujda (Marocco)", "OUD");
            airports.Add("Paderborn (Germania)", "PAD");
            airports.Add("Pafos (Cipro)", "PFO");
            airports.Add("Palanga (Lituania)", "PLQ");
            airports.Add("Palermo (Italia)", "PMO");
            airports.Add("Palma (Spagna)", "PMI");
            airports.Add("Pardubice (Repubblica Ceca)", "PED");
            airports.Add("Parigi (Beauvais) (Francia)", "BVA");
            airports.Add("Parigi (Vatry) (Francia)", "XCR");
            airports.Add("Parma (Italia)", "PMF");
            airports.Add("Perpignan (Francia)", "PGF");
            airports.Add("Perugia (Italia)", "PEG");
            airports.Add("Pescara (Italia)", "PSR");
            airports.Add("Pisa (Italia)", "PSA");
            airports.Add("Plovdiv (Bulgaria)", "PDV");
            airports.Add("Podgorica (Montenegro)", "TGD");
            airports.Add("Poitiers (Francia)", "PIS");
            airports.Add("Pola (Croazia)", "PUY");
            airports.Add("Ponta Delgada (Portogallo)", "PDL");
            airports.Add("Poprad - Tatry (Tatra Mountains) (Slovacchia)", "TAT");
            airports.Add("Porto (Portogallo)", "OPO");
            airports.Add("Poznan (Polonia)", "POZ");
            airports.Add("Praga (Repubblica Ceca)", "PRG");
            airports.Add("Preveza - Aktion (Grecia)", "PVK");
            airports.Add("Rabat (Marocco)", "RBA");
            airports.Add("Reggio Calabria (Italia)", "REG");
            airports.Add("Riga (Lettonia)", "RIX");
            airports.Add("Rimini (Italia)", "RMI");
            airports.Add("Rodez (Francia)", "RDZ");
            airports.Add("Rodi (Grecia)", "RHO");
            airports.Add("Roma (Ciampino) (Italia)", "CIA");
            airports.Add("Roma (Fiumicino) (Italia)", "FCO");
            airports.Add("Rovaniemi - Lapponia (Finlandia)", "RVN");
            airports.Add("Rzeszow (Polonia)", "RZE");
            airports.Add("Salisburgo (Austria)", "SZG");
            airports.Add("Salonicco (Grecia)", "SKG");
            airports.Add("Santander (Spagna)", "SDR");
            airports.Add("Santiago (Spagna)", "SCQ");
            airports.Add("Santorini Nazionale (Grecia)", "JTR");
            airports.Add("Saragozza (Spagna)", "ZAZ");
            airports.Add("Sarajevo (Bosnia & Herzegovina)", "SJJ");
            airports.Add("Shannon (Irlanda)", "SNN");
            airports.Add("Siviglia (Spagna)", "SVQ");
            airports.Add("Skelleftea (Svezia)", "SFT");
            airports.Add("Skiathos (Grecia)", "JSI");
            airports.Add("Sofia (Bulgaria)", "SOF");
            airports.Add("Spalato (Croazia)", "SPU");
            airports.Add("Stettino (Polonia)", "SZZ");
            airports.Add("Stoccolma Arlanda (Svezia)", "ARN");
            airports.Add("Stoccolma Västerås (Svezia)", "VST");
            airports.Add("Strasbourg (Francia)", "SXB");
            airports.Add("Tallinn (Estonia)", "TLL");
            airports.Add("Tangeri (Marocco)", "TNG");
            airports.Add("Teesside (Regno Unito)", "MME");
            airports.Add("Tel Aviv (Israele)", "TLV");
            airports.Add("Tenerife (Nord) (Spagna)", "TFN");
            airports.Add("Tenerife (Sud) (Spagna)", "TFS");
            airports.Add("Terceira Lajes (Portogallo)", "TER");
            airports.Add("Tirana (Albania)", "TIA");
            airports.Add("Tolosa (Francia)", "TLS");
            airports.Add("Torino (Italia)", "TRN");
            airports.Add("Tours Valle della Loira (Francia)", "TUF");
            airports.Add("Trapani-Marsala (Italia)", "TPS");
            airports.Add("Trieste (Italia)", "TRS");
            airports.Add("Tétouan (Marocco)", "TTU");
            airports.Add("Valencia (Spagna)", "VLC");
            airports.Add("Valladolid (Spagna)", "VLL");
            airports.Add("Varna (Bulgaria)", "VAR");
            airports.Add("Varsavia (Chopin) (Polonia)", "WAW");
            airports.Add("Varsavia (Modlin) (Polonia)", "WMI");
            airports.Add("Venezia (Treviso) (Italia)", "TSF");
            airports.Add("Venezia M.Polo (Italia)", "VCE");
            airports.Add("Verona (Italia)", "VRN");
            airports.Add("Vienna (Austria)", "VIE");
            airports.Add("Vigo (Spagna)", "VGO");
            airports.Add("Vilnius (Lituania)", "VNO");
            airports.Add("Vitoria (Spagna)", "VIT");
            airports.Add("Växjö Småland (Svezia)", "VXO");
            airports.Add("Zacinto (Grecia)", "ZTH");
            airports.Add("Zagabria (Croazia)", "ZAG");


        }


        public void InitializeListView()
        {
            // Imposta le proprietà della ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Aggiungi le colonne alla ListView
            listView1.Columns.Add("Aeroporto", 200);
            listView1.Columns.Add("Codice", 100);

            // Popola la ListView con gli aeroporti e i codici
            foreach (var airport in airports)
            {
                ListViewItem item = new ListViewItem(airport.Key);
                item.SubItems.Add(airport.Value);
                listView1.Items.Add(item);
            }
        }


        private void txtPaese_TextChanged_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string searchText = txtPaese.Text.ToLower(); // Testo di ricerca in minuscolo

            foreach (var airport in airports)
            {
                // Se il nome dell'aeroporto inizia con il testo di ricerca
                if (airport.Key.ToLower().StartsWith(searchText))
                {
                    // Aggiungi l'aeroporto alla ListView
                    listView1.Items.Add(new ListViewItem(new string[] { airport.Key, airport.Value }));
                }
            }
        }


        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostra il testo selezionato nella TextBox
            if (listView1.SelectedItems.Count > 0)
            {
                txtPaese.Text = listView1.SelectedItems[0].Text;
            }
        }


        private void txtPaese_Click_1(object sender, EventArgs e)
        {
            // Mostra la ListView quando viene cliccata la TextBox
            listView1.Visible = true;
        }




        //private void dtPartenza_ValueChanged_1(object sender, EventArgs e)
        //        {
        // DateTime selectedDate = dtPartenza.Value;

        //            // Formatta la data nel formato desiderato (anno-mese-giorno) utilizzando la cultura "en-US"
        //            string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        //            if (selectedDate < DateTime.Now.AddDays(1))
        //            {
        //                lbErroreData.Text = "Il dato deve essere dopo domani.";
        //                //btnInformazioni.Enabled = false;

        //            
        //            else
        //            {
        //                lbErroreData.Text = "";
        //            }
        //        }

        //        private void dtRitorno_ValueChanged_1(object sender, EventArgs e)
        //        {
        //DateTime selectedDate2 = dtRitorno.Value;

        //            // Formatta la data nel formato desiderato (anno-mese-giorno) utilizzando la cultura "en-US"
        //            string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        //            if (selectedDate2 < DateTime.Now.AddDays(1))
        //            {

        //            }
        //        }




        //private void btnInformazioni_Click(object sender, EventArgs e)

        //{

        //    DateTime selectedDate = dtPartenza.Value;
        //    string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        //    Console.WriteLine("formattedDate: " + formattedDate); // Aggiungi questa linea per il debug



        //    // Verifica che la data di partenza non sia mai minore di un giorno in più rispetto ad oggi
        //    if (selectedDate < DateTime.Now.AddDays(1))
        //    {
        //        lbErroreData.Text = "Il dato deve essere dopo domani.";
        //       return;
        //    }
        //    else
        //    {
        //        lbErroreData.Text = "";

        //    }

        //    //RITORNO
        //    DateTime selectedDate2 = dtRitorno.Value;
        //    string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        //    Console.WriteLine("formattedDate: " + formattedDate2); // Aggiungi questa linea per il debug


        //    //// Verifica che la data di ritorno non sia mai minore della data di partenza
        //    if (selectedDate2 < selectedDate)
        //    {
        //        lbErroreData.Text = "Il dato deve essere dopo la data di inizio";
        //     return;
        //    }
        //    else
        //    {
        //        lbErroreData.Text = "";
        //    }





        //    // Verifica se è stato selezionato un aeroporto
        //    if (listView1.SelectedItems.Count > 0)
        //    {
        //        // Ottieni il nome e il codice dell'aeroporto selezionato
        //        partenzaAeroporto = listView1.SelectedItems[0].Text;
        //        airportCode = listView1.SelectedItems[0].SubItems[1].Text;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Seleziona un aeroporto prima di procedere.");
        //        return;
        //    }
        //    //  string message3 = $"Informazioni:\nPartenza: {airportCode}\nBudget: {budget}\nData di Andata: {formattedDate}\nData di Ritorno: {formattedDate2}";
        //    // MessageBox.Show(message3, "Dettagli Viaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    // C$"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget=150&trip-type-category={tipoViaggio}");

        //    // txtLink.Text = $"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget=150&trip-type-category={tipoViaggio}";



        //        if (rbSpecifica.Checked)
        //        {

        //            txtLink.Text = $"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate}&budget=150"; 

        //        }
        //        // Esegui questa parte se non è selezionato nessun elemento dalla ComboBox
        //        if (rbIntervallo.Checked)
        //        {

        //            txtLink.Text = $"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget=150";

        //        }



        //    //MessageBox.Show(txtLink.Text);



        //    string urlScreenVolo = txtLink.Text;



        //    ScrapingBrowser browser = new ScrapingBrowser();
        //    browser.AllowAutoRedirect = true;
        //    browser.AllowMetaRedirect = true;
        //    // Inizializza il WebDriver di Chrome
        //    ChromeOptions options = new ChromeOptions();
        //    options.AddArgument("--window-position=-2000,-2000"); // Imposta la posizione della finestra fuori dallo schermo
        //    IWebDriver driver = new ChromeDriver(options);

        //    // Naviga verso la pagina web
        //    driver.Navigate().GoToUrl(txtLink.Text);

        //    try
        //    {
        //        //Trova il bottone tramite il selettore CSS, XPath o altri metodi di localizzazione
        //        var buttonScreenVolo = driver.FindElement(By.CssSelector("div#cookie-popup-with-overlay"));
        //        var buttonScreenVolo1 = buttonScreenVolo.FindElement(By.CssSelector("div.cookie-popup-with-overlay__box"));
        //        var buttonScreenVolo2 = buttonScreenVolo1.FindElement(By.CssSelector("div.cookie-popup-with-overlay__buttons"));
        //        var buttonScreenVolo3 = buttonScreenVolo2.FindElement(By.CssSelector("button.cookie-popup-with-overlay__button"));



        //        buttonScreenVolo3.Click();



        //        IWebElement divElement = driver.FindElement(By.XPath("//div[@class='FR']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
        //        IWebElement child = divElement.FindElement(By.XPath(".//main[@ui-view='mainView']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
        //        IWebElement child1 = child.FindElement(By.XPath(".//div[@class='farefinder-expanded']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
        //        IWebElement child2 = child1.FindElement(By.XPath(".//div[@class='container results-container']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div

        //        // Ora puoi catturare uno screenshot del quinto figlio div
        //        Screenshot screenshot = ((ITakesScreenshot)child2).GetScreenshot();
        //        screenshot.SaveAsFile($"div_screenshot{num}.png");
        //    }

        //    catch (NoSuchElementException ex)
        //    {
        //        Console.WriteLine("Uno dei div non è stato trovato: " + ex.Message);
        //    }

        //    finally
        //    {
        //        // Chiudi il WebDriver
        //        driver.Quit();
        //        tabControl.SelectedIndex = 1;
        //        tabPage2.Visible = true;
        //        pictureVolo.Image = Image.FromFile($"div_screenshot{num}.png");
        //        num++;
        //    }



        //}

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void btnInformazioni_Click(object sender, EventArgs e)
        {
            // Ottieni la data di partenza
            DateTime selectedDate = dtPartenza.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("formattedDate: " + formattedDate); // Aggiungi questa linea per il debug

            // Verifica che la data di partenza non sia mai minore di un giorno in più rispetto ad oggi


            // Ottieni la data di ritorno
            DateTime selectedDate2 = dtRitorno.Value;
            string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("formattedDate: " + formattedDate2); // Aggiungi questa linea per il debug

            if (rbSpecifica.Checked == true)
            {
                if (selectedDate < DateTime.Now.AddDays(1))
                {
                    lbErroreData.Text = "La data di partenza deve essere dopo domani.";
                    return;
                }
                else
                {
                    lbErroreData.Text = "";
                }


            }
            if (rbIntervallo.Checked == true)
            {
                if (selectedDate < DateTime.Now.AddDays(1))
                {
                    lbErroreData.Text = "La data di partenza deve essere dopo domani.";
                    return;
                }
                else
                {
                    lbErroreData.Text = "";
                }
                if (selectedDate2 < selectedDate)
                {
                    lbErroreData.Text = "La data di ritorno deve essere dopo la data di partenza";
                    return;
                }
                else
                {
                    lbErroreData.Text = "";
                }
            }
            //

            // Verifica se è stato selezionato un aeroporto
            if (listView1.SelectedItems.Count > 0)
            {
                // Ottieni il nome e il codice dell'aeroporto selezionato
                partenzaAeroporto = listView1.SelectedItems[0].Text;
                airportCode = listView1.SelectedItems[0].SubItems[1].Text;
            }
            else
            {
                MessageBox.Show("Seleziona un aeroporto prima di procedere.");
                return;
            }

            // Costruisci il link in base alle opzioni selezionate

            if (rbSpecifica.Checked)
            {
                txtLink.Text = $"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate}&budget=150";
            }
            else if (rbIntervallo.Checked)
            {
                txtLink.Text = $"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget=150";
            }
            else
            {
                // Gestisci altri casi se necessario
                return;
            }

            // Esegui il resto del codice per il web scraping e l'elaborazione dell'immagine
            EseguiScraping(txtLink.Text);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void EseguiScraping(string url)
        {
            // Esegui il web scraping e l'elaborazione dell'immagine qui

            string urlScreenVolo = txtLink.Text;



            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;
            // Inizializza il WebDriver di Chrome
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-position=-2000,-2000"); // Imposta la posizione della finestra fuori dallo schermo
            IWebDriver driver = new ChromeDriver(options);

            // Naviga verso la pagina web
            driver.Navigate().GoToUrl(txtLink.Text);

            try
            {
                //Trova il bottone tramite il selettore CSS, XPath o altri metodi di localizzazione
                var buttonScreenVolo = driver.FindElement(By.CssSelector("div#cookie-popup-with-overlay"));
                var buttonScreenVolo1 = buttonScreenVolo.FindElement(By.CssSelector("div.cookie-popup-with-overlay__box"));
                var buttonScreenVolo2 = buttonScreenVolo1.FindElement(By.CssSelector("div.cookie-popup-with-overlay__buttons"));
                var buttonScreenVolo3 = buttonScreenVolo2.FindElement(By.CssSelector("button.cookie-popup-with-overlay__button"));



                buttonScreenVolo3.Click();



                IWebElement divElement = driver.FindElement(By.XPath("//div[@class='FR']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child = divElement.FindElement(By.XPath(".//main[@ui-view='mainView']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child1 = child.FindElement(By.XPath(".//div[@class='farefinder-expanded']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child2 = child1.FindElement(By.XPath(".//div[@class='container results-container']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div

                // Ora puoi catturare uno screenshot del quinto figlio div
                Screenshot screenshot = ((ITakesScreenshot)child2).GetScreenshot();
                screenshot.SaveAsFile($"div_screenshot{num}.png");
            }

            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Uno dei div non è stato trovato: " + ex.Message);
            }

            finally
            {
                // Chiudi il WebDriver
                driver.Quit();
                tabControl.SelectedIndex = 4;
                tabPage5.Visible = true;
                pictureVolo.Image = Image.FromFile($"div_screenshot{num}.png");
                num++;
            }
        }


        private void txtPartenza_Click(object sender, EventArgs e)
        {
            rbIntervallo.Visible = true;
            rbSpecifica.Visible = true;
            panelPartenza.Visible = true;
        }


        private void rbSpecifica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSpecifica.Checked)
            {
                dtPartenza.Visible = true;

            }


        }


        private void rbIntervallo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIntervallo.Checked)
            {
                dtPartenza.Visible = true;
                dtRitorno.Visible = true;

            }
            else
            {
                dtRitorno.Visible = false;
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void btnMeteo_Click_1(object sender, EventArgs e)
        {
            var luogo = txtMeteo.Text;
            string url = ($"https://www.3bmeteo.com/meteo/{luogo}");

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            // Inizializza il WebDriver di Chrome
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Massimizza la finestra del browser
            IWebDriver driver = new ChromeDriver(options);

            // Naviga verso la pagina web
            driver.Navigate().GoToUrl($"https://www.3bmeteo.com/meteo/{luogo}");

            try
            {
                // Trova il bottone tramite il selettore CSS, XPath o altri metodi di localizzazione
                var buttonMeteo = driver.FindElement(By.CssSelector("div#iubenda-cs-banner"));
                var buttonMeteo1 = buttonMeteo.FindElement(By.CssSelector("div.iubenda-cs-container"));
                var buttonMeteo2 = buttonMeteo1.FindElement(By.CssSelector("div.iubenda-cs-content"));
                var buttonMeteo3 = buttonMeteo2.FindElement(By.CssSelector("div.iubenda-cs-rationale"));
                var buttonMeteo4 = buttonMeteo3.FindElement(By.CssSelector("div.iubenda-cs-opt-group"));
                var buttonMeteo5 = buttonMeteo4.FindElement(By.CssSelector("div.iubenda-cs-opt-group-consent"));
                var buttonMeteo6 = buttonMeteo5.FindElement(By.CssSelector("button.iubenda-cs-accept-btn"));


                // Esegui il clic sul bottone
                buttonMeteo6.Click();

                IWebElement divElement = driver.FindElement(By.XPath("//div[@id='wrapper']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child = divElement.FindElement(By.XPath(".//section[@id='main']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child1 = child.FindElement(By.XPath(".//div[@class='box noMarg']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div


                // Ora puoi catturare uno screenshot del quinto figlio div
                Screenshot screenshot = ((ITakesScreenshot)child1).GetScreenshot();
                screenshot.SaveAsFile($"div_screenshot2{num}.png");
            }

            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Uno dei div non è stato trovato: " + ex.Message);
            }

            finally
            {
                // Chiudi il WebDriver
                driver.Quit();
                pictureBoxMeteo.Image = Image.FromFile($"div_screenshot2{num}.png");

                num++;

            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private async void btnCartina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCitta.Text))
            {
                MessageBox.Show("Inserisci una città");
                return;
            }

            var parola = txtCitta.Text;

            string url = $"https://www.google.com/search?q={parola}+mappa&tbm=isch&source";

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            WebPage webpage = await browser.NavigateToPageAsync(new Uri(url));
            //await browser.NavigateToPageAsync(new Uri(url));
            //rg_i

            //var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("div.BnJWBc").ToList();
            var html = webpage.Html.OwnerDocument.DocumentNode.CssSelect("html").First().InnerHtml;

            var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.DS1iW").ToList();
            var urlImg = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.DS1iW").First().GetAttributeValue("src");

            var request = WebRequest.Create(urlImg);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBoxCartina.Image = Bitmap.FromStream(stream);
            }
        }

        private async void btnPaesaggio_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCitta.Text))
            {
                MessageBox.Show("Inserisci una città");
                return;
            }

            var parola = txtCitta.Text;

            string url = $"https://www.google.com/search?q={parola}+Paesaggio&tbm=isch&source";

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            WebPage webpage = await browser.NavigateToPageAsync(new Uri(url));
            //await browser.NavigateToPageAsync(new Uri(url));
            //rg_i

            //var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("div.BnJWBc").ToList();
            var html = webpage.Html.OwnerDocument.DocumentNode.CssSelect("html").First().InnerHtml;

            var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.DS1iW").ToList();
            var urlImg = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.DS1iW").First().GetAttributeValue("src");

            var request = WebRequest.Create(urlImg);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBoxPaesaggio.Image = Bitmap.FromStream(stream);
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------

        private void btnIndicazioni_Click(object sender, EventArgs e)
        {
            var luogo = txtIndicazioni.Text;
            string url = $"https://www.travel365.it/destinazioni/europa/italia/lombardia/{luogo}/";

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            // Inizializza il WebDriver di Chrome
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Massimizza la finestra del browser
            IWebDriver driver = new ChromeDriver(options);

            // Naviga verso la pagina web
            driver.Navigate().GoToUrl($"https://www.travel365.it/destinazioni/europa/italia/lombardia/{luogo}/");

            try
            {
                // Trova il bottone tramite il selettore CSS, XPath o altri metodi di localizzazione

                var buttonIndicazioni = driver.FindElement(By.CssSelector("div.fc-consent-root"));
                var buttonIndicazioni1 = buttonIndicazioni.FindElement(By.CssSelector("div.fc-dialog-container"));
                var buttonIndicazioni2 = buttonIndicazioni1.FindElement(By.CssSelector("div.fc-dialog"));
                var buttonIndicazioni3 = buttonIndicazioni2.FindElement(By.CssSelector("div.fc-footer-buttons-container"));
                var buttonIndicazioni4 = buttonIndicazioni3.FindElement(By.CssSelector("div.fc-footer-buttons"));
                var buttonIndicazioni5 = buttonIndicazioni4.FindElement(By.CssSelector("button.fc-button"));


                // Esegui il clic sul bottone
                buttonIndicazioni5.Click();

                IWebElement divElement = driver.FindElement(By.XPath("//div[@id='content']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child = divElement.FindElement(By.XPath(".//div[@id='pagecity']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child1 = child.FindElement(By.XPath(".//div[@class='stickycontainer']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child2 = child1.FindElement(By.XPath(".//div[@class='transport']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div

                // Ora puoi catturare uno screenshot del quinto figlio div
                Screenshot screenshot = ((ITakesScreenshot)child2).GetScreenshot();
                screenshot.SaveAsFile($"div_screenshot{num}.png");
            }

            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Uno dei div non è stato trovato: " + ex.Message);
            }

            finally
            {
                // Chiudi il WebDriver
                driver.Quit();
                pictureBoxIndicazioni.Image = Image.FromFile($"div_screenshot{num}.png");

                num++;
            }
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            string a = txtNomePasseggero.Text;
            string b = txtPaese.Text;
            string c = textbox2.Text;

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c))
            {
                MessageBox.Show("Inserisci i dati");        // CONTROLLO SE TUTTE LE TB SONO PIENE
                return;
            }

            voli nuovovolo = default;     // CREO NUOVI GIOCATORI


            nuovovolo.Nome = a;
            nuovovolo.LuogoPartenza = b;
            nuovovolo.LuogoArrivo = c;

            elevoli[num] = nuovovolo;
            num = num + 1;

            MessageBox.Show("Tutti i dati sono stati inseriti correttamente");
                        
            smalltxtNome.Text = txtNomePasseggero.Text;
            smalltbNVolo.Text = "1SAN6OS9";
            smalltbPosto.Text = "A6";
            smalltbGate.Text = "Gate A19";
            smalltbPartenzaBiglietto.Text = txtPaese.Text;
            smalltbArrivoBiglietto.Text = textbox2.Text;

            lblNomePasseggeroBiglietto.Text = txtNomePasseggero.Text;
            lblNumeroVoloBiglietto.Text = "1SAN6OS9";
            lblPostoBiglietto.Text = "A6";
            lblGateBiglietto.Text = "Gate A19";



        }


        //--------------------------------------------------------------------------------------------------------------------------------------------


    }



}