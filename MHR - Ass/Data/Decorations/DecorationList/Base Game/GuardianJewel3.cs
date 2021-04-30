using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class GuardianJewel3 : Decoration
    {
        public GuardianJewel3()
        {
            Name = "Guardian Jewel 3";
            Skill = new OffensiveGuard(1);
            Type = SlotType.Large;
        }
    }
}