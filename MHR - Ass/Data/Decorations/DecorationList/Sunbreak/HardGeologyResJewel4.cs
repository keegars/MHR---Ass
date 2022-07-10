using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardGeologyResJewel4 : Decoration
    {
        public HardGeologyResJewel4()
        {
            Name = "Hard Geology Res Jewel 4";
            Skill = new Geologist(3);
            Type = SlotType.ExtraLarge;
        }
    }
}