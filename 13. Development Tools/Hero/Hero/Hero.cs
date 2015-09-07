namespace Hero
{
    using System;
    using log4net;
    using log4net.Config;

    /// <summary>
    /// Class representing a hero
    /// </summary>
    public class Hero
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Hero));
        private int attack;
        private int health;
        private int defence;

        /// <summary>
        /// Initializes a new instance of the Hero class
        /// </summary>
        /// <param name="attack">Hero's attack</param>
        /// <param name="defence">Hero's defense</param>
        /// <param name="health">Hero's health</param>
        public Hero(int attack, int defence, int health)
        {
            this.Attack = attack;
            this.Defence = defence;
            this.Health = health;
        }

        /// <summary>
        /// Gets or sets the hero's attack
        /// </summary>
        public int Attack
        {
            get
            {
                return this.attack;
            }

            set
            {
                this.attack = value;
            }
        }

        /// <summary>
        /// Gets or sets the hero's health
        /// </summary>
        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                this.health = value;
            }
        }

        /// <summary>
        /// Gets or sets the hero's defense
        /// </summary>
        public int Defence
        {
            get
            {
                return this.defence;
            }

            set
            {
                this.defence = value;
            }
        }

        /// <summary>
        /// A method simulating a fight between two heroes.
        /// Each turn every hero hits the other with power = attacker attack - defender defense
        /// When a hero's health is 0 or lower, the other one wins and gains 1/10 of opponents attack and defense
        /// </summary>
        /// <param name="opponent">Attacker's opponent</param>
        public void Fight(Hero opponent)
        {
            XmlConfigurator.Configure();

            Logger.Info("A fight has started");

            while (true)
            {
                if (this.Health <= 0)
                {
                    opponent.Attack += this.Attack / 10;
                    opponent.Defence += this.Defence / 10;
                    Console.WriteLine("Defender wins the fight: attack: +{0}, defence +{1}", this.Attack / 10, this.Defence / 10);
                    Logger.Info(string.Format("Defender wins the fight: attack: +{0}, defence +{1}", this.Attack / 10, this.Defence / 10));
                    break;
                }
                else if (opponent.Health <= 0)
                {
                    this.Attack += opponent.Attack / 10;
                    this.Defence += opponent.Defence / 10;
                    Console.WriteLine("Attacker wins the fight: attack: +{0}, defence +{1}", opponent.Attack / 10, opponent.Defence / 10);
                    Logger.Info(string.Format("Attacker wins the fight: attack: +{0}, defence +{1}", opponent.Attack / 10, opponent.Defence / 10));
                    break;
                }
                else
                {
                    int heroHitPower = this.Attack - opponent.Defence;
                    int oppHitPower = opponent.Attack - this.Defence;

                    if (heroHitPower > 0)
                    {
                        opponent.Health -= heroHitPower;
                        Logger.Info(string.Format("Attacker does {0} damage. Defender HP: {1}", heroHitPower, opponent.Health));
                    }

                    if (oppHitPower > 0)
                    {
                        this.Health -= oppHitPower;
                        Logger.Info(string.Format("Defender does {0} damage. Attacker HP: {1}", oppHitPower, this.Health));
                    }
                }
            }

            Logger.Info("Fight ended");
        }
    }
}
