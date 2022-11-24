using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoenixDevelopment.BitCalculator.UX
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxSize.Text = (UTF8Encoding.UTF8.GetByteCount(textBoxInput.Text)*8).ToString();

            string HexText = null;

            foreach (char c in textBoxInput.Text)
            {
                HexText += string.Format("{0:x2}", (uint)System.Convert.ToUInt32(c)) + " ";
            }

            textBoxHex.Text = HexText;
        }
    }
}
