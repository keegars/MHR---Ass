using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GrandGodsPeer : ArmorSet
    {
        public GrandGodsPeer()
        {
            Name = "Grand God's Peer";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 134;
            Fire.Value = 2;
            Water.Value = 1;
            Ice.Value = -5;
            Thunder.Value = 3;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Heroics(2))
                .AddSkill(new MaximumMight(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new MaximumMight(1))
                .AddSkill(new LatentPower(1))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new LatentPower(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new CriticalBoost(1))
                .AddSkill(new MaximumMight(1))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalBoost(2))
                .AddSkill(new LatentPower(2))
                .AddSkill(new FlinchFree(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}