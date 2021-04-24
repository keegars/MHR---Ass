using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Skalda : ArmorSet
    {
        public Skalda()
        {
            Name = "Skalda/Spio";

            //Base values
            BaseDefense = 12;
            Fire.Value = 3;
            Water.Value = -1;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PoisonAttack(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalEye(1));

            Arm = new ArmArmor(this)
                .AddSkill(new PoisonResistance(1));

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalEye(1));

            Leg = new LegArmor(this)
                .AddSkill(new PoisonResistance(1));
        }
    }
}