using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FundTransferConfirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string transferorSelected = "";
        string AmountSelected = "";
        string AccountSelected = "";
        string transfereeSelected = "";
        string AccountSelectedTo = "";

        // Retrive Transferor infromation from session 

        if (Session["transferorSelection"] != null)
        {
             transferorSelected = Session["transferorSelection"].ToString();
        }

        if (Session["AmountTransfer"] != null)
        {
            AmountSelected = Session["AmountTransfer"].ToString();
        }

        if (Session["radioButtonFrom"] != null)
        {
            AccountSelected = Session["radioButtonFrom"].ToString();
        }

        //  Retrive Transferee infromation from session

        if(Session["transfereeSelection"] != null)
        {
            transfereeSelected = Session["transfereeSelection"].ToString();
        }

        if (Session["radioButtonTo"] != null)
        {
            AccountSelectedTo = Session["radioButtonTo"].ToString();
        }

        
        foreach (Customer customer in Customer.GetAllCustomers())
        {
            if (customer.Id.ToString() == transferorSelected.ToString())
            {
                lblNameTransferor.Text += customer.ToString();
                lblAccountTransferor.Text += AccountSelected.ToString();
                lblAmount.Text += AmountSelected.ToString();


            } // End of if (customer.Id.ToString() == transferorSelected.ToString())

            else if(customer.Id.ToString() == transfereeSelected.ToString())
            {
                lblNameTransferee.Text += customer.ToString();
                lblAccountTransferee.Text += AccountSelectedTo.ToString();
            } // End of else if(customer.Id.ToString() == transfereeSelected.ToString())

        } // End of  foreach (Customer customer in Customer.GetAllCustomers())

    } // End of  protected void Page_Load(object sender, EventArgs e)


    protected void Button_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("FundTransferTo.aspx");
    }

    protected void Button_Complete_Click(object sender, EventArgs e)
    { 
        // call the sessions again b/c they are not public to all methods. 
        string transferorSelected = "";
        string AmountSelected = "";
        string AccountSelected = "";
        string transfereeSelected = "";
        string AccountSelectedTo = "";

        // Retrive Transferor infromation from session 
        if (Session["transferorSelection"] != null)
        {
            transferorSelected = Session["transferorSelection"].ToString();
        }

        if (Session["AmountTransfer"] != null)
        {
            AmountSelected = Session["AmountTransfer"].ToString();
        }
    
        double Amount = double.Parse(AmountSelected);

        if (Session["radioButtonFrom"] != null)
        {
            AccountSelected = Session["radioButtonFrom"].ToString();
        }

        // Retrive Transferee infromation from session 
        if (Session["transfereeSelection"] != null)
        {
            transfereeSelected = Session["transfereeSelection"].ToString();
        }

        if (Session["radioButtonTo"] != null)
        {
            AccountSelectedTo = Session["radioButtonTo"].ToString();
        }
      
        Transaction transaction = new Transaction(Amount);

        foreach (Customer customer in Customer.GetAllCustomers())
        {
            if (customer.Id.ToString() == transferorSelected.ToString())
            {
                if(AccountSelected == customer.Checking.ToString())
                {
                    customer.Checking.Withdraw(transaction);

                    // save the balance that is being withdrawed 
                    Session["BalanceTransferor"] = customer.Checking.ToString();
                }
                else if (AccountSelected == customer.Saving.ToString())
                {
                    customer.Saving.Withdraw(transaction);

                    Session["BalanceTransferor"] = customer.Saving.ToString();
                }

            } // End of if (customer.Id.ToString() == transferorSelected.ToString())
            else if (customer.Id.ToString() == transfereeSelected.ToString())
            {
                if (AccountSelectedTo == customer.Checking.ToString())
                {
                    customer.Checking.Deposit(transaction);

                    Session["BalanceTransferee"] = customer.Checking.ToString();
                }
                else if (AccountSelectedTo == customer.Saving.ToString())
                {
                    customer.Saving.Deposit(transaction);

                    Session["BalanceTransferee"] = customer.Saving.ToString();
                }

            } // End of else if (customer.Id.ToString() == transfereeSelected.ToString())
        } // End of foreach (Customer customer in Customer.GetAllCustomers())

       Response.Redirect("FundTransferResult.aspx");

    } // End of protected void Button_Complete_Click(object sender, EventArgs e)
} // End of public partial class FundTransferConfirmation : System.Web.UI.Page