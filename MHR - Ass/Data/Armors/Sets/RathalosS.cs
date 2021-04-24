using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RathalosS : ArmorSet
    {
        public RathalosS()
        {
            Name = "Rathalos S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 62;
            Fire.Value = 3;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Partbreaker(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Partbreaker(1))
                .AddSkill(new Windproof(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new Windproof(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Partbreaker(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}