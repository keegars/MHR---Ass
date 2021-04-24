using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SliderJewel1 : Decoration
    {
        public SliderJewel1()
        {
            Name = "Slider Jewel 1";
            Skill = new AffinitySliding(1);
            Type = SlotType.Small;
        }
    }
}