using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class PyreKadaki : ArmorSet
    {
        public PyreKadaki()
        {
            Name = "Pyre-Kadaki";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 128;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MaximumMight(1))
                .AddSkill(new BlastAttack(1))
                .AddSkill(new WirebugWhisperer(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new MaximumMight(1))
                .AddSkill(new WirebugWhisperer(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MaximumMight(1))
                .AddSkill(new RapidMorph(1))
                .AddSkill(new BlastResistance(1))
                .AddSkill(new TuneUp(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new PeakPerformance(2))
                .AddSkill(new BlastAttack(2))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new BlastResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}