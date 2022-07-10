using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GargwaX : ArmorSet
    {
        public GargwaX()
        {
            Name = "Gargwa X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 98;
            Fire.Value = -3;
            Water.Value = -2;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new LeapOfFaith(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}