using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardSatiatedResJewel4 : Decoration
    {
        public HardSatiatedResJewel4()
        {
            Name = "Hard Satiated Res Jewel 4";
            Skill = new FreeMeal(3);
            Type = SlotType.ExtraLarge;
        }
    }
}