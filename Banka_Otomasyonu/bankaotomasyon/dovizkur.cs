using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace bankaotomasyon
{
    public partial class dovizkur : Form
    {
        public dovizkur()
        {
            InitializeComponent();
        }

        private void dovizkur_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)  //timer ile verilerin düzenli güncellenmesi
        {
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";   //Kur bilgilerinin tcmb ssitesinden çekilmesi
            var TCMB_xml = new XmlDocument();
            string USD_alıs;
            string USD_satıs;
            string EUR_alıs;
            string EUR_satıs;
            string GBP_alıs;
            string GBP_satıs;
            string AZN_alıs;
            string AZN_satıs;

            TCMB_xml.Load(TCMB_Kur);
            USD_alıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            usdal.Text = USD_alıs;
            USD_satıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            usdsat.Text = USD_satıs;
            EUR_alıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            eural.Text = EUR_alıs;
            EUR_satıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            eursat.Text = EUR_satıs;
            GBP_alıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            gbpal.Text = GBP_alıs;
            GBP_satıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            gbpsat.Text = GBP_satıs;
            AZN_alıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexBuying").InnerXml;
            aznal.Text = AZN_alıs;
            AZN_satıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexSelling").InnerXml;
            aznsat.Text = AZN_satıs;


        }

        private void eural_Click(object sender, EventArgs e)
        {

        }
    }
}
