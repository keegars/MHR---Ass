using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Anjanath : ArmorSet
    {
        public Anjanath()
        {
            Name = "Anjanath";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 70;
            Fire.Value = 3;
            Water.Value = -3;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new MarathonRunner(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Slugger(1))
                .AddSkill(new AttackBoost(1));

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(2));

            Leg = new LegArmor(this)
                .AddSkill(new MarathonRunner(1));
        }
    }
}