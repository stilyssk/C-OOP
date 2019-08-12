namespace P07_FamilyTree
{
    public interface IParentChildPair
    {
        IPersonStore Child { get; set; }
        IPersonStore Parent { get; set; }
    }
}