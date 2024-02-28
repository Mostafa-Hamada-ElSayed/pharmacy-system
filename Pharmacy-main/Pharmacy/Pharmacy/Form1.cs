using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class pharmacy : Form
    {
        struct info
        {
            public int idx;
            public int pr;
            public string drug;
            public int num;

        }
        info[] infoArray = new info[100];
        public int pos = 0;
        public pharmacy()
        {
            InitializeComponent();
        }
        private void AddDrug_Click(object sender, EventArgs e)
        {
            infoArray[pos].idx = int.Parse(TId.Text);
            infoArray[pos].pr = int.Parse(TPrice.Text);
            infoArray[pos].drug = TDrugName.Text.ToString();
            infoArray[pos].num = int.Parse(TCount.Text);
            pos++;
        }
        private void DisplayItems_Click(object sender, EventArgs e)
        {
            TDisplayItems.Text = string.Empty;
            for (int i = 0; i <= pos && i < 100; i++)
            {
                if (infoArray[i].num < 10)
                {
                    TDisplayItems.Text += $"{infoArray[i].drug}{Environment.NewLine}";
                }
            }

        }

        private void DisplayPrice_Click(object sender, EventArgs e)
        {
            TDisplayPrice.Text = string.Empty;
            for (int i = 0; i <= pos && i < 100; i++)
            {
                if (infoArray[i].pr > 1000)
                {
                    TDisplayPrice.Text += $"{infoArray[i].drug}{Environment.NewLine}";
                }
            }

        }

    }
}
