<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="widthTextBox_TextChanged"></asp:TextBox>
        <br />
        Height:&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="heightTextBox_TextChanged"></asp:TextBox>
        <br />
        Length:
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="lengthTextBox_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadio" runat="server" AutoPostBack="True" GroupName="deliveryGroup" OnCheckedChanged="groundRadio_checkChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadio" runat="server" AutoPostBack="True" GroupName="deliveryGroup" OnCheckedChanged="airRadio_checkChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayRadio" runat="server" AutoPostBack="True" GroupName="deliveryGroup" OnCheckedChanged="nextDayRadio_checkChanged" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
