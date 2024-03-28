
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyBar.Models.Components
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of ingredient.
    /// </summary>
    public enum IngredientType
    {
        [JsonProperty("fresh")]
        Fresh,
        [JsonProperty("long-life")]
        LongLife,
        [JsonProperty("packaged")]
        Packaged,
    }

    public static class IngredientTypeExtension
    {
        public static string Value(this IngredientType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static IngredientType ToEnum(this string value)
        {
            foreach(var field in typeof(IngredientType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is IngredientType)
                    {
                        return (IngredientType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum IngredientType");
        }
    }

}