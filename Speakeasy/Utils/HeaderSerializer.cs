
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Utils
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Reflection;

    internal static class HeaderSerializer
    {
        public static void PopulateHeaders(ref HttpRequestMessage httpRequest, object? request)
        {
            if (request == null)
            {
                return;
            }

            var props = request.GetType().GetProperties();

            foreach (var prop in props)
            {
                var val = prop.GetValue(request);
                if (val == null)
                {
                    continue;
                }

                var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetHeaderMetadata();
                if (metadata == null || metadata.Name == "")
                {
                    continue;
                }

                var headerValue = SerializeHeader(val, metadata.Explode);
                if (headerValue != "")
                {
                    httpRequest.Headers.Add(metadata.Name, headerValue);
                }
            }
        }

        private static string SerializeHeader(object value, bool explode)
        {
            if (Utilities.IsClass(value))
            {
                var items = new List<string>();

                var props = value.GetType().GetProperties();

                foreach (var prop in props)
                {
                    var val = prop.GetValue(value);
                    if (val == null)
                    {
                        continue;
                    }

                    var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetHeaderMetadata();
                    if (metadata == null || metadata.Name == null)
                    {
                        continue;
                    }

                    if (explode)
                    {
                        items.Add($"{metadata.Name}={Utilities.ValueToString(val)}");
                    }
                    else
                    {
                        items.Add(metadata.Name);
                        items.Add(Utilities.ValueToString(val));
                    }
                }

                return string.Join(",", items);
            }
            else if (Utilities.IsDictionary(value))
            {
                var items = new List<string>();

                foreach (DictionaryEntry entry in (IDictionary)value)
                {
                    var key = entry.Key?.ToString();

                    if (key == null)
                    {
                        continue;
                    }

                    if (explode)
                    {
                        items.Add($"{key}={Utilities.ValueToString(entry.Value)}");
                    }
                    else
                    {
                        items.Add(key);
                        items.Add(Utilities.ValueToString(entry.Value));
                    }
                }

                return string.Join(",", items);
            }
            else if (Utilities.IsList(value))
            {
                var items = new List<string>();

                foreach (var item in (IList)value)
                {
                    items.Add(Utilities.ValueToString(item));
                }

                return string.Join(",", items);
            }
            else
            {
                return Utilities.ValueToString(value);
            }
        }
    }
}
