using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GoreMagala : ArmorSet
    {
        public GoreMagala()
        {
            Name = "Gore Magala";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 128;
            Fire.Value = -2;
            Water.Value = 2;
            Ice.Value = 2;
            Thunder.Value = -1;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Agitator(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Coalescence(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Coalescence(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Coalescence(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Agitator(3))
                .AddSkill(new SpeedEating(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}