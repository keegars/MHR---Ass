using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DragonJewel1 : Decoration
    {
        public DragonJewel1()
        {
            Name = "Dragon Jewel 1";
            Skill = new DragonAttack(1);
            Type = SlotType.Small;
        }
    }
}