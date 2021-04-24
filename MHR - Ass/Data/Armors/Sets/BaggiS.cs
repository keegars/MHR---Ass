using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BaggiS : ArmorSet
    {
        public BaggiS()
        {
            Name = "Baggi S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 36;
            Fire.Value = -4;
            Water.Value = -1;
            Ice.Value = 2;
            Thunder.Value = -1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new IceAttack(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new IceAttack(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new SleepResistance(2))
                .AddSkill(new IceAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new SleepResistance(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}