using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Kadachi : ArmorSet
    {
        public Kadachi()
        {
            Name = "Kadachi";
            

            //Base values
            BaseDefense = 20;
            Fire.Value = 0;
            Water.Value = -3;
            Ice.Value = 0;
            Thunder.Value = 3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new JumpMaster(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalEye(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(1));

            Waist = new WaistArmor(this)
                .AddSkill(new ThunderAttack(2));

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(1))
                .AddSkill(new CriticalEye(1));
        }
    }
}