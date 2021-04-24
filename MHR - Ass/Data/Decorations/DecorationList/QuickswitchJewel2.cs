using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class QuickswitchJewel2 : Decoration
    {
        public QuickswitchJewel2()
        {
            Name = "Quickswitch Jewel 2";
            Skill = new RapidMorph(1);
            Type = SlotType.Medium;
        }
    }
}