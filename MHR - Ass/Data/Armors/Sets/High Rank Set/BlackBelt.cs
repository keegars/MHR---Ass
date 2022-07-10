using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BlackBelt : ArmorSet
    {
        public BlackBelt()
        {
            Name = "Black Belt";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 36;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Earplugs(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Earplugs(1));

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new RecoveryUp(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSkill(new Constitution(1));

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new FlinchFree(1));
        }
    }
}