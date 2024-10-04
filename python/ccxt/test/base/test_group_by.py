import os
import sys

root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))))
sys.path.append(root)

# ----------------------------------------------------------------------------

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

# ----------------------------------------------------------------------------
# -*- coding: utf-8 -*-

import ccxt  # noqa: F402
from ccxt.test.exchange.base import test_shared_methods  # noqa E402

def test_group_by():
    exchange = ccxt.Exchange({
        'id': 'sampleexchange',
    })
    sample_array = [{
    'foo': 'a',
}, {
    'foo': 'b',
}, {
    'foo': 'c',
}, {
    'foo': 'b',
}, {
    'foo': 'c',
}, {
    'foo': 'c',
}]
    current_value = exchange.group_by(sample_array, 'foo')
    stored_value = {
        'a': [{
    'foo': 'a',
}],
        'b': [{
    'foo': 'b',
}, {
    'foo': 'b',
}],
        'c': [{
    'foo': 'c',
}, {
    'foo': 'c',
}, {
    'foo': 'c',
}],
    }
    test_shared_methods.assert_deep_equal(exchange, None, 'testGroupBy', current_value, stored_value)
