using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BlazeJewel1 : Decoration
    {
        public BlazeJewel1()
        {
            Name = "Blaze Jewel 1";
            Skill = new FireAttack(1);
            Type = SlotType.Small;
        }
    }
}