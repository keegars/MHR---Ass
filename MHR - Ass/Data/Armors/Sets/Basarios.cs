using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Basarios : ArmorSet
    {
        public Basarios()
        {
            Name = "Basarios";
            

            //Base values
            BaseDefense = 22;
            Fire.Value = 0;
            Water.Value = -2;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new DefenseBoost(2));

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new SpeedSharpening(1));

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedSharpening(1))
                .AddSkill(new DefenseBoost(1));

            Leg = new LegArmor(this)
                .AddSkill(new LoadShells(1))
                .AddSkill(new DefenseBoost(1));
        }
    }
}