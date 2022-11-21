using KindergartenWebServices.Models;

namespace KindergartenWebServices.Services
{
    public class StaffelstufenRechnerService
    {

        public void BerechneStaffelstufe(Kind kind)
        {
            /*
            string einkommensgrenze9Ausconfig = _configuration["Einkommensgrenze9"];
            double einkommensgrenze9 = Double.Parse(einkommensgrenze9Ausconfig);

            string einkommensgrenze8Ausconfig = _configuration["Einkommensgrenze8"];
            double einkommensgrenze8 = Double.Parse(einkommensgrenze8Ausconfig);

            string einkommensgrenze7Ausconfig = _configuration["Einkommensgrenze7"];
            double einkommensgrenze7 = Double.Parse(einkommensgrenze7Ausconfig);

            string einkommensgrenze6Ausconfig = _configuration["Einkommensgrenze6"];
            double einkommensgrenze6 = Double.Parse(einkommensgrenze6Ausconfig);

            string einkommensgrenze5Ausconfig = _configuration["Einkommensgrenze5"];
            double einkommensgrenze5 = Double.Parse(einkommensgrenze5Ausconfig);

            string einkommensgrenze4Ausconfig = _configuration["Einkommensgrenze4"];
            double einkommensgrenze4 = Double.Parse(einkommensgrenze4Ausconfig);

            string einkommensgrenze3Ausconfig = _configuration["Einkommensgrenze3"];
            double einkommensgrenze3 = Double.Parse(einkommensgrenze3Ausconfig);

            string einkommensgrenze2Ausconfig = _configuration["Einkommensgrenze2"];
            double einkommensgrenze2 = Double.Parse(einkommensgrenze2Ausconfig);

            string einkommensgrenze1Ausconfig = _configuration["Einkommensgrenze1"];
            double einkommensgrenze1 = Double.Parse(einkommensgrenze1Ausconfig);
            */

            double einkommensgrenze1 = 1830.20;
            double einkommensgrenze2 = 1952.22;
            double einkommensgrenze3 = 2074.24;
            double einkommensgrenze4 = 2196.26;
            double einkommensgrenze5 = 2318.28;
            double einkommensgrenze6 = 2440.30;
            double einkommensgrenze7 = 2562.32;
            double einkommensgrenze8 = 2806.35;
            double einkommensgrenze9 = 3050.38;
         

            if (kind.Familieneinkommen > einkommensgrenze9)
            {
                kind.Staffelstufe = 10;
            }
            else if (kind.Familieneinkommen > einkommensgrenze8)
            {
                kind.Staffelstufe = 9;
            }
            else if (kind.Familieneinkommen > einkommensgrenze7)
            {
                kind.Staffelstufe = 8;
            }
            else if (kind.Familieneinkommen > einkommensgrenze6)
            {
                kind.Staffelstufe = 7;
            }
            else if (kind.Familieneinkommen > einkommensgrenze5)
            {
                kind.Staffelstufe = 6;
            }
            else if (kind.Familieneinkommen > einkommensgrenze4)
            {
                kind.Staffelstufe = 5;
            }
            else if (kind.Familieneinkommen > einkommensgrenze3)
            {
                kind.Staffelstufe = 4;
            }
            else if (kind.Familieneinkommen > einkommensgrenze2)
            {
                kind.Staffelstufe = 3;
            }
            else if (kind.Familieneinkommen > einkommensgrenze1)
            {
                kind.Staffelstufe = 2;
            }
            else 
            {
                kind.Staffelstufe = 1;
            }

            if (kind.AnzahlGeschwister > 0)
            {
                for (int i = 1; i < kind.AnzahlGeschwister+1; i++)
                {
                    kind.Staffelstufe -= 1;
                }
            }
        }
    }
}

