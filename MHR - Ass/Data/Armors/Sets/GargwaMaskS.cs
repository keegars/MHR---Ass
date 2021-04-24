using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GargwaMaskS : ArmorSet
    {
        public GargwaMaskS()
        {
            Name = "Gargwa Mask S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 54;
            Fire.Value = -3;
            Water.Value = -2;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new LeapofFaith(1))
                .AddSkill(new GoodLuck(1));
        }
    }
}