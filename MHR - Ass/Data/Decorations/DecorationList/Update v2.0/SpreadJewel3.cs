using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SpreadJewel3 : Decoration
    {
        public SpreadJewel3()
        {
            Name = "Spread Jewel 3";
            Skill = new SpreadUp(1);
            Type = SlotType.Large;
        }
    }
}