using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Key generatable for encrypting and decrypting
/// </summary>
public class Key
{
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
            this.keyChars =   "`".ToCharArray() ;
        }
    }

    public String encryptLower(String rawText, bool encrypt)
    {
        String encryptedText = "";
        int textLength = rawText.Length;
        int keyLength = this.keyChars.Length;

        //duplicate or truncate the key to be the same length as the text
        char[] longKey = new char[textLength];
        for (int i = 0; i < textLength; i++)
        {
            longKey[i] = this.keyChars[i % keyLength];
        }

        //lower case to reduce identifying eg 'I'
        String rawLower = rawText.ToLower();
        char[] rawLowerChars = rawLower.ToCharArray();

        char[] encryptedChars = new char[textLength];
        //true if encrypt, false if decrypt
        if (encrypt)
        {
            for (int i = 0; i < textLength; i++)
            {
                int increasedInt = (int)rawLowerChars[i] + (int)longKey[i] - 96;    //;set a=1 by deducting 96
                if (increasedInt > (int)'z')
                {
                    increasedInt -= 26;
                }
                encryptedChars[i] = (char)increasedInt;
                if (rawLowerChars[i] == 32)
                {
                    encryptedChars[i] = ' ';
                }

            }
        }
        else
        {
            for (int i = 0; i < textLength; i++)
            {
                int increasedInt = (int)rawLowerChars[i] - (int)longKey[i] + 96;
                if (increasedInt < (int)'a')
                {
                    increasedInt += 26;
                }
                encryptedChars[i] = (char)increasedInt;
                if (rawLowerChars[i] == 32)
                {
                    encryptedChars[i] = ' ';
                }
            }
        }
        for(int i = 0; i < textLength; i++)
        {
            encryptedText += encryptedChars[i].ToString();
        }

        return encryptedText;
    }
}