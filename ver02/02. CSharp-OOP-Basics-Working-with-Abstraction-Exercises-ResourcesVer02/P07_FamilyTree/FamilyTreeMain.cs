using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07_FamilyTree
{
    public class FamilyTreeMain : IFamilyTreeMain
    {
        private IPersonStore mainPerson;
        private List<IParentChildPair> pairParentChild;
        private List<IPersonStore> listPerson;

        public FamilyTreeMain()
        {
            this.MainPerson = new PersonStore();
            this.PairParentChild = new List<IParentChildPair>();
            this.ListPerson = new List<IPersonStore>();
        }

        public IPersonStore MainPerson
        {
            get
            {
                return this.mainPerson;
            }
            set
            {
                this.mainPerson = value;
            }
        }

        private List<IParentChildPair> PairParentChild
        {
            get => pairParentChild;
            set => pairParentChild = value;
        }

        private List<IPersonStore> ListPerson { get => listPerson; set => listPerson = value; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(MainPerson.ToString());

            //foreach (var item in PairParentChild)
            //{
            //    result.AppendLine(item.Parent.ToString() + "  ---  " + item.Child.ToString());
            //}
            result.AppendLine("Parents:");
            foreach (var parentChild in PairParentChild)
            {
                if (parentChild.Child.Name==MainPerson.Name)
                {
                    if (parentChild.Parent.Name != MainPerson.Name)
                    {
                        result.AppendLine(parentChild.Parent.ToString());

                    }

                }
            }
            result.AppendLine("Children:");

            foreach (var parentChild in PairParentChild)
            {
                if (parentChild.Parent.Name == MainPerson.Name)
                {
                    if (parentChild.Child.Name != MainPerson.Name)
                    {
                        result.AppendLine(parentChild.Child.ToString());

                    }

                }
            }
            return result.ToString().TrimEnd();
        }

        public void AddMainPerson(string inputPersonalString)
        {

            string[] inputPersonalArray = inputPersonalString
                .Split(new[] { '-' })
                .ToArray();

            if (inputPersonalArray.Length == 2)
            {
                for (int i = 0; i < inputPersonalArray.Length; i++)
                {
                    if (IsBirthday(inputPersonalArray[i]))
                    {
                        this.MainPerson.AddDate(inputPersonalArray[i]);
                    }
                    else
                    {
                        this.MainPerson.AddName(inputPersonalArray[i]);
                    }
                }
            }
            else
            {
                if (IsBirthday(inputPersonalArray[0]))
                {
                    this.MainPerson.AddDate(inputPersonalArray[0]);
                }
                else
                {
                    this.MainPerson.AddName(inputPersonalArray[0]);
                }
            }
        }

        public void AddParentChildPair(string inputParetnString, string inputChildString)
        {
            IParentChildPair newParentChildPair = new ParentChildPair();

            if (IsBirthday(inputParetnString))
            {
                newParentChildPair.Parent.AddDate(inputParetnString);
            }
            else
            {
                newParentChildPair.Parent.AddName(inputParetnString);

            }

            if (IsBirthday(inputChildString))
            {
                newParentChildPair.Child.AddDate(inputChildString);
            }
            else
            {
                newParentChildPair.Child.AddName(inputChildString);

            }
            PairParentChild.Add(newParentChildPair);
        }

        public void UpdateParentChildPair(string inputName, string inputBirthday)
        {

            //if (PairParentChild.Any(x => x.Parent.Birthday == inputBirthday))
            //{
            //    int index = PairParentChild.FindIndex(x => x.Parent.Birthday == inputBirthday);
            //    PairParentChild[index].Parent.AddName(inputName);
            //}
            //if (PairParentChild.Any(x => x.Parent.Name == inputName))
            //{
            //    int index = PairParentChild.FindIndex(x => x.Parent.Name == inputName);
            //    PairParentChild[index].Parent.AddDate(inputBirthday);
            //}

            //if (PairParentChild.Any(x => x.Child.Birthday == inputBirthday))
            //{
            //    int index = PairParentChild.FindIndex(x => x.Child.Birthday == inputBirthday);
            //    PairParentChild[index].Child.AddName(inputName);
            //}
            //if (PairParentChild.Any(x => x.Child.Name == inputName))
            //{
            //    int index = PairParentChild.FindIndex(x => x.Child.Name == inputName);
            //    PairParentChild[index].Child.AddDate(inputBirthday);
            //}

            //if (MainPerson.Name == inputName)
            //{
                
            //    MainPerson.AddDate(inputBirthday);
            //}
            //if (MainPerson.Birthday == inputBirthday)
            //{

            //    MainPerson.AddName(inputName);
            //}
            IPersonStore tempPerson = new PersonStore();
            tempPerson.AddDate(inputBirthday);
            tempPerson.AddName(inputName);
            ListPerson.Add(tempPerson);

        }

        private bool IsBirthday(string input)
        {
            return Char.IsDigit(input[0]);
        }

        public void UpdateAll()
        {
            
            for (int i = 0; i < PairParentChild.Count; i++)
            {
                if (PairParentChild[i].Parent.Birthday==string.Empty)
                {
                    int index = ListPerson.FindIndex(x => x.Name == pairParentChild[i].Parent.Name);
                    PairParentChild[i].Parent.Birthday = ListPerson[index].Birthday;
                }
                if (PairParentChild[i].Parent.Name == string.Empty)
                {
                    int index = ListPerson.FindIndex(x => x.Birthday == pairParentChild[i].Parent.Birthday);
                    PairParentChild[i].Parent.Name = ListPerson[index].Name;
                }

                if (PairParentChild[i].Child.Birthday == string.Empty)
                {
                    int index = ListPerson.FindIndex(x => x.Name == pairParentChild[i].Child.Name);
                    PairParentChild[i].Child.Birthday = ListPerson[index].Birthday;
                }
                if (PairParentChild[i].Child.Name == string.Empty)
                {
                    int index = ListPerson.FindIndex(x => x.Birthday == pairParentChild[i].Child.Birthday);
                    PairParentChild[i].Child.Name = ListPerson[index].Name;
                }
            }

            if (mainPerson.Birthday==string.Empty)
            {
                int index = ListPerson.FindIndex(x => x.Name == mainPerson.Name);
                mainPerson.Birthday = ListPerson[index].Birthday;
            }
            if (mainPerson.Name == string.Empty)
            {
                int index = ListPerson.FindIndex(x => x.Birthday == mainPerson.Birthday);
                mainPerson.Name = ListPerson[index].Name;
            }

        }
        
        
    }
}
