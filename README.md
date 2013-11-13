c_sharp_decryption
==================

Decrypting a string with C#

Synopsis
--------
A little project for decrypting items in C# that have been encrypted using a public/private key combination and the PHP openssl_public_encrypt function.

Requirements
------------
* C# (duh)
* Public/Private Key Pair
* Data you've encrypted (or plan on encrypting) with the openssl_public_encrypt function


Generate the key for C#
------------
Grab your existing public/private key pair and do the following:

- - -
openssl pkcs12 -export -out privatekey.pfx -in public_key.crt -inkey private.cer -name "my certificate"
- - -

Modifying the Code
-----------------
Head into the C# project and change the "certLocation" variable to where you generated that private key from above. (You remember where you put it right?)

Much Thanks
-----------
Much thanks to this [article](http://www.csharpbydesign.com/2008/04/asymmetric-key-encryption-with.html) that pointed me in the right direction. As well as a ton of [stackoverflow](http://stackoverflow.com/) articles. 

That's it!
----------
Enjoy! Or ask me questions! Or yell at me, whatever makes you happy.
