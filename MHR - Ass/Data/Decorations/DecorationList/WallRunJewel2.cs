using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class WallRunJewel2 : Decoration
    {
        public WallRunJewel2()
        {
            Name = "Wall Run Jewel 2";
            Skill = new WallRunner(1);
            Type = SlotType.Medium;
        }
    }
}