using System;
using System.Collections.Generic;
using DbConnection;

namespace CRUd_MySQL
{
    class Program
    {
        static void Main(string[] args)
        {   
            RetrieveAll();
            // CreateUser();
            // Update();
            // delete();
        }

        public static void RetrieveAll(){
            System.Console.WriteLine("Here are all users in database");
            List<Dictionary<string, object>> users = DbConnector.Query("SELECT * FROM consoleDB");
            foreach (var user in users){
                // System.Console.WriteLine($"id : {0}, Name : {1} {2}, Favorite Number : {3}",user["idconsoleDB"],user["FirstName"],user["LastName"],user["FavortiteNumber"]);
                System.Console.WriteLine("Id :" + user["idconsoleDB"] + "| Name:" + user["FirstName"] + " " + user["LastName"] + " - "+ "Favorite Number :" + user["FavortiteNumber"]);
            }
        }

        public static void CreateUser(){
            System.Console.WriteLine("Enter Your first name");
            string Inputfname = Console.ReadLine();
            System.Console.WriteLine("Enter Your last name");
            string Inputlname = Console.ReadLine();
            System.Console.WriteLine("Enter Your favorite number");
            string Inputfnum = Console.ReadLine();
            int MyInt = int.Parse(Inputfnum);
            // List<Dictionary<string, object>> users = DbConnector.Execute($"INSERT INTO consoleDB (FirstName, LastName, FavortiteNumber, updated_at, created_at); VALUES ({fname}, {lname}, {fnum},now(),now()); ");
            DbConnector.Execute($"INSERT INTO consoleDB (FirstName, LastName, FavortiteNumber, updated_at, created_at) VALUES ('{Inputfname}','{Inputlname}','{MyInt}',now(),now());"); 
        }

        public static void Update(){
            System.Console.WriteLine("Enter the ID number for want to changing about specific object");
            string idnum = Console.ReadLine();
            int MyInt = int.Parse(idnum);
            System.Console.WriteLine("Do you want to Update first name? Y/N");
            string line = Console.ReadLine();
            switch(line){
                case "y":
                    System.Console.WriteLine("The put the new first name");
                    string fname = Console.ReadLine();
                    DbConnector.Execute($"UPDATE consoleDB SET FirstName = '{fname}' WHERE idconsoleDB = '{MyInt}'");
                    break;
                case "n":
                    System.Console.WriteLine("Do you want to change last name? Y/N");
                    string line2 = Console.ReadLine();
                    switch(line2){
                        case "y":
                        System.Console.WriteLine("Then put the new last name");
                        string lname = Console.ReadLine();
                        DbConnector.Execute($"UPDATE consoleDB SET LastName = '{lname}' WHERE idconsoleDB = '{MyInt}'");
                        break;

                        case "n":
                        System.Console.WriteLine("Then do You want to change favorite number? Y/N");
                        string line3 = Console.ReadLine();
                        switch(line3){
                            case "y":
                            System.Console.WriteLine("Then put the new favorite number");
                            string fnum = Console.ReadLine();
                            DbConnector.Execute($"UPDATE consoleDB SET FavortiteNumber = '{fnum}' WHERE idconsoleDB = '{MyInt}'");
                            break;

                            case "n":
                            System.Console.WriteLine("Canceling...");
                            break;
                        }
                        break;
                    }
                    break;
            }
        }

        public static void delete(){
            System.Console.WriteLine("Enter the ID number you want to delete about");
            string deleteid = Console.ReadLine();
            int MyInt = int.Parse(deleteid);
            DbConnector.Execute($"DELETE FROM consoleDB WHERE idconsoleDB = '{MyInt}'");
        }
    }
}
