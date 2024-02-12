// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class luno : Exchange
{
    public luno (object args = null): base(args) {}

    public async Task<object> exchangeGetMarkets (object parameters = null)
    {
        return await this.callAsync ("exchangeGetMarkets",parameters);
    }

    public async Task<object> exchangePrivateGetCandles (object parameters = null)
    {
        return await this.callAsync ("exchangePrivateGetCandles",parameters);
    }

    public async Task<object> publicGetOrderbook (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderbook",parameters);
    }

    public async Task<object> publicGetOrderbookTop (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderbookTop",parameters);
    }

    public async Task<object> publicGetTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetTicker",parameters);
    }

    public async Task<object> publicGetTickers (object parameters = null)
    {
        return await this.callAsync ("publicGetTickers",parameters);
    }

    public async Task<object> publicGetTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetTrades",parameters);
    }

    public async Task<object> privateGetAccountsIdPending (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountsIdPending",parameters);
    }

    public async Task<object> privateGetAccountsIdTransactions (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountsIdTransactions",parameters);
    }

    public async Task<object> privateGetBalance (object parameters = null)
    {
        return await this.callAsync ("privateGetBalance",parameters);
    }

    public async Task<object> privateGetBeneficiaries (object parameters = null)
    {
        return await this.callAsync ("privateGetBeneficiaries",parameters);
    }

    public async Task<object> privateGetFeeInfo (object parameters = null)
    {
        return await this.callAsync ("privateGetFeeInfo",parameters);
    }

    public async Task<object> privateGetFundingAddress (object parameters = null)
    {
        return await this.callAsync ("privateGetFundingAddress",parameters);
    }

    public async Task<object> privateGetListorders (object parameters = null)
    {
        return await this.callAsync ("privateGetListorders",parameters);
    }

    public async Task<object> privateGetListtrades (object parameters = null)
    {
        return await this.callAsync ("privateGetListtrades",parameters);
    }

    public async Task<object> privateGetSendFee (object parameters = null)
    {
        return await this.callAsync ("privateGetSendFee",parameters);
    }

    public async Task<object> privateGetOrdersId (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersId",parameters);
    }

    public async Task<object> privateGetWithdrawals (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdrawals",parameters);
    }

    public async Task<object> privateGetWithdrawalsId (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdrawalsId",parameters);
    }

    public async Task<object> privateGetTransfers (object parameters = null)
    {
        return await this.callAsync ("privateGetTransfers",parameters);
    }

    public async Task<object> privatePostAccounts (object parameters = null)
    {
        return await this.callAsync ("privatePostAccounts",parameters);
    }

    public async Task<object> privatePostAddressValidate (object parameters = null)
    {
        return await this.callAsync ("privatePostAddressValidate",parameters);
    }

    public async Task<object> privatePostPostorder (object parameters = null)
    {
        return await this.callAsync ("privatePostPostorder",parameters);
    }

    public async Task<object> privatePostMarketorder (object parameters = null)
    {
        return await this.callAsync ("privatePostMarketorder",parameters);
    }

    public async Task<object> privatePostStoporder (object parameters = null)
    {
        return await this.callAsync ("privatePostStoporder",parameters);
    }

    public async Task<object> privatePostFundingAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostFundingAddress",parameters);
    }

    public async Task<object> privatePostWithdrawals (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawals",parameters);
    }

    public async Task<object> privatePostSend (object parameters = null)
    {
        return await this.callAsync ("privatePostSend",parameters);
    }

    public async Task<object> privatePostOauth2Grant (object parameters = null)
    {
        return await this.callAsync ("privatePostOauth2Grant",parameters);
    }

    public async Task<object> privatePutAccountsIdName (object parameters = null)
    {
        return await this.callAsync ("privatePutAccountsIdName",parameters);
    }

    public async Task<object> privateDeleteWithdrawalsId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteWithdrawalsId",parameters);
    }

}