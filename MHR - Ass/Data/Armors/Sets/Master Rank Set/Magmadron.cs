using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Magmadron : ArmorSet
    {
        public Magmadron()
        {
            Name = "Magmadron";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 128;
            Fire.Value = 2;
            Water.Value = -2;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Resentment(1))
                .AddSkill(new Heroics(1))
                .AddSkill(new FireAttack(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Resuscitate(1))
                .AddSkill(new Heroics(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Resentment(1))
                .AddSkill(new GuardUp(1))
                .AddSkill(new Heroics(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Resuscitate(1))
                .AddSkill(new GuardUp(1))
                .AddSlot(new LargeSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Resuscitate(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new LargeSlot())
                .AddSlot(new LargeSlot());
        }
    }
}