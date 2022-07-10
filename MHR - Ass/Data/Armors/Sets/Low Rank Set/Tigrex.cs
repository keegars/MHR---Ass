using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Tigrex : ArmorSet
    {
        public Tigrex()
        {
            Name = "Tigrex";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 72;
            Fire.Value = 2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSkill(new SpeedEating(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSkill(new Bludgeoner(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Bludgeoner(2));

            Waist = new WaistArmor(this)
                .AddSkill(new Earplugs(1));

            Leg = new LegArmor(this)
                .AddSkill(new SpeedEating(1));
        }
    }
}