<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Text="Please enter at least 26 characters, this will be your key,(needed to decode) or click here to generate a key"></asp:Label>
        <asp:Button ID="Button2" runat="server" Text="Generate Key" />
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Key: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="600px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="rawTextBox" runat="server" Height="178px" Width="350px"></asp:TextBox>
            <asp:Button ID="encodeButton" runat="server" Text="encode -&gt;" />
        <asp:Button ID="decodeButton" runat="server" Text="Decode&lt;-" OnClick="Button1_Click" />
            <asp:TextBox ID="encodedTextBox" runat="server" Height="178px" Width="350px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
