
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyBar.Utils
{
    using System;
    using System.Reflection;
    using System.Text;

    internal static class SecuritySerializer
    {
        public static ISpeakeasyHttpClient Apply(ISpeakeasyHttpClient client, Func<object> securitySource)
        {
            if (securitySource == null)
            {
                return client;
            }

            var security = securitySource();
            if (security == null)
            {
                return client;
            }

            client = new SpeakeasyHttpClient(client);

            var props = security.GetType().GetProperties();

            foreach (var prop in props)
            {
                var value = prop.GetValue(security, null);

                if (value == null)
                {
                    continue;
                }

                var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetSecurityMetadata();
                if (metadata == null)
                {
                    continue;
                }

                if (metadata.Option)
                {
                    ApplyOption(ref client, value);
                }
                else if (metadata.Scheme)
                {
                    if (metadata.SubType == "basic" && !Utilities.IsClass(value))
                    {
                        ApplyScheme(ref client, metadata, security);
                        return client;
                    }
                    else
                    {
                        ApplyScheme(ref client, metadata, value);
                    }
                }
            }

            return client;
        }

        private static void ApplyOption(ref ISpeakeasyHttpClient client, object option)
        {
            var props = option.GetType().GetProperties();

            foreach (var prop in props)
            {
                var value = prop.GetValue(option, null);

                if (value == null)
                {
                    continue;
                }

                var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetSecurityMetadata();
                if (metadata == null || !metadata.Scheme)
                {
                    continue;
                }

                ApplyScheme(ref client, metadata, value);
            }
        }

        private static void ApplyScheme(
            ref ISpeakeasyHttpClient client,
            SpeakeasyMetadata.SecurityMetadata schemeMetadata,
            object scheme
        )
        {
            if (Utilities.IsClass(scheme))
            {
                if (schemeMetadata.Type == "http" && schemeMetadata.SubType == "basic")
                {
                    ApplyBasicAuthScheme(ref client, scheme);
                    return;
                }

                var props = scheme.GetType().GetProperties();

                foreach (var prop in props)
                {
                    var value = prop.GetValue(scheme, null);

                    if (value == null)
                    {
                        continue;
                    }

                    var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetSecurityMetadata();
                    if (metadata == null || metadata.Name == "")
                    {
                        continue;
                    }

                    ApplySchemeValue(ref client, schemeMetadata, metadata, value);
                }
            }
            else
            {
                ApplySchemeValue(ref client, schemeMetadata, schemeMetadata, scheme);
            }
        }

        private static void ApplySchemeValue(
            ref ISpeakeasyHttpClient client,
            SpeakeasyMetadata.SecurityMetadata schemeMetadata,
            SpeakeasyMetadata.SecurityMetadata valueMetadata,
            object value
        )
        {
            if (valueMetadata.Name == "")
            {
                return;
            }

            switch (schemeMetadata.Type)
            {
                case "apiKey":
                    switch (schemeMetadata.SubType)
                    {
                        case "header":
                            client.AddHeader(valueMetadata.Name, Utilities.ValueToString(value));
                            break;
                        case "query":
                            client.AddQueryParam(
                                valueMetadata.Name,
                                Utilities.ValueToString(value)
                            );
                            break;
                        case "cookie":
                            client.AddHeader(
                                "cookie",
                                $"{valueMetadata.Name}={Utilities.ValueToString(value)}"
                            );
                            break;
                        default:
                            throw new Exception(
                                $"Unknown apiKey subType: {schemeMetadata.SubType}"
                            );
                    }
                    break;
                case "openIdConnect":
                    client.AddHeader(valueMetadata.Name, Utilities.PrefixBearer(Utilities.ValueToString(value)));
                    break;
                case "oauth2":
                    client.AddHeader(valueMetadata.Name, Utilities.PrefixBearer(Utilities.ValueToString(value)));
                    break;
                case "http":
                    switch (schemeMetadata.SubType)
                    {
                        case "bearer":
                            client.AddHeader(
                                valueMetadata.Name,
                                Utilities.PrefixBearer(Utilities.ValueToString(value))
                            );
                            break;
                        default:
                            throw new Exception($"Unknown http subType: {schemeMetadata.SubType}");
                    }
                    break;
                default:
                    throw new Exception($"Unknown security type: {schemeMetadata.Type}");
            }
        }

        private static void ApplyBasicAuthScheme(ref ISpeakeasyHttpClient client, object scheme)
        {
            var props = scheme.GetType().GetProperties();

            string username = "";
            string password = "";

            foreach (var prop in props)
            {
                var value = prop.GetValue(scheme, null);

                if (value == null)
                {
                    continue;
                }

                var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetSecurityMetadata();
                if (metadata == null || metadata.Name == "")
                {
                    continue;
                }

                if (metadata.Name == "username")
                {
                    username = Utilities.ValueToString(value);
                }
                else if (metadata.Name == "password")
                {
                    password = Utilities.ValueToString(value);
                }
            }

            var auth = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
            client.AddHeader("Authorization", $"Basic {auth}");
        }
    }
}
