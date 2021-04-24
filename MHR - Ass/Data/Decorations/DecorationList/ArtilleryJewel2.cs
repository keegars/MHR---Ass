using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ArtilleryJewel2 : Decoration
    {
        public ArtilleryJewel2()
        {
            Name = "Artillery Jewel 2";
            Skill = new Artillery(1);
            Type = SlotType.Medium;
        }
    }
}