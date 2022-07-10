using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class HeavyKnight : ArmorSet
    {
        public HeavyKnight()
        {
            Name = "Heavy Knight";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 130;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new GuardUp(1))
                .AddSkill(new Artillery(1))
                .AddSkill(new LoadShells(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new Artillery(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new GuardUp(2))
                .AddSkill(new RazorSharp(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new QuickSheath(1))
                .AddSkill(new OffensiveGuard(1));

            Leg = new LegArmor(this)
                .AddSkill(new GuardUp(1))
                .AddSkill(new QuickSheath(1))
                .AddSkill(new RazorSharp(1))
                .AddSlot(new SmallSlot());
        }
    }
}