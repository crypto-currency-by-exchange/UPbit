using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShareInvest.UPbit.Models;

public class Caution
{
    /// <summary>가격 급등락 경보 발령 여부</summary>
    [DataMember, JsonProperty("PRICE_FLUCTUATIONS"), JsonPropertyName("PRICE_FLUCTUATIONS")]
    public bool PriceFluctuations
    {
        get; set;
    }

    /// <summary>거래량 급등 경보 발령 여부</summary>
    [DataMember, JsonProperty("TRADING_VOLUME_SOARING"), JsonPropertyName("TRADING_VOLUME_SOARING")]
    public bool TradingVolumeSoaring
    {
        get; set;
    }

    /// <summary>입금량 급등 경보 발령 여부</summary>
    [DataMember, JsonProperty("DEPOSIT_AMOUNT_SOARING"), JsonPropertyName("DEPOSIT_AMOUNT_SOARING")]
    public bool DepositAmountSoaring
    {
        get; set;
    }

    /// <summary>가격 차이 경보 발령 여부</summary>
    [DataMember, JsonProperty("GLOBAL_PRICE_DIFFERENCES"), JsonPropertyName("GLOBAL_PRICE_DIFFERENCES")]
    public bool GlobalPriceDifferences
    {
        get; set;
    }

    /// <summary>소수 계정 집중 경보 발령 여부</summary>
    [DataMember, JsonProperty("CONCENTRATION_OF_SMALL_ACCOUNTS"), JsonPropertyName("CONCENTRATION_OF_SMALL_ACCOUNTS")]
    public bool ConcentrationOfSmallAccounts
    {
        get; set;
    }

    [DataMember, Newtonsoft.Json.JsonIgnore, Key]
    public string? Code
    {
        get; set;
    }
}