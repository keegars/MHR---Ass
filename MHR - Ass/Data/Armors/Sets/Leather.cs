using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Leather : ArmorSet
    {
        public Leather()
        {
            Name = "Leather";
            

            //Base values
            BaseDefense = 1;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new HungerResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new Botanist(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Geologist(1));

            Waist = new WaistArmor(this)
                .AddSkill(new RecoveryUp(1));

            Leg = new LegArmor(this)
                .AddSkill(new Geologist(1));
        }
    }
}