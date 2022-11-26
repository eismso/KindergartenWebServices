using KindergartenWebServices.Models;

namespace KindergartenWebServices.Services
{
    public class StaffelstufenRechnerService
    {
        private double einkommensgrenze1 = 1830.20;
        private double einkommensgrenze2 = 1952.22;
        private double einkommensgrenze3 = 2074.24;
        private double einkommensgrenze4 = 2196.26;
        private double einkommensgrenze5 = 2318.28;
        private double einkommensgrenze6 = 2440.30;
        private double einkommensgrenze7 = 2562.32;
        private double einkommensgrenze8 = 2806.35;
        private double einkommensgrenze9 = 3050.38;

        public void BerechneStaffelstufe(Kind kind)
        {
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
        }
    }
}

