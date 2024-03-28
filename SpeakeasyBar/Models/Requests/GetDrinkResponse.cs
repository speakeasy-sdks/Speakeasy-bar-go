
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyBar.Models.Requests
{
    using SpeakeasyBar.Models.Components;
    using System.Net.Http;
    using System;
    
    public class GetDrinkResponse
    {

        /// <summary>
        /// An error occurred interacting with the API.
        /// </summary>
        public APIError? APIError { get; set; }

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// A drink.
        /// </summary>
        public Drink? Drink { get; set; }

        /// <summary>
        /// An unknown error occurred interacting with the API.
        /// </summary>
        public Error? Error { get; set; }

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        public HttpResponseMessage RawResponse { get; set; } = default!;
    }
}