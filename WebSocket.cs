using Newtonsoft.Json;

using ShareInvest.Crypto;
using ShareInvest.UPbit.EventHandler;

namespace ShareInvest.UPbit;

public class WebSocket : ShareWebSocket<TickerEventArgs>
{
    public WebSocket() : base("api.upbit.com/websocket/v1")
    {

    }

    /// <summary>
    /// ticket: 수신하는 대상을 식별
    /// type: 수신하고 싶은 시세 정보를 나열하는 필드
    /// format: DEFAULT(기본형), SIMPLE(축약형)
    /// </summary>
    public async Task RequestAsync(params object[] objArr)
    {
        Queue<object> queue = new();

        foreach (var obj in objArr)
        {
            queue.Enqueue(obj);
        }
        await base.RequestAsync(JsonConvert.SerializeObject(queue));
    }

    public override async Task RequestAsync(string json)
    {
        await base.RequestAsync(json);
    }

    public override async Task ReceiveAsync()
    {
        await base.ReceiveAsync();
    }

    public override async Task ConnectAsync(string? token = null, TimeSpan? interval = null)
    {
        await base.ConnectAsync(token, interval: interval ?? TimeSpan.FromSeconds(0xA));
    }
}