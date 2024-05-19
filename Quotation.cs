using Newtonsoft.Json;

using RestSharp;

using ShareInvest.Crypto;
using ShareInvest.UPbit.Models;

using System.Net;

namespace ShareInvest.UPbit;

public class Quotation : ShareQuotation
{
    public Quotation() : base("https://api.upbit.com/v1")
    {

    }

    public override async Task<RestResponse> GetMarketAsync(bool isDetails = true)
    {
        return await base.GetMarketAsync(isDetails);
    }

    public async Task<Market[]> GetMarketAsync()
    {
        var res = await GetMarketAsync(true);

        if (HttpStatusCode.OK != res.StatusCode || string.IsNullOrEmpty(res.Content))
        {
            return [];
        }
        return JsonConvert.DeserializeObject<Market[]>(res.Content) ?? [];
    }

    public override async Task<RestResponse> GetTickerAsync(params string[] codeArr)
    {
        return await base.GetTickerAsync(codeArr);
    }

    public async Task<Ticker[]> GetTickerAsync(Market[] markets)
    {
        var res = await GetTickerAsync([.. from m in markets
                                           where !string.IsNullOrEmpty(m.Code)
                                           select m.Code]);

        if (HttpStatusCode.OK != res.StatusCode || string.IsNullOrEmpty(res.Content))
        {
            return [];
        }
        return JsonConvert.DeserializeObject<Ticker[]>(res.Content) ?? [];
    }
}