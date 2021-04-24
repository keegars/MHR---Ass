using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class PepJewel1 : Decoration
    {
        public PepJewel1()
        {
            Name = "Pep Jewel 1";
            Skill = new SleepResistance(1);
            Type = SlotType.Small;
        }
    }
}