using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class JaggiMaskX : ArmorSet
    {
        public JaggiMaskX()
        {
            Name = "Jaggi Mask X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 98;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AffinitySliding(1))
                .AddSkill(new MarathonRunner(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}