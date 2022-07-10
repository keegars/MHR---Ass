using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Skull : ArmorSet
    {
        public Skull()
        {
            Name = "Skull";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 70;
            Fire.Value = -3;
            Water.Value = -3;
            Ice.Value = -3;
            Thunder.Value = -3;
            Dragon.Value = 4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Fortify(1));
        }
    }
}