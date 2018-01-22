<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MegaCasinoChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Reel1Image" runat="server" Height="100px" Width="100px" />
        <asp:Image ID="Reel2Image" runat="server" Height="100px" Width="100px" />
        <asp:Image ID="Reel3Image" runat="server" Height ="100px" Width="100px"/>
    
        <br />
        <br />
        Your bet:
        <asp:TextBox ID="betAmountTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server" ViewStateMode="Enabled"></asp:Label>
        <br />
        <br />
        PAYOFF:<br />
        <br />
        1 Cherry - 2:1<br />
        2 Cherries - 3:1<br />
        3 Cherries - 4:1<br />
        3 7s - JACKPOT - 100:1<br />
        <br />
        However, 1 or more BAR, you lose.</div>
    </form>
</body>
</html>
