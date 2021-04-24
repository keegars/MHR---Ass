using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FortitudeJewel2 : Decoration
    {
        public FortitudeJewel2()
        {
            Name = "Fortitude Jewel 2";
            Skill = new Fortify(1);
            Type = SlotType.Medium;
        }
    }
}