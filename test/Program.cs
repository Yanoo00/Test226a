using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        #region private attributes
        private static char[] operateur = new char[] { '-', '+', '*', '/' };
        private static float operande1 = 9;
        private static float operande2 =0;
        private static float resultat = 0;
        private static int i = 0;

        #endregion private attributes

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            for (i = 0; i < 4; i++)
            {
                Console.Write("Le résultat de " + operande1 + operateur[i] + operande2 + " \n");
                resultat = addition(operande1, operande2);
                Console.Write(resultat + "\n");
                
            }
            Console.ReadLine(); //Pour que la fenetre reste ouverte
        }

        private static float addition(float op1, float op2)
        {
                        
                switch (i)
                {
                    case 0:
                        return op1 - op2;
                        
                    case 1:
                        return op1 + op2;

                    case 2:
                        return op1 * op2;

                    case 3:
                    if(op1 == 0 || op2 == 0)
                    {
                        return 123;
                    }
                    else
                    {
                        return op1 / op2;
                    }
                        

                    default:
                        break;
                }
            
            return 0;
            
        }
    }
}
