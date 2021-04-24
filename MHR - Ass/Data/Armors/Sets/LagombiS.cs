using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class LagombiS : ArmorSet
    {
        public LagombiS()
        {
            Name = "Lagombi S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 36;
            Fire.Value = -3;
            Water.Value = 1;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSkill(new IceAttack(2))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AffinitySliding(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new IceAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Constitution(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new JumpMaster(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}