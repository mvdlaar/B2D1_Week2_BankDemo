using System;

namespace B2D1_Week2_BankDemo
{
    class Transactie
    {
        protected Rekening ontvangst;
        protected Rekening verzend;
        protected decimal bedrag;
        protected DateTime datum;
        protected string transactieNummer;

        // Deze methode is een constructor
        // Deze verschilt op 2 belangrijke manieren van andere methoden:
        // 1. Er is geen return type (impliciet is het return type een instantie 
        //    van de betreffende klasse (in dit geval een Transactie)
        // 2. Het is geen reguliere methode: deze wordt niet vanuit een object
        //    maar vanuit de klasse aangeroepen.
        // De naam van de constructor is altijd dezelfde als die van de klasse
        public Transactie(Rekening van, Rekening naar, decimal bedrag)
        {
            ontvangst = naar;
            verzend = van;
            this.bedrag = bedrag;
            datum = DateTime.Now;
            transactieNummer = "42";
        }
    }
}
