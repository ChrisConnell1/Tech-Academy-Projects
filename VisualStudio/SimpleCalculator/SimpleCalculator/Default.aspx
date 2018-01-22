<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Simple Calculator</h2>
    
    </div>
        <p>
            <span class="auto-style1">First Value:</span><asp:TextBox ID="firstNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style1">Second Value:</span><asp:TextBox ID="secondNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="plusButton" runat="server" OnClick="Button2_Click" Text="+" Width="33px" />
            <asp:Button ID="minusButton" runat="server" OnClick="minusButton_Click" Text="-" Width="34px" />
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" Width="36px" />
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" Width="39px" />
        </p>
        <asp:Label ID="resultLabel" runat="server" BackColor="#33CCFF" Font-Bold="True"></asp:Label>
    </form>
</body>
</html>
