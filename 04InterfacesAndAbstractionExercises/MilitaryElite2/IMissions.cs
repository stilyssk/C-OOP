namespace MilitaryElite2
{
    public interface IMissions
    {
        string CondeName { get; set; }
        string States { get; set; }

        bool CompleteMission();
    }
}