﻿namespace Luciferin.Infrastructure.GoCardless.Models;

using System.Text.Json.Serialization;

public class AccountDetails
{
    [JsonPropertyName("cashAccountType")]
    public string CashAccountType { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("iban")]
    public string Iban { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("ownerName")]
    public string OwnerName { get; set; }

    [JsonPropertyName("product")]
    public string Product { get; set; }

    [JsonPropertyName("resourceId")]
    public string ResourceId { get; set; }
}