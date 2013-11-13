c_sharp_decryption
==================

Decrypting a string with C# - a little project for decrypting items that have been encrypted using a public/private key combination and the PHP openssl_public_encrypt function.

How I generated the key for C#

openssl pkcs12 -export -out privatekey.pfx -in public_key.crt -inkey private.cer -name "my certificate"
