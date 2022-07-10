using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RathalosX : ArmorSet
    {
        public RathalosX()
        {
            Name = "Rathalos X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 130;
            Fire.Value = 3;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Partbreaker(1))
                .AddSkill(new CriticalBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Partbreaker(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new Earplugs(2))
                .AddSkill(new CriticalBoost(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AttackBoost(2))
                .AddSkill(new Windproof(2))
                .AddSkill(new CriticalBoost(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Partbreaker(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}