using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class CunningSpecs : ArmorSet
    {
        public CunningSpecs()
        {
            Name = "Cunning Specs";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 80;
            Fire.Value = 2;
            Water.Value = 2;
            Ice.Value = 2;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Geologist(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());
        }
    }
}