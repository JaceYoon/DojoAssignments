using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson(); 

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================
            
            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist FromMtVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon").Single();
            Console.WriteLine($"The artist {FromMtVernon.ArtistName} from Mt Vernon is {FromMtVernon.Age} years old");
            //Who is the youngest artist in our collection of artists?
            Artist Youngest = Artists.OrderBy(artist => artist.Age).First();
            System.Console.WriteLine($"Yougest artist is {Youngest.ArtistName} and he/she's age is {Youngest.Age}");
            //Display all artists with 'William' somewhere in their real name
            List<Artist> Williams = Artists.Where(artist => artist.RealName.Contains("William")).ToList();
            foreach(var artist in Williams){
                System.Console.WriteLine(artist.ArtistName + "-" + artist.RealName);
            }
            //Display all groups with names less than 8 characters in length.
            List<Group> eightlaters = Groups.Where(group => group.GroupName.Length > 8).ToList();
            foreach(var group in eightlaters){
                System.Console.WriteLine($"the group name '{group.GroupName}' has {group.GroupName.Length} length");
            }
            //Display the 3 oldest artist from Atlanta
            List<Artist> topthree = Artists.Where(artist => artist.Hometown == "Atlanta").OrderBy(artist => -artist.Age).ToList();
            System.Console.WriteLine("the 3 oldest artist from Atlanta .. below");
            for(var i =0; i < 3; i++){
                System.Console.WriteLine("name : " + topthree[i].ArtistName + "and age is :" + topthree[i].Age);
            }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            // List<Artist> NoNewYorker = Artists.Where(artist => artist.Hometown != "New York City").ToList();
            
            for(var i = 1; i < Groups.Count+1; i++){
                var j = 0;
                List<Artist> EachGroupMember = Artists.Where(artist => artist.GroupId == i).ToList();
                Group CurGroup = Groups.Where(group => group.Id == i).Single();
                // System.Console.WriteLine($"{CurGroup.GroupName} - {EachGroupMember.Count}");
                
                while(j < EachGroupMember.Count){
                    if(EachGroupMember[j].Hometown == "New York City"){
                        break;
                    }else{
                        if(j == EachGroupMember.Count-1){
                            System.Console.WriteLine($"No NewYoker in Group {CurGroup.GroupName}");
                            break;
                        }else{
                            j++;
                        } 
                    }
                }
            }

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            Group WuTang = Groups.Where(group => group.GroupName == "Wu-Tang Clan").Single();
            List<Artist> WuTangmembers = Artists.Where(artist => artist.GroupId == WuTang.Id).ToList();
            System.Console.WriteLine("Here are WuTangClan's members");
            foreach(var artist in WuTangmembers){
                System.Console.WriteLine($"WuTangClan Memer '{artist.ArtistName}'");
            }
        }
    }
}
