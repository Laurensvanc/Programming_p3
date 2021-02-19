using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class Team
    {
        List<Programmer> programmerList;

        public Team()
        {

            programmerList = new List<Programmer>();
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer programmer in programmerList)
            {
                programmer.Print();
            }
        }

        public void AddProgrammer(Programmer programmer)
        {
            programmerList.Add(programmer);
        }
    }
}
