using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorChangerForm
{
    public partial class Form1 : Form
    {
        private List<Color> renkListesi;
        private int renkIndex = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // 10 farklı rengi tanımlıyoruz
            renkListesi = new List<Color>
            {
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Yellow,
                Color.Orange,
                Color.Purple,
                Color.Pink,
                Color.Teal,
                Color.Brown,
                Color.Gray
            };

            // İlk rengi uygula
            this.BackColor = renkListesi[renkIndex];
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Enter tuşuna basıldığında renk değiştir
            if (keyData == Keys.Enter)
            {
                renkIndex = (renkIndex + 1) % renkListesi.Count; // Liste sonuna geldiğinde başa dön
                this.BackColor = renkListesi[renkIndex];
                return true; // İşlendiğini belirt
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

