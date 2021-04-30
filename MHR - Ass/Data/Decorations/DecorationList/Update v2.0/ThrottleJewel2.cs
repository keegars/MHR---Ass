using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ThrottleJewel2 : Decoration
    {
        public ThrottleJewel2()
        {
            Name = "Throttle Jewel 2";
            Skill = new LatentPower(1);
            Type = SlotType.Medium;
        }
    }
}