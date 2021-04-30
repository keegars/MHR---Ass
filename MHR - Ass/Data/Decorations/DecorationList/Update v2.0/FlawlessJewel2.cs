using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FlawlessJewel2 : Decoration
    {
        public FlawlessJewel2()
        {
            Name = "Flawless Jewel 2";
            Skill = new PeakPerformance(1);
            Type = SlotType.Medium;
        }
    }
}