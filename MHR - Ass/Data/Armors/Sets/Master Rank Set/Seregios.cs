using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Seregios : ArmorSet
    {
        public Seregios()
        {
            Name = "Seregios ";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 130;
            Fire.Value = 4;
            Water.Value = 0;
            Ice.Value = -2;
            Thunder.Value = -3;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new BladescaleHone(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new BladescaleHone(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Handicraft(3));

            Waist = new WaistArmor(this)
                .AddSkill(new WallRunnerBoost(1))
                .AddSkill(new WallRunner(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new BladescaleHone(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}