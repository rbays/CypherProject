<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
   
    <form id="form1" runat="server">
    <div class="container">
    <h1 class ="jumbotron">Encrypt and decrypt messages</h1>
    <div class ="row">
         <div class="col-xs-8"><asp:Label CSSclass="writing" ID="Label2" runat="server" Text="Enter a key or generate one.<br/>Longer is stronger."></asp:Label></div>
          <div class="col-xs-4"><asp:Button CSSclass="button" ID="keyGenButton" runat="server" Text="Generate Cypher Key" OnClick="keyGenButton_Click" /></div>
    </div> <!--end of first row-->
    <div class ="row">
            <div class="col-xs-4"> <asp:Label CSSclass="writing" ID="Label1" runat="server" Text="Enter Key: "></asp:Label></div>
            <div class="col-xs-4"><asp:TextBox CssClass="textBox" ID="keyTextBox" runat="server" Width="100%"></asp:TextBox></div>
            <div class="col-xs-4"><asp:Button CSSclass="button" ID="checkKeyButton" runat="server" Text="Check Cypher Key" OnClick="checkKeyButton_Click" /></div>
    </div><!--end of keygen row-->
    <div class="row">    
            <div class="col-xs-4"><asp:Label CSSclass="writing" ID="staticCurrentKeyLabel" runat="server" Text="Current Cypher Key: "></asp:Label></div>
            <div class="col-xs-4"><asp:TextBox CssClass="textBox" ID="currentKeyLabel" runat="server" ReadOnly="True" Width="100%"></asp:TextBox></div>
            <div class="col-xs-4"><asp:Label CSSclass="writing" ID="invalidKeyLabel" runat="server" Text=" "></asp:Label></div>
    </div><!--end of key row-->
    <div class="row">
        <div class="col-xs-4 col-xs-offset-4">
            <asp:Label ID="messageCharWarningLabel" runat="server" Text="Only the following characters will be decrypted:<br>a-z A-Z 0-9 .,?!'@£$# and space.<br>Other characters will be decrypted as '#'"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12"><asp:TextBox ID="rawTextBox" CssClass="textBox center-block" runat="server" TextMode="MultiLine"></asp:TextBox></div>
    </div><!--end of text box1 row-->
    <div class="row"> 
        <div class="col-xs-3 col-xs-offset-3"><asp:Button CSSclass="button" ID="encodeButton" runat="server" Text="apply your cypher" OnClick="encodeButton_Click" Enabled="False" /></div>
        <div class="col-xs-3"><asp:Button CSSclass="button" ID="decodeButton" runat="server" Text="Remove your cypher" OnClick="decodeButton_Click" Enabled="False" /></div>
    </div><!--end of encrypt buttons row-->
    <div class="row">
        <div class="col-xs-12" >
            <div id="parchmentBox">
                <asp:TextBox ID="encodedTextBox" CssClass="textBox center-block" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
            </div>
        </div>
    </div><!--end of text box2 row-->
    </div>
    </form>
</body>
</html>
