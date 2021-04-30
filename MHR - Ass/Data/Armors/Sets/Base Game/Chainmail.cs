using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Chainmail : ArmorSet
    {
        public Chainmail()
        {
            Name = "Chainmail";

            //Base values
            BaseDefense = 4;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Botanist(1))
                .AddSkill(new DefenseBoost(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new DefenseBoost(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Botanist(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Guard(1));

            Leg = new LegArmor(this)
                .AddSkill(new StaminaSurge(1));
        }
    }
}