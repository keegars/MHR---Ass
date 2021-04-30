using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FrostJewel1 : Decoration
    {
        public FrostJewel1()
        {
            Name = "Frost Jewel 1";
            Skill = new IceAttack(1);
            Type = SlotType.Small;
        }
    }
}