using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class MakluvaX : ArmorSet
    {
        public MakluvaX()
        {
            Name = "Makluva X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 112;
            Fire.Value = 1;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SleepResistance(2))
                .AddSkill(new SpeedEating(2))
                .AddSkill(new StaminaSurge(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WaterAttack(3))
                .AddSkill(new SpeedEating(3))
                .AddSkill(new StaminaSurge(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new BubblyDance(1))
                .AddSkill(new LeapOfFaith(1))
                .AddSkill(new Resuscitate(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SleepResistance(1))
                .AddSkill(new WaterAttack(1))
                .AddSkill(new Resuscitate(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new BubblyDance(2))
                .AddSkill(new SpeedEating(2))
                .AddSkill(new Resuscitate(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}