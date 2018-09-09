using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FundTransferFrom : System.Web.UI.Page
{

    private Customer customerTransferor;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false) // == false will display list before the submit button is clicked 
        {
            // create a new list so you can obtain the GetAllCustomers list from the Customer class. 
            List<Customer> customerList = new List<Customer>();
            customerList = Customer.GetAllCustomers();
           
            // display the customers names and ID in the dropdownlist. 
            foreach (Customer customer in customerList)
            {
                // ListItem is in the aspx file for dropDownList. 
                ListItem item = new ListItem(customer.ToString(), customer.Id.ToString());
                dropDownList1.Items.Add(item); // add the item into the dropDownList1 created in aspx file. 

            } // End of foreach (Customer customer in Customer.GetAllCustomers())

        } // End of if (IsPostBack == false)

        // create loop when the transferor customer is selected from the dropDownList1. 
        foreach (ListItem transferor in dropDownList1.Items)
        {
            // if transferor customer is selected than the saving and checking balance should display 
            if (transferor.Selected)
            {
                foreach (Customer customer in Customer.GetAllCustomers())
                {
                    // if the Id and name (customer.ToString) is the same as the text (transferor.text) in the 
                    //transferor dropDownList than you can move forward to the next step. 
                    if (customer.ToString() == transferor.Text) 
                    {
                        // assign the radioButton ID to the accounts in order to print the balance 
                        radioBtnFromAccount.Items[0].Text = customer.Checking.ToString();
                        radioBtnFromAccount.Items[1].Text = customer.Saving.ToString();

                    } // End of if (customer.ToString() == transferor.Text)

                } // End of foreach (Customer customer in Customer.GetAllCustomers())

            } // End of if (transferor.Selected)


        } // End of foreach (ListItem transferor in dropDownList1.Items)


    } // End of  protected void Page_Load(object sender, EventArgs e)

   
    protected void btnNext_Click(object sender, EventArgs e)
    {
        // saving the amount that transferor entered 
        Session["AmountTransfer"] = TextBoxamount.Text; // amount that was entered 

        Response.Redirect("FundTransferTo.aspx");

    } // End of protected void btnNext_Click(object sender, EventArgs e)

    
    protected void rblFromAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        //  need to get the index of the selected transferor customer in the dropdownlist.  
        string valueSelected = dropDownList1.SelectedValue;

        // saving the index of the selected transferor customer from the ddl into  the session varibale. 
        Session["transferorSelection"] = valueSelected;
        // we want to print the valueSelected as a int type instead of string, thus have to convert. 
        int CustomerId = int.Parse(valueSelected); 
        // selectedCustomer gets the Id of the selected transferor customer. 
        Customer selectedCustomer = Customer.GetCustomerById(CustomerId);

        // If the Checking radioButton is selected 
        if (radioBtnFromAccount.Items[0].Selected)
        {
            // Session variable will store the balance of the checking account for selected transferor customer. 
            Session["radioButtonFrom"] = selectedCustomer.Checking.ToString();

            // If the transferor customer selected has a status of Regular 
            if (selectedCustomer.Status == CustomerStatus.REGULAR)
            {
                // The customer can only Transfer a Max of $300 in the amount. 
                if (selectedCustomer.Checking.Balance > CheckingAccount.MaxTransferAmount)
                {
                    // validates that your amount is in range 
                    RVAmount.MaximumValue = CheckingAccount.MaxTransferAmount.ToString();
                }
                // if balance less than 300 it will come here and say that your max is your balance. 
                else
                {
                    // validates that your amount is in range 
                    RVAmount.MaximumValue = selectedCustomer.Checking.Balance.ToString();
                }

            } // End of if(selectedCustomer.Status == CustomerStatus.REGULAR)

            else
            {
                RVAmount.MaximumValue = selectedCustomer.Checking.Balance.ToString();//preminum
            }
        } // End of if (radioBtnFromAccount.Items[0].Selected)

        else if (radioBtnFromAccount.Items[1].Selected)
        {
            // Session variable will store the balance of the saving account for selected transferor customer.
            Session["radioButtonFrom"] = selectedCustomer.Saving.ToString();

            RVAmount.MaximumValue = selectedCustomer.Saving.Balance.ToString();
        } // End of else if (radioBtnFromAccount.Items[1].Selected)


    } // End of protected void rblFromAccount_SelectedIndexChanged(object sender, EventArgs e)
} // End of public partial class FundTransferFrom : System.Web.UI.Page






