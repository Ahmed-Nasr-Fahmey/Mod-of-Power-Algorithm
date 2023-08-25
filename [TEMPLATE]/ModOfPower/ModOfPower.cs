using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class ModOfPow
    {
        #region YOUR CODE IS HERE
        /// <summary>
        /// Calculate Mod of Power (B^P mod M) in an efficient way
        /// </summary>
        /// <param name="B">Base</param>
        /// <param name="P">Power</param>
        /// <param name="M">Modulus</param>
        /// <returns>Result of B^P mod M </returns>
        public static long ModOfPower(long B, long P, long M)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();
            


            //   R = (B ^ P) Mod (M)


            long R = 1;

            if ((P == 0 || B == 1) && M != 1)  // (Any value power ZERO || Any Base equal ONE ) ==> R is equal ONE
            {
                return 1;
            }

            if (P == 1)  // (Any value power ONE) ==> R is  B % M
            {
                return B % M;
            }

            if (M == 1 || B == 0)  // Any value modulo ONE is equal ZERO  || Any base equal to ZERO 
            {
                return 0;
            }
            
            B = B % M;  // To Reduce base             

            while (P > 0)  // The time complexity is O(Log(P)) ==>  P, P/2, P/4, ... , P/2^i < 0 ==> i = # iterations = Log(P)
            {
                if (P % 2 == 1)   // If P is odd, multiply result with B modulo M
                {
                    R = (B * R) % M;
                }
                P = P / 2;       // Divide P by 2 and square B modulo M ==>   (B^P) == ((B^2)^(P/2))  ==> Greedy
                B = (B * B) % M;
            }

            while(R < 0)    // if modulo result is -ve
            {
                R += M;
            }

            return R;
            
        }
        
        #endregion
    }
}
