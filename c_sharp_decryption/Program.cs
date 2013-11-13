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

			string encryptedString = "kvxNG/wRBTvTDFsCd3NU3hSzOJV1rqEAzeskl8NSsrWeCk4uA/r2PNFDe9BP70+dc126SWl0/YmDMXb9IFzZgcNxLZ6UnlqZ8MEWkXR7WpFBW0o14nyOMgitcjG2qW5rEZ9OhGVa/+C+h9QUJlHbFe75llZtbw689gDEf17Ms1cuezZN9gmTKruWteN61Jsu8WvgDmt4f+DgElsQYN6MdbNGpaC+wA33e3lGhg3nQCVH+iKd+J73hu8MxM+jmSo0TmMHH87J1HjSwLHuFJQXMtLAq0YKm9mVVCWVCr4jzgb0SgLJ+llESh0fHajb1ah/7ATW7XVRSVBQSpO2v9mWhw==";

			Encryption encObj = new Encryption (certLocation);

			Console.WriteLine (encObj.Decrypt (encryptedString)); //Hello World!

		}
	}
}
