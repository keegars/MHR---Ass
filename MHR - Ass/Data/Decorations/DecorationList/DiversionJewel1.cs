using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DiversionJewel1 : Decoration
    {
        public DiversionJewel1()
        {
            Name = "Diversion Jewel 1";
            Skill = new Diversion(1);
            Type = SlotType.Small;
        }
    }
}