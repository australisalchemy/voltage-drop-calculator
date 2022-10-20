using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace ElectricalCalculator
{
    public partial class frmMain : Form
    {
        public double m_ResistivityOhms = 0;
        public double m_LengthMetres = 0;
        public double m_ResistanceOhms = 0;
        public double m_CSAMMS = 0;
        public double m_LoadAmps = 0;
        public double m_VoltageDrops = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void UpdateVariables()
        {
            // handle the metal resistivity section here
            if (btnSilver.Checked)
            {
                m_ResistivityOhms = 1.59e-8;
            }
            else if (btnCopper.Checked)
            {
                m_ResistivityOhms = 1.7e-7;
            }
            else if (btnAluminium.Checked)
            {
                m_ResistivityOhms = 2.82e-8;
            }
            else if (btnGold.Checked)
            {
                m_ResistivityOhms = 2.44e-8;
            }
            else if (btnIron.Checked)
            {
                m_ResistivityOhms = 1.0e-7;
            }
            else
            {
                MessageBox.Show("Please select a metal type!", "Metal Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // check the variables to ensure they're valid input first
            // convert all the variables and put them in their place holders
            try
            {
                m_LengthMetres = double.Parse(txtLength.Text);
                m_LoadAmps = double.Parse(txtSrcCurrent.Text);
                m_CSAMMS = double.Parse(txtCSA.Text);
            }
            catch
            {
                txtLength.Text = "1";
                txtSrcCurrent.Text = "1";
                txtCSA.Text = "1";
            }

            // display the resistivity data
            txtResistivity.Text = string.Format("{0} Ω/m", ToLongString(m_ResistivityOhms));

            Calculate();
        }


        public void Calculate()
        {
            // we follow the general formula of R = ρL/A
            // where ρ is the resistivity
            // L is the length
            // A is the CSA
            // R is the resistance
            m_ResistanceOhms = (m_ResistivityOhms * 10e-6) * m_LengthMetres / (m_CSAMMS * 10e-6);

            // calculate the voltage drop using ohms law (V = IR)
            m_VoltageDrops = m_LoadAmps * m_ResistanceOhms;

            // display the resistance and voltage drop data now
            txtResistance.Text = string.Format("{0} Ω", ToLongString(m_ResistanceOhms));
            lblVoltageDisplay.Text = string.Format("{0} V", ToLongString(m_VoltageDrops));

            
        }

        // taken from StackOverflow (Thibaut Brard)
        private static string ToLongString(double input)
        {
            string str = input.ToString().ToUpper();

            // if string representation was collapsed from scientific notation, just return it:
            if (!str.Contains("E")) return str;

            bool negativeNumber = false;

            if (str[0] == '-')
            {
                str = str.Remove(0, 1);
                negativeNumber = true;
            }

            string sep = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            char decSeparator = sep.ToCharArray()[0];

            string[] exponentParts = str.Split('E');
            string[] decimalParts = exponentParts[0].Split(decSeparator);

            // fix missing decimal point:
            if (decimalParts.Length == 1) decimalParts = new string[] { exponentParts[0], "0" };

            int exponentValue = int.Parse(exponentParts[1]);

            string newNumber = decimalParts[0] + decimalParts[1];

            string result;

            if (exponentValue > 0)
            {
                result =
                    newNumber +
                    GetZeros(exponentValue - decimalParts[1].Length);
            }
            else // negative exponent
            {
                result =
                    "0" +
                    decSeparator +
                    GetZeros(exponentValue + decimalParts[0].Length) +
                    newNumber;

                result = result.TrimEnd('0');
            }

            if (negativeNumber)
                result = "-" + result;

            return result;
        }

        // taken from StackOverflow (Thibaut Brard)
        private static string GetZeros(int zeroCount)
        {
            if (zeroCount < 0)
                zeroCount = Math.Abs(zeroCount);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < zeroCount; i++) sb.Append("0");

            return sb.ToString();
        }


        private void txtCSA_TextChanged(object sender, EventArgs e)
        {
            UpdateVariables();
        }
    }
}
