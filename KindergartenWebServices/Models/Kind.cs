namespace KindergartenWebServices.Models
{
    public class Kind
    {
        public int KindId { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string SVN { get; set; }
        public int Geburtstag { get; set; }
        public int Geburtsmonat { get; set; }
        public int Geburtsjahr { get; set; }

        public string HauptwohnsitzAdresse { get; set; }
        public string HauptwohnsitzPLZ { get; set; }
        public string HauptwohnsitzOrt { get; set; }

        public string ErzBerechtiger1Nachname { get; set; }
        public string ErzBerechtiger1Vorname { get; set; }
        public string ErzBerechtiger1SVN { get; set; }
        public string ErzBerechtiger2Nachname { get; set; }
        public string ErzBerechtiger2Vorname { get; set; }
        public string ErzBerechtiger2SVN { get; set; }

        public string RechnungAdresse { get; set; }
        public string RechnungPLZ { get; set; }
        public string RechnungOrt { get; set; }
        public string EmailRechnung { get; set; }

        public string Betreuungsart { get; set; }
        public string Betreuungsumfang { get; set; }

        public float Familieneinkommen { get; set; }
        public int AnzahlGeschwister { get; set; }


        public int Staffelstufe { get; set; }
        public float Betreuungsbeitrag { get; set; }

   
        

    }
}
