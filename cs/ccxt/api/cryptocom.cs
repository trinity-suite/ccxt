// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class cryptocom : Exchange
{
    public cryptocom (object args = null): base(args) {}

    public async Task<object> v1PublicGetPublicAuth (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicAuth",parameters);
    }

    public async Task<object> v1PublicGetPublicGetInstruments (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetInstruments",parameters);
    }

    public async Task<object> v1PublicGetPublicGetBook (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetBook",parameters);
    }

    public async Task<object> v1PublicGetPublicGetCandlestick (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetCandlestick",parameters);
    }

    public async Task<object> v1PublicGetPublicGetTrades (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetTrades",parameters);
    }

    public async Task<object> v1PublicGetPublicGetTickers (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetTickers",parameters);
    }

    public async Task<object> v1PublicGetPublicGetValuations (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetValuations",parameters);
    }

    public async Task<object> v1PublicGetPublicGetExpiredSettlementPrice (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetExpiredSettlementPrice",parameters);
    }

    public async Task<object> v1PublicGetPublicGetInsurance (object parameters = null)
    {
        return await this.callAsync ("v1PublicGetPublicGetInsurance",parameters);
    }

    public async Task<object> v1PublicPostPublicStakingGetConversionRate (object parameters = null)
    {
        return await this.callAsync ("v1PublicPostPublicStakingGetConversionRate",parameters);
    }

    public async Task<object> v1PrivatePostPrivateSetCancelOnDisconnect (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateSetCancelOnDisconnect",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetCancelOnDisconnect (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetCancelOnDisconnect",parameters);
    }

    public async Task<object> v1PrivatePostPrivateUserBalance (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateUserBalance",parameters);
    }

    public async Task<object> v1PrivatePostPrivateUserBalanceHistory (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateUserBalanceHistory",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetPositions (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetPositions",parameters);
    }

    public async Task<object> v1PrivatePostPrivateCreateOrder (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateCreateOrder",parameters);
    }

    public async Task<object> v1PrivatePostPrivateCreateOrderList (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateCreateOrderList",parameters);
    }

    public async Task<object> v1PrivatePostPrivateCancelOrder (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateCancelOrder",parameters);
    }

    public async Task<object> v1PrivatePostPrivateCancelOrderList (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateCancelOrderList",parameters);
    }

    public async Task<object> v1PrivatePostPrivateCancelAllOrders (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateCancelAllOrders",parameters);
    }

    public async Task<object> v1PrivatePostPrivateClosePosition (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateClosePosition",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetOrderHistory (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetOrderHistory",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetOpenOrders (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetOpenOrders",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetOrderDetail (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetOrderDetail",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetTrades (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetTrades",parameters);
    }

    public async Task<object> v1PrivatePostPrivateChangeAccountLeverage (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateChangeAccountLeverage",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetTransactions (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetTransactions",parameters);
    }

    public async Task<object> v1PrivatePostPrivateCreateSubaccountTransfer (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateCreateSubaccountTransfer",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetSubaccountBalances (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetSubaccountBalances",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetOrderList (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetOrderList",parameters);
    }

    public async Task<object> v1PrivatePostPrivateCreateWithdrawal (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateCreateWithdrawal",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetCurrencyNetworks (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetCurrencyNetworks",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetDepositAddress (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetDepositAddress",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetAccounts (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetAccounts",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetWithdrawalHistory (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetWithdrawalHistory",parameters);
    }

    public async Task<object> v1PrivatePostPrivateGetDepositHistory (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateGetDepositHistory",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingStake (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingStake",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingUnstake (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingUnstake",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingGetStakingPosition (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingGetStakingPosition",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingGetStakingInstruments (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingGetStakingInstruments",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingGetOpenStake (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingGetOpenStake",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingGetStakeHistory (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingGetStakeHistory",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingGetRewardHistory (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingGetRewardHistory",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingConvert (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingConvert",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingGetOpenConvert (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingGetOpenConvert",parameters);
    }

    public async Task<object> v1PrivatePostPrivateStakingGetConvertHistory (object parameters = null)
    {
        return await this.callAsync ("v1PrivatePostPrivateStakingGetConvertHistory",parameters);
    }

    public async Task<object> v2PublicGetPublicAuth (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicAuth",parameters);
    }

    public async Task<object> v2PublicGetPublicGetInstruments (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicGetInstruments",parameters);
    }

    public async Task<object> v2PublicGetPublicGetBook (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicGetBook",parameters);
    }

    public async Task<object> v2PublicGetPublicGetCandlestick (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicGetCandlestick",parameters);
    }

    public async Task<object> v2PublicGetPublicGetTicker (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicGetTicker",parameters);
    }

    public async Task<object> v2PublicGetPublicGetTrades (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicGetTrades",parameters);
    }

    public async Task<object> v2PublicGetPublicMarginGetTransferCurrencies (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicMarginGetTransferCurrencies",parameters);
    }

    public async Task<object> v2PublicGetPublicMarginGetLoadCurrenices (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicMarginGetLoadCurrenices",parameters);
    }

    public async Task<object> v2PublicGetPublicRespondHeartbeat (object parameters = null)
    {
        return await this.callAsync ("v2PublicGetPublicRespondHeartbeat",parameters);
    }

    public async Task<object> v2PrivatePostPrivateSetCancelOnDisconnect (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateSetCancelOnDisconnect",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetCancelOnDisconnect (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetCancelOnDisconnect",parameters);
    }

    public async Task<object> v2PrivatePostPrivateCreateWithdrawal (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateCreateWithdrawal",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetWithdrawalHistory (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetWithdrawalHistory",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetCurrencyNetworks (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetCurrencyNetworks",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetDepositHistory (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetDepositHistory",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetDepositAddress (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetDepositAddress",parameters);
    }

    public async Task<object> v2PrivatePostPrivateExportCreateExportRequest (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateExportCreateExportRequest",parameters);
    }

    public async Task<object> v2PrivatePostPrivateExportGetExportRequests (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateExportGetExportRequests",parameters);
    }

    public async Task<object> v2PrivatePostPrivateExportDownloadExportOutput (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateExportDownloadExportOutput",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetAccountSummary (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetAccountSummary",parameters);
    }

    public async Task<object> v2PrivatePostPrivateCreateOrder (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateCreateOrder",parameters);
    }

    public async Task<object> v2PrivatePostPrivateCancelOrder (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateCancelOrder",parameters);
    }

    public async Task<object> v2PrivatePostPrivateCancelAllOrders (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateCancelAllOrders",parameters);
    }

    public async Task<object> v2PrivatePostPrivateCreateOrderList (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateCreateOrderList",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetOrderHistory (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetOrderHistory",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetOpenOrders (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetOpenOrders",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetOrderDetail (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetOrderDetail",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetTrades (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetTrades",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetAccounts (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetAccounts",parameters);
    }

    public async Task<object> v2PrivatePostPrivateGetSubaccountBalances (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateGetSubaccountBalances",parameters);
    }

    public async Task<object> v2PrivatePostPrivateCreateSubaccountTransfer (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateCreateSubaccountTransfer",parameters);
    }

    public async Task<object> v2PrivatePostPrivateOtcGetOtcUser (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateOtcGetOtcUser",parameters);
    }

    public async Task<object> v2PrivatePostPrivateOtcGetInstruments (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateOtcGetInstruments",parameters);
    }

    public async Task<object> v2PrivatePostPrivateOtcRequestQuote (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateOtcRequestQuote",parameters);
    }

    public async Task<object> v2PrivatePostPrivateOtcAcceptQuote (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateOtcAcceptQuote",parameters);
    }

    public async Task<object> v2PrivatePostPrivateOtcGetQuoteHistory (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateOtcGetQuoteHistory",parameters);
    }

    public async Task<object> v2PrivatePostPrivateOtcGetTradeHistory (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateOtcGetTradeHistory",parameters);
    }

    public async Task<object> v2PrivatePostPrivateOtcCreateOrder (object parameters = null)
    {
        return await this.callAsync ("v2PrivatePostPrivateOtcCreateOrder",parameters);
    }

    public async Task<object> derivativesPublicGetPublicAuth (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicAuth",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetInstruments (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetInstruments",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetBook (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetBook",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetCandlestick (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetCandlestick",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetTrades (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetTrades",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetTickers (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetTickers",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetValuations (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetValuations",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetExpiredSettlementPrice (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetExpiredSettlementPrice",parameters);
    }

    public async Task<object> derivativesPublicGetPublicGetInsurance (object parameters = null)
    {
        return await this.callAsync ("derivativesPublicGetPublicGetInsurance",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateSetCancelOnDisconnect (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateSetCancelOnDisconnect",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetCancelOnDisconnect (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetCancelOnDisconnect",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateUserBalance (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateUserBalance",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateUserBalanceHistory (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateUserBalanceHistory",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetPositions (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetPositions",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateCreateOrder (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateCreateOrder",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateCreateOrderList (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateCreateOrderList",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateCancelOrder (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateCancelOrder",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateCancelOrderList (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateCancelOrderList",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateCancelAllOrders (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateCancelAllOrders",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateClosePosition (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateClosePosition",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateConvertCollateral (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateConvertCollateral",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetOrderHistory (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetOrderHistory",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetOpenOrders (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetOpenOrders",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetOrderDetail (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetOrderDetail",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetTrades (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetTrades",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateChangeAccountLeverage (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateChangeAccountLeverage",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetTransactions (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetTransactions",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateCreateSubaccountTransfer (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateCreateSubaccountTransfer",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetSubaccountBalances (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetSubaccountBalances",parameters);
    }

    public async Task<object> derivativesPrivatePostPrivateGetOrderList (object parameters = null)
    {
        return await this.callAsync ("derivativesPrivatePostPrivateGetOrderList",parameters);
    }

}