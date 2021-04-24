using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class UroktorS : ArmorSet
    {
        public UroktorS()
        {
            Name = "Uroktor S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 52;
            Fire.Value = 4;
            Water.Value = -2;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Torso = new TorsoArmor(this)
                .AddSkill(new FireAttack(3))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new FireAttack(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}