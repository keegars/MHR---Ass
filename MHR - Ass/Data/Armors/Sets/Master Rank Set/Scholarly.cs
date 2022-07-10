using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Scholarly : ArmorSet
    {
        public Scholarly()
        {
            Name = "Scholarly";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 132;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WideRange(3))
                .AddSkill(new CaptureMaster(3))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new BlightResistance(3))
                .AddSkill(new FreeMeal(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new RecoveryUp(3))
                .AddSkill(new FreeMeal(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new QuickSheath(3))
                .AddSkill(new FreeMeal(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ItemProlonger(3))
                .AddSkill(new WideRange(3))
                .AddSlot(new MediumSlot());
        }
    }
}