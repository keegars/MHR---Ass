using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SoaringFeather : ArmorSet
    {
        public SoaringFeather()
        {
            Name = "Soaring Feather";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 134;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WirebugWhisperer(3))
                .AddSkill(new WallRunnerBoost(3))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}