using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FireResJewel1 : Decoration
    {
        public FireResJewel1()
        {
            Name = "Fire Res Jewel 1";
            Skill = new FireResistance(1);
            Type = SlotType.Small;
        }
    }
}