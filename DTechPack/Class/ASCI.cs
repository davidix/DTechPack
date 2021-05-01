using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;


namespace DTechPack
{
    class ASCI
    {
        public static string enc(string Str, string Key, string IV)
        {
            byte[] Xb1 = ASCIIEncoding.ASCII.GetBytes(Key);
            byte[] Xb2 = ASCIIEncoding.ASCII.GetBytes(IV);
            DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();
            MemoryStream MemS = new MemoryStream();
            CryptoStream CrP = new CryptoStream(MemS, DESCSP.CreateEncryptor(Xb1, Xb2), CryptoStreamMode.Write);
            StreamWriter Writer = new StreamWriter(CrP);
            Writer.Write(Str);
            Writer.Flush();
            CrP.FlushFinalBlock();
            return Convert.ToBase64String(MemS.GetBuffer(), 0, (int)MemS.Length);
        }
        public static string dec(string Str, string Key, string IV)
        {
            byte[] Xb1 = ASCIIEncoding.ASCII.GetBytes(Key);
            byte[] Xb2 = ASCIIEncoding.ASCII.GetBytes(IV);
            DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();
            MemoryStream MemS = new MemoryStream(Convert.FromBase64String(Str));
            CryptoStream CrP = new CryptoStream(MemS, DESCSP.CreateDecryptor(Xb1, Xb2), CryptoStreamMode.Read);
            StreamReader Reader = new StreamReader(CrP);
            return Reader.ReadToEnd();
        }
        //-----//-----//-----//-----//-----//
        public static string enc2(string Str)
        {
            DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();
            MemoryStream MemS = new MemoryStream();
            CryptoStream CrP = new CryptoStream(MemS, DESCSP.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter Writer = new StreamWriter(CrP);
            Writer.Write(Str);
            Writer.Flush();
            CrP.FlushFinalBlock();
            return Convert.ToBase64String(MemS.GetBuffer(), 0, (int)MemS.Length);
        }
        public static string dec2(string Str)
        {
            DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();
            MemoryStream MemS = new MemoryStream(Convert.FromBase64String(Str));
            CryptoStream CrP = new CryptoStream(MemS, DESCSP.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader Reader = new StreamReader(CrP);
            return Reader.ReadToEnd();
        }
        public static void FileDec(string Input, string Output)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes("DavidBreihi");

                FileStream fsCrypt = new FileStream(Input, FileMode.Open);
                DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();
                CryptoStream cs = new CryptoStream(fsCrypt, DESCSP.CreateDecryptor(key, key), CryptoStreamMode.Read);
                FileStream fsOut = new FileStream(Output, FileMode.Create);
                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch { }
            //try
            //{
            //    UnicodeEncoding UE = new UnicodeEncoding();
            //    byte[] Key = UE.GetBytes("Dav!dBrٍٍٍريالhi");
            //    FileStream Fin = new FileStream(Input, FileMode.Open);
            //    DESCryptoServiceProvider DESCSP = new DESCryptoServiceProvider();
            //    CryptoStream CS = new CryptoStream(Fin, DESCSP.CreateEncryptor(Key, Key), CryptoStreamMode.Read);
            //    FileStream Fout = new FileStream(Output, FileMode.Create);
            //    int TempByte;
            //    while ((TempByte = CS.ReadByte()) != -1)
            //        Fout.WriteByte((byte)TempByte);
            //    Fin.Close(); Fout.Close(); CS.Close();
            //}
            //catch { }
        }


//-----------------------------------------------------------
        public static void EncryptFile(string inputFile, string outputFile)
        {

            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(@"myKey123");
                FileStream fsCrypt = new FileStream(outputFile, FileMode.Create);
                RC2CryptoServiceProvider RMCrypto = new RC2CryptoServiceProvider();
                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);
                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }

        public static void DecryptFile(string inputFile, string outputFile)
        {

            {
                string password = @"myKey123"; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                //RijndaelManaged RMCrypto = new RijndaelManaged();
                RC2CryptoServiceProvider RMCrypto = new RC2CryptoServiceProvider();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
        }

    }
}
