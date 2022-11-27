﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text;


public class KigaVerwaltungsSoftware
{
    static HttpClient client = new HttpClient();

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
            int ergebnisAlsInt = 0;
            bool canConvert = int.TryParse(ergebnis, out ergebnisAlsInt);
            if (canConvert)
            {
                Console.WriteLine($"\nDie Berechnung ergibt Staffelstufe {ergebnisAlsInt}");
            }
            else
            {
                Console.WriteLine($"\nFehler: {ergebnis}");
            }
            //int ergebnisAlsInt = int.Parse(ergebnis);
           


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





