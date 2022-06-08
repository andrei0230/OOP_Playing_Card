namespace OOP_Playing_Card
{
    public class Deck
    {
        #region Fields

        private Stack<Card> _cards = new Stack<Card>();

        private int _count = 0;

        private Suit[] _suitList = (Suit[])Enum.GetValues(typeof(Suit));

        private Rank[] _rankList = (Rank[])Enum.GetValues(typeof(Rank));

        #endregion

        #region Constructors

        public Deck()
        {
            foreach(Suit suit in _suitList)
            {
                foreach(Rank rank in _rankList)
                {
                    Card _card = new Card(suit, rank);

                    _cards.Push(_card);
                    _count++;
                }
            }
        }

        #endregion

        #region Methods

        public Card DrawCard()
        {
            if (this.Count != 0)
            {
                _count--;
                return _cards.Pop();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Shuffle(int times)
        {
            Card[] arr = new Card[this.Count];
            int counter = 0;
            Random random = new Random();

            for(int i = 0; i < this.Count; i++)
            {
                arr[i] = _cards.Pop();
                counter++;
            }
           
            for(int j = 0; j < times; j++)
            {
                for (int i = counter - 1; i > 0; --i)
                {
                    int k = random.Next(i + 1);
                    Card temp = arr[i];
                    arr[i] = arr[k];
                    arr[k] = temp;
                }
            }

            foreach(Card card in arr)
            {
                _cards.Push(card);
            }
        }

        #endregion

        #region Properties

        public int Count { get { return _count; } }

        #endregion
    }
}
