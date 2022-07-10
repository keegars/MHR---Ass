using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Hawk : ArmorSet
    {
        public Hawk()
        {
            Name = "Hawk";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 126;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Constitution(2))
                .AddSkill(new WeaknessExploit(2))
                .AddSkill(new GoodLuck(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Constitution(1))
                .AddSkill(new QuickSheath(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new SpeedEating(1))
                .AddSkill(new QuickSheath(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedEating(2))
                .AddSkill(new Constitution(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CaptureMaster(1))
                .AddSkill(new GoodLuck(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}