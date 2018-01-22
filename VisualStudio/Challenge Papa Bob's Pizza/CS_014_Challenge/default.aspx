<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_014_Challenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            font-weight: bold;
        }
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle2 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" AlternateText="bob" ImageUrl="~/PapaBob.png" />
        <span class="newStyle1">Papa Bob&#39;s Pizza and Software</span></div>
        <p>
            &nbsp;</p>
        <asp:RadioButton ID="babyBob" runat="server" GroupName="sizeGroup" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="momBob" runat="server" Checked="True" GroupName="sizeGroup" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="popBob" runat="server" GroupName="sizeGroup" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinCrust" runat="server" Checked="True" GroupName="crustGroup" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepDish" runat="server" GroupName="crustGroup" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionBox" runat="server" Text="Onion (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redBox" runat="server" Text="Red Peppers ($0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesBox" runat="server" Text="Anchovies (+$2)" />
        <h3 class="auto-style1">Papa Bob&#39;s <span class="newStyle2">Special Deal</span></h3>
        <p>
            Save $2 when you order pepperoni, green peppers and anchovies OR pepperoni, red pepper and onion to your pizza!</p>
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <br />
        Total: $<asp:Label ID="totalLabel" runat="server" Text="0.00"></asp:Label>
        <br />
        <br />
        Note: Ordering is only available online and for pickup only, we&#39;re working on being better so please bear with us!</form>
</body>
</html>
