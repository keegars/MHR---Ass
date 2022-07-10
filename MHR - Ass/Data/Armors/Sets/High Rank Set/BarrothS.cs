using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BarrothS : ArmorSet
    {
        public BarrothS()
        {
            Name = "Barroth S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 80;
            Fire.Value = -3;
            Water.Value = -1;
            Ice.Value = -1;
            Thunder.Value = 3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new DefenseBoost(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new AffinitySliding(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new DefenseBoost(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new DefenseBoost(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}