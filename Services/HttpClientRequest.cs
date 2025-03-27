namespace BlazorCrud.Services
{
    public class HttpClientRequest
    {
        public async Task<HttpResponseMessage> RequestHttp(HttpRequestMessage msg, bool disableSSL = false)
        {
            var handler = new HttpClientHandler();

            if (disableSSL)
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            using (var client = new HttpClient(handler))
            {
                return await client.SendAsync(msg);
            }
        }
    }
}
