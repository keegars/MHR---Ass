using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class IngotX : ArmorSet
    {
        public IngotX()
        {
            Name = "Ingot X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 102;
            Fire.Value = -1;
            Water.Value = -1;
            Ice.Value = 0;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Windproof(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Windproof(2))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ThunderAttack(3))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new PowerProlonger(2))
                .AddSkill(new AttackBoost(2))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}