// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> Defines the type of a datasource. </summary>
    public readonly partial struct SearchIndexerDataSourceType : IEquatable<SearchIndexerDataSourceType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SearchIndexerDataSourceType"/> values are the same. </summary>
        public SearchIndexerDataSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureSqlValue = "azuresql";
        private const string CosmosDbValue = "cosmosdb";
        private const string AzureBlobValue = "azureblob";
        private const string AzureTableValue = "azuretable";
        private const string MySqlValue = "mysql";

        /// <summary> azuresql. </summary>
        public static SearchIndexerDataSourceType AzureSql { get; } = new SearchIndexerDataSourceType(AzureSqlValue);
        /// <summary> cosmosdb. </summary>
        public static SearchIndexerDataSourceType CosmosDb { get; } = new SearchIndexerDataSourceType(CosmosDbValue);
        /// <summary> azureblob. </summary>
        public static SearchIndexerDataSourceType AzureBlob { get; } = new SearchIndexerDataSourceType(AzureBlobValue);
        /// <summary> azuretable. </summary>
        public static SearchIndexerDataSourceType AzureTable { get; } = new SearchIndexerDataSourceType(AzureTableValue);
        /// <summary> mysql. </summary>
        public static SearchIndexerDataSourceType MySql { get; } = new SearchIndexerDataSourceType(MySqlValue);
        /// <summary> Determines if two <see cref="SearchIndexerDataSourceType"/> values are the same. </summary>
        public static bool operator ==(SearchIndexerDataSourceType left, SearchIndexerDataSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchIndexerDataSourceType"/> values are not the same. </summary>
        public static bool operator !=(SearchIndexerDataSourceType left, SearchIndexerDataSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SearchIndexerDataSourceType"/>. </summary>
        public static implicit operator SearchIndexerDataSourceType(string value) => new SearchIndexerDataSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchIndexerDataSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchIndexerDataSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
