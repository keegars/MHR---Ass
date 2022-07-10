using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Damascus : ArmorSet
    {
        public Damascus()
        {
            Name = "Damascus";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 88;
            Fire.Value = -1;
            Water.Value = 2;
            Ice.Value = 1;
            Thunder.Value = -3;
            Dragon.Value = -1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new TremorResistance(2))
                .AddSkill(new Earplugs(2));

            Torso = new TorsoArmor(this)
                .AddSkill(new TremorResistance(1))
                .AddSkill(new Handicraft(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSkill(new Handicraft(1))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Handicraft(2))
                .AddSlot(new SmallSlot());
        }
    }
}