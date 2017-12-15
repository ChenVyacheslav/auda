using Audatex.FraudCheckServiceReferences;

namespace Audatex
{
    public class FraudCheckServices
    {
        protected readonly ClaimsHistoryServicePortClient client;

        protected FraudCheckServices()
        {
        }

        public FraudCheckServices(ClaimsHistoryServicePortClient client)
        {
            this.client = client;
        }

        public static FraudCheckServices Create()
        {
            return new FraudCheckServices(new ClaimsHistoryServicePortClient());
        }


        public B2BResponse FindExternal(B2BRequest request)
        {
            return client.findExternal(request);
        }
    }
}
