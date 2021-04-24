using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Ingot : ArmorSet
    {
        public Ingot()
        {
            Name = "Ingot";

            //Base values
            BaseDefense = 18;
            Fire.Value = -1;
            Water.Value = -1;
            Ice.Value = 0;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Windproof(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Windproof(1));

            Arm = new ArmArmor(this)
                .AddSkill(new ThunderAttack(2));

            Waist = new WaistArmor(this)
                .AddSkill(new PowerProlonger(1));

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new CriticalEye(1));
        }
    }
}