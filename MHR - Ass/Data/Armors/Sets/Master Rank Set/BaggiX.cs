using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BaggiX : ArmorSet
    {
        public BaggiX()
        {
            Name = "Baggi X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 98;
            Fire.Value = -4;
            Water.Value = -1;
            Ice.Value = 2;
            Thunder.Value = -1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SleepAttack(1))
                .AddSkill(new IceResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new SleepAttack(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new SleepResistance(2))
                .AddSkill(new SleepAttack(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new SleepResistance(2))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new IceResistance(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}