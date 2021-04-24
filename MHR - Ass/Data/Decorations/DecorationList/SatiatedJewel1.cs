
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SatiatedJewel1 : Decoration
    {
        public SatiatedJewel1()
        {
            Name = "Satiated Jewel 1";
            Skill = new FreeMeal(1);
            Type = SlotType.Small;
        }
    }
}


            