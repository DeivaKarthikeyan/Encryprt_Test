using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EncryptFile_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath =ConfigurationSettings.AppSettings["filePath"];
            var result = EncryptFile(filePath);

        }

        static bool  EncryptFile(string filePath)
        {
            bool isFileEncrypted;
          
            AESencrypt AES_Encrypt = new AESencrypt();
            string file = filePath;
            string password = "f@@tball@12345$";

            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            try
            {
                byte[] bytesEncrypted = AES_Encrypt.Encrypt(bytesToBeEncrypted, passwordBytes);

                string fileEncrypted = file;

                File.WriteAllBytes(fileEncrypted, bytesEncrypted);
                isFileEncrypted = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.ToString());
            }

            return isFileEncrypted;
        }
    }
}
