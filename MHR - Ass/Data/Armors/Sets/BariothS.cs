using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BariothS : ArmorSet
    {
        public BariothS()
        {
            Name = "Barioth S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 58;
            Fire.Value = -3;
            Water.Value = 0;
            Ice.Value = 3;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalDraw(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSkill(new MaximumMight(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalDraw(1))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new QuickSheath(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}