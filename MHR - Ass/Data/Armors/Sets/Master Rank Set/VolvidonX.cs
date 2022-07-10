using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class VolvidonX : ArmorSet
    {
        public VolvidonX()
        {
            Name = "Volvidon X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 106;
            Fire.Value = 2;
            Water.Value = -3;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ParalysisAttack(2))
                .AddSkill(new Earplugs(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RapidMorph(1))
                .AddSkill(new JumpMaster(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeExtender(1))
                .AddSkill(new ParalysisAttack(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Earplugs(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RapidMorph(2))
                .AddSkill(new EvadeExtender(2))
                .AddSlot(new SmallSlot());
        }
    }
}