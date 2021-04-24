using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Brigade : ArmorSet
    {
        public Brigade()
        {
            Name = "Brigade";

            //Base values
            BaseDefense = 26;
            Fire.Value = 1;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Botanist(2));

            Torso = new TorsoArmor(this)
                .AddSkill(new BlightResistance(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Geologist(2));

            Waist = new WaistArmor(this)
                .AddSkill(new BlightResistance(1));

            Leg = new LegArmor(this)
                .AddSkill(new Wide_Range(1));
        }
    }
}