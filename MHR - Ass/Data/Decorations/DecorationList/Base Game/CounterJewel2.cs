using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class CounterJewel2 : Decoration
    {
        public CounterJewel2()
        {
            Name = "Counter Jewel 2";
            Skill = new Counterstrike(1);
            Type = SlotType.Medium;
        }
    }
}