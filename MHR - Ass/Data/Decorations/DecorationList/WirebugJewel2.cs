
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class WirebugJewel2 : Decoration
    {
        public WirebugJewel2()
        {
            Name = "Wirebug Jewel 2";
            Skill = new WirebugWhisperer(1);
            Type = SlotType.Medium;
        }
    }
}


            