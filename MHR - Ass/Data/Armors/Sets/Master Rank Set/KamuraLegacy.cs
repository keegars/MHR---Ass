using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KamuraLegacy : ArmorSet
    {
        public KamuraLegacy()
        {
            Name = "Kamura Legacy";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 92;
            Fire.Value = 2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new DivineBlessing(2))
                .AddSkill(new Resuscitate(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WirebugWhisperer(2))
                .AddSkill(new WallRunner(2))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new Heroics(2))
                .AddSkill(new DivineBlessing(2))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WirebugWhisperer(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WallRunner(2))
                .AddSkill(new Resuscitate(2))
                .AddSkill(new AffinitySliding(2))
                .AddSlot(new MediumSlot());
        }
    }
}