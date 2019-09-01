using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* This is a test program to see how cards are moved when a deck of cards are shuffled
 * It is used to test different kinds of shuffles
 * Not much has been done to date
 */

namespace CardPositions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> deck = new List<string>(52);
        private List<string> suits = new List<string>();
        List<string> shuffleList = new List<string>();
        int cuts = 0;
        int matches = 0;

        private void CheckMatch()       //Check deck to see if all match
        {
            for (int i = 0; i < shuffleList.Count(); i++)       //Check every card with original
            {
                if (liBxCards.Items[i] == liBxShuffle1.Items[i])        //if match, add one to match
                {
                    matches++;

                    if (matches == 52)      //if whole deck matches
                    {
                        MessageBox.Show("Completed! \nIt took " + cuts + " cut(s) to complete this shuffle");
                        matches = 0;
                        cuts = 0;
                    }
                }
            }

            matches = 0;
        }

        private void SetDeck(List<string> suits)        //Set deck to unshuffled state
        {
            string[] numbers = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

            if (suits.Count == 0)
            {
                suits.Add(" of Spades");
                suits.Add(" of Hearts");
                suits.Add(" of Diamonds");
                suits.Add(" of Clubs");
            }

            deck.Clear();

            for (int i = 0; i < suits.Count(); i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    deck.Add(numbers[j] + suits[i]);
                }
            }
        }

        private void OrderShuffle()     //Deals four stacks of cards, one card per stack at a time, then assumes that stacks are fused after shuffle
        {
            int next = 1;
            cuts++;
            shuffleList.Clear();

            for (int i = 0; i < deck.Count(); i += 4)       //Every fourth one, 13 per stack
            {
                shuffleList.Add(deck[i]);

                if (i >= deck.Count() - 4 && next < 4)
                {
                    shuffleList.Add(deck[(i + 5) - 52]);
                    i = next;
                    next++;
                }
            }

            if (shuffleList.Count() != 0)
            {
                for (int i = 0; i < shuffleList.Count(); i++)
                {
                    deck[i] = shuffleList[i];
                }
            }
        }

        public void DealShuffle ()      //Incomplete
        {
            int next = 1;
            cuts++;
            shuffleList.Clear();

            for (int i = deck.Count(); i > 0; i -= 4)       //Every fourth one, 13 per stack
            {
                shuffleList.Add(deck[52 -i]);

                if (i <= 4 && next > 48)
                {
                    shuffleList.Add(deck[(52 - i + 5)]);
                    i = next;
                    next++;
                }
            }

            if (shuffleList.Count() != 0)
            {
                for (int i = 0; i < shuffleList.Count(); i++)
                {
                    deck[i] = shuffleList[i];
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            liBxCards.Items.Clear();
            SetDeck(suits);

            for (int i = 0; i < deck.Count(); i++)      //Add cards to listbox
            {
                liBxCards.Items.Add(deck[i]);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            liBxShuffle1.Items.Clear();
            OrderShuffle();
            
            for (int i = 0; i < shuffleList.Count(); i++)       //Add cards to shuffled list box
            {
                liBxShuffle1.Items.Add(shuffleList[i]);
            }

            CheckMatch();       //Check to see if shuffled cards match unshuffled cards
        }
    }
}
