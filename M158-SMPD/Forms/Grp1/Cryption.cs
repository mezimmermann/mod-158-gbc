using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace M158_SMPD.Forms.Grp1
{
    class Cryption
    {
        public static string encrypt(string StrToEncrypt)
        {
            byte[] ByteSalt;
            new RNGCryptoServiceProvider().GetBytes(ByteSalt = new byte[16]);

            var vpbkdf2Algorithm = new Rfc2898DeriveBytes(StrToEncrypt, ByteSalt, 10000);
            byte[] ByteHash = vpbkdf2Algorithm.GetBytes(20);
            byte[] ByteHashBytes = new byte[36];

            Array.Copy(ByteSalt, 0, ByteHashBytes, 0, 16);
            Array.Copy(ByteHash, 0, ByteHashBytes, 16, 20);

            string StrEncryptedPassword = Convert.ToBase64String(ByteHashBytes);

            return StrEncryptedPassword;
        }
        
        public static bool checkPwd(string StrToDecrypt, string StrPassword)
        {
            byte[] ByteHashBytes = Convert.FromBase64String(StrToDecrypt);
            byte[] ByteSalt = new byte[16];
            Array.Copy(ByteHashBytes, 0, ByteSalt, 0, 16);
            var vpbkdf2Algorithm = new Rfc2898DeriveBytes(StrPassword, ByteSalt, 10000);
            byte[] ByteHash = vpbkdf2Algorithm.GetBytes(20);

            bool BoolPasswordAccess = true;

            for (int i = 0; i < 20; i++)
            {
                if (ByteHashBytes[i + 16] != ByteHash[i])
                {
                    BoolPasswordAccess = false;
                }
            }

            return BoolPasswordAccess;
        }
    }
}
