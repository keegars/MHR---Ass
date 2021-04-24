using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Kamura : ArmorSet
    {
        public Kamura()
        {
            Name = "Kamura";
            

            //Base values
            BaseDefense = 1;
            Fire.Value = 1;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new DivineBlessing(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new WirebugWhisperer(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Heroics(1));

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalEye(1));

            Leg = new LegArmor(this)
                .AddSkill(new WallRunner(1));
        }
    }
}