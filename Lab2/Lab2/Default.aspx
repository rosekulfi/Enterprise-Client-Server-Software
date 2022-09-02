<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab 2 - Anika Sharma</title>
</head>
<body style="height: 297px; width: 394px">
    <form id="form1" runat="server">
        <div style="height: 222px; width: 382px;">
        <asp:Panel ID="Panel1" runat="server" BackColor="#CC99FF" Height="218px" BorderColor="Black" BorderStyle="Solid" Direction="LeftToRight" Font-Bold="True" Font-Size="X-Large" HorizontalAlign="Center">
            <br />
            <br />
            Temperature
            <br />
            Converter<br />
            <div>
                <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="Medium" Text="Fahrenheit: "></asp:Label>
                &nbsp;
                <asp:TextBox ID="fahTextBox" runat="server" Width="158px"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Size="Medium" Text="Centregrade:"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="celTextBox" runat="server" Width="150px"></asp:TextBox>
                <div>
                    <asp:Label ID="errorMsg" runat="server" BackColor="White" Font-Bold="False" Font-Italic="False" Font-Size="Medium" ForeColor="Red"></asp:Label>
                </div>
            </div>
        </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server" BorderColor="Black" BorderStyle="Solid" Height="62px" Width="376px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="convertButton" runat="server" Text="Convert" OnClick="convertButton_Click" />
        </asp:Panel>
    </form>
</body>
</html>
