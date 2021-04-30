using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class LeapJewel3 : Decoration
    {
        public LeapJewel3()
        {
            Name = "Leap Jewel 3";
            Skill = new JumpMaster(1);
            Type = SlotType.Large;
        }
    }
}