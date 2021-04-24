using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class PreciseJewel2 : Decoration
    {
        public PreciseJewel2()
        {
            Name = "Precise Jewel 2";
            Skill = new AimBooster(1);
            Type = SlotType.Medium;
        }
    }
}