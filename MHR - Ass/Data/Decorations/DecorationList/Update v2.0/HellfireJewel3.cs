using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HellfireJewel3 : Decoration
    {
        public HellfireJewel3()
        {
            Name = "Hellfire Jewel 3";
            Skill = new HellfireCloak(1);
            Type = SlotType.Large;
        }
    }
}