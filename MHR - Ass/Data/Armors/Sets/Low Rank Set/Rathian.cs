using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Rathian : ArmorSet
    {
        public Rathian()
        {
            Name = "Rathian";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 72;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BlightResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new RecoveryUp(1));

            Arm = new ArmArmor(this)
                .AddSkill(new BlightResistance(1));

            Waist = new WaistArmor(this)
                .AddSkill(new RecoveryUp(1))
                .AddSkill(new WideRange(1));

            Leg = new LegArmor(this)
                .AddSkill(new FreeMeal(1));
        }
    }
}