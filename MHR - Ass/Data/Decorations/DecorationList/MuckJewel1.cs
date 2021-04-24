using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class MuckJewel1 : Decoration
    {
        public MuckJewel1()
        {
            Name = "Muck Jewel 1";
            Skill = new MuckResistance(1);
            Type = SlotType.Small;
        }
    }
}