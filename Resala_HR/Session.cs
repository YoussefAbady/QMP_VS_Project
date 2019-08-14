using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resala_HR
{
    /// <summary>
    /// Singleton pattern 
    /// </summary>
    public class Session
    {
        private static Session session; 

        private  User user;
        private  Branch branch;

        private Session(String UID , String BID)
        {
            this.user = new User(UID) ;
            this.branch = new Branch(BID);
        }

        public static Session getSession()
        {
            return session;

        }
 
        public static DataModels.Result login(String username, String password)
        {
            string query = string.Format("SELECT ALL FROM ALL ; ");

            DataTable DT = null;
            DataModels.Result res = Database.execute(query, ref DT);

            if (res != DataModels.Result.SUCCESS)
                return res;

            else if (DT.Rows.Count == 0)
                return DataModels.Result.USER_NOT_FOUND;

            else if (DT.Rows.Count == 1)
            {

                String UID = DT.Rows[0]["U_ID"].ToString();
                String BID = DT.Rows[0]["BR_ID"].ToString();
                String name = DT.Rows[0]["FULL_NAME"].ToString();

                session = new Session(UID, BID);

                return DataModels.Result.SUCCESS;
            }
            else
                return DataModels.Result.RETURN_TO_ADMIN_ERROR;

        }

        public void logout()
        {
            session = null; 
        }

    }
}
