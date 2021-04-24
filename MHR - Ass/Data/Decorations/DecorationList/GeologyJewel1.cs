using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class GeologyJewel1 : Decoration
    {
        public GeologyJewel1()
        {
            Name = "Geology Jewel 1";
            Skill = new Geologist(1);
            Type = SlotType.Small;
        }
    }
}