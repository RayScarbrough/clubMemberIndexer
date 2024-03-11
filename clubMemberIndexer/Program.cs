using System;
using System.Drawing;
namespace Club
{
    
    class ClubMembers
    {
        public const int Size = 15;  // global variable
        private string[] Members = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // constructor
        public ClubMembers()
        {
             ClubType = "";
             ClubLocation  = "";
             MeetingDate = "";
        }
        //indexer get and set methods
        public string this[int index]
        {
            get { return Members[index]; }
            set { Members[index] = value; }
        }
    }

    class ClubMember
    {
        static void Main(string[] args)
        {
            
            ClubMembers club = new ClubMembers();

            
            club[0] = "John Doe";
            club[1] = "Jane Smith";
            club[2] = "Emily Johnson";

            
            club.ClubType = "Coding Club";
            club.ClubLocation = "Erics Basement";
            club.MeetingDate = "Tuesday at 6 PM";

            
            Console.WriteLine($"Club Type: {club.ClubType}");
            Console.WriteLine($"Club Location: {club.ClubLocation}");
            Console.WriteLine($"Meeting Date: {club.MeetingDate}");
            Console.WriteLine("Members:");
            for (int i = 0; i < ClubMembers.Size; i++)
            {
                if (!string.IsNullOrEmpty(club[i]))
                {
                    Console.WriteLine($"- {club[i]}");
                }
            }
        }
    }
}
