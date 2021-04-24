using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class IceResJewel1 : Decoration
    {
        public IceResJewel1()
        {
            Name = "Ice Res Jewel 1";
            Skill = new IceResistance(1);
            Type = SlotType.Small;
        }
    }
}