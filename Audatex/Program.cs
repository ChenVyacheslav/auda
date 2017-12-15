using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audatex
{
    class Program
    {
        protected static AudaHistoryServices audaHistoryServices = AudaHistoryServices.Create();
        protected static FraudCheckServices fraudCheckServices = FraudCheckServices.Create();

        static void Main(string[] args)
        {
            var b2bParameters = new List<AudaHistoryServiceReferences.B2BParameter>();
            b2bParameters.Add(new AudaHistoryServiceReferences.B2BParameter { name = "loginId", value = "" });
            b2bParameters.Add(new AudaHistoryServiceReferences.B2BParameter { name = "password", value = "" });
            b2bParameters.Add(new AudaHistoryServiceReferences.B2BParameter { name = "VIN", value = "TMBNW26Y374019349" });
            var b2bRequest = new AudaHistoryServiceReferences.B2BRequest() { parameter = b2bParameters.ToArray() };
            var responseAuda = audaHistoryServices.History(b2bRequest);

            var b2bParametersFraud = new List<FraudCheckServiceReferences.B2BParameter>();
            b2bParametersFraud.Add(new FraudCheckServiceReferences.B2BParameter { name = "loginId", value = "" });
            b2bParametersFraud.Add(new FraudCheckServiceReferences.B2BParameter { name = "password", value = "" });
            b2bParametersFraud.Add(new FraudCheckServiceReferences.B2BParameter { name = "VIN", value = "TMBNW26Y374019349" });

            var b2bFraudRequest = new FraudCheckServiceReferences.B2BRequest() { parameter = b2bParametersFraud.ToArray() };
            var responseFraud = fraudCheckServices.FindExternal(b2bFraudRequest);

            Console.WriteLine(responseAuda);
            Console.ReadKey();
        }
    }
}
