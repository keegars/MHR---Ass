using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Barroth : ArmorSet
    {
        public Barroth()
        {
            Name = "Barroth";
            

            //Base values
            BaseDefense = 18;
            Fire.Value = -3;
            Water.Value = -1;
            Ice.Value = -1;
            Thunder.Value = 3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new DefenseBoost(1));

            Arm = new ArmArmor(this)
                .AddSkill(new AffinitySliding(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Guard(1));

            Leg = new LegArmor(this)
                .AddSkill(new Guard(1));
        }
    }
}