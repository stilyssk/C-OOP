using System.Collections.Generic;

namespace P07_FamilyTree
{
    public interface IFamilyTreeMain
    {
        IPersonStore MainPerson { get; set; }

        void AddMainPerson(string inputPersonalString);

        void AddParentChildPair(string inputParetnString, string inputChildString);

        void UpdateParentChildPair(string inputName, string inputBirthday);

        string ToString();

        void UpdateAll();
    }
}