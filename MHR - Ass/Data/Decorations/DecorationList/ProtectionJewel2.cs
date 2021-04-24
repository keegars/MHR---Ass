
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ProtectionJewel2 : Decoration
    {
        public ProtectionJewel2()
        {
            Name = "Protection Jewel 2";
            Skill = new DivineBlessing(1);
            Type = SlotType.Medium;
        }
    }
}


            