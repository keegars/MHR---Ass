using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Bishaten : ArmorSet
    {
        public Bishaten()
        {
            Name = "Bishaten";
            

            //Base values
            BaseDefense = 22;
            Fire.Value = -2;
            Water.Value = 2;
            Ice.Value = -4;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new StunResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Wide_Range(1));

            Arm = new ArmArmor(this)
                .AddSkill(new StunResistance(1));

            Waist = new WaistArmor(this)
                .AddSkill(new ItemProlonger(1));

            Leg = new LegArmor(this)
                .AddSkill(new MaximumMight(1));
        }
    }
}