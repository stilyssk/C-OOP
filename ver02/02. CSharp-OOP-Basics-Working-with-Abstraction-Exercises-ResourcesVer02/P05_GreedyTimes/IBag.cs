using System.Collections.Generic;

namespace P05_GreedyTimes
{
    public interface IBag
    {
        List<ICash> Cash { get; set; }
        List<IGem> Gem { get; set; }
        long Gold { get; set; }
        long OcupateBag { get; set; }

        void AddCash(string name, long count);
        void AddGem(string name, long count);
        string PrintResult();
    }
}