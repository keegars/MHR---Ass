using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BoltJewel1 : Decoration
    {
        public BoltJewel1()
        {
            Name = "Bolt Jewel 1";
            Skill = new ThunderAttack(1);
            Type = SlotType.Small;
        }
    }
}