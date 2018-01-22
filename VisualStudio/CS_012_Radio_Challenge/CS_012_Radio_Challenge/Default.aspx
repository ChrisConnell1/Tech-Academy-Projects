<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_012_Radio_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please select your preferred method of note taking:
    
    </div>
        <asp:RadioButton ID="PencilBox" runat="server" Text="Pencil" GroupName="notes" />
        <br />
        <asp:RadioButton ID="PenBox" runat="server" Text="Pen" GroupName="notes" />
        <br />
        <asp:RadioButton ID="phoneBox" runat="server" Text="Phone" GroupName="notes" />
        <br />
        <asp:RadioButton ID="tabletBox" runat="server" Text="Tablet" GroupName="notes" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go" />
        <br />
        <br />
        <asp:Image ID="imageResult" runat="server" />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
