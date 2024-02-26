
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar
{
    using Newtonsoft.Json;
    using Speakeasy.Bar.Models.Components;
    using Speakeasy.Bar.Models.Requests;
    using Speakeasy.Bar.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    public interface IConfig
    {

        /// <summary>
        /// Subscribe to webhooks.
        /// 
        /// <remarks>
        /// Subscribe to webhooks.
        /// </remarks>
        /// </summary>
        Task<SubscribeToWebhooksResponse> SubscribeToWebhooksAsync(List<RequestBody> request);
    }

    public class Config: IConfig
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.272.4";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.272.4 1.0.0 Speakeasy.Bar";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Config(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<SubscribeToWebhooksResponse> SubscribeToWebhooksAsync(List<RequestBody> request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/webhooks/subscribe";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var serializedBody = RequestBodySerializer.Serialize(request, "Request", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;

            var response = new SubscribeToWebhooksResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {

                return response;
            }

            if((response.StatusCode >= 500 && response.StatusCode < 600))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.APIError = JsonConvert.DeserializeObject<APIError>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }

                return response;
            }
                    response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }

        
    }
}