using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Pukei : ArmorSet
    {
        public Pukei()
        {
            Name = "Pukei";

            //Base values
            BaseDefense = 20;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpecialAmmoBoost(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Constitution(1));

            Arm = new ArmArmor(this)
                .AddSkill(new SpareShot(1));

            Waist = new WaistArmor(this)
                .AddSkill(new PoisonAttack(2));

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(1));
        }
    }
}