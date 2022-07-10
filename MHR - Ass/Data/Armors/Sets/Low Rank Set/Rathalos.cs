using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Rathalos : ArmorSet
    {
        public Rathalos()
        {
            Name = "Rathalos";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 72;
            Fire.Value = 4;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = -4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new FireAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Partbreaker(1))
                .AddSkill(new Windproof(1));

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(1));

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Windproof(1));

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new FireAttack(1));
        }
    }
}