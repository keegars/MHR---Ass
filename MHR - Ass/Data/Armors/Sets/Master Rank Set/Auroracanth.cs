using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Auroracanth : ArmorSet
    {
        public Auroracanth()
        {
            Name = "Auroracanth";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 116;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MastersTouch(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new MastersTouch(1))
                .AddSkill(new IceAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new MastersTouch(1))
                .AddSkill(new IceAttack(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new Agitator(1))
                .AddSkill(new IceAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}