using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Barbania : ArmorSet
    {
        public Barbania()
        {
            Name = "Barbania";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 126;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WeaknessExploit(1))
                .AddSkill(new CaptureMaster(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Partbreaker(1))
                .AddSkill(new Counterstrike(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WeaknessExploit(1))
                .AddSkill(new Partbreaker(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WeaknessExploit(1))
                .AddSkill(new Counterstrike(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Partbreaker(1))
                .AddSkill(new Counterstrike(1))
                .AddSkill(new GoodLuck(1))
                .AddSlot(new LargeSlot());
        }
    }
}