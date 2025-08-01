using GateOperationApp.Models;
using Newtonsoft.Json;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace GateOperationApp.Service
{
    public class GateApi
    {
        private readonly string Url;
        private readonly string Token;
        public string ErrorMessage { get; private set; } = "";

        private static readonly HttpClient client = new HttpClient();

        public GateApi(string url, string token)
        {
            Url = url;
            Token = token;

            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);
            client.Timeout = TimeSpan.FromMilliseconds(10000);
        }

        public async Task<Receipt?> GetReceiptWithNoAsync(string no)
        {
            var policyResult = await Policy.Handle<WebException>(ex => (ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.ServiceUnavailable)
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(retryAttempt * 2))
                .ExecuteAndCaptureAsync(async () => await client.GetAsync($"/api/join/receipts/{no}").ConfigureAwait(false));
            if (policyResult.Outcome == OutcomeType.Failure && !policyResult.Result.IsSuccessStatusCode)
                return null;
            else
                return JsonConvert.DeserializeObject<Receipt>(await policyResult.Result.Content.ReadAsStringAsync().ConfigureAwait(false));
        }

        public async Task<bool> DeleteReceiptAsync(string receiptNo)
        {
            var policyResult = await Policy.Handle<WebException>(ex => (ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.ServiceUnavailable)
                .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(retryAttempt * 2))
                .ExecuteAndCaptureAsync(async () => await client.DeleteAsync($"/api/join/receipts/{receiptNo}").ConfigureAwait(false));
            if (policyResult.Outcome == OutcomeType.Failure)
                return false;
            if (policyResult.Result.StatusCode == HttpStatusCode.OK)
                return true;
            else
                return false;
        }
    }
}
