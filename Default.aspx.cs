using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {

            ListItem selectedItem = MyCheckBoxList.SelectedItem;

            if (selectedItem != null)
            {

                Response.Write("SelectedItem Text: " + selectedItem.Text + "<br />");
                Response.Write("SelectedItem Value: " + selectedItem.Value + "<br /><br />");
            }
            else
            {
                Response.Write("No items selected!  <br /><br />");
            }


            string selectedValue = MyCheckBoxList.SelectedValue;

            if (!string.IsNullOrEmpty(selectedValue))
            {

                Response.Write("SelectedValue: " + selectedValue + "<br /><br />");
            }
            else
            {
                Response.Write("No items selected!  <br /><br />");
            }
        }
    }
}