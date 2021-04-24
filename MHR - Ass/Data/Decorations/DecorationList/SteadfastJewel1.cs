using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SteadfastJewel1 : Decoration
    {
        public SteadfastJewel1()
        {
            Name = "Steadfast Jewel 1";
            Skill = new StunResistance(1);
            Type = SlotType.Small;
        }
    }
}