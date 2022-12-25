using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_2
{
    /* The struct User is responsible for keeping the properties of every user in the database */
    public struct User
    {
        private string userName, password, userType, firstName, lastName, DOB;

        public User(string userName, string password, string userType, string firstName, string lastName, string DOB)
        {
            this.userName = userName;
            this.password = password;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
        }

        public string getType()
        {
            return this.userType;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public string getPassword()
        {
            return this.password;
        }

        public override string ToString()
        {
            return userName + "," + password + "," + userType + "," + firstName + "," + lastName + "," + DOB;
        }
    }

    /* The class Filemanager is responsible for importing the "login.txt" file into a LinkedList,
     * and also for validating login details, validating unique usernames, and adding new users to the database */
    public class FileManager
    {
        private LinkedList<User> users;
        private const string LoginPath = @"..\..\..\login.txt";
        public FileManager()
        {
            users = new LinkedList<User>();
            string[] lines = File.ReadAllLines(LoginPath);
            foreach (string line in lines)
            {
                string[] userDetails = line.Split(',');
                users.AddLast(new User(userDetails[0], userDetails[1], userDetails[2], userDetails[3], userDetails[4], userDetails[5]));
            }
        }

        public string getUserType(string userName)
        {
            foreach (User user in users)
            {
                if (user.getUserName().Equals(userName))
                {
                    return user.getType();
                }
            }
            return null;
        }

        public bool validateLogin(string userName, string password)
        {
            foreach (User user in users)
            {
                if (user.getUserName().Equals(userName) && user.getPassword().Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        public bool validateUserName(string userName)
        {
            foreach (User user in users)
            {
                if (user.getUserName().Equals(userName))
                {
                    return false;
                }
            }
            return true;
        }

        public void addNewUser(string userName, string password, string userType, string firstName, string lastName, string DOB)
        {
            User user = new User(userName, password, userType, firstName, lastName, DOB);
            users.AddLast(user);
            File.AppendAllText(LoginPath, "\n" + user.ToString());

        }
    }
}
