using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Chaos : ArmorSet
    {
        public Chaos()
        {
            Name = "Chaos";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 64;
            Fire.Value = 2;
            Water.Value = -2;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Mushroomancer(1));

            Torso = new TorsoArmor(this);
        }
    }
}