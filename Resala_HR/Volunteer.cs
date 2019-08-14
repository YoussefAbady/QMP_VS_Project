using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resala_HR
{
    class Volunteer
    {
        public int ID , BR_ID ;
        public DateTime DOB, joinDate; 
        public string name , phone_num , Email , whatsapp_num , region ;
        public DataModels.Education_Level education;
        public bool isMiniCamp , isTshirt ;
        public DataModels.Gender gender;
        public DataModels.Cell_Operator phone_opr;

        public int add()
        {

            return 0 ;

        }

        public void update()
        {

        }

        public int getID(string phone , string name= "")
        {

            return 0 ; 

        }

        public void getData()
        {

        }

        public void archive()
        {

        }

    }
}
