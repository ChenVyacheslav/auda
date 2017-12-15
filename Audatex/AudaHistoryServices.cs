using Audatex.AudaHistoryServiceReferences;

namespace Audatex
{
    public class AudaHistoryServices
    {
        protected readonly AudaHistoryServicePortClient client;

        protected AudaHistoryServices()
        {
        }

        public AudaHistoryServices(AudaHistoryServicePortClient client)
        {
            this.client = client;
        }

        public static AudaHistoryServices Create()
        {
            return new AudaHistoryServices(new AudaHistoryServicePortClient());
        }

        public B2BResponse History(B2BRequest request)
        {
            return client.getHistory(request);
        }
    }
}
