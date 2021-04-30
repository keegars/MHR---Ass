using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SalvoJewel3 : Decoration
    {
        public SalvoJewel3()
        {
            Name = "Salvo Jewel 3";
            Skill = new RapidFireUp(1);
            Type = SlotType.Large;
        }
    }
}