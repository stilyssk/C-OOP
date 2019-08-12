namespace P07_FamilyTree
{
    public interface IPersonStore
    {
        string Birthday { get; set; }
        string Name { get; set; }
        void AddDate(string inputStringDate);
        void AddName(string inputStringDate);
        string ToString();
    }
}