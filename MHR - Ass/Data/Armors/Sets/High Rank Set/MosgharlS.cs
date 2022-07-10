using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class MosgharlS : ArmorSet
    {
        public MosgharlS()
        {
            Name = "Mosgharl S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 72;
            Fire.Value = -3;
            Water.Value = 1;
            Ice.Value = 3;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BlastResistance(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new ReloadSpeed(2))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new BlastResistance(1))
                .AddSkill(new FlinchFree(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new FireAttack(3))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RecoilDown(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}