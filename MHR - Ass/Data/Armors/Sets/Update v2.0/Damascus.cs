using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Damascus : ArmorSet
    {
        public Damascus()
        {
            Name = "Damascus";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 68;
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
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSkill(new TremorResistance(1))
                .AddSkill(new Handicraft(1));

            Arm = new ArmArmor(this)
                .AddSlot(new MediumSlot())
                .AddSlot(new SmallSlot())
                .AddSkill(new Earplugs(1));

            Waist = new WaistArmor(this)
                .AddSlot(new SmallSlot())
                .AddSkill(new Earplugs(1))
                .AddSkill(new Handicraft(1));

            Leg = new LegArmor(this)
                .AddSlot(new SmallSlot())
                .AddSkill(new Handicraft(2));
        }
    }
}