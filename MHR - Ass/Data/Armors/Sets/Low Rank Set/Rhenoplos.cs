using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Rhenoplos : ArmorSet
    {
        public Rhenoplos()
        {
            Name = "Rhenoplos";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 66;
            Fire.Value = 2;
            Water.Value = 0;
            Ice.Value = -2;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PierceUp(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Artillery(1))
                .AddSkill(new StunResistance(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Artillery(1));

            Waist = new WaistArmor(this)
                .AddSkill(new TremorResistance(1));

            Leg = new LegArmor(this)
                .AddSkill(new TremorResistance(1));
        }
    }
}