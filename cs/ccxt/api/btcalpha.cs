// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class btcalpha : Exchange
{
    public btcalpha (object args = null): base(args) {}

    public async Task<object> publicGetCurrencies (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrencies",parameters);
    }

    public async Task<object> publicGetPairs (object parameters = null)
    {
        return await this.callAsync ("publicGetPairs",parameters);
    }

    public async Task<object> publicGetOrderbookPairName (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderbookPairName",parameters);
    }

    public async Task<object> publicGetExchanges (object parameters = null)
    {
        return await this.callAsync ("publicGetExchanges",parameters);
    }

    public async Task<object> publicGetChartsPairTypeChart (object parameters = null)
    {
        return await this.callAsync ("publicGetChartsPairTypeChart",parameters);
    }

    public async Task<object> publicGetTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetTicker",parameters);
    }

    public async Task<object> privateGetWallets (object parameters = null)
    {
        return await this.callAsync ("privateGetWallets",parameters);
    }

    public async Task<object> privateGetOrdersOwn (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersOwn",parameters);
    }

    public async Task<object> privateGetOrderId (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderId",parameters);
    }

    public async Task<object> privateGetExchangesOwn (object parameters = null)
    {
        return await this.callAsync ("privateGetExchangesOwn",parameters);
    }

    public async Task<object> privateGetDeposits (object parameters = null)
    {
        return await this.callAsync ("privateGetDeposits",parameters);
    }

    public async Task<object> privateGetWithdraws (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdraws",parameters);
    }

    public async Task<object> privatePostOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostOrder",parameters);
    }

    public async Task<object> privatePostOrderCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderCancel",parameters);
    }

}