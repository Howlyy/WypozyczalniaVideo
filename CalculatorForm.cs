using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WypożyczalniaVideo
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Metoda uzycia przycisku Wylicz w groupboxie Netto na brutto. Wywołuje metodę Netto_brutto_calculate(netto_price, vat_percent) i wypisuje wartosć wyliczoną do NBBruttoTB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NBCalculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                double netto_price = Convert.ToDouble(NBNettoTB.Text);
                double vat_percent = Convert.ToDouble(NBVatCB.Text.Trim('%'));

                double brutto = Netto_brutto_calculate(netto_price, vat_percent);



                NBBruttoTB.Text = brutto.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Sprawdz dane! Błędne wartości!");
            }
            
        }
        /// <summary>
        /// Metoda uzycia przycisku Wylicz w groupboxie Brutto na netto. Wywołuje metodę Brutto_netto_calculate(netto_price, vat_percent) i wypisuje wartosć wyliczoną do BNBruttoTB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BNCalculateBTN_Click(object sender, EventArgs e)
        {

            try
            {
                double brutto_price = Convert.ToDouble(BNBruttoTB.Text);
                double vat_percent = Convert.ToDouble(BNVatCB.Text.Trim('%'));

                double netto = Brutto_netto_calculate(brutto_price, vat_percent);



                BNNettoTB.Text = netto.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Sprawdz dane! Błędne wartości!");
            }
            

            
        }

        /// <summary>
        /// Metoda użycia przycisku Wylicz w groupboxie Netto na kwota końcowa. Wywołuje metodę End_price_calculate(int netto, double vat, double marza) i wylicza kwotę końcą do NKEndPriceTB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NKCalculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                double netto_price = Convert.ToDouble(NKNettoTB.Text);
                double vat_percent = Convert.ToDouble(NKVatCB.Text.Trim('%'));
                double marza_percent = Convert.ToDouble(NKMarzaCB.Text.Trim('%'));

                double end_price = End_price_calculate(netto_price, vat_percent, marza_percent);



                NKEndPriceTB.Text = end_price.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Sprawdz dane! Błędne wartości!");
            }
            
        }


        /// <summary>
        /// Metoda użycia przycisku Wylicz w groupboxie Kwota po odsetkach. Wywołuje metodę 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KOCalculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                double netto_price = Convert.ToDouble(KONettoTB.Text);
                double vat_percent = Convert.ToDouble(KOVatCB.Text.Trim('%'));
                double marza_percent = Convert.ToDouble(KOMarzaCB.Text.Trim('%'));
                double interest_percent = Convert.ToDouble(KOOdsetkiCB.Text.Trim('%'));

                double interest_end_price = Interest_end_price_calculate(netto_price, vat_percent, marza_percent, interest_percent);



                KOEndpriceTB.Text = interest_end_price.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Sprawdz dane! Błędne wartości!");
            }
            

            
        }

        /// <summary>
        /// Methoda wyliczająca z kwoty netto i procentu vatu, kwotę brutto
        /// </summary>
        /// <param name="netto">Kwota netto</param>
        /// <param name="vat">Procent Vatu</param>
        /// <returns>double brutto_price - wyliczona kwota brutto</returns>
        public static double Netto_brutto_calculate(double netto, double vat)
        {

            double brutto_price = netto * (1 +  vat / 100);

            return Math.Round(brutto_price, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Metoda wyliczająca z kwoty brutto i procentu vatu, kwote netto
        /// </summary>
        /// <param name="brutto">Kwota brutto</param>
        /// <param name="vat">Procent vatu</param>
        /// <returns>double netto_price - wyliczona kwota netto</returns>
        public static double Brutto_netto_calculate(double brutto, double vat)
        {
            double netto_price = brutto / (1 + vat / 100);

            return Math.Round(netto_price, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Metoda wyliczająca kwotę końcową z kwoty netto, procentu vatu oraz procentu marży.
        /// </summary>
        /// <param name="netto">Kwota Netto</param>
        /// <param name="vat">Procent vatu</param>
        /// <param name="marza">Procent marzy</param>
        /// <returns>double end_price - wyliczona kwota końcowa</returns>
        public static double End_price_calculate(double netto, double vat, double marza)
        {
            double end_price = ((netto * (1 + vat / 100)) * (1 + marza/ 100));

            return Math.Round(end_price, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Metoda wyliczająca kwotę końcową po odestkach z kwoty netto, procentu vatu, procentu marży i procentu odsetek.
        /// </summary>
        /// <param name="netto">Kwota netto</param>
        /// <param name="vat">Procent vatu</param>
        /// <param name="marza">Procent marży</param>
        /// <param name="interest">Procent odsetek</param>
        /// <returns>double end_price - wyliczona kwota końcowa po odsetkach</returns>
        public static double Interest_end_price_calculate(double netto, double vat, double marza, double interest)
        {
            double end_price = (((netto * (1 + vat / 100)) * (1 + marza / 100)) * (1 + interest / 100));

            return Math.Round(end_price, 2, MidpointRounding.AwayFromZero);
        }
        
    }
}
