using System.ComponentModel.DataAnnotations;

namespace KindergartenWebServices.Models
{
    public class Kind
    {
        //ID wird in Kinderdatenbank erstellt
        [Range(0, int.MaxValue, ErrorMessage = "ID darf nicht negativ sein")]
        public int KindId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Nachname muss mind. 2 Zeichen lang sein")] 
        public string Nachname { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Vorname muss mind. 2 Zeichen lang sein")]
        public string Vorname { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "SVN muss mind. 10 Zeichen lang sein")]
        public string SVN { get; set; }
        [Required]
        [Range(1, 31, ErrorMessage = "Geburtstag muss zw. 1 und 31 sein")]
        public int Geburtstag { get; set; }
        [Required]
        [Range(1, 12, ErrorMessage = "Geburtsmonat muss zw. 1 und 12 sein")]
        public int Geburtsmonat { get; set; }
        [Required]
        [Range(2000, int.MaxValue, ErrorMessage = "Geburtsjahr muss mind. 2000 sein")]
        public int Geburtsjahr { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Adresse muss mind. 2 Zeichen lang sein")]
        public string HauptwohnsitzAdresse { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "PLZ muss mind. 4 Zeichen lang sein")]
        public string HauptwohnsitzPLZ { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Ort muss mind. 2 Zeichen lang sein")]
        public string HauptwohnsitzOrt { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "ErzBerechtiger1Nachname muss mind. 2 Zeichen lang sein")]
        public string ErzBerechtiger1Nachname { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "ErzBerechtiger1Vorname muss mind. 2 Zeichen lang sein")]
        public string ErzBerechtiger1Vorname { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "ErzBerechtiger1SVN muss mind. 10 Zeichen lang sein")]
        public string ErzBerechtiger1SVN { get; set; }

        [MinLength(2, ErrorMessage = "ErzBerechtiger2Nachname muss mind. 2 Zeichen lang sein")]
        public string ErzBerechtiger2Nachname { get; set; }
        [MinLength(2, ErrorMessage = "ErzBerechtiger2Vorname muss mind. 3 Zeichen lang sein")]
        public string ErzBerechtiger2Vorname { get; set; }
        [MinLength(10, ErrorMessage = "ErzBerechtiger2SVN muss mind. 10 Zeichen lang sein")]
        public string ErzBerechtiger2SVN { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "RechnungAdresse muss mind. 2 Zeichen lang sein")]
        public string RechnungAdresse { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "RechnungPLZ muss mind. 4 Zeichen lang sein")]
        public string RechnungPLZ { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "RechnungOrt muss mind. 2 Zeichen lang sein")]
        public string RechnungOrt { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Email muss mind. 5 Zeichen lang sein")] 
        public string EmailRechnung { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Betreuungsart muss mind. 2 Zeichen lang sein")]
        public string Betreuungsart { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Betreuungsumfang muss mind. 3 Zeichen lang sein")]
        public string Betreuungsumfang { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Familieneinkommen darf nicht negativ sein")]
        public float Familieneinkommen { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Geschwisteranzahl darf nicht negativ sein")]
        public int AnzahlGeschwister { get; set; }

        [Range(0, 10, ErrorMessage = "Staffelstufe muss zw. 0 und 10 liegen")]
        public int Staffelstufe { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Betreuungsbeitrag darf nicht negativ sein")]
        public float Betreuungsbeitrag { get; set; }

   
        

    }
}
