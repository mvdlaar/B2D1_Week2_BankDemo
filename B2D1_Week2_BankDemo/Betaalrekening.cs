namespace B2D1_Week2_BankDemo
{
    // Met onderstaande notatie wordt duidelijk gemaakt dat dit 
    // een specialisatie is van de klasse Rekening
    class Betaalrekening: Rekening
    {
        protected decimal roodStaanRente;
        protected int pasnummer;
        protected double kosten;

        public double Kosten {
            get { return kosten; }
        }

        public Betaalrekening()
        {
            kosten = 50;
        }

        public void GeldOpnemen(decimal bedrag)
        {
            saldo -= bedrag;
        }
    }
}
