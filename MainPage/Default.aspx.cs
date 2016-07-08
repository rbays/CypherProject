using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page
{
    static Key currentKey;
    static String currentKeyString = "";
        

    protected void Page_Load(object sender, EventArgs e)
    {
        messageCharWarningLabel.Visible = false;
        invalidKeyLabel.Visible = false;
               
    }

    protected void encodeButton_Click(object sender, EventArgs e)
    {
        checkValidText();
        encodedTextBox.Text = new Key(currentKeyLabel.Text).encrypt(rawTextBox.Text, true);
    }

    protected void decodeButton_Click(object sender, EventArgs e)
    {
        encodedTextBox.Text = new Key(currentKeyLabel.Text).encrypt(rawTextBox.Text, false);
    }

    //generate new random key on button press
    protected void keyGenButton_Click(object sender, EventArgs e)
    {
        Random rand = new Random();
        string keyString = "";
        int length = 10;
        for (int i = 0; i < length; i++)
        {
            char c = Key.permittedChars[rand.Next(1, Key.permittedChars.Length)];
            keyString += c.ToString();
        }
        currentKey = new Key(keyString);
        currentKeyString = keyString;
        CheckValidKey();
        UpdateKeyString();
    }

    //sends current key string to label
    protected void UpdateKeyString()
    {
        currentKeyLabel.Text = currentKeyString;
    } 


    //checks whether the current keystring displayed on the screen is a valid key
    protected void CheckValidKey()
    {
        Key.validKey = true;
        char invalidChar = ' ';
        for (int i = 0; i < currentKeyString.Length; i++)
        {
            if (Key.permittedChars.Contains(currentKeyString.ElementAt(i)) == false)
            {
                Key.validKey = false;
                invalidChar = currentKeyString.ElementAt(i);
            }
        }
        if (Key.validKey)
        {
            invalidKeyLabel.Text = " ";
            invalidKeyLabel.Visible = false;
        }
        else
        {
            invalidKeyLabel.Text = "Illegal character: '" + invalidChar.ToString() + "'";
            invalidKeyLabel.Visible = true;
        }
        setButtonAvail();
    }

    //sets key from text book, checking if it is valid
    protected void checkKeyButton_Click(object sender, EventArgs e)
    {
        currentKeyString = keyTextBox.Text;
        char[] toValidate = currentKeyString.ToCharArray();
        String returnedString = "";
        for (int i = 0; i < toValidate.Length; i++)
        {
            if (Key.permittedChars.Contains(toValidate[i]))
            {
                returnedString += toValidate[i].ToString();
            }
            else
            {
                returnedString = "";
                break;
            }
        }
        currentKeyLabel.Text = returnedString;
        currentKey = new Key(keyTextBox.Text);
        CheckValidKey();
    }

    //enables or disables buttons if the key is valid
    private void setButtonAvail()
    {
        if (Key.validKey)
        {
            encodeButton.Enabled = true;
            decodeButton.Enabled = true;
        }
        else
        {
            encodeButton.Enabled = false;
            decodeButton.Enabled = false;
        }
    }

    private void checkValidText()
    {
        for (int i = 0; i < rawTextBox.Text.Length; i++)
        {
            if (Key.permittedChars.Contains(rawTextBox.Text.ElementAt(i)) == false)
            {
                messageCharWarningLabel.Visible = true;
            }
        }
    }
}