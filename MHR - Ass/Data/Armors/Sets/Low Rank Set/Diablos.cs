using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Diablos : ArmorSet
    {
        public Diablos()
        {
            Name = "Diablos";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 72;
            Fire.Value = 3;
            Water.Value = -1;
            Ice.Value = -3;
            Thunder.Value = -1;
            Dragon.Value = -1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new StaminaSurge(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(1));

            Arm = new ArmArmor(this)
                .AddSkill(new OffensiveGuard(1));

            Waist = new WaistArmor(this)
                .AddSkill(new StaminaSurge(1));

            Leg = new LegArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new OffensiveGuard(1));
        }
    }
}