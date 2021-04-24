using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class IngotS : ArmorSet
    {
        public IngotS()
        {
            Name = "Ingot S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 40;
            Fire.Value = -1;
            Water.Value = -1;
            Ice.Value = 0;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Windproof(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Windproof(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ThunderAttack(3))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new PowerProlonger(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new CriticalEye(2))
                .AddSlot(new SmallSlot());
        }
    }
}