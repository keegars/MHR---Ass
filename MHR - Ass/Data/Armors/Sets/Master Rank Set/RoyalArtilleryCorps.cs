using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RoyalArtilleryCorps : ArmorSet
    {
        public RoyalArtilleryCorps()
        {
            Name = "Royal Artillery Corps";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 114;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Steadiness(2))
                .AddSkill(new RecoilDown(2))
                .AddSkill(new EvadeExtender(2))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Ballistics(3))
                .AddSkill(new RecoilDown(3))
                .AddSkill(new EvadeExtender(3));

            Arm = new ArmArmor(this)
                .AddSkill(new AmmoUp(1))
                .AddSkill(new ReloadSpeed(1))
                .AddSkill(new Artillery(1))
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new AmmoUp(2))
                .AddSkill(new ReloadSpeed(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new SpareShot(3))
                .AddSkill(new SpecialAmmoBoost(3))
                .AddSkill(new Artillery(3));
        }
    }
}