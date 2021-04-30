using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class GrinderJewel1 : Decoration
    {
        public GrinderJewel1()
        {
            Name = "Grinder Jewel 1";
            Skill = new SpeedSharpening(1);
            Type = SlotType.Small;
        }
    }
}