<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_023_Challenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 130px;
            height: 150px;
        }
        .auto-style2 {
            font-size: x-large;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="..." class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <span class="auto-style2"><strong>Asset Performance Tracker</strong></span></div>
        <p>
            Asset Name:
            <asp:TextBox ID="assetNameBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:
            <asp:TextBox ID="electionsRiggedBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:
            <asp:TextBox ID="actsPerformedBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addAsset" runat="server" OnClick="addAsset_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
