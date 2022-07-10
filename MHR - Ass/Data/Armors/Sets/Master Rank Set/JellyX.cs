using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class JellyX : ArmorSet
    {
        public JellyX()
        {
            Name = "Jelly X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 132;
            Fire.Value = 1;
            Water.Value = 3;
            Ice.Value = 2;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Partbreaker(1))
                .AddSkill(new DivineBlessing(1))
                .AddSkill(new Focus(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new BlastAttack(2))
                .AddSkill(new Focus(2))
                .AddSkill(new ChargeMaster(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new DivineBlessing(2))
                .AddSkill(new Focus(2))
                .AddSkill(new ChargeMaster(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Partbreaker(2))
                .AddSkill(new Slugger(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new BlastAttack(1))
                .AddSkill(new ChargeMaster(1))
                .AddSkill(new Slugger(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}