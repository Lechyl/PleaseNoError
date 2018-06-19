using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PleaseNoError
{
    public partial class Ze_Tian_Ji : System.Web.UI.Page
    {
        bool ButtonA = false;
        bool ButtonB = false;
        bool ButtonC = false;
        bool ButtonD = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            PlayerScreen.Text = "Welcome to Argondia";
            PlayerScreen.Text = "You're walking on the main route, you see 3 interesting shops";
            Button_A.Text = "Die Hard";
            Button_B.Text = "No Go away";
            Button_C.Text = "Please stay";
            Button_D.Visible = false;
        }
        
        public void Scene1()
        {


            if (ButtonA == true)
            {
                PlayerScreen.Text = "You ran to the Die Hard and hopefully tries to die.";
                ButtonA = false;
            }
            else if (ButtonB == true)
            {
                ButtonB = false;
                PlayerScreen.Text = "NONGAEUGNAEOUIJGAE";
            }
        }

        protected void Button_A_Click(object sender, EventArgs e)
        {
            ButtonA = true;
            Scene1();
           
        }

        protected void Button_B_Click(object sender, EventArgs e)
        {
            
            ButtonB = true;
        }
        protected void Button_C_Click(object sender, EventArgs e)
        {
          
            ButtonC = true;
        }

        protected void Button_D_Click(object sender, EventArgs e)
        {
            ButtonD = true;
            
        }

        protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(int.Parse(DDL1.SelectedItem.Value) == 1)
            {
                
                Response.Redirect("PleaseWork.aspx");
            }
            else
            {

            }
        }
    }
}