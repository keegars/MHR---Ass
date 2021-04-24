using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class JaggiMaskS : ArmorSet
    {
        public JaggiMaskS()
        {
            Name = "Jaggi Mask S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 36;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AffinitySliding(1))
                .AddSlot(new MediumSlot());
        }
    }
}