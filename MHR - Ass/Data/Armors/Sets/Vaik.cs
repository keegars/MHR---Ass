using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Vaik : ArmorSet
    {
        public Vaik()
        {
            Name = "Vaik";

            //Base values
            BaseDefense = 18;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = -1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AmmoUp(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Steadiness(1));

            Arm = new ArmArmor(this)
                .AddSkill(new NormalRapidUp(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Steadiness(1));

            Leg = new LegArmor(this)
                .AddSkill(new AmmoUp(1));
        }
    }
}