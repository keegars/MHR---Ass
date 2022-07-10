using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BishatenX : ArmorSet
    {
        public BishatenX()
        {
            Name = "Bishaten X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = -2;
            Water.Value = 2;
            Ice.Value = -4;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new WideRange(1))
                .AddSkill(new StunResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WideRange(3))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new StunResistance(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new MaximumMight(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MaximumMight(1))
                .AddSkill(new MastersTouch(1))
                .AddSkill(new SpeedEating(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}