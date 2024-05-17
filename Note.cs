namespace ShareInvest.UPbit;

/// <summary>
/// EVEN: 보합
/// RISE: 상승
/// FALL: 하락
/// </summary>
public enum Change
{
    EVEN,
    RISE,
    FALL
}

/// <summary>
/// ASK: 매도
/// BID: 매수
/// </summary>
public enum Order
{
    ASK,
    BID
}

/// <summary>
/// PREVIEW: 입금지원
/// ACTIVE: 거래지원가능
/// DELISTED: 거래지원종료
/// </summary>
public enum MarketState
{
    PREVIEW,
    ACTIVE,
    DELISTED
}

/// <summary>
/// NONE: 해당없음
/// CAUTION: 투자유의
/// </summary>
public enum MarketWarning
{
    NONE,
    CAUTION
}

/// <summary>
/// SNAPSHOT
/// REALTIME: 실시간
/// </summary>
public enum StreamType
{
    SNAPSHOT,
    REALTIME
}