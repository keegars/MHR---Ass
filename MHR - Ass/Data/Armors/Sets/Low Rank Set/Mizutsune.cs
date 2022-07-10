using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Mizutsune : ArmorSet
    {
        public Mizutsune()
        {
            Name = "Mizutsune";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 70;
            Fire.Value = 0;
            Water.Value = 2;
            Ice.Value = 1;
            Thunder.Value = -3;
            Dragon.Value = -1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WaterAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new BubblyDance(1))
                .AddSkill(new WaterAttack(1));

            Arm = new ArmArmor(this)
                .AddSkill(new WaterAttack(1))
                .AddSkill(new FreeMeal(1));

            Waist = new WaistArmor(this)
                .AddSkill(new FreeMeal(1));

            Leg = new LegArmor(this)
                .AddSkill(new BubblyDance(1));
        }
    }
}