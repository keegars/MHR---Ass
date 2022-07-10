using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GuildBard : ArmorSet
    {
        public GuildBard()
        {
            Name = "Guild Bard";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 112;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new EvadeWindow(2))
                .AddSkill(new MuckResistance(2))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new GoodLuck(1))
                .AddSkill(new CaptureMaster(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Diversion(1))
                .AddSkill(new GoodLuck(1))
                .AddSkill(new BlightResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new HornMaestro(1))
                .AddSkill(new Steadiness(1))
                .AddSkill(new GoodLuck(1))
                .AddSkill(new DivineBlessing(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new EvadeWindow(2))
                .AddSkill(new Mushroomancer(2))
                .AddSkill(new Counterstrike(2))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}