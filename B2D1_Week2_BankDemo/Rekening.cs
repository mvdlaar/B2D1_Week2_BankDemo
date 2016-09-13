using System;

namespace B2D1_Week2_BankDemo
{
    class Rekening
    {
        // De visibility modifiers zorgen ervoor dat een klasse, methode, property of veld wel of niet zichtbaar is voor andere klassen

        // private betekent: alleen zichtbaar in de huidige klasse
        // protected betekent: private plus zichtbaar in afgeleide klassen
        // internal betekent: internal plus zichtbaar in andere klassen in dezelfde namespace
        // public betekent: vanuit alle andere klassen zichtbaar

        protected decimal saldo;
        protected string rekeninghouder;
        protected string rekeningnummer;
        protected DateTime start;
        protected bool beeindigd;
        protected DateTime einde;

        public static decimal ConvertEURtoUSD(decimal bedrag)
        {
            return Convert.ToDecimal(1.2)*bedrag;
        }

        public Rekening()
        {
            // Met onderstaande code wordt de startdatum gevuld
            // met de huidige datum (en tijd)
            start = DateTime.Now;
        }

        // Hieronder zie je een property
        // Een property definieert getters en setters voor een eigenschap van een klasse
        // Deze kunnen bijvoorbeeld uit een veld komen, zoals hieronder
        // (dit maakt het saldo read-only beschikbaar aan andere klassen)
        // Maar kunnen bijvoorbeeld ook berekend worden of uit een andere databron komen.
        public decimal Saldo {
            get { return saldo; }
        }

        public Transactie Geldovermaken(Rekening doelrekening, decimal bedrag)
        {
            return new Transactie(this, doelrekening, bedrag);
        }

        public void Beeindigen()
        {
            beeindigd = true;
            einde = DateTime.Now;
        }
    }
}
