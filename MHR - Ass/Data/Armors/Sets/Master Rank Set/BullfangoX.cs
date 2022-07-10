using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BullfangoX : ArmorSet
    {
        public BullfangoX()
        {
            Name = "Bullfango X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 98;
            Fire.Value = 0;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Diversion(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new LargeSlot());
        }
    }
}