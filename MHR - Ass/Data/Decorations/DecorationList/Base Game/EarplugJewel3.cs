using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class EarplugJewel3 : Decoration
    {
        public EarplugJewel3()
        {
            Name = "Earplug Jewel 3";
            Skill = new Earplugs(1);
            Type = SlotType.Large;
        }
    }
}