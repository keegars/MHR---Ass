using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BlackLeather : ArmorSet
    {
        public BlackLeather()
        {
            Name = "Black Leather";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 80;
            Fire.Value = 2;
            Water.Value = 2;
            Ice.Value = 2;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Leg = new LegArmor(this)
                .AddSkill(new WirebugWhisperer(2))
                .AddSlot(new LargeSlot());
        }
    }
}