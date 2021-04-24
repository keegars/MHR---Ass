using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Bone : ArmorSet
    {
        public Bone()
        {
            Name = "Bone";
            

            //Base values
            BaseDefense = 10;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Partbreaker(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new StaminaThief(1));

            Arm = new ArmArmor(this)
                .AddSkill(new StaminaThief(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Focus(1));

            Leg = new LegArmor(this)
                .AddSkill(new MuckResistance(1));
        }
    }
}