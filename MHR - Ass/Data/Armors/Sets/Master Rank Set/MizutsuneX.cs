using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class MizutsuneX : ArmorSet
    {
        public MizutsuneX()
        {
            Name = "Mizutsune X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 130;
            Fire.Value = 0;
            Water.Value = 2;
            Ice.Value = 1;
            Thunder.Value = -3;
            Dragon.Value = -1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Resuscitate(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new BubblyDance(1))
                .AddSkill(new Resuscitate(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Resuscitate(1))
                .AddSkill(new FreeMeal(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new BubblyDance(1))
                .AddSkill(new FreeMeal(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new BubblyDance(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}