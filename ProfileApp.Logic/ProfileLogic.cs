using ProfileApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileApp.Logic
{
    public class ProfileLogic
    {
        public bool CreateProfile(Profile model)
        {
            //implement logic
            if(model.FirstName == "john")
            {
                return false;
            }
            else if(model.FirstName == "kasali")
            {
                return false;
            }
            else if (model.DateOfBirth > DateTime.Now)           
            {
                return false;
               
            }


            else
            {
                return true;
            }
        }

        public bool UpdateProfile(string firstName, string lastName)
        {
            return default;
        }

        public bool UpdateDateOfBirth(DateTime dateOfBirth)
        {
            return default;
        }

        public Profile GetProfile(string firstName)
        {
            return default;
        }

        public string CreateMyProfile(Profile model)
        {
            int age = DateTime.Now.Year - model.DateOfBirth.Year;
            if(age > 18)
            {
                return "You are eliigible";
            }
            else
            {
                return "You are ineligible";

            }
        }
        
        public string CreateNewProfile(Profile model)
        {
            int age = DateTime.Now.Year - model.DateOfBirth.Year;
            string Name = "john";
            if (age > 18 && model.FirstName == Name)
            {
                return "We dont allow john";
            }
            else
            {
                return "you are successfully registered";
            }
        }


    }
}


