using System;
using WulkanowyQr;

namespace WulkanowyQr.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var encode = Qr.Encode("ABCDEFG", "CODE");
            var decode = Qr.Decode("ABCDEFG", "ENCRYPTED_CODE");
        }
    }
}