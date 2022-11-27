using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text;


public class KigaVerwaltungsSoftware
{
    static HttpClient client = new HttpClient();

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
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Willkommen in deiner KIGA-Verwaltungs-App!\n");
        Console.WriteLine("Für die Staffelstufenberechnung gib bitte die Daten des Kindes ein:\n");

        bool berechnen = true;

        while (berechnen)
        {
            Kind request = new Kind();

            request.KindId = 1;

            Console.WriteLine("Nachname des Kindes:");
            request.Nachname = Console.ReadLine();

            Console.WriteLine("Vorname des Kindes:");
            request.Vorname = Console.ReadLine();

            Console.WriteLine("SVN des Kindes:");
            request.SVN = Console.ReadLine();

            Console.WriteLine("Familieneinkommen:");
            request.Familieneinkommen = float.Parse(Console.ReadLine());

            Console.WriteLine("Geschwisteranzahl des Kindes:");
            request.AnzahlGeschwister = int.Parse(Console.ReadLine());

            // dummy data
            request.Geburtstag = 4;
            request.Geburtsmonat = 2;
            request.Geburtsjahr = 2018;
            request.HauptwohnsitzAdresse = "Lindengasse 33";
            request.HauptwohnsitzPLZ = "8045";
            request.HauptwohnsitzOrt = "Graz";
            request.ErzBerechtiger1Nachname = "Testfrau";
            request.ErzBerechtiger1Vorname = "Susi";
            request.ErzBerechtiger1SVN = "1234123412";
            request.ErzBerechtiger2Nachname = "Testmann";
            request.ErzBerechtiger2Vorname = "Peter";
            request.ErzBerechtiger2SVN = "8888134512";
            request.RechnungAdresse = "Lindengasse 33";
            request.RechnungPLZ = "8045";
            request.RechnungOrt = "Graz";
            request.EmailRechnung = "muster@gmail.com";
            request.Betreuungsart = "KK";
            request.Betreuungsumfang = "7-9";

            string ergebnis = PostStaffelstufe(request).Result;
            Console.WriteLine($"\nDie Berechnung ergibt Staffelstufe {ergebnis}");


            Console.WriteLine("\nSoll das Programm jetzt beendet werden? (Y/N)");
            string abfrage = Console.ReadLine();
            switch (abfrage)
            {
                case "y":
                case "Y":
                    berechnen = false;
                    Console.WriteLine("Programm wird beendet...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
                case "n":
                case "N":
                    Console.WriteLine("\nGib weitere Daten zur Berechnung ein:\n");
                    break;
            }
        }
    }

    
     public static async Task<string> PostStaffelstufe(Kind request)
    {
        var json = JsonConvert.SerializeObject(request);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        string message = "Fehler: Staffelstufe konnte nicht berechnet werden." +
            "\n Überprüfe die Werte";

        string url = "https://localhost:7270/Staffelstufenberechnung";
        var response = await client.PostAsync(url, data);
        var result = await response.Content.ReadAsStringAsync();
        
        if (result !=null)
        {
            return result;
        }
        else
        {           
            return message;
        }
    }

}





