<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab 3</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 398px">
            <asp:Panel ID="Panel1" runat="server" BackColor="Silver" BorderStyle="Solid" Font-Size="Large" Height="349px" Width="282px">
&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Find Anagrams" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                <br />
                <br />
                &nbsp;
                <br />
                &nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Size="Medium" Text="Enter a character string: "></asp:Label>
                &nbsp;<asp:TextBox ID="stringInput" runat="server" Height="16px" Width="70px"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:CheckBox ID="elimDups" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Eliminate Duplicates"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="anagramsList" runat="server" Width="145px" OnSelectedIndexChanged="anagramsList_SelectedIndexChanged"></asp:ListBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="findAnagrams" runat="server" Height="21px" OnClick="findAnagrams_Click" Text="Find Anagrams" Width="105px" />
                <br />
                <br />
                &nbsp;&nbsp;
                <asp:Label ID="bottomText" runat="server" Font-Size="Small"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
