using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BullfangoMaskS : ArmorSet
    {
        public BullfangoMaskS()
        {
            Name = "Bullfango Mask S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 36;
            Fire.Value = 0;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Bludgeoner(2))
                .AddSlot(new SmallSlot());
        }
    }
}