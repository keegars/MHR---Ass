using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class NargacugaX : ArmorSet
    {
        public NargacugaX()
        {
            Name = "Nargacuga X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 116;
            Fire.Value = -2;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = -3;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new Constitution(1))
                .AddSkill(new FlinchFree(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new FlinchFree(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new EvadeExtender(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new EvadeExtender(2))
                .AddSkill(new CriticalEye(2))
                .AddSkill(new FlinchFree(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new EvadeWindow(2))
                .AddSkill(new CriticalEye(2))
                .AddSkill(new Constitution(2))
                .AddSlot(new SmallSlot());
        }
    }
}