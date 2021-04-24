using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class TrueshotJewel2 : Decoration
    {
        public TrueshotJewel2()
        {
            Name = "Trueshot Jewel 2";
            Skill = new SpecialAmmoBoost(1);
            Type = SlotType.Medium;
        }
    }
}