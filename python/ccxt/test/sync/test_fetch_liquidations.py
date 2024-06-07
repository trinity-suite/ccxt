import os
import sys

root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))))
sys.path.append(root)

# ----------------------------------------------------------------------------

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

# ----------------------------------------------------------------------------
# -*- coding: utf-8 -*-

from ccxt.test.base import test_shared_methods  # noqa E402
from ccxt.test.base import test_liquidation  # noqa E402

def test_fetch_liquidations(exchange, skipped_properties, code):
    method = 'fetchLiquidations'
    if not exchange.has['fetchLiquidations']:
        return
    items = exchange.fetch_liquidations(code)
    assert isinstance(items, list), exchange.id + ' ' + method + ' ' + code + ' must return an array. ' + exchange.json(items)
    now = exchange.milliseconds()
    for i in range(0, len(items)):
        test_liquidation(exchange, skipped_properties, method, items[i], code)
    test_shared_methods.assert_timestamp_order(exchange, method, code, items)
