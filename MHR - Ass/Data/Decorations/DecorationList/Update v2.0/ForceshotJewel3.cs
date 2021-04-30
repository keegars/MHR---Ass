using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ForceshotJewel3 : Decoration
    {
        public ForceshotJewel3()
        {
            Name = "Forceshot Jewel 3";
            Skill = new NormalRapidUp(1);
            Type = SlotType.Large;
        }
    }
}