using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HASH_Checker
{
    internal class HashReader
    {
        internal static string ReadHashFromFile(string path, HashType hashType)
        {
            try
            {
                if (!File.Exists(path))
                {
                    return "File not exists / Read permissions needed.";
                }

                string hash = "";

                using (FileStream stream = File.OpenRead(path))
                {
                    switch (hashType)
                    {
                        case HashType.MD5:
                            using (MD5 crypt = MD5.Create())
                            {
                                byte[] hashBytes = crypt.ComputeHash(stream);
                                hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                            }
                            break;
                        case HashType.SHA1:
                            using (SHA1 crypt = SHA1.Create())
                            {
                                byte[] hashBytes = crypt.ComputeHash(stream);
                                hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                            }
                            break;
                        case HashType.SHA256:
                            using (SHA256 crypt = SHA256.Create())
                            {
                                byte[] hashBytes = crypt.ComputeHash(stream);
                                hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                            }
                            break;
                        case HashType.SHA512:
                            using (SHA512 crypt = SHA512.Create())
                            {
                                byte[] hashBytes = crypt.ComputeHash(stream);
                                hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                            }
                            break;
                    }
                }
                return hash;
            }
            catch (Exception err)
            {
                return $"Error occured! {err.StackTrace}";
            }
        }
    }
}
