using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GrandChaos : ArmorSet
    {
        public GrandChaos()
        {
            Name = "Grand Chaos";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 106;
            Fire.Value = 2;
            Water.Value = -2;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Mushroomancer(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Mushroomancer(2))
                .AddSkill(new HornMaestro(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}