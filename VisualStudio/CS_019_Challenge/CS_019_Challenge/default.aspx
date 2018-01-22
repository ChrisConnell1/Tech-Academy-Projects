<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_019_Challenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 151px;
            height: 190px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>
            <img alt=".." class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <br />
            <span class="auto-style2">Spy New Assignment Form</span></h2>
        <p>
            Spy Code Name:
            <asp:TextBox ID="codeName" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:
            <asp:TextBox ID="assignmentName" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:</p>
        <p>
            <asp:Calendar ID="firstCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="secondCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="thirdCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Assign" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
