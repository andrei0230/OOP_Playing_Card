namespace OOP_Playing_Card
{
    public class Card
    {
        #region Fields

        private Suit _suit;

        private Rank _rank;

        #endregion

        #region Constructors
        
        public Card(Suit suit, Rank rank)
        {
            _suit = suit;
            _rank = rank;
        }

        #endregion

        #region Properties

        public Suit Suit { get { return _suit; } }

        public Rank Rank { get { return _rank; } }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }

        #endregion
    }
}
