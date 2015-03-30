// Benjamin Chu
// Console / Text Only Hearthstone

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hearthstone Battle Start!");
            int round = 1; // Starts at Turn 1
            // Creating Player objects
            Player player1 = new Player();
            Player player2 = new Player();

            // Deck generation
            List<Card> player1Deck = new List<Card>();
            List<Card> player2Deck = new List<Card>();
            // Sorry this is BAD and I know it
            Card card1 = new Card(1, 1, 0, false); // 10 cards that deal 1 damage and cost 1 mana
            Card card2 = new Card(1, 1, 0, false);
            Card card3 = new Card(1, 1, 0, false);
            Card card4 = new Card(1, 1, 0, false);
            Card card5 = new Card(1, 1, 0, false);
            Card card6 = new Card(1, 1, 0, false);
            Card card7 = new Card(1, 1, 0, false);
            Card card8 = new Card(1, 1, 0, false);
            Card card9 = new Card(1, 1, 0, false);
            Card card10 = new Card(1, 1, 0, false);
            Card card11 = new Card(2, 2, 0, false); // 4 cards that deal 2 damage and cost 2 mana
            Card card12 = new Card(2, 2, 0, false);
            Card card13 = new Card(2, 2, 0, false);
            Card card14 = new Card(2, 2, 0, false);
            Card card15 = new Card(3, 3, 0, false); // 2 cards that deal 3 damage and cost 3 mana
            Card card16 = new Card(3, 3, 0, false);
            Card card17 = new Card(4, 4, 0, false); // 2 cards that deal 4 damage and cost 4 mana
            Card card18 = new Card(4, 4, 0, false);
            Card card19 = new Card(5, 5, 0, false); // 2 cards that deal 5 damage and cost 5 mana
            Card card20 = new Card(5, 5, 0, false);
            Card card21 = new Card(1, 0, 1, false); // 5 cards that heal for 1 HP and cost 1 mana
            Card card22 = new Card(1, 0, 1, false);
            Card card23 = new Card(1, 0, 1, false);
            Card card24 = new Card(1, 0, 1, false);
            Card card25 = new Card(1, 0, 1, false);
            Card card26 = new Card(2, 0, 2, false); // 2 cards that heal for 2 HP and cost 2 mana
            Card card27 = new Card(2, 0, 2, false);
            Card card28 = new Card(1, 1, 0, true); // 2 cards that deal 1 damage and cost 1 mana, player draws another card
            Card card29 = new Card(1, 1, 0, true);
            Card card30 = new Card(5, 4, 0, false);
            player1Deck.Add(card1);
            player1Deck.Add(card2);
            player1Deck.Add(card3);
            player1Deck.Add(card4);
            player1Deck.Add(card5);
            player1Deck.Add(card6);
            player1Deck.Add(card7);
            player1Deck.Add(card8);
            player1Deck.Add(card9);
            player1Deck.Add(card10);
            player1Deck.Add(card11);
            player1Deck.Add(card12);
            player1Deck.Add(card13);
            player1Deck.Add(card14);
            player1Deck.Add(card15);
            player1Deck.Add(card16);
            player1Deck.Add(card17);
            player1Deck.Add(card18);
            player1Deck.Add(card19);
            player1Deck.Add(card20);
            player1Deck.Add(card21);
            player1Deck.Add(card22);
            player1Deck.Add(card23);
            player1Deck.Add(card24);
            player1Deck.Add(card25);
            player1Deck.Add(card26);
            player1Deck.Add(card27);
            player1Deck.Add(card28);
            player1Deck.Add(card29);
            player1Deck.Add(card30);
            player1Deck.Shuffle();
            player2Deck.Add(card1);
            player2Deck.Add(card2);
            player2Deck.Add(card3);
            player2Deck.Add(card4);
            player2Deck.Add(card5);
            player2Deck.Add(card6);
            player2Deck.Add(card7);
            player2Deck.Add(card8);
            player2Deck.Add(card9);
            player2Deck.Add(card10);
            player2Deck.Add(card11);
            player2Deck.Add(card12);
            player2Deck.Add(card13);
            player2Deck.Add(card14);
            player2Deck.Add(card15);
            player2Deck.Add(card16);
            player2Deck.Add(card17);
            player2Deck.Add(card18);
            player2Deck.Add(card19);
            player2Deck.Add(card20);
            player2Deck.Add(card21);
            player2Deck.Add(card22);
            player2Deck.Add(card23);
            player2Deck.Add(card24);
            player2Deck.Add(card25);
            player2Deck.Add(card26);
            player2Deck.Add(card27);
            player2Deck.Add(card28);
            player2Deck.Add(card29);
            player2Deck.Add(card30);
            player2Deck.Shuffle();

            // List for each player's hand
            List<Card> player1Hand = new List<Card>();
            List<Card> player2Hand = new List<Card>();

            // Initial 4 card draw for player 1
            int deck1Position = 0, deck2Position = 0;
            for (int i = 0; i < 4; i++) 
            {
                player1Hand.Add(player1Deck[deck1Position]);
                deck1Position++;
            }

            // Initial 4 card draw for player 2
            for (int i = 0; i < 4; i++)
            {
                player2Hand.Add(player2Deck[deck2Position]);
                deck2Position++;
            }

            // Boolean values to control player flow
            bool player1Turn = true, player2Turn = false;

            // Main program while-loop, if any player's HP hits 0, the loop ends
            while (player1.getPlayerHP() > 1 || player2.getPlayerHP() > 1)
            {
                // Player 1's Turn
                if (player1Turn == true) {
                    // Get available mana for turn
                    while (player1.getMana() > 0)
                    {
                        // At start of each turn, player gets 1 card draw
                        player1Hand.Add(player1Deck[deck1Position]);
                        deck1Position++;
                        int player1Size = player1Hand.Count;
                        // UI for information per turn
                        Console.WriteLine("                           ");
                        Console.WriteLine("====== Player 1 Turn ======");
                        Console.WriteLine("Turn #: " + round);
                        Console.WriteLine("Your HP: " + player1.getPlayerHP());
                        Console.WriteLine("Your Mana Crystals: " + player1.getMana());
                        Console.WriteLine("Cards in Hand: " + player1Size);
                        // UI of each card
                        for (int i = 0; i < player1Size; i++)
                        {
                            Console.WriteLine("Card # " + i + " - [Cost: " + player1Hand[i].getCost() + ", Damage: " + player1Hand[i].getDamage() + ", Heal: " + player1Hand[i].getHeal() + ", Draw Card? " + player1Hand[i].getDraw() + "]");
                        }
                        // User input
                        Console.WriteLine("Please enter the card # you would like to play: ");
                        // String conversion to int
                        int numVal = Convert.ToInt32(Console.ReadLine());
                        // Here the cost of each card is evaluated against available mana
                        if (player1Hand[numVal].getCost() <= player1.playerMana)
                        {
                            // If there is available mana, damage will be delt, health will be restored, cost will be subtracted and cardDraw will be given
                            player1.playerMana -= player1Hand[numVal].getCost();
                            player2.playerHP -= player1Hand[numVal].getDamage();
                            player1.playerHP += player1Hand[numVal].getHeal();
                            // Card draw
                            if (player1Hand[numVal].getDraw() == true)
                            {
                                player1Hand.Add(player1Deck[deck1Position]);
                                deck1Position++;
                            }
                            // Removing the player card from Player 1's hand
                            player1Hand.RemoveAt(numVal);
                        }
                        else
                        {
                            // If not enough mana, throw error.
                            Console.WriteLine("You don't have enough mana!");
                        }

                    }
                    // Boolean values flip for player 2 turn
                    player1Turn = false;
                    player2Turn = true;
                    // Mana is restored for next turn and incremented by 1
                    player1.playerMana = player1.playerMana + round + 1;
                    // Check if player 2 is dead
                    if (player2.getPlayerHP() <= 0)
                    {
                        Console.WriteLine("Player 1 has won!");
                        break;
                    }
                }

                if (player2Turn == true)
                {
                    while (player2.getMana() > 0)
                    {
                        player2Hand.Add(player2Deck[deck2Position]);
                        deck2Position++;
                        int player2Size = player2Hand.Count;
                        Console.WriteLine("                           ");
                        Console.WriteLine("====== Player 2 Turn ======");
                        Console.WriteLine("Turn #: " + round);
                        Console.WriteLine("Your HP: " + player2.getPlayerHP());
                        Console.WriteLine("Your Mana Crystals: " + player2.getMana());
                        Console.WriteLine("Cards in Hand: " + player2Size);
                        for (int i = 0; i < player2Size; i++)
                        {
                            Console.WriteLine("Card # " + i + " - [Cost: " + player2Hand[i].getCost() + ", Damage: " + player2Hand[i].getDamage() + ", Heal: " + player2Hand[i].getHeal() + ", Draw Card? " + player2Hand[i].getDraw() + "]");
                        }
                        Console.WriteLine("Please enter the card # you would like to play: ");

                        int numVal = Convert.ToInt32(Console.ReadLine());

                        if (player2Hand[numVal].getCost() <= player2.playerMana)
                        {
                            player2.playerMana -= player2Hand[numVal].getCost();
                            player1.playerHP -= player2Hand[numVal].getDamage();
                            player2.playerHP += player2Hand[numVal].getHeal();

                            if (player2Hand[numVal].getDraw() == true)
                            {
                                player2Hand.Add(player2Deck[deck2Position]);
                                deck2Position++;
                            }
                            player2Hand.RemoveAt(numVal);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough mana!");
                        }

                    }

                    player1Turn = true;
                    player2Turn = false;
                    player2.playerMana = player2.playerMana + round + 1;

                    if (player1.getPlayerHP() <= 0)
                    {
                        Console.WriteLine("Player 2 has won!");
                        break;
                    }
                }
                round++;

            }
            Console.WriteLine("It's Over!");
            
        }
    }

    // Player Class
    public class Player
    {

        public int playerHP;
        public int playerMana;

        // Constructor
        public Player()
        {
            playerHP = 30;
            playerMana = 1;
        }

        public void setPlayerHP(int number)
        {
            playerHP = number;
        }

        public int getPlayerHP()
        {
            return playerHP;
        }

        public void incrementPlayerHP()
        {
            playerHP++;
        }

        public void decrementPlayerHP()
        {
            playerHP--;
        }

        public void setMana(int number)
        {
            playerMana = number;
        }

        public int getMana()
        {
            return playerMana;
        }
    }

    // Card class
    public class Card
    {
        protected int cardCost = 0;
        protected int cardDamage = 0;
        protected int cardHeal = 0;
        protected bool drawCard = false;

        // Constructor
        public Card(int cost, int damage, int heal, bool draw)
        {
            cardCost = cost;
            cardDamage = damage;
            cardHeal = heal;
            drawCard = draw;
        }

        public void setCost(int number)
        {
            cardCost = number;
        }

        public int getCost()
        {
            return cardCost;
        }

        public void setDamage(int number)
        {
            cardDamage = number;
        }

        public int getDamage()
        {
            return cardDamage;
        }

        public void setHeal(int number)
        {
            cardHeal = number;
        }

        public int getHeal()
        {
            return cardHeal;
        }

        public bool getDraw()
        {
            return drawCard;
        }

    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

}
