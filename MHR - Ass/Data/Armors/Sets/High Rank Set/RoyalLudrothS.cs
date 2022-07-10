using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RoyalLudrothS : ArmorSet
    {
        public RoyalLudrothS()
        {
            Name = "Royal Ludroth S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 78;
            Fire.Value = -3;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new PeakPerformance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new StaminaSurge(2))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MarathonRunner(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new PeakPerformance(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PowerProlonger(2))
                .AddSlot(new LargeSlot());
        }
    }
}