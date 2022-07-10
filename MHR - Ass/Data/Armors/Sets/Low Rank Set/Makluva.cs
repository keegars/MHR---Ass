using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Makluva : ArmorSet
    {
        public Makluva()
        {
            Name = "Makluva";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = 1;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SleepResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new WaterAttack(2));

            Arm = new ArmArmor(this)
                .AddSkill(new LeapOfFaith(1));

            Waist = new WaistArmor(this)
                .AddSkill(new SleepResistance(1));

            Leg = new LegArmor(this)
                .AddSkill(new SpeedEating(1));
        }
    }
}