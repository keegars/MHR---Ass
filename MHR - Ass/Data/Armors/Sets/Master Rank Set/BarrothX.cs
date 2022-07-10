using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BarrothX : ArmorSet
    {
        public BarrothX()
        {
            Name = "Barroth X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 106;
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
                .AddSkill(new SpreadUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new DefenseBoost(2))
                .AddSkill(new MuckResistance(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new AffinitySliding(2))
                .AddSkill(new OffensiveGuard(2))
                .AddSkill(new SpreadUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Guard(3))
                .AddSkill(new DefenseBoost(3))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new DefenseBoost(2))
                .AddSkill(new OffensiveGuard(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}