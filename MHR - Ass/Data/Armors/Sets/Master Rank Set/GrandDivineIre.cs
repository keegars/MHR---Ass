using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GrandDivineIre : ArmorSet
    {
        public GrandDivineIre()
        {
            Name = "Grand Divine Ire";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 140;
            Fire.Value = 2;
            Water.Value = 1;
            Ice.Value = -6;
            Thunder.Value = 3;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Furious(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new RazorSharp(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new ChainCrit(1))
                .AddSkill(new MaximumMight(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Furious(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ChainCrit(1))
                .AddSkill(new CriticalElement(1))
                .AddSkill(new RazorSharp(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Furious(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}