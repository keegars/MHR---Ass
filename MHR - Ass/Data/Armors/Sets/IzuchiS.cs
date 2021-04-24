using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class IzuchiS : ArmorSet
    {
        public IzuchiS()
        {
            Name = "Izuchi S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 36;
            Fire.Value = 2;
            Water.Value = -1;
            Ice.Value = 0;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new RecoverySpeed(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}