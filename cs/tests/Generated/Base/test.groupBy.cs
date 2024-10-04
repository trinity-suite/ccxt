using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

public partial class BaseTest
{
        public void testGroupBy()
        {
            var exchange = new ccxt.Exchange(new Dictionary<string, object>() {
                { "id", "sampleexchange" },
            });
            object sampleArray = new List<object>() {new Dictionary<string, object>() {
            { "foo", "a" },
        }, new Dictionary<string, object>() {
            { "foo", "b" },
        }, new Dictionary<string, object>() {
            { "foo", "c" },
        }, new Dictionary<string, object>() {
            { "foo", "b" },
        }, new Dictionary<string, object>() {
            { "foo", "c" },
        }, new Dictionary<string, object>() {
            { "foo", "c" },
        }};
            object currentValue = exchange.groupBy(sampleArray, "foo");
            object storedValue = new Dictionary<string, object>() {
                { "a", new List<object>() {new Dictionary<string, object>() {
            { "foo", "a" },
        }} },
                { "b", new List<object>() {new Dictionary<string, object>() {
            { "foo", "b" },
        }, new Dictionary<string, object>() {
            { "foo", "b" },
        }} },
                { "c", new List<object>() {new Dictionary<string, object>() {
            { "foo", "c" },
        }, new Dictionary<string, object>() {
            { "foo", "c" },
        }, new Dictionary<string, object>() {
            { "foo", "c" },
        }} },
            };
            AssertDeepEqual(exchange, null, "testGroupBy", currentValue, storedValue);
        }
}