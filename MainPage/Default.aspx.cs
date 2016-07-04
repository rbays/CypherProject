using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)    //needs removing
    {
        Key newKey = new Key(keyTextBox.Text);
        rawTextBox.Text = newKey.encryptLower(encodedTextBox.Text, false);

    }

    protected void encodeButton_Click(object sender, EventArgs e)
    {
        Key newKey = new Key(keyTextBox.Text);
        encodedTextBox.Text = newKey.encryptLower(rawTextBox.Text, true);
    }


}