using System;
using Xunit;

namespace WulkanowyQr.Test
{
    public class QrTest
    {
        private const string _key = "tDVS4ykCBBAeN33h";
        private const string _content = "CERT#http://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT";
        private const string _base64 = "pDXpCcBDr7/wssR2YJpdaB+BXPJD5I28epToqZ1bO5O8qUTBru7NVAm9Rf3lDUr3RKAmoXKm5D96TnTI1yfUzQ==";
        
        [Fact]
        public void EncodeQr()
        {
            string result = Qr.Encode(_key, _content);
            Assert.Equal(_base64, result);
        }

        [Fact]
        public void DecodeQr()
        {
            string result = Qr.Decode(_key, _base64);
            Assert.Equal(_content, result);
        }
    }
}