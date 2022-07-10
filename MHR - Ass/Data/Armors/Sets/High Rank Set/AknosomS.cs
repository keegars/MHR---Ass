using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AknosomS : ArmorSet
    {
        public AknosomS()
        {
            Name = "Aknosom S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 76;
            Fire.Value = 3;
            Water.Value = -3;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new FireAttack(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new PeakPerformance(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new FireAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PeakPerformance(1))
                .AddSkill(new FireAttack(1))
                .AddSlot(new SmallSlot());
        }
    }
}