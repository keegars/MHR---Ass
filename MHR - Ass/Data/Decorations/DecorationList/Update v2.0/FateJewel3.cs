using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FateJewel3 : Decoration
    {
        public FateJewel3()
        {
            Name = "Fate Jewel 3";
            Skill = new GoodLuck(1);
            Type = SlotType.Large;
        }
    }
}