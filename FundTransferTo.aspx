<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundTransferTo.aspx.cs" Inherits="FundTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bank of Algonquin</title>
    <link href="App_Themes/SiteStyles.css" rel="stylesheet" />

</head>
<body style="background-color: lightyellow">
    <h1>Online Fund Transfer Service</h1>
    <form id="form1" runat="server">
        <h2 class="distinct">Transfer To</h2>
        <asp:DropDownList ID="dropDownListTo" runat="server" AutoPostBack="true">

        <asp:ListItem Selected="True" value ="-1">Selected Transferee...</asp:ListItem>
        
        </asp:DropDownList><br /><br />
         <asp:RequiredFieldValidator ID="rfvTransferee" runat="server"  InitialValue="-1" ControlToValidate="dropDownListTo" ForeColor ="Red"
            ErrorMessage="Must Select One" Display ="Dynamic"></asp:RequiredFieldValidator>

        <asp:Label ID="lblToAccount" runat="server" Text="From Account"></asp:Label>
       
        <asp:RadioButtonList ID="radioBtnToAccount" runat="server" AutoPostBack="true" OnSelectedIndexChanged="radioBtnToAccount_SelectedIndexChanged">
            <asp:ListItem Text="Checking">

            </asp:ListItem>
            <asp:ListItem Text="Saving"></asp:ListItem>       

        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="rfvRadioButton" runat="server"  InitialValue="" ControlToValidate="radioBtnToAccount" ForeColor ="Red"
            ErrorMessage="Must Select An Account" Display ="Dynamic"></asp:RequiredFieldValidator>



        <br /> 
        <asp:Button ID="Button_Back" runat="server" OnClick="Button_Back_Click" Text="<Back" CssClass="button"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button_Next" runat="server" Text="Next>" OnClick="Button_Next_Click" CssClass="button"/>
        <br />
&nbsp;<br />
      <%-- <asp:Button ID="Button_Next" runat="server" Text="Next" OnClick="Button_Next_Click" CssClass="button"/> --%>



    </form>
</body>
</html>
