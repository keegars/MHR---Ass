using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Malzeno : ArmorSet
    {
        public Malzeno()
        {
            Name = "Malzeno";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 138;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 3;
            Thunder.Value = -1;
            Dragon.Value = -4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BloodRite(1))
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new BloodRite(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSkill(new BlightResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new EvadeExtender(1))
                .AddSkill(new BlightResistance(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new BloodRite(1))
                .AddSkill(new EvadeExtender(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PeakPerformance(2))
                .AddSkill(new WeaknessExploit(2))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}