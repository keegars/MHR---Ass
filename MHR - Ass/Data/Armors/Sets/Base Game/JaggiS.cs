using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class JaggiS : ArmorSet
    {
        public JaggiS()
        {
            Name = "Jaggi S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 42;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MasterMounter(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}