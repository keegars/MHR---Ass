using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BullfangoMask : ArmorSet
    {
        public BullfangoMask()
        {
            Name = "Bullfango Mask";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 64;
            Fire.Value = 0;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Bludgeoner(1));
        }
    }
}