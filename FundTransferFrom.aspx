<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundTransferFrom.aspx.cs" Inherits="FundTransferFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bank of Algonquin</title>
    <link href="App_Themes/SiteStyles.css" rel="stylesheet" />

</head>
<body style="background-color: lightyellow">
    <h1>Online Fund Transfer Service</h1>
    <form id="form1" runat="server">

    
     <h2 class="distinct">Transfer From</h2>

        <asp:DropDownList ID="dropDownList1" runat="server" AutoPostBack="true" >
       <asp:ListItem value ="-1">Selected Transferor...</asp:ListItem>   
        </asp:DropDownList><br />

        <asp:RequiredFieldValidator ID="RFV1" runat="server"  InitialValue="-1" ControlToValidate="dropDownList1" ForeColor ="Red"
            ErrorMessage="Must Select One" Display ="Dynamic"></asp:RequiredFieldValidator>
        <br />
        


        <asp:Label ID="lblFromAccount" runat="server" ></asp:Label>
       
        <asp:RadioButtonList ID="radioBtnFromAccount" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblFromAccount_SelectedIndexChanged">
            <asp:ListItem Text="Checking">

            </asp:ListItem>
            <asp:ListItem Text="Saving"></asp:ListItem> 
            
        </asp:RadioButtonList>

         <asp:RequiredFieldValidator ID="RFV2" runat="server"  InitialValue="" ControlToValidate="radioBtnFromAccount" ForeColor ="Red"
            ErrorMessage="Must Select An Account" Display ="Dynamic"></asp:RequiredFieldValidator>
       
        <br />
       
        <br />
        <br />
        <br />

        <asp:Label ID="lblamount" runat="server" Text="Amount"></asp:Label>

        <asp:TextBox ID="TextBoxamount" runat="server"></asp:TextBox><br /> <br />

        <asp:RequiredFieldValidator ID="rfvAmount" runat="server"  InitialValue="" ControlToValidate="TextBoxamount" ForeColor ="Red"
            ErrorMessage="Cannot Be Blank!" Display ="Dynamic"></asp:RequiredFieldValidator>

        <asp:RangeValidator ID="RVAmount" runat="server"  ControlToValidate ="TextBoxamount"
            ErrorMessage="Exceeding your Amount" MinimumValue ="1" MaximumValue ="99999" Type ="Double"
            ForeColor ="Red" Display="Dynamic"></asp:RangeValidator>
 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 
        <asp:Button ID="btnNext" runat="server" Text="Next>" OnClick="btnNext_Click" CssClass="button"   />
       
        
        
       
    </form>
</body>
</html>
