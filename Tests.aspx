<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tests.aspx.cs" Inherits="_484Class1.Tests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="Radiobttn" runat="server">
            <asp:ListItem Text="Small" Value="5"></asp:ListItem>
            <asp:ListItem Text="Medium" Value="9"></asp:ListItem>
            <asp:ListItem Text="Large" Value="11"></asp:ListItem>
            <asp:ListItem Text="X-Large" Value="18"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:CheckBoxList ID="checkcheese" runat="server">
            <asp:ListItem ID="ches" Text="cheese" Selected="True"  ></asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="checkpep" runat="server">
            <asp:ListItem ID="Pep" Text="Pepperoni" Value="2"></asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="checkbef" runat="server">
            <asp:ListItem ID="Bef" Text="Beef" Value="3"></asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="checkpepp" runat="server">
            <asp:ListItem ID="Pepp" Text="Peppers" Value="1"></asp:ListItem>
            </asp:CheckBoxList>
             <asp:CheckBoxList ID="checkon" runat="server">
            <asp:ListItem ID="On" Text="Onion" Value="1"></asp:ListItem>
            </asp:CheckBoxList>
            <asp:CheckBoxList ID="checkpin" runat="server">
            <asp:ListItem ID="Pin" Text="Pineapple" Value="4"></asp:ListItem>
            </asp:CheckBoxList>
           



            <asp:DropDownList ID="DropDown" runat="server">
                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lblCustName" runat="server" Text="Customer Name:"></asp:Label>
            <asp:TextBox ID="CustName" runat="server" Text=""></asp:TextBox>
            <br />
            <asp:Button ID="bttnAddOrder" runat="server" Text="bttnAddOrder" OnClick="bttnAddOrder_Click" />
            <br />
            <asp:textbox ID="Ordertxt" runat="server" Height="267px" Width="477px" Rows="10" textmode="MultiLine"></asp:textbox>
        </div>
    </form>
</body>
</html>
