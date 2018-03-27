<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formular 1.0 and test thingy</title>
</head>
<body>
    <form id="form1" runat="server">

    <div>
    
        <asp:Literal ID="Literal_person" runat="server"></asp:Literal>

        <asp:Literal ID="Literal_json" runat="server"></asp:Literal>

        <asp:Literal ID="Literal_interface" runat="server"></asp:Literal>

        <br /><asp:Literal ID="Literal_xml" runat="server"></asp:Literal>
        
        <asp:Literal ID="Literal_letter" runat="server"></asp:Literal>

        <br /><asp:Literal ID="Literal_day" runat="server"></asp:Literal>

        <br /><asp:Literal ID="Literal_calc" runat="server"></asp:Literal>

        <br />

        <br /><asp:Menu ID="Menu_site" runat="server" DataSourceID="SiteMapDataSource1"></asp:Menu>

        <br /><asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1"></asp:TreeView>

        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />


    <h1>Formular 1.0 and test thingy</h1>

        <table>
            <tr>
                <td>Name: </td><td><asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email: </td><td><asp:TextBox ID="TextBox_email" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Favorite Food: </td><td><asp:TextBox ID="TextBox_food" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Choose Favorite Phone: </td><td><asp:DropDownList ID="DropDownList_phone" runat="server"><asp:ListItem Text="Sony" Value="Sony"></asp:ListItem><asp:ListItem Text="Apple" Value="Apple"></asp:ListItem></asp:DropDownList></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button_send" runat="server" Text="Submit" OnClick="Button_send_Click" /></td><td></td>
            </tr>
        </table>

        <br />

        <asp:GridView ID="GridView_show" runat="server"></asp:GridView>

        <asp:Literal ID="Literal_loop" runat="server"></asp:Literal>

    </div>
    </form>
</body>
</html>
