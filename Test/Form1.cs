using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Khmerconverter;

namespace Test
{
    public partial class Form1 : Form
    {
        UnicodeToLegacy _toLegacy = new UnicodeToLegacy();
        LegacyToUnicode _toUnicode = new LegacyToUnicode();
        public Form1()
        {
            InitializeComponent();
        }

        private void btntoLimon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUnicode.Text))
            {
                txtLimon.Text = _toLegacy.process(txtUnicode.Text, "Limon S1");
            }
        }

        private void btnToUnicode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLimon.Text))
            {
                txtUnicode.Text = _toUnicode.process(txtLimon.Text, "Limon S1");
            }
        }
    }
}
