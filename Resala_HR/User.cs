using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resala_HR
{
    public class User
    {
        public String name ,UID , BID ;
        public DataModels.User_Privilege priv;
        public DataModels.Role role;



        public User(String UID)
        {
            this.UID = UID; 

            // retrive branch data
        }


        private void getUserInfo(String UID)
        {

        }

    }
}
