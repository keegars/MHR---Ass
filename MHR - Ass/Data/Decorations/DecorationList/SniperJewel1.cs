using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SniperJewel1 : Decoration
    {
        public SniperJewel1()
        {
            Name = "Sniper Jewel 1";
            Skill = new Steadiness(1);
            Type = SlotType.Small;
        }
    }
}