using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Lagombi : ArmorSet
    {
        public Lagombi()
        {
            Name = "Lagombi";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = -3;
            Water.Value = 1;
            Ice.Value = 4;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new AffinitySliding(1));

            Arm = new ArmArmor(this)
                .AddSkill(new IceAttack(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Constitution(1));

            Leg = new LegArmor(this)
                .AddSkill(new CriticalEye(1));
        }
    }
}