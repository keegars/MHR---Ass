using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class MosgharlMX : ArmorSet
    {
        public MosgharlMX()
        {
            Name = "Mosgharl (M) X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 108;
            Fire.Value = -3;
            Water.Value = 1;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BlastResistance(2))
                .AddSkill(new FireAttack(2))
                .AddSkill(new CriticalElement(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new TuneUp(1))
                .AddSkill(new Steadiness(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new BlastResistance(1))
                .AddSkill(new FlinchFree(1))
                .AddSkill(new CriticalElement(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new FireAttack(3))
                .AddSkill(new FlinchFree(3))
                .AddSkill(new CriticalElement(3))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new TuneUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}