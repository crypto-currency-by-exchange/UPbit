using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.UPbit.Models;

public class Orderbook : Response
{
    public string? Code
    {
        get; set;
    }

    public long Timestamp
    {
        get; set;
    }

    [DataMember, JsonProperty("total_ask_size")]
    public double TotalAskSize
    {
        get; set;
    }

    [DataMember, JsonProperty("total_bid_size")]
    public double TotalBidSize
    {
        get; set;
    }

    [DataMember, JsonProperty("orderbook_units")]
    public Unit[]? Units
    {
        get; set;
    }

    [DataMember, JsonProperty("stream_type")]
    public string? StreamType
    {
        get; set;
    }

    public int Level
    {
        get; set;
    }
}