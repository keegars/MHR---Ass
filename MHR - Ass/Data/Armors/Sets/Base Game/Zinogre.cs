using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Zinogre : ArmorSet
    {
        public Zinogre()
        {
            Name = "Zinogre";

            //Base values
            BaseDefense = 28;
            Fire.Value = 0;
            Water.Value = -1;
            Ice.Value = -4;
            Thunder.Value = 4;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new CriticalEye(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new CriticalEye(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(1));

            Waist = new WaistArmor(this)
                .AddSkill(new LatentPower(1));

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(2));
        }
    }
}