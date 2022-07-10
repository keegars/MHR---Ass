using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RhopessaX : ArmorSet
    {
        public RhopessaX()
        {
            Name = "Rhopessa X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 118;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalElement(2))
                .AddSkill(new EvadeWindow(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new CriticalEye(1))
                .AddSkill(new DragonAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(2))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new DragonAttack(3))
                .AddSkill(new CriticalEye(3))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new DragonAttack(2))
                .AddSkill(new EvadeWindow(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}