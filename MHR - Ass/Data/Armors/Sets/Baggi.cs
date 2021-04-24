using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Baggi : ArmorSet
    {
        public Baggi()
        {
            Name = "Baggi";

            //Base values
            BaseDefense = 10;
            Fire.Value = -4;
            Water.Value = -1;
            Ice.Value = 2;
            Thunder.Value = -1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new IceAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1));

            Arm = new ArmArmor(this)
                .AddSkill(new SleepResistance(1))
                .AddSkill(new IceAttack(1));

            Waist = new WaistArmor(this)
                .AddSkill(new SleepResistance(1));

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1));
        }
    }
}