using System;
using System.Collections.Generic;

namespace Cards
{
    internal class Hand
    {

        private List<Carte> _cartes;
        public List<Carte> Cartes
        {
            get { return _cartes; }
        }

        public Hand(List<Carte> cartes)
        {
            _cartes = new List<Carte>(cartes);
        }
        public Hand()
        {
            _cartes = new List<Carte>();
        }

        //Surcharge de l'opérateur +. Avec ceci, Hand + Carte et Hand += Carte retournent la main avec la carte ajoutée.
        public static Hand operator +(Hand hand, Carte newCard)
        {
            hand._cartes.Add(newCard);

            return hand;
        }

        public Carte SelectCard()
        {
            //TODO implement actual selection mechanics.
            throw new NotImplementedException();
        }
    }

    class Deck
    {
        Stack<Carte> Cartes = new Stack<Carte>();

        public Deck()
        {

        }

        internal void ShuffleInto(Carte carte)
        {
            Cartes.Push(carte);
            Shuffle();
        }

        void Shuffle()
        {
            //todo implement shuffle
        }
    }
}