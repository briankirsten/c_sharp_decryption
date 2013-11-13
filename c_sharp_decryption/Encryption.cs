using System;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace RSA_Decrypt
{
	public class Encryption
	{
		public string certLocation;

		public Encryption (string certLocation)
		{
			this.certLocation = certLocation;
		}

		public string Decrypt(string strBase64CipherText)
		{
			X509Certificate2 cert = GetCertificate();

			RSACryptoServiceProvider rsaObj;

			if(cert.HasPrivateKey) { 
				rsaObj = (RSACryptoServiceProvider)cert.PrivateKey; 
			} else 
				throw new CryptographicException("Private key not contained within certificate."); 

			if (rsaObj == null)
				return "";

			byte[] decryptedBytes; 

			try{ 
				decryptedBytes = rsaObj.Decrypt(Convert.FromBase64String(strBase64CipherText), false); 
			} catch { 
				throw new CryptographicException("Unable to decrypt data."); 
			} 

			return System.Text.Encoding.UTF8.GetString (decryptedBytes);
		}

		private X509Certificate2 GetCertificate()
		{
			X509Certificate2 myCertificate;

			try{ 
				myCertificate = new X509Certificate2(certLocation); 
			} catch{ 
				throw new CryptographicException("Unable to open key file."); 
			}

			return myCertificate;
		}
	}
}

