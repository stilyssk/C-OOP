using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class CardRepository : ICardRepository
    {
        private List<ICard> cardsList;

        public CardRepository()
        {
            this.cardsList = new List<ICard>();
        }

        public int Count => this.cardsList.Count;

        public IReadOnlyCollection<ICard> Cards => this.cardsList.AsReadOnly();

        public void Add(ICard card)
        {

            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }
            if (cardsList.Exists(x => x.Name == card.Name))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }
            cardsList.Add(card);
        }

        public ICard Find(string name)
        {
            return cardsList.Find(x => x.Name == name);
        }

        public bool Remove(ICard card)
        {

            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }
            return cardsList.Remove(card);
        }
    }
}
