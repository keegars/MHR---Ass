using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class LudrothX : ArmorSet
    {
        public LudrothX()
        {
            Name = "Ludroth X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = -3;
            Water.Value = 4;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new Focus(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new StaminaSurge(2))
                .AddSkill(new Focus(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new PowerProlonger(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new PeakPerformance(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PowerProlonger(2))
                .AddSkill(new Focus(2))
                .AddSlot(new LargeSlot());
        }
    }
}