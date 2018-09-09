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
       
        if (IsPostBack == false)
        {
            // calling the saved transferor customer session from firstpage. 
            // we are calling b/c we want to remove them from the dropDownList
            string transferor = Session["transferorSelection"].ToString();

            // Displays the Id and Name of the Tansferee's in the dropDownList not including
            //the selected transferor from firstPage. 
            foreach (Customer customer in Customer.GetAllCustomers())
            {
                if(customer.Id.ToString() !=transferor)
                {
                    ListItem item = new ListItem(customer.ToString(), customer.Id.ToString());
                    dropDownListTo.Items.Add(item);
                } // End of if(customer.Id.ToString() !=transferor)


            } // End of foreach (Customer customer in Customer.GetAllCustomers())

        } // End of if (IsPostBack == false)

        // 
        foreach (ListItem dropdownTransferee in dropDownListTo.Items)
        {
            if (dropdownTransferee.Selected)
            {
                foreach (Customer customer in Customer.GetAllCustomers())
                {
                    if (customer.ToString() == dropdownTransferee.Text)
                    {
                        radioBtnToAccount.Items[0].Text = customer.Checking.ToString();
                        radioBtnToAccount.Items[1].Text = customer.Saving.ToString();

                    } // End of if (customer.ToString() == dropdown.Text)

                } // End of foreach (Customer customer in Customer.GetAllCustomers())

            } // End of  if (dropdown.Selected)

        } // End of foreach (ListItem dropdown in dropDownListTo.Items)


    } // End of  protected void Page_Load(object sender, EventArgs e)
    

    protected void Button_Next_Click(object sender, EventArgs e)
    {       
       Response.Redirect("FundTransferConfirmation.aspx");
    } // End of protected void ButtonNext_Click(object sender, EventArgs e)


    protected void Button_Back_Click(object sender, EventArgs e)
    {  
        Response.Redirect("FundTransferFrom.aspx");
    } // End of protected void Button1_Click(object sender, EventArgs e)

    protected void radioBtnToAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        string valueSelected = dropDownListTo.SelectedValue;

        Session["transfereeSelection"] = valueSelected;
        int CustomerId = int.Parse(valueSelected);

        Customer selectedCustomer = Customer.GetCustomerById(CustomerId);

        if (radioBtnToAccount.Items[0].Selected)
        {
            //Session["btnRadioTo"] = selectedCustomer.Checking.ToString();
            Session["radioButtonTo"] = selectedCustomer.Checking.ToString();


        }
        else if (radioBtnToAccount.Items[1].Selected)
        {
            //Session["btnRadioTo"] = selectedCustomer.Saving.ToString();
            Session["radioButtonTo"] = selectedCustomer.Saving.ToString();

        }
    } // End of  protected void radioBtnToAccount_SelectedIndexChanged(object sender, EventArgs e)
} // 


    

