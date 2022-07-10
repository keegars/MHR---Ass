using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BrigadeX : ArmorSet
    {
        public BrigadeX()
        {
            Name = "Brigade X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 114;
            Fire.Value = 1;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Botanist(2))
                .AddSkill(new DivineBlessing(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CaptureMaster(1))
                .AddSkill(new Geologist(1))
                .AddSkill(new MarathonRunner(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Geologist(2))
                .AddSkill(new SpiribirdsCall(2))
                .AddSkill(new DivineBlessing(2))
                .AddSlot(new LargeSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new GoodLuck(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CarvingPro(1))
                .AddSkill(new Botanist(1))
                .AddSkill(new MarathonRunner(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());
        }
    }
}