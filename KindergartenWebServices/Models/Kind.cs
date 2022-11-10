namespace KindergartenWebServices.Models
{
    public class Kind
    {
        public int KindId { get; set; }
        public int SVN { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }

        public int ErzBerechtiger1SVN { get; set; }
        public string ErzBerechtiger1Nachname { get; set; }
        public string ErzBerechtiger1Vorname { get; set; }
        public int ErzBerechtiger2SVN { get; set; }
        public string ErzBerechtiger2Nachname { get; set; }
        public string ErzBerechtiger2Vorname { get; set; }

        public string Adresse { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }

        public int AnzahlGeschwister { get; set; }

        public float Familieneinkommen { get; set; }

        public string Leistung { get; set; }

        public float Betreuungsbeitrag { get; set; }

        public string KontaktTelefon { get; set; }
        public string KontaktEmail { get; set; }

    }
}
