using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Hund
{
    class HundMitAnzeigen : Hund
    {

        String bild, hilf = @"..\..\..\hund";
        int i = 0;
        private TextBox Namensanzeige;
        private TextBox Typenanzeige;
        private PictureBox Bildanzeige;

        public HundMitAnzeigen(String n, String t, String b) : base(n, t, b) { }

        public void Init(TextBox n, TextBox t, PictureBox b)
        {
            Namensanzeige = n;
            Typenanzeige = t;
            Bildanzeige = b;
        }

        public void Anzeigen()
        {
            Namensanzeige.Text = ZeigeName();
            Typenanzeige.Text = ZeigeTyp();
            try
            {
                Bildanzeige.Image = Image.FromFile(ZeigeBild());
            }
            catch
            {
                MessageBox.Show("Bild kann nicht angezeigt werden");
            }
        }

        public void Loeschen()
        {
            Namensanzeige.Text = loeschen();
            Typenanzeige.Text = loeschen();
            Bildanzeige.Image = null;
        }

        public void bewegen()
        {
            try
            {
                bild = hilf + Convert.ToInt16(i%1 + 1) + ".png";
                Bildanzeige.Image = Image.FromFile(bild);
                Bildanzeige.Refresh();
                Thread.Sleep(200);
            }
            catch
            {
                MessageBox.Show("Bild kann nicht angezeigt werden");
            } 
            
        }
    }
}
