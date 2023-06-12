using PermitToWorkSystem.Data.IServices;
using PermitToWorkSystem.Utility;
using System.Security.Cryptography;
using System.Text;

namespace PermitToWorkSystem.Data.Service
{
    public class EncryptDecryptService : IEncryptDecryptService
    {
       
            private readonly byte[] encryptionKey; // Encryption key for AES
            private readonly DecryptionOptions _decryptionOptions;
            private readonly IConfiguration _configuration;
            public EncryptDecryptService(IConfiguration configuration)
            {
                _configuration = configuration;
                _decryptionOptions = _configuration.GetSection("AesKey").Get<DecryptionOptions>();
                encryptionKey = GenerateEncryptionKey(); // Generate a new encryption key
            }
            public string EncryptID(int id)
            {
                using (var aes = Aes.Create())
                {
                    aes.Key = encryptionKey;
                    aes.Mode = CipherMode.CBC; // Set the cipher mode
                    aes.Padding = PaddingMode.PKCS7; // Set the padding mode

                    aes.GenerateIV();
                    var iv = aes.IV;

                    byte[] idBytes = Encoding.UTF8.GetBytes(id.ToString());
                    byte[] encryptedBytes;

                    using (var encryptor = aes.CreateEncryptor())
                    {
                        encryptedBytes = encryptor.TransformFinalBlock(idBytes, 0, idBytes.Length);
                    }

                    byte[] combinedBytes = iv.Concat(encryptedBytes).ToArray();
                    return Convert.ToBase64String(combinedBytes);
                }
            }
            public string DecryptID(string encryptedID)
            {
                byte[] combinedBytes = Convert.FromBase64String(encryptedID);

                using (var aes = Aes.Create())
                {
                    aes.Key = encryptionKey;
                    aes.Mode = CipherMode.CBC; // Set the cipher mode
                    aes.Padding = PaddingMode.PKCS7; // Set the padding mode

                    var iv = combinedBytes.Take(aes.BlockSize / 8).ToArray();
                    var encryptedBytes = combinedBytes.Skip(aes.BlockSize / 8).ToArray();

                    using (var decryptor = aes.CreateDecryptor(aes.Key, iv))
                    {
                        var decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                        return Encoding.UTF8.GetString(decryptedBytes);
                    }
                }
            }

            public byte[] GenerateEncryptionKey()
            {
                var key = _decryptionOptions.Key;
                var byteKey = Encoding.UTF8.GetBytes(key);
                return byteKey;
            }
        }
    }

