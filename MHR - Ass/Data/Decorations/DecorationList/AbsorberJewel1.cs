using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class AbsorberJewel1 : Decoration
    {
        public AbsorberJewel1()
        {
            Name = "Absorber Jewel 1";
            Skill = new RecoilDown(1);
            Type = SlotType.Small;
        }
    }
}