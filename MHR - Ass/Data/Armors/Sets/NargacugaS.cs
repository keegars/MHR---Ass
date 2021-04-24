using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class NargacugaS : ArmorSet
    {
        public NargacugaS()
        {
            Name = "Nargacuga S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 60;
            Fire.Value = -2;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new EvadeExtender(2))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new EvadeWindow(2))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot());
        }
    }
}