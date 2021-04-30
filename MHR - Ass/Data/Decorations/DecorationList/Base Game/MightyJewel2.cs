using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class MightyJewel2 : Decoration
    {
        public MightyJewel2()
        {
            Name = "Mighty Jewel 2";
            Skill = new MaximumMight(1);
            Type = SlotType.Medium;
        }
    }
}