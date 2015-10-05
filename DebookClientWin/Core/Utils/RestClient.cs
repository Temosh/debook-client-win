using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using DebookClientWin.Core.Model;
using Newtonsoft.Json;

namespace DebookClientWin.Core.Utils
{
    internal class RestClient
    {
        private readonly string _serverUrl;

        public RestClient(string serverUrl)
        {
            _serverUrl = serverUrl;
        }

        public List<LocalDebt> GetLocalDebts()
        {
            return JsonConvert.DeserializeObject<List<LocalDebt>>(GetQuery("/debt/local"));
        }

        private string GetQuery(string query)
        {
            var wc = new WebClient();
            var responceBytes = wc.DownloadData(_serverUrl + query);

            Debug.WriteLine("Web service GET query: " + (_serverUrl + query) + "; Response: " + TraceResponse(responceBytes));

            return Encoding.UTF8.GetString(responceBytes);
        }

        private static string TraceResponse(byte[] responceBytes)
        {
            return new StreamReader(new MemoryStream(responceBytes)).ReadToEnd();
        }
    }
}
