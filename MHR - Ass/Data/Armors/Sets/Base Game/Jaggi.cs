using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Jaggi : ArmorSet
    {
        public Jaggi()
        {
            Name = "Jaggi";

            //Base values
            BaseDefense = 14;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(1));

            Leg = new LegArmor(this)
                .AddSkill(new MasterMounter(1));
        }
    }
}