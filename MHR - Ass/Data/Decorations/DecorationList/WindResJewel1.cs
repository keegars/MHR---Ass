
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class WindResJewel1 : Decoration
    {
        public WindResJewel1()
        {
            Name = "Wind Res Jewel 1";
            Skill = new Windproof(1);
            Type = SlotType.Small;
        }
    }
}


            