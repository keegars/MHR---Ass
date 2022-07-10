using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Izuchi : ArmorSet
    {
        public Izuchi()
        {
            Name = "Izuchi";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = 2;
            Water.Value = -1;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSkill(new RecoverySpeed(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(1));

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalEye(1));

            Leg = new LegArmor(this)
                .AddSkill(new RecoverySpeed(1));
        }
    }
}