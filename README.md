c_sharp_decryption
==================

Decrypting a string with C#

How I generated the key for C#

openssl pkcs12 -export -out privatekey.pfx -in public_key.crt -inkey private.cer -name "my certificate"
