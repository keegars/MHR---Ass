using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SharpJewel2 : Decoration
    {
        public SharpJewel2()
        {
            Name = "Sharp Jewel 2";
            Skill = new ProtectivePolish(1);
            Type = SlotType.Medium;
        }
    }
}