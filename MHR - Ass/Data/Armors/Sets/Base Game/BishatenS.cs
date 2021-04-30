using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BishatenS : ArmorSet
    {
        public BishatenS()
        {
            Name = "Bishaten S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 52;
            Fire.Value = -2;
            Water.Value = 2;
            Ice.Value = -4;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new Wide_Range(1))
                .AddSkill(new StunResistance(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Wide_Range(1))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new StunResistance(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ItemProlonger(1))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new MaximumMight(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}