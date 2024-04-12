using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace DataLayer
{
    public class Profile
    {
        public List<Group> groupList = new List<Group>();

        public static void DisplayGroup(Group group)
        {
            Console.WriteLine("Group Name: " + group.Name);
            Console.WriteLine("Group Members: " + group.Members);
            Console.WriteLine("Debut Date: " + group.DebutDate);
            Console.WriteLine("Company: " + group.Company);

        }
    }
}
