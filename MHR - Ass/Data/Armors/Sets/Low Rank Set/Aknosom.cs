using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Aknosom : ArmorSet
    {
        public Aknosom()
        {
            Name = "Aknosom";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = 3;
            Water.Value = -3;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new FireAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new QuickSheath(1));

            Arm = new ArmArmor(this)
                .AddSkill(new FireAttack(1));

            Waist = new WaistArmor(this)
                .AddSkill(new RecoverySpeed(1));

            Leg = new LegArmor(this)
                .AddSkill(new FireAttack(1));
        }
    }
}