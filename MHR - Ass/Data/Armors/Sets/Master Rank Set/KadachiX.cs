using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KadachiX : ArmorSet
    {
        public KadachiX()
        {
            Name = "Kadachi X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = 0;
            Water.Value = -3;
            Ice.Value = 0;
            Thunder.Value = 3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new JumpMaster(1))
                .AddSkill(new Constitution(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new MindsEye(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new CriticalElement(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Constitution(3))
                .AddSkill(new Fortify(3))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new MindsEye(2))
                .AddSkill(new CriticalElement(2))
                .AddSkill(new PierceUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Constitution(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new CriticalElement(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}