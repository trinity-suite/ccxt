// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class paymium : Exchange
{
    public paymium (object args = null): base(args) {}

    public async Task<object> publicGetCountries (object parameters = null)
    {
        return await this.callAsync ("publicGetCountries",parameters);
    }

    public async Task<object> publicGetCurrencies (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrencies",parameters);
    }

    public async Task<object> publicGetDataCurrencyTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetDataCurrencyTicker",parameters);
    }

    public async Task<object> publicGetDataCurrencyTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetDataCurrencyTrades",parameters);
    }

    public async Task<object> publicGetDataCurrencyDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetDataCurrencyDepth",parameters);
    }

    public async Task<object> publicGetBitcoinChartsIdTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetBitcoinChartsIdTrades",parameters);
    }

    public async Task<object> publicGetBitcoinChartsIdDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetBitcoinChartsIdDepth",parameters);
    }

    public async Task<object> privateGetUser (object parameters = null)
    {
        return await this.callAsync ("privateGetUser",parameters);
    }

    public async Task<object> privateGetUserAddresses (object parameters = null)
    {
        return await this.callAsync ("privateGetUserAddresses",parameters);
    }

    public async Task<object> privateGetUserAddressesAddress (object parameters = null)
    {
        return await this.callAsync ("privateGetUserAddressesAddress",parameters);
    }

    public async Task<object> privateGetUserOrders (object parameters = null)
    {
        return await this.callAsync ("privateGetUserOrders",parameters);
    }

    public async Task<object> privateGetUserOrdersUuid (object parameters = null)
    {
        return await this.callAsync ("privateGetUserOrdersUuid",parameters);
    }

    public async Task<object> privateGetUserPriceAlerts (object parameters = null)
    {
        return await this.callAsync ("privateGetUserPriceAlerts",parameters);
    }

    public async Task<object> privateGetMerchantGetPaymentUuid (object parameters = null)
    {
        return await this.callAsync ("privateGetMerchantGetPaymentUuid",parameters);
    }

    public async Task<object> privatePostUserAddresses (object parameters = null)
    {
        return await this.callAsync ("privatePostUserAddresses",parameters);
    }

    public async Task<object> privatePostUserOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostUserOrders",parameters);
    }

    public async Task<object> privatePostUserWithdrawals (object parameters = null)
    {
        return await this.callAsync ("privatePostUserWithdrawals",parameters);
    }

    public async Task<object> privatePostUserEmailTransfers (object parameters = null)
    {
        return await this.callAsync ("privatePostUserEmailTransfers",parameters);
    }

    public async Task<object> privatePostUserPaymentRequests (object parameters = null)
    {
        return await this.callAsync ("privatePostUserPaymentRequests",parameters);
    }

    public async Task<object> privatePostUserPriceAlerts (object parameters = null)
    {
        return await this.callAsync ("privatePostUserPriceAlerts",parameters);
    }

    public async Task<object> privatePostMerchantCreatePayment (object parameters = null)
    {
        return await this.callAsync ("privatePostMerchantCreatePayment",parameters);
    }

    public async Task<object> privateDeleteUserOrdersUuid (object parameters = null)
    {
        return await this.callAsync ("privateDeleteUserOrdersUuid",parameters);
    }

    public async Task<object> privateDeleteUserOrdersUuidCancel (object parameters = null)
    {
        return await this.callAsync ("privateDeleteUserOrdersUuidCancel",parameters);
    }

    public async Task<object> privateDeleteUserPriceAlertsId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteUserPriceAlertsId",parameters);
    }

}