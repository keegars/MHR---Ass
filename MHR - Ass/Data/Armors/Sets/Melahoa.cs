using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Melahoa : ArmorSet
    {
        public Melahoa()
        {
            Name = "Melahoa";

            //Base values
            BaseDefense = 18;
            Fire.Value = 0;
            Water.Value = 1;
            Ice.Value = 0;
            Thunder.Value = 3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ParalysisResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new RecoveryUp(1));

            Arm = new ArmArmor(this)
                .AddSkill(new ParalysisResistance(1))
                .AddSkill(new RecoveryUp(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new RecoverySpeed(1));

            Leg = new LegArmor(this)
                .AddSkill(new RecoverySpeed(2));
        }
    }
}