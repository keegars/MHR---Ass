using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Sailor : ArmorSet
    {
        public Sailor()
        {
            Name = "Sailor";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 138;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpiribirdsCall(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new EvadeWindow(4))
                .AddSkill(new WirebugWhisperer(4))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Focus(3))
                .AddSkill(new WirebugWhisperer(3))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ProtectivePolish(3))
                .AddSkill(new WirebugWhisperer(3))
                .AddSkill(new Ballistics(3))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MarathonRunner(3))
                .AddSkill(new EvadeWindow(3))
                .AddSlot(new LargeSlot());
        }
    }
}