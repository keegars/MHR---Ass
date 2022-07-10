using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RoyalLudroth : ArmorSet
    {
        public RoyalLudroth()
        {
            Name = "Royal Ludroth";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 70;
            Fire.Value = -3;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WaterAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new StaminaSurge(1));

            Arm = new ArmArmor(this)
                .AddSkill(new MarathonRunner(1));

            Waist = new WaistArmor(this)
                .AddSkill(new WaterAttack(2));

            Leg = new LegArmor(this)
                .AddSkill(new PowerProlonger(1));
        }
    }
}