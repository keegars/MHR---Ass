using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class TenderizerJewel2 : Decoration
    {
        public TenderizerJewel2()
        {
            Name = "Tenderizer Jewel 2";
            Skill = new WeaknessExploit(1);
            Type = SlotType.Medium;
        }
    }
}