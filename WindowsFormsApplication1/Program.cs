using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string GetMD5HashFromString(string input)
        {
            ASCIIEncoding enc = new ASCIIEncoding();

            byte[] inputVal = enc.GetBytes(input.ToCharArray());

            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] retVal = md5.ComputeHash(inputVal);

            string retString = "";

            for (int i = 0; i < retVal.Length; i++)
            {
                string strBuffer = retVal[i].ToString("X");
                if (strBuffer.Length < 2)
                {
                    strBuffer = "0" + strBuffer;
                }
                retString += strBuffer;
            }
            return retString;
        }

        public static string GetSHA1HashFromString(string input)
        {
            ASCIIEncoding enc = new ASCIIEncoding();

            byte[] inputVal = enc.GetBytes(input.ToCharArray());

            SHA1 hash = new SHA1CryptoServiceProvider();

            byte[] retVal = hash.ComputeHash(inputVal);

            string retString = "";

            for (int i = 0; i < retVal.Length; i++)
            {
                string strBuffer = retVal[i].ToString("X");
                if (strBuffer.Length < 2)
                {
                    strBuffer = "0" + strBuffer;
                }
                retString += strBuffer;
            }
            return retString;
        }
    }
}
