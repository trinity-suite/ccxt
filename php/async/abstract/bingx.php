<?php

namespace ccxt\async\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class bingx extends \ccxt\async\Exchange {
    public function spot_v1_public_get_common_symbols($params = array()) {
        return $this->request('common/symbols', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_public_get_market_trades($params = array()) {
        return $this->request('market/trades', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_public_get_market_depth($params = array()) {
        return $this->request('market/depth', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_public_get_market_kline($params = array()) {
        return $this->request('market/kline', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_public_get_ticker_24hr($params = array()) {
        return $this->request('ticker/24hr', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function spot_v1_private_get_trade_query($params = array()) {
        return $this->request('trade/query', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_private_get_trade_openorders($params = array()) {
        return $this->request('trade/openOrders', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_private_get_trade_historyorders($params = array()) {
        return $this->request('trade/historyOrders', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_private_get_account_balance($params = array()) {
        return $this->request('account/balance', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_private_post_trade_order($params = array()) {
        return $this->request('trade/order', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_private_post_trade_cancel($params = array()) {
        return $this->request('trade/cancel', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_private_post_trade_batchorders($params = array()) {
        return $this->request('trade/batchOrders', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spot_v1_private_post_trade_cancelorders($params = array()) {
        return $this->request('trade/cancelOrders', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spot_v3_private_get_get_asset_transfer($params = array()) {
        return $this->request('get/asset/transfer', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v3_private_get_asset_transfer($params = array()) {
        return $this->request('asset/transfer', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v3_private_get_capital_deposit_hisrec($params = array()) {
        return $this->request('capital/deposit/hisrec', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v3_private_get_capital_withdraw_history($params = array()) {
        return $this->request('capital/withdraw/history', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spot_v3_private_post_post_asset_transfer($params = array()) {
        return $this->request('post/asset/transfer', array('spot', 'v3', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_public_get_server_time($params = array()) {
        return $this->request('server/time', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_public_get_quote_contracts($params = array()) {
        return $this->request('quote/contracts', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_price($params = array()) {
        return $this->request('quote/price', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_depth($params = array()) {
        return $this->request('quote/depth', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_trades($params = array()) {
        return $this->request('quote/trades', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_premiumindex($params = array()) {
        return $this->request('quote/premiumIndex', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_fundingrate($params = array()) {
        return $this->request('quote/fundingRate', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_klines($params = array()) {
        return $this->request('quote/klines', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_openinterest($params = array()) {
        return $this->request('quote/openInterest', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_ticker($params = array()) {
        return $this->request('quote/ticker', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_public_get_quote_bookticker($params = array()) {
        return $this->request('quote/bookTicker', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swap_v2_private_get_user_balance($params = array()) {
        return $this->request('user/balance', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_user_positions($params = array()) {
        return $this->request('user/positions', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_user_income($params = array()) {
        return $this->request('user/income', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_trade_openorders($params = array()) {
        return $this->request('trade/openOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_trade_order($params = array()) {
        return $this->request('trade/order', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_trade_margintype($params = array()) {
        return $this->request('trade/marginType', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_trade_leverage($params = array()) {
        return $this->request('trade/leverage', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_trade_forceorders($params = array()) {
        return $this->request('trade/forceOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_trade_allorders($params = array()) {
        return $this->request('trade/allOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_trade_allfillorders($params = array()) {
        return $this->request('trade/allFillOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_user_income_export($params = array()) {
        return $this->request('user/income/export', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_user_commissionrate($params = array()) {
        return $this->request('user/commissionRate', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_get_quote_bookticker($params = array()) {
        return $this->request('quote/bookTicker', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_post_trade_order($params = array()) {
        return $this->request('trade/order', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_post_trade_batchorders($params = array()) {
        return $this->request('trade/batchOrders', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_post_trade_closeallpositions($params = array()) {
        return $this->request('trade/closeAllPositions', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_post_trade_margintype($params = array()) {
        return $this->request('trade/marginType', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_post_trade_leverage($params = array()) {
        return $this->request('trade/leverage', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_post_trade_positionmargin($params = array()) {
        return $this->request('trade/positionMargin', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_post_trade_order_test($params = array()) {
        return $this->request('trade/order/test', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_delete_trade_order($params = array()) {
        return $this->request('trade/order', array('swap', 'v2', 'private'), 'DELETE', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_delete_trade_batchorders($params = array()) {
        return $this->request('trade/batchOrders', array('swap', 'v2', 'private'), 'DELETE', $params, null, null, array("cost" => 3));
    }
    public function swap_v2_private_delete_trade_allopenorders($params = array()) {
        return $this->request('trade/allOpenOrders', array('swap', 'v2', 'private'), 'DELETE', $params, null, null, array("cost" => 3));
    }
    public function contract_v1_private_get_allposition($params = array()) {
        return $this->request('allPosition', array('contract', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function contract_v1_private_get_allorders($params = array()) {
        return $this->request('allOrders', array('contract', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function contract_v1_private_get_balance($params = array()) {
        return $this->request('balance', array('contract', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function wallets_v1_private_get_capital_config_getall($params = array()) {
        return $this->request('capital/config/getall', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function wallets_v1_private_get_capital_deposit_address($params = array()) {
        return $this->request('capital/deposit/address', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function wallets_v1_private_get_capital_innertransfer_records($params = array()) {
        return $this->request('capital/innerTransfer/records', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function wallets_v1_private_get_capital_subaccount_deposit_address($params = array()) {
        return $this->request('capital/subAccount/deposit/address', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function wallets_v1_private_get_capital_deposit_subhisrec($params = array()) {
        return $this->request('capital/deposit/subHisrec', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function wallets_v1_private_get_capital_subaccount_innertransfer_records($params = array()) {
        return $this->request('capital/subAccount/innerTransfer/records', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function wallets_v1_private_post_capital_withdraw_apply($params = array()) {
        return $this->request('capital/withdraw/apply', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function wallets_v1_private_post_capital_innertransfer_apply($params = array()) {
        return $this->request('capital/innerTransfer/apply', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function wallets_v1_private_post_capital_subaccountinnertransfer_apply($params = array()) {
        return $this->request('capital/subAccountInnerTransfer/apply', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function wallets_v1_private_post_capital_deposit_createsubaddress($params = array()) {
        return $this->request('capital/deposit/createSubAddress', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function subaccount_v1_private_get_list($params = array()) {
        return $this->request('list', array('subAccount', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function subaccount_v1_private_get_assets($params = array()) {
        return $this->request('assets', array('subAccount', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function subaccount_v1_private_get_apikey_query($params = array()) {
        return $this->request('apiKey/query', array('subAccount', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function subaccount_v1_private_post_create($params = array()) {
        return $this->request('create', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subaccount_v1_private_post_apikey_create($params = array()) {
        return $this->request('apiKey/create', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subaccount_v1_private_post_apikey_edit($params = array()) {
        return $this->request('apiKey/edit', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subaccount_v1_private_post_apikey_del($params = array()) {
        return $this->request('apiKey/del', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subaccount_v1_private_post_updatestatus($params = array()) {
        return $this->request('updateStatus', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function account_v1_private_get_uid($params = array()) {
        return $this->request('uid', array('account', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function account_v1_private_post_innertransfer_authorizesubaccount($params = array()) {
        return $this->request('innerTransfer/authorizeSubAccount', array('account', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function user_auth_private_post_userdatastream($params = array()) {
        return $this->request('userDataStream', array('user', 'auth', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function copytrading_v1_private_get_swap_trace_currenttrack($params = array()) {
        return $this->request('swap/trace/currentTrack', array('copyTrading', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function copytrading_v1_private_post_swap_trace_closetrackorder($params = array()) {
        return $this->request('swap/trace/closeTrackOrder', array('copyTrading', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function copytrading_v1_private_post_swap_trace_settpsl($params = array()) {
        return $this->request('swap/trace/setTPSL', array('copyTrading', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function api_v3_private_get_asset_transfer($params = array()) {
        return $this->request('asset/transfer', array('api', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function api_v3_private_get_capital_deposit_hisrec($params = array()) {
        return $this->request('capital/deposit/hisrec', array('api', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function api_v3_private_get_capital_withdraw_history($params = array()) {
        return $this->request('capital/withdraw/history', array('api', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function api_v3_private_post_post_asset_transfer($params = array()) {
        return $this->request('post/asset/transfer', array('api', 'v3', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function spotV1PublicGetCommonSymbols($params = array()) {
        return $this->request('common/symbols', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PublicGetMarketTrades($params = array()) {
        return $this->request('market/trades', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PublicGetMarketDepth($params = array()) {
        return $this->request('market/depth', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PublicGetMarketKline($params = array()) {
        return $this->request('market/kline', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PublicGetTicker24hr($params = array()) {
        return $this->request('ticker/24hr', array('spot', 'v1', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function spotV1PrivateGetTradeQuery($params = array()) {
        return $this->request('trade/query', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PrivateGetTradeOpenOrders($params = array()) {
        return $this->request('trade/openOrders', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PrivateGetTradeHistoryOrders($params = array()) {
        return $this->request('trade/historyOrders', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PrivateGetAccountBalance($params = array()) {
        return $this->request('account/balance', array('spot', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV1PrivatePostTradeOrder($params = array()) {
        return $this->request('trade/order', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spotV1PrivatePostTradeCancel($params = array()) {
        return $this->request('trade/cancel', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spotV1PrivatePostTradeBatchOrders($params = array()) {
        return $this->request('trade/batchOrders', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spotV1PrivatePostTradeCancelOrders($params = array()) {
        return $this->request('trade/cancelOrders', array('spot', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function spotV3PrivateGetGetAssetTransfer($params = array()) {
        return $this->request('get/asset/transfer', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV3PrivateGetAssetTransfer($params = array()) {
        return $this->request('asset/transfer', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV3PrivateGetCapitalDepositHisrec($params = array()) {
        return $this->request('capital/deposit/hisrec', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV3PrivateGetCapitalWithdrawHistory($params = array()) {
        return $this->request('capital/withdraw/history', array('spot', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function spotV3PrivatePostPostAssetTransfer($params = array()) {
        return $this->request('post/asset/transfer', array('spot', 'v3', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PublicGetServerTime($params = array()) {
        return $this->request('server/time', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PublicGetQuoteContracts($params = array()) {
        return $this->request('quote/contracts', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuotePrice($params = array()) {
        return $this->request('quote/price', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuoteDepth($params = array()) {
        return $this->request('quote/depth', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuoteTrades($params = array()) {
        return $this->request('quote/trades', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuotePremiumIndex($params = array()) {
        return $this->request('quote/premiumIndex', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuoteFundingRate($params = array()) {
        return $this->request('quote/fundingRate', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuoteKlines($params = array()) {
        return $this->request('quote/klines', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuoteOpenInterest($params = array()) {
        return $this->request('quote/openInterest', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuoteTicker($params = array()) {
        return $this->request('quote/ticker', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PublicGetQuoteBookTicker($params = array()) {
        return $this->request('quote/bookTicker', array('swap', 'v2', 'public'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function swapV2PrivateGetUserBalance($params = array()) {
        return $this->request('user/balance', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetUserPositions($params = array()) {
        return $this->request('user/positions', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetUserIncome($params = array()) {
        return $this->request('user/income', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetTradeOpenOrders($params = array()) {
        return $this->request('trade/openOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetTradeOrder($params = array()) {
        return $this->request('trade/order', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetTradeMarginType($params = array()) {
        return $this->request('trade/marginType', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetTradeLeverage($params = array()) {
        return $this->request('trade/leverage', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetTradeForceOrders($params = array()) {
        return $this->request('trade/forceOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetTradeAllOrders($params = array()) {
        return $this->request('trade/allOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetTradeAllFillOrders($params = array()) {
        return $this->request('trade/allFillOrders', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetUserIncomeExport($params = array()) {
        return $this->request('user/income/export', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetUserCommissionRate($params = array()) {
        return $this->request('user/commissionRate', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateGetQuoteBookTicker($params = array()) {
        return $this->request('quote/bookTicker', array('swap', 'v2', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivatePostTradeOrder($params = array()) {
        return $this->request('trade/order', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivatePostTradeBatchOrders($params = array()) {
        return $this->request('trade/batchOrders', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivatePostTradeCloseAllPositions($params = array()) {
        return $this->request('trade/closeAllPositions', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivatePostTradeMarginType($params = array()) {
        return $this->request('trade/marginType', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivatePostTradeLeverage($params = array()) {
        return $this->request('trade/leverage', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivatePostTradePositionMargin($params = array()) {
        return $this->request('trade/positionMargin', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivatePostTradeOrderTest($params = array()) {
        return $this->request('trade/order/test', array('swap', 'v2', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateDeleteTradeOrder($params = array()) {
        return $this->request('trade/order', array('swap', 'v2', 'private'), 'DELETE', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateDeleteTradeBatchOrders($params = array()) {
        return $this->request('trade/batchOrders', array('swap', 'v2', 'private'), 'DELETE', $params, null, null, array("cost" => 3));
    }
    public function swapV2PrivateDeleteTradeAllOpenOrders($params = array()) {
        return $this->request('trade/allOpenOrders', array('swap', 'v2', 'private'), 'DELETE', $params, null, null, array("cost" => 3));
    }
    public function contractV1PrivateGetAllPosition($params = array()) {
        return $this->request('allPosition', array('contract', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function contractV1PrivateGetAllOrders($params = array()) {
        return $this->request('allOrders', array('contract', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function contractV1PrivateGetBalance($params = array()) {
        return $this->request('balance', array('contract', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function walletsV1PrivateGetCapitalConfigGetall($params = array()) {
        return $this->request('capital/config/getall', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function walletsV1PrivateGetCapitalDepositAddress($params = array()) {
        return $this->request('capital/deposit/address', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function walletsV1PrivateGetCapitalInnerTransferRecords($params = array()) {
        return $this->request('capital/innerTransfer/records', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function walletsV1PrivateGetCapitalSubAccountDepositAddress($params = array()) {
        return $this->request('capital/subAccount/deposit/address', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function walletsV1PrivateGetCapitalDepositSubHisrec($params = array()) {
        return $this->request('capital/deposit/subHisrec', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function walletsV1PrivateGetCapitalSubAccountInnerTransferRecords($params = array()) {
        return $this->request('capital/subAccount/innerTransfer/records', array('wallets', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function walletsV1PrivatePostCapitalWithdrawApply($params = array()) {
        return $this->request('capital/withdraw/apply', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function walletsV1PrivatePostCapitalInnerTransferApply($params = array()) {
        return $this->request('capital/innerTransfer/apply', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function walletsV1PrivatePostCapitalSubAccountInnerTransferApply($params = array()) {
        return $this->request('capital/subAccountInnerTransfer/apply', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function walletsV1PrivatePostCapitalDepositCreateSubAddress($params = array()) {
        return $this->request('capital/deposit/createSubAddress', array('wallets', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function subAccountV1PrivateGetList($params = array()) {
        return $this->request('list', array('subAccount', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function subAccountV1PrivateGetAssets($params = array()) {
        return $this->request('assets', array('subAccount', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 3));
    }
    public function subAccountV1PrivateGetApiKeyQuery($params = array()) {
        return $this->request('apiKey/query', array('subAccount', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function subAccountV1PrivatePostCreate($params = array()) {
        return $this->request('create', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subAccountV1PrivatePostApiKeyCreate($params = array()) {
        return $this->request('apiKey/create', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subAccountV1PrivatePostApiKeyEdit($params = array()) {
        return $this->request('apiKey/edit', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subAccountV1PrivatePostApiKeyDel($params = array()) {
        return $this->request('apiKey/del', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function subAccountV1PrivatePostUpdateStatus($params = array()) {
        return $this->request('updateStatus', array('subAccount', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function accountV1PrivateGetUid($params = array()) {
        return $this->request('uid', array('account', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function accountV1PrivatePostInnerTransferAuthorizeSubAccount($params = array()) {
        return $this->request('innerTransfer/authorizeSubAccount', array('account', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 3));
    }
    public function userAuthPrivatePostUserDataStream($params = array()) {
        return $this->request('userDataStream', array('user', 'auth', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function copyTradingV1PrivateGetSwapTraceCurrentTrack($params = array()) {
        return $this->request('swap/trace/currentTrack', array('copyTrading', 'v1', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function copyTradingV1PrivatePostSwapTraceCloseTrackOrder($params = array()) {
        return $this->request('swap/trace/closeTrackOrder', array('copyTrading', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function copyTradingV1PrivatePostSwapTraceSetTPSL($params = array()) {
        return $this->request('swap/trace/setTPSL', array('copyTrading', 'v1', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
    public function apiV3PrivateGetAssetTransfer($params = array()) {
        return $this->request('asset/transfer', array('api', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function apiV3PrivateGetCapitalDepositHisrec($params = array()) {
        return $this->request('capital/deposit/hisrec', array('api', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function apiV3PrivateGetCapitalWithdrawHistory($params = array()) {
        return $this->request('capital/withdraw/history', array('api', 'v3', 'private'), 'GET', $params, null, null, array("cost" => 1));
    }
    public function apiV3PrivatePostPostAssetTransfer($params = array()) {
        return $this->request('post/asset/transfer', array('api', 'v3', 'private'), 'POST', $params, null, null, array("cost" => 1));
    }
}
