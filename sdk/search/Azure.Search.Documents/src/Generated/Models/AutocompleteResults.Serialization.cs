// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class AutocompleteResults
    {
        internal static AutocompleteResults DeserializeAutocompleteResults(JsonElement element)
        {
            AutocompleteResults result = new AutocompleteResults();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.coverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Coverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Results.Add(Autocompletion.DeserializeAutocompletion(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}