using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Key for encrypting and decrypting text
/// </summary>
public class Key
{
    private static string permittedString = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,?!'@£$#";
    public static char[] permittedChars = permittedString.ToCharArray();
    public static bool validKey = false;  

    private char[] keyChars;

    //Key generated from a string
    public Key(String input)
    {
        if (input != "")
        {
            this.keyChars = input.ToCharArray();
        }
        else
        {
            this.keyChars =   " ".ToCharArray() ;
        }
    }

    //code for encrypting and decrypting text forward true is encrypt, otherwise decrypt
    public String encrypt(String rawText, bool forward)
    {
        String encryptedText = "";
        int direction;
        int textLength = rawText.Length;
        int keyLength = this.keyChars.Length;
        
        //duplicate or truncate the key to be the same length as the text
        char[] longKey = new char[textLength];
        for (int i = 0; i < textLength; i++)
        {
            longKey[i] = this.keyChars[i % keyLength];
        }

        //convert to char array
        char[] rawChars = rawText.ToCharArray();

        char[] encryptedChars = new char[textLength];
        //true if encrypt, false if decrypt
        if (forward)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
        for (int i = 0; i < textLength; i++)
        {
            int increasedInt = Array.IndexOf(permittedChars, rawChars[i]) + Array.IndexOf(permittedChars,longKey[i])*direction;
            increasedInt = (increasedInt + permittedChars.Length) % permittedChars.Length;  //add on the max before taking modulo incase value is below 0

            encryptedChars[i] = permittedChars[increasedInt];
        }
       
        //change char array to string
        for (int i = 0; i < textLength; i++)
        {
            encryptedText += encryptedChars[i].ToString();
        }

        return encryptedText;
    }
}