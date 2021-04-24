using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RhopessaS : ArmorSet
    {
        public RhopessaS()
        {
            Name = "Rhopessa S/Aelucanth S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 62;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalElement(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new CriticalEye(2))
                .AddSkill(new DragonAttack(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new DragonAttack(3))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new DragonAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}