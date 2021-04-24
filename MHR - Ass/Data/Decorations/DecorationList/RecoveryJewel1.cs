
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class RecoveryJewel1 : Decoration
    {
        public RecoveryJewel1()
        {
            Name = "Recovery Jewel 1";
            Skill = new RecoverySpeed(1);
            Type = SlotType.Small;
        }
    }
}


            