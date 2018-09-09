using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FundTransfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string transferorSelected = "";
        string AmountSelected = "";
        string transfereeSelected = "";
        string balanceTransferor = "";
        string balanceTransferee = "";

        // Retrive Transferor and Transferee infromation from session 

        if (Session["transferorSelection"] != null)
        {
           transferorSelected = Session["transferorSelection"].ToString();
        }

        if (Session["AmountTransfer"] != null)
        {
            AmountSelected = Session["AmountTransfer"].ToString();
        }

        if (Session["transfereeSelection"] != null)
        {
            transfereeSelected = Session["transfereeSelection"].ToString();
        }

        if (Session["BalanceTransferor"] != null)
        {
            balanceTransferor = Session["BalanceTransferor"].ToString();
        }

        if (Session["BalanceTransferee"] != null)
        {
            balanceTransferee = Session["BalanceTransferee"].ToString();
        }      

        foreach (Customer customer in Customer.GetAllCustomers())
        {
            if (customer.Id.ToString() == transferorSelected.ToString())
            {
                lblAmount.Text += AmountSelected.ToString();
                lblTransferor.Text += customer.ToString();
                lblAccountTransferor.Text += balanceTransferor.ToString();

            } 
            else if (customer.Id.ToString() == transfereeSelected.ToString())
            {
                lblTransferee.Text += customer.ToString();
                lblAccountTransferee.Text += balanceTransferee.ToString();
            }

        } // End of foreach (Customer customer in Customer.GetAllCustomers())

    } // End of protected void Page_Load(object sender, EventArgs e)


    protected void Button_Click(object sender, EventArgs e)
    {
        Response.Redirect("FundTransferFrom.aspx");
    }
} // End of public partial class FundTransfer : System.Web.UI.Page