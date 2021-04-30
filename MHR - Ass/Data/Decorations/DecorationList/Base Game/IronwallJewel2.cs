using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class IronwallJewel2 : Decoration
    {
        public IronwallJewel2()
        {
            Name = "Ironwall Jewel 2";
            Skill = new Guard(1);
            Type = SlotType.Medium;
        }
    }
}