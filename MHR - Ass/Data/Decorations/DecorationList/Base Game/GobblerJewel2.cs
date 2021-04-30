using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class GobblerJewel2 : Decoration
    {
        public GobblerJewel2()
        {
            Name = "Gobbler Jewel 2";
            Skill = new SpeedEating(1);
            Type = SlotType.Medium;
        }
    }
}