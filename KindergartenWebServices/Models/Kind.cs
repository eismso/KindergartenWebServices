using System.ComponentModel.DataAnnotations;

namespace KindergartenWebServices.Models
{
    public class Kind
    {
        //[Required]
        public int KindId { get; set; }

        [Required]
        [MinLength(2)] 
        public string Nachname { get; set; }
        [Required]
        [MinLength(2)]
        public string Vorname { get; set; }
        [Required]
        [MinLength(10)]
        public string SVN { get; set; }
        [Required]
        public int Geburtstag { get; set; }
        [Required]
        public int Geburtsmonat { get; set; }
        [Required]
        public int Geburtsjahr { get; set; }

        [Required]
        [MinLength(2)]
        public string HauptwohnsitzAdresse { get; set; }
        [Required]
        [MinLength(4)]
        public string HauptwohnsitzPLZ { get; set; }
        [Required]
        [MinLength(2)]
        public string HauptwohnsitzOrt { get; set; }

        [Required]
        [MinLength(2)]
        public string ErzBerechtiger1Nachname { get; set; }
        [Required]
        [MinLength(2)]
        public string ErzBerechtiger1Vorname { get; set; }
        [Required]
        [MinLength(10)]
        public string ErzBerechtiger1SVN { get; set; }
        public string ErzBerechtiger2Nachname { get; set; }
        public string ErzBerechtiger2Vorname { get; set; }
        public string ErzBerechtiger2SVN { get; set; }

        [Required]
        [MinLength(2)]
        public string RechnungAdresse { get; set; }
        [Required]
        [MinLength(4)]
        public string RechnungPLZ { get; set; }
        [Required]
        [MinLength(2)]
        public string RechnungOrt { get; set; }
        [Required]
        [MinLength(5)] 
        public string EmailRechnung { get; set; }

        [Required]
        [MinLength(2)]
        public string Betreuungsart { get; set; }
        [Required]
        [MinLength(3)]
        public string Betreuungsumfang { get; set; }

        public float Familieneinkommen { get; set; }
        public int AnzahlGeschwister { get; set; }


        public int Staffelstufe { get; set; }
        public float Betreuungsbeitrag { get; set; }

   
        

    }
}
