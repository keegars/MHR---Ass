using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class MakluvaS : ArmorSet
    {
        public MakluvaS()
        {
            Name = "Makluva S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 52;
            Fire.Value = 1;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SleepResistance(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WaterAttack(3))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new BubblyDance(1))
                .AddSkill(new LeapofFaith(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SleepResistance(1))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new BubblyDance(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}