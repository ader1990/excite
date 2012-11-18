using RMA.ExciteModels;
using RMA.ExciteBussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMA.ExciteBussinessLogic
{
    public class ExciteService : IExciteService
    {
        bool IExciteService.AddUser(String userName)
        {
            using (ExciteContext db = new ExciteContext())
            {
                UserProfile user = db.UserProfiles.FirstOrDefault(u => u.UserName.ToLower() == userName.ToLower());
                // Check if user already exists
                if (user == null)
                {
                    // Insert name into the profile table
                    db.UserProfiles.Add(new UserProfile { UserName = userName });
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
