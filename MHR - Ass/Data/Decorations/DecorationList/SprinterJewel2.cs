using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SprinterJewel2 : Decoration
    {
        public SprinterJewel2()
        {
            Name = "Sprinter Jewel 2";
            Skill = new MarathonRunner(1);
            Type = SlotType.Medium;
        }
    }
}