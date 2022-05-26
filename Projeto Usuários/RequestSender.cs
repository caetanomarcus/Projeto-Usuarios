namespace Projeto_Usuários
{
    public class RequestSender
    {
        private static Dictionary<string, HttpClient> _CLIENTS = new Dictionary<string, HttpClient>();

        private HttpClient _client;

        public RequestSender(string baseURI)
        {
            var value = _CLIENTS.GetValueOrDefault(baseURI);
            if (value == null)
            {
                var newClient = new HttpClient();
                newClient.BaseAddress = new Uri(baseURI);
                _CLIENTS.Add(baseURI, newClient);
                _client = newClient;
            }
            else
            {
                _client = _CLIENTS.GetValueOrDefault(baseURI);
            }
        }

        public async Task<string> Get(string path)
        {
            var response = await _client.GetStringAsync(path);
            return response;
        }
    }
}
