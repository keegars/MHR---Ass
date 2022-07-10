using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class JyuratodusX : ArmorSet
    {
        public JyuratodusX()
        {
            Name = "Jyuratodus X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new OffensiveGuard(1))
                .AddSkill(new EvadeExtender(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new PowerProlonger(2))
                .AddSkill(new EvadeExtender(2))
                .AddSkill(new Resentment(2))
                .AddSkill(new TuneUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Resentment(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new GuardUp(1))
                .AddSkill(new PowerProlonger(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new GuardUp(2))
                .AddSkill(new Resentment(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}