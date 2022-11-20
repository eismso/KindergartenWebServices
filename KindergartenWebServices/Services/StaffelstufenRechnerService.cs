using KindergartenWebServices.Models;

namespace KindergartenWebServices.Services
{
    public class StaffelstufenRechnerService
    {
        private readonly IConfiguration _configuration;

        public int BerechneStaffelstufe(Kind kind)
        {
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


            if (kind.Familieneinkommen > einkommensgrenze9)
            {
                return 10;
            }
            else if (kind.Familieneinkommen > einkommensgrenze8)
            {
                return 9;
            }
            else if (kind.Familieneinkommen > einkommensgrenze7)
            {
                return 8;
            }
            else if (kind.Familieneinkommen > einkommensgrenze6)
            {
                return 7;
            }
            else if (kind.Familieneinkommen > einkommensgrenze5)
            {
                return 6;
            }
            else if (kind.Familieneinkommen > einkommensgrenze4)
            {
                return 5;
            }
            else if (kind.Familieneinkommen > einkommensgrenze3)
            {
                return 4;
            }
            else if (kind.Familieneinkommen > einkommensgrenze2)
            {
                return 3;
            }
            else if (kind.Familieneinkommen > einkommensgrenze1)
            {
                return 2;
            }
            else if (kind.Familieneinkommen <= einkommensgrenze1)
            {
                return 1;
            }
        }
    }
}

