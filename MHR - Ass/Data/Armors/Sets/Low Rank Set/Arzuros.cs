using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Arzuros : ArmorSet
    {
        public Arzuros()
        {
            Name = "Arzuros";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Fortify(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Counterstrike(1));

            Arm = new ArmArmor(this)
                .AddSkill(new DefenseBoost(1));

            Waist = new WaistArmor(this)
                .AddSkill(new DefenseBoost(1));

            Leg = new LegArmor(this)
                .AddSkill(new Diversion(1));
        }
    }
}