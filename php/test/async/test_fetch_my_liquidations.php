<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
use React\Async;
use React\Promise;
include_once PATH_TO_CCXT . '/test/base/test_shared_methods.php';
include_once PATH_TO_CCXT . '/test/base/test_liquidation.php';

function test_fetch_my_liquidations($exchange, $skipped_properties, $code) {
    return Async\async(function () use ($exchange, $skipped_properties, $code) {
        $method = 'fetchMyLiquidations';
        if (!$exchange->has['fetchMyLiquidations']) {
            return;
        }
        $items = Async\await($exchange->fetch_my_liquidations($code));
        assert(gettype($items) === 'array' && array_keys($items) === array_keys(array_keys($items)), $exchange->id . ' ' . $method . ' ' . $code . ' must return an array. ' . $exchange->json($items));
        $now = $exchange->milliseconds();
        for ($i = 0; $i < count($items); $i++) {
            test_liquidation($exchange, $skipped_properties, $method, $items[$i], $code);
        }
        assert_timestamp_order($exchange, $method, $code, $items);
    }) ();
}
