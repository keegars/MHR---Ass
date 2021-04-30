using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class EnduringJewel2 : Decoration
    {
        public EnduringJewel2()
        {
            Name = "Enduring Jewel 2";
            Skill = new ItemProlonger(1);
            Type = SlotType.Medium;
        }
    }
}