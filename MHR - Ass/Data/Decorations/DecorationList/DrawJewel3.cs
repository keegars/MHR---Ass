using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DrawJewel3 : Decoration
    {
        public DrawJewel3()
        {
            Name = "Draw Jewel 3";
            Skill = new CriticalDraw(1);
            Type = SlotType.Large;
        }
    }
}