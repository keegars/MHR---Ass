using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FootingJewel2 : Decoration
    {
        public FootingJewel2()
        {
            Name = "Footing Jewel 2";
            Skill = new TremorResistance(1);
            Type = SlotType.Medium;
        }
    }
}