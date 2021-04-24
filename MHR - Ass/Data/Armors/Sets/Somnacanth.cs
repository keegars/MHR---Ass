using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Somnacanth : ArmorSet
    {
        public Somnacanth()
        {
            Name = "Somnacanth";
            

            //Base values
            BaseDefense = 22;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SleepAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new ItemProlonger(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Bombardier(1))
                .AddSkill(new DivineBlessing(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Bombardier(1));

            Leg = new LegArmor(this)
                .AddSkill(new DivineBlessing(1));
        }
    }
}