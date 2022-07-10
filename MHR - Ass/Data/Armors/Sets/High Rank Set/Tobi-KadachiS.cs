using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class TobiKadachiS : ArmorSet
    {
        public TobiKadachiS()
        {
            Name = "Tobi-Kadachi S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 78;
            Fire.Value = 0;
            Water.Value = -3;
            Ice.Value = 0;
            Thunder.Value = 3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new JumpMaster(1))
                .AddSkill(new Constitution(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new MindsEye(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(3))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new MindsEye(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}