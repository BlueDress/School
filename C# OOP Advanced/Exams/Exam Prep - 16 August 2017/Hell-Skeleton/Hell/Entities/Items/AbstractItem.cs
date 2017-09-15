namespace Hell.Entities.Items
{
    public class AbstractItem
    {
        private string name;
        private long strengthBonus;
        private long agilityBonus;
        private long intelligenceBonus;
        private long hitPointsBonus;
        private long damageBonus;

        public AbstractItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus)
        {
            this.Name = name;
            this.StrengthBonus = strengthBonus;
            this.AgilityBonus = agilityBonus;
            this.IntelligenceBonus = intelligenceBonus;
            this.HitPointsBonus = hitPointsBonus;
            this.DamageBonus = damageBonus;             
        }  
                         
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public long StrengthBonus
        {
            get
            {
                return this.strengthBonus;
            }

            set
            {
                this.strengthBonus = value;
            }
        }

        public long AgilityBonus
        {
            get
            {
                return this.agilityBonus;
            }

            set
            {
                this.agilityBonus = value;
            }
        }

        public long IntelligenceBonus
        {
            get
            {
                return this.intelligenceBonus;
            }

            set
            {
                this.intelligenceBonus = value;
            }
        }

        public long HitPointsBonus
        {
            get
            {
                return this.hitPointsBonus;
            }

            set
            {
                this.hitPointsBonus = value;
            }
        }

        public long DamageBonus
        {
            get
            {
                return this.damageBonus;
            }

            set
            {
                this.damageBonus = value;
            }
        }
    }                       
}                           
