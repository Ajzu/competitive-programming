using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming
{
    public class Circuits
    {
        public Circuits()
        {

        }

        public void DistributionOfToys()
        {
            //Check for size constraints
            int T = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<T; i++)
            {
                //check for size constraints
                int N = Convert.ToInt32(Console.ReadLine());
                if(N >= 3)
                {
                    
                }
            }
        }


        #region MarchCircuit2020

        public void DislikesAndParty(int totalFriendsN, List<string> identityDislikes)
        {
            try
            {
                int totalHandshakes = 10 * totalFriendsN;
                Dictionary<string, string> handshakesPerFriend = new Dictionary<string, string>();

                for(int i=0; i<identityDislikes.Count; i++)
                {
                    string[] identityDislikesPerPerson = identityDislikes[i].Split().ToArray();
                    string identity = identityDislikesPerPerson[0];
                    handshakesPerFriend.Add(identity, string.Join(" ", identityDislikesPerPerson.Skip(1)));
                    //sort string in the increasing order
                    
                    //after sorting store the items in the other list
                }

                for (int i = 0; i < handshakesPerFriend.Count; i++)
                {
                    string friend = handshakesPerFriend.Keys.ElementAt(i);
                    for( int k=0; k<handshakesPerFriend.Count; k++)
                    {
                        string currentFriend = handshakesPerFriend.Keys.ElementAt(k);
                        string currentDislikes = handshakesPerFriend[currentFriend];

                        if (friend != handshakesPerFriend.Keys.ElementAt(k))
                        {
                            string[] dislikes = currentDislikes.Split().ToArray();
                            for(int j=0; j<dislikes.Length; j++)
                            {
                                if(friend == dislikes[j])
                                {
                                    bool addDislikes = handshakesPerFriend[friend].Contains(currentFriend);
                                    if(!addDislikes)
                                    {
                                        handshakesPerFriend[friend] = handshakesPerFriend[friend] + " " + currentFriend;
                                    }

                                    bool addFriendsDislikes = handshakesPerFriend[currentFriend].Contains(friend);

                                    if (!addFriendsDislikes)
                                    {
                                        handshakesPerFriend[currentFriend] = handshakesPerFriend[currentFriend] + " " + friend; 
                                    }
                                    break;
                                }
                            }
                        }
                    } 
                }

                int result = 0;
                foreach(KeyValuePair<string, string> item in handshakesPerFriend)
                {
                    int totalDislikes = item.Value.Split().ToArray().Length;
                    int tempResult = ((totalFriendsN-1) - totalDislikes);
                    result += tempResult;
                }


            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        #endregion MarchCircuit2020

    }
}
