using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class CrimsonValstrax : ArmorSet
    {
        public CrimsonValstrax()
        {
            Name = "Crimson Valstrax";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 100;
            Fire.Value = -2;
            Water.Value = -2;
            Ice.Value = -2;
            Thunder.Value = -2;
            Dragon.Value = 3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Dragonheart(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Dragonheart(1))
                .AddSkill(new Resuscitate(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Dragonheart(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Dragonheart(1))
                .AddSkill(new Resuscitate(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Dragonheart(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}