using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace MyWebsite.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        MBASystemNewEntities db = new MBASystemNewEntities();


        public User user = new User();

        protected void Page_Load(object sender, EventArgs e)
        {
            var menu = Page.Master.FindControl("Menu1") as Menu;
            menu.Visible = false;
            
        }
      /*  private void CreateALog(int UserID, String category, string description)
        {
            int saveSuccess = 0;
            try
            {
                Log log = new Log();
                log.UserID = userID;
                log.Category = category;
                log.Description = description;
                db.Logs.Add(log);
                saveSuccess = db.SaveChanges();
                if (saveSuccess == 0)
                {
                    lblSuccess.Text = "Error creating logs.";
                }
            }
            catch (Exception ex)
            {
                lblSuccess.Text = "Error in database " + ex.InnerException;
            }
            return (saveSuccess);



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
           /
        }*/
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var menu = Page.Master.FindControl("Menu1") as Menu;
            int saveSuccess = 0;
            bool authenticated = false;
            var username = TbxUser.Text;
            var password = TbxPass.Text;
            foreach (var record in db.Users.Where(t => t.Username == username && t.Password == password))
            {
                authenticated = true;
                user = record;
            }
            // Cannot save record whilst inside a foreach loop. Must be completed outside the loop
           // saveSuccess = CreateALog(Convert.ToInt16(user.user_id), "Login", "User " + user.username.ToString() + " authenticated successfully.");
            // saveSuccess indicates if the record has been saved successfully into the SQL database
            if (authenticated /*&& saveSuccess == 1*/)
            {
                // Use a session state to store the current user.
                // See https://msdn.microsoft.com/en-us/library/ms178581.aspx for details
                HttpContext.Current.Session["currentUser"] = user;

                //Send user to the home page when authenticated
                Response.Redirect("~/pages/home.aspx");
            }
            else
            {
                // Show error message to user
                lblSuccess.Text = "Problem logging in. Pleae re-enter details.";
            }
            if (authenticated == true)
            {
                menu.Visible = true;
            }
            else
                menu.Visible = false;

             

            /*
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