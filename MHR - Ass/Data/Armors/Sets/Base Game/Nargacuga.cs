using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Nargacuga : ArmorSet
    {
        public Nargacuga()
        {
            Name = "Nargacuga";

            //Base values
            BaseDefense = 26;
            Fire.Value = -2;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new EvadeWindow(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalEye(1));

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new EvadeExtender(1));

            Waist = new WaistArmor(this)
                .AddSkill(new EvadeExtender(1));

            Leg = new LegArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new CriticalEye(1));
        }
    }
}