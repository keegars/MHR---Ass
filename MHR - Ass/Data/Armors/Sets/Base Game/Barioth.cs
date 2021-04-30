using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Barioth : ArmorSet
    {
        public Barioth()
        {
            Name = "Barioth";

            //Base values
            BaseDefense = 20;
            Fire.Value = -5;
            Water.Value = 0;
            Ice.Value = 3;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalDraw(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new QuickSheath(1));

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalEye(1));

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalEye(2));

            Leg = new LegArmor(this)
                .AddSkill(new QuickSheath(1));
        }
    }
}