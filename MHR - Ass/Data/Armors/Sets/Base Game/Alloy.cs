using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Alloy : ArmorSet
    {
        public Alloy()
        {
            Name = "Alloy";

            //Base values
            BaseDefense = 10;
            Fire.Value = -1;
            Water.Value = 0;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WaterAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new SpeedSharpening(1));

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalEye(1));

            Waist = new WaistArmor(this)
                .AddSkill(new WaterAttack(1))
                .AddSkill(new CriticalEye(1));

            Leg = new LegArmor(this)
                .AddSkill(new SpeedSharpening(1));
        }
    }
}