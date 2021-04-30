using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FungiformJewel3 : Decoration
    {
        public FungiformJewel3()
        {
            Name = "Fungiform Jewel 3";
            Skill = new Mushroomancer(1);
            Type = SlotType.Large;
        }
    }
}