using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class MedicineJewel2 : Decoration
    {
        public MedicineJewel2()
        {
            Name = "Medicine Jewel 2";
            Skill = new RecoveryUp(1);
            Type = SlotType.Medium;
        }
    }
}