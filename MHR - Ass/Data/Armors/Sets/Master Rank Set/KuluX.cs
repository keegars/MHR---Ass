using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KuluX : ArmorSet
    {
        public KuluX()
        {
            Name = "Kulu X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 100;
            Fire.Value = 0;
            Water.Value = -3;
            Ice.Value = 1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MaximumMight(2))
                .AddSkill(new QuickSheath(2))
                .AddSkill(new StunResistance(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Slugger(2))
                .AddSkill(new QuickSheath(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Slugger(1))
                .AddSkill(new StaminaThief(1))
                .AddSkill(new QuickSheath(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new StaminaThief(1))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new StunResistance(2))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new LargeSlot());
        }
    }
}