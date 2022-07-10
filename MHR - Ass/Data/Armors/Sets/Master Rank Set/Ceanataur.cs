using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Ceanataur : ArmorSet
    {
        public Ceanataur()
        {
            Name = "Ceanataur";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 116;
            Fire.Value = 1;
            Water.Value = 2;
            Ice.Value = -1;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSkill(new PeakPerformance(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Grinder_S(1))
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Grinder_S(1))
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new PierceUp(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Grinder_S(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSkill(new MarathonRunner(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new PierceUp(1))
                .AddSlot(new SmallSlot());
        }
    }
}