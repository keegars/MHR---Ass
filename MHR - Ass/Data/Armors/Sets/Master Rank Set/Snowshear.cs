using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Snowshear : ArmorSet
    {
        public Snowshear()
        {
            Name = "Snowshear";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 128;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Grinder_S(1))
                .AddSkill(new StaminaThief(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new TremorResistance(1))
                .AddSkill(new StaminaThief(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new RecoverySpeed(3))
                .AddSkill(new LatentPower(3))
                .AddSkill(new AttackBoost(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new TremorResistance(2))
                .AddSkill(new StaminaThief(2))
                .AddSkill(new AttackBoost(2))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Grinder_S(1))
                .AddSkill(new LatentPower(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new MediumSlot());
        }
    }
}