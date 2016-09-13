using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B2D1_Week2_BankDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hieronder is een List gedefinieerd waar alleen Betaalrekeningen aan toegevoegd kunnen worden
            // Maar Studentrekeningen en Afterworkrekeningen zijn ook Betaalrekeningen!
            List<Betaalrekening> rekeningen = new List<Betaalrekening>();
            rekeningen.Add(new Betaalrekening());
            rekeningen.Add(new Afterworkrekening());
            rekeningen.Add(new Studentrekening());

            // Onderstaande regel laat polymorfisme zien:
            // rekeningen[2] wordt gebruikt alsof deze van het type "Betaalrekening" is,
            // maar is van het type "Studentrekening" (zie hierboven)
            // intern weet .NET dat het een Studentrekening is en zal gedrag en eigenschappen
            // behandelen als het juiste type (Studentrekening, Betaalrekening, Rekening of zelfs Object, 
            // afhankelijk van de context, waarbij het meest specifieke type prioriteit heeft
            textBox1.Text = rekeningen[2].Kosten.ToString();

            // Een methode is een manier om berichten te versturen tussen twee objecten
            // Onderstaande methode is een bericht van dit object (een instantie van Form1)
            // naar het 3e item in rekeningen, waarbij het tweede item uit rekeningen en het getal 200
            // als parameters/argumenten worden meegegeven.
            rekeningen[2].Geldovermaken(rekeningen[1], 200);

            // Onderstaande methode is static en wordt aangeroepen vanuit de klasse
            // Normale methoden worden vanuit een object aangeroepen.
            // Static dien je alleen te gebruiken wanneer een methode niet bij een object,
            // maar bij de klasse hoort. Dit is echt een uitzondering!
            Rekening.ConvertEURtoUSD(12);
        }
    }
}
