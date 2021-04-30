using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HandicraftJewel3 : Decoration
    {
        public HandicraftJewel3()
        {
            Name = "Handicraft Jewel 3";
            Skill = new Handicraft(1);
            Type = SlotType.Large;
        }
    }
}