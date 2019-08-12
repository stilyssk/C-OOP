﻿using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player:IPlayer
    {
        private string username;
        private int health;
        private ICardRepository cardRepository;
        private bool isDead;
        protected Player(ICardRepository cardRepository, string username, int health)
        {
            this.CardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string. ");
                }
                this.username = value;
            }
        }

        public ICardRepository CardRepository
        {
            get
            {
               return this.CardRepository;
            }
            private set
            {
                this.cardRepository = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero. ");
                }
                this.health = value;
            }
        }

        public bool IsDead
        {
            get
            {
                return this.isDead; 
            }
            private set
            {
                this.isDead = value;
            }
        }

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints <= 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }
            if (this.Health-damagePoints<0)
            {
                this.Health = 0;
            }
            this.Health -= damagePoints;

        }
    }
}
