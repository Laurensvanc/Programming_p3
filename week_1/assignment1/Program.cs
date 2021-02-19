using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mainProgram = new Program();
            mainProgram.Start();
        }

        void Start()
        {
            Team team = new Team();

            team.AddProgrammer(new Programmer("Peter", Specialty.Csharp));
            team.AddProgrammer(new Programmer("Kevin", Specialty.Java));
            team.AddProgrammer(new Programmer("John", Specialty.Csharp));
            team.AddProgrammer(new Programmer("Susan", Specialty.Java));
            team.AddProgrammer(new Programmer("Emma"));

            team.PrintAllTeamMembers();

            Console.ReadKey();
        }
    }
}
