using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class FlameSeal : ArmorSet
    {
        public FlameSeal()
        {
            Name = "FlameSeal";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 56;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(4));
        }
    }
}