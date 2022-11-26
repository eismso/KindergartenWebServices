using System.Net.Http.Json;
using KindergartenWebServices;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using System.Text.Json.Serialization;
using System;


public class KigaVerwaltungsSoftware
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

    public static void Main ()
    {
        Console.WriteLine("Willkommen in deiner KIGA-Verwaltungs-App!");
        Console.WriteLine("Bitte gib die Daten des neuen Kindes ein:");

        Kind request = new Kind();

        request.KindId= 1;

        Console.WriteLine("Nachname des Kindes:");
        request.Nachname = Console.ReadLine();

        Console.WriteLine("Vorname des Kindes:");
        request.Vorname = Console.ReadLine();

        Console.WriteLine("SVN des Kindes:");
        request.SVN = Console.ReadLine();

        request.Geburtstag = 4;
        request.Geburtsmonat = 2;
        request.Geburtsjahr = 2018;

        Console.WriteLine("PLZ des Hauptwohnsitzes des Kindes:");
        request.HauptwohnsitzPLZ = Console.ReadLine();

        Console.WriteLine("Ort des Hauptwohnsitzes des Kindes:");
        request.HauptwohnsitzOrt = Console.ReadLine();

        Console.WriteLine("Adresse des Hauptwohnsitzes des Kindes:");
        request.HauptwohnsitzAdresse = Console.ReadLine();

        request.ErzBerechtiger1Nachname = "Testfrau";
        request.ErzBerechtiger1Vorname = "Susi";
        request.ErzBerechtiger1SVN = "1234";
        request.ErzBerechtiger2Nachname = "Testmann";
        request.ErzBerechtiger2Vorname = "Peter";
        request.ErzBerechtiger2SVN = "8888";
        request.RechnungAdresse = "Lindengasse 33";
        request.RechnungPLZ = "8045";
        request.RechnungOrt = "Graz";
        request.EmailRechnung = "muster@gmail.com";
        request.Betreuungsart = "Kindergarten";
        request.Betreuungsumfang = "8h pro Woche";
        request.Familieneinkommen = 3000;
        request.AnzahlGeschwister = 2;

    }

    private static void Post(Kind request)
    {
        var json = JsonConvert.SerializeObject(request);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        HttpClient client = new HttpClient();

        string url = "https://localhost:7270/api/kind";

        var response = client.PostAsync(url, data).Result;

        var result = response.Content.ReadAsStringAsync();
        Console.WriteLine(result);
    }

}





