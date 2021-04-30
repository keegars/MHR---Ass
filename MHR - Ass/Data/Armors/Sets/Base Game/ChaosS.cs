using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ChaosS : ArmorSet
    {
        public ChaosS()
        {
            Name = "Chaos S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 40;
            Fire.Value = 2;
            Water.Value = -2;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Mushroomancer(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Mushroomancer(2));
        }
    }
}