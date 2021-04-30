using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FurorJewel2 : Decoration
    {
        public FurorJewel2()
        {
            Name = "Furor Jewel 2";
            Skill = new Resentment(1);
            Type = SlotType.Medium;
        }
    }
}