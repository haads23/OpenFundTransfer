<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundTransferResult.aspx.cs" Inherits="FundTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bank of Algonquin</title>
     <link href="App_Themes/SiteStyles.css" rel="stylesheet" />

</head>
<body style="background-color: lightyellow">
    <h1>Online Fund Transfer Service</h1>
    <form id="form1" runat="server">
        <p>Thank you for using our Online fund transfer service</p>
        <p>Amount: $     <asp:Label ID="lblAmount" runat="server" ></asp:Label> has been transfered</p>
        <br />
        <h3>From</h3>

        
        <p>
            <asp:Label ID="lblTransferor" runat="server" Text="Name: "></asp:Label>
        </p>

        <p>
            <asp:Label ID="lblAccountTransferor" runat="server" Text="Account: "></asp:Label>
        </p>


         <h3>To</h3>

         <p>
            <asp:Label ID="lblTransferee" runat="server" Text="Name: "></asp:Label>
        </p>

        <p>
            <asp:Label ID="lblAccountTransferee" runat="server" Text="Account: "></asp:Label>
        </p>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button" runat="server" Text="Start A New Transfer" OnClick="Button_Click" CssClass="button" Width="180px" />
        
    </form>
</body>
</html>
