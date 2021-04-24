using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DiveJewel1 : Decoration
    {
        public DiveJewel1()
        {
            Name = "Dive Jewel 1";
            Skill = new LeapofFaith(1);
            Type = SlotType.Small;
        }
    }
}