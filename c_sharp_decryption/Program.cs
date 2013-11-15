using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Security.Cryptography;

namespace RSA_Decrypt
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string certLocation = "[PRIVATE KEY LOCATION]";

			string encryptedString = "[ENCRYPTED STRING]";

			Encryption encObj = new Encryption (certLocation);

			Console.WriteLine (encObj.Decrypt (encryptedString));

		}
	}
}
