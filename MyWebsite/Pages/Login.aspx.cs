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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var username = TbxUser.Text.Trim();
            var password = TbxPass.Text.Trim();
         //   foreach (var user in db..Where(t => t.username == username && t.password == password))
         //   {

         //   }
        }
    }
}