using System;
using System.Security.Cryptography;
using System.Text;

namespace Eurofurence.App.Common.Utility
{
    public static class StringExtensions
    {
        public static Guid AsHashToGuid(this string input, string salt = null)
        {
            //Нужно явно определять тип, var запрещенб RCS1264
            var inputBytes = Encoding.UTF8.GetBytes(salt + input);
            var hashBytes = MD5.Create().ComputeHash(inputBytes);

            //rcs1250 Использовать ключевое слово new() implicit_when_type_is_obvious
            var hashGuid = new Guid(hashBytes);

            return hashGuid;
        }
    }
}