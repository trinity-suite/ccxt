import os
import sys

root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))))
sys.path.append(root)

# ----------------------------------------------------------------------------

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

# ----------------------------------------------------------------------------
# -*- coding: utf-8 -*-

from ccxt.test.base import test_order_book  # noqa E402

async def test_fetch_order_books(exchange, skipped_properties):
    method = 'fetchOrderBooks'
    symbol = exchange.symbols[0]
    order_books = await exchange.fetch_order_books([symbol])
    assert isinstance(order_books, dict), exchange.id + ' ' + method + ' must return an object. ' + exchange.json(order_books)
    order_book_keys = list(order_books.keys())
    assert len(order_book_keys), exchange.id + ' ' + method + ' returned 0 length data'
    for i in range(0, len(order_book_keys)):
        symbol_inner = order_book_keys[i]
        test_order_book(exchange, skipped_properties, method, order_books[symbol_inner], symbol_inner)
