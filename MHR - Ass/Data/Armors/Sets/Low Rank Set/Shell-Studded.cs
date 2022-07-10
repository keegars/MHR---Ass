using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ShellStudded : ArmorSet
    {
        public ShellStudded()
        {
            Name = "Shell-Studded";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 32;
            Fire.Value = 0;
            Water.Value = 2;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WaterResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new ReloadSpeed(1));

            Arm = new ArmArmor(this)
                .AddSkill(new RecoilDown(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Ballistics(1));

            Leg = new LegArmor(this)
                .AddSkill(new SpreadUp(1));
        }
    }
}