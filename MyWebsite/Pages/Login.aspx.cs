using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebsite.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        MBASystemEntities db = new MBASystemEntities();
        
      //  User user = new User();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void CreateALog(int UserID, String category, string description)
        {
         /*
            Logs logs = new Logs();
            logs.userID = userID;
            logs.category = category;
            logs.description = description;
            db.logs.Add(logs);
            int success = db.SaveChanges();
            if (success == 0)
            {
                lblSuccess.Text = "Error creating logs.";
            }
        */
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var username = TbxUser.Text.Trim();
            var password = TbxPass.Text.Trim();
            /*foreach (var record in db.User.where(TbxPass => TbxUser == username && t.password == password))
              {
                  Response.Redirect("../pages/Home.aspx")
              }
              if(authenticated)
              {
                  
              }
              else
              {
                    lblSuccess.Text = "Problem loggin in. Please re-enter details.";
              }
              lblMessage.Text = "User details entered are " + username + " " + password;

      */
        }
    }
}