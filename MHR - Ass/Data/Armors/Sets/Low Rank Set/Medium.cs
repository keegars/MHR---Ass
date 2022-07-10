using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Medium : ArmorSet
    {
        public Medium()
        {
            Name = "Medium";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpeedEating(1))
                .AddSkill(new FreeMeal(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new WideRange(1));

            Arm = new ArmArmor(this)
                .AddSkill(new WideRange(1));

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedEating(1));

            Leg = new LegArmor(this)
                .AddSkill(new WideRange(1));
        }
    }
}