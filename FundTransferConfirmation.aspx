<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundTransferConfirmation.aspx.cs" Inherits="FundTransferConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="App_Themes/SiteStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Online Fund Transfer Service</h1>
        <h2 class="distinct">Review and Complete</h2>
        <div>
            <h3> Transferer</h3>
            <br />
            <%--<asp:Label ID="lbltransfror" runat="server" Text="Transferor"></asp:Label>--%>
            <asp:Label ID="lblNameTransferor" runat="server" Text="Name: "></asp:Label>
            <br />
                      
            <asp:Label ID="lblAccountTransferor" runat="server" Text="Account: "></asp:Label>
            <br />
             <asp:Label ID="lblAmount" runat="server" Text="Amount: $"></asp:Label>
            

            <%--<asp:Label ID="lbltransferee" runat="server" Text="Transferee"></asp:Label><br />--%>
            <h3> Transferee</h3>
              <br />
            <asp:Label ID="lblNameTransferee" runat="server" Text="Name: "></asp:Label>
            <br />
            <asp:Label ID="lblAccountTransferee" runat="server" Text="Account: "></asp:Label>
            <br />
            <br />
            <br />
           
            <asp:Button ID="Button_Back" runat="server" Text="<Back" OnClick="Button_Back_Click" CssClass="button" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button_Complete" runat="server" Text="Complete" OnClick="Button_Complete_Click" CssClass="button" />
           
            <br />


        </div>
        

        
    </form>
</body>
</html>
