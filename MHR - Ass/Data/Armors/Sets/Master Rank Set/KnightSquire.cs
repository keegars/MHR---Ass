using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KnightSquire : ArmorSet
    {
        public KnightSquire()
        {
            Name = "Knight Squire";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new SpeedEating(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RazorSharp(1))
                .AddSkill(new FlinchFree(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new GuardUp(3))
                .AddSkill(new FlinchFree(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WeaknessExploit(1))
                .AddSkill(new CriticalBoost(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RazorSharp(2))
                .AddSkill(new CriticalBoost(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}