using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class DeathStenchX : ArmorSet
    {
        public DeathStenchX()
        {
            Name = "Death Stench X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 118;
            Fire.Value = 3;
            Water.Value = 1;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ProtectivePolish(1))
                .AddSkill(new SpeedSharpening(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Fortify(1))
                .AddSkill(new RapidMorph(1))
                .AddSkill(new PierceUp(1))
                .AddSkill(new FlinchFree(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MaximumMight(2))
                .AddSkill(new AttackBoost(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new ProtectivePolish(1))
                .AddSkill(new MaximumMight(1))
                .AddSkill(new SpareShot(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new ProtectivePolish(1))
                .AddSkill(new RapidMorph(1))
                .AddSkill(new Focus(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}