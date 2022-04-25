<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_484Class1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CIS 484 Section 4 First Web Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
                <asp:Label ID="lablMyName" runat="server" Text="Type Your Name:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextMyName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnDisplay" runat="server" Text="Display ->"  OnClick="BtnDisplay_Click"/>
            <br />
            <asp:Label ID="labeldisplay" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
        </div>
        <br />
        <br />
