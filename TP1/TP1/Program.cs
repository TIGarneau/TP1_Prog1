using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbrJour;
            
            int x = 1;
            int xDay = 1;
            bool conv = false;
            int jour1 = 1;
            int ite = 1;
           
            while (ite == 1) {
                Console.WriteLine("Entrez le nombre de jour dans le mois (28-31): ");
                conv = int.TryParse(Console.ReadLine(), out nbrJour);
                if (conv)
                {
                    if (nbrJour >= 28 && nbrJour <= 31)//verfication si le nombre est dans les valeurs permises
                    {
                        int iteJour = 1;

                        while (iteJour == 1)
                        {

                            Console.WriteLine("Quelle jour de la semaine debute le mois? (1 = Dimanche, 2 = Lundi , 3 = Mardi ,ETC.)");
                            conv = int.TryParse(Console.ReadLine(), out jour1);
                            if (conv)
                            {
                                if (jour1 >= 1 && jour1 <=7)
                                {
                                    //continue
                                    ite = 0;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Entrez une valeur entre 1-7");
                                }
                               
                            }
                            else
                            {
                                Console.WriteLine("Entrez une nombre SVP!");
                            }
                        }
                        Console.WriteLine("D  \tL \t M  \tM  \tJ \t V  \tS\n");
                        
                        for (x = 1; x <= nbrJour; x++)
                            {
                                if (x == 1)//premiere iteration
                                {
                                
                                    switch (jour1)
                                    {
                                        case 1: //dimanche
                                            Console.Write(x + "");
                                        xDay = 1;
                                            break;
                                        case 2:
                                            Console.Write("\t " + x);
                                        xDay = 2;
                                        break;
                                        case 3:
                                            Console.Write("\t " + "\t " + x);
                                        xDay = 3;
                                        break;
                                        case 4:
                                            Console.Write("\t " + "\t " + "\t " + x);
                                        xDay = 4;
                                        break;
                                        case 5:
                                            Console.Write("\t " + "\t " + "\t " + "\t " + x);
                                        xDay = 5;
                                        break;
                                        case 6:
                                            Console.Write("\t " + "\t " + "\t " + "\t " + "\t " + x);
                                        xDay = 6;
                                        break;
                                        case 7:
                                            Console.WriteLine("\t " + "\t " + "\t " + "\t " + "\t " + "\t " + x);
                                        xDay = 7;
                                        break;
                                    }
                                }
                                else//pas la 1ere iteration
                                {

                                
                                    if (xDay == 7)
                                    {
                                         Console.Write(x + "\n");
                                    }
                                    else
                                    {
                                         Console.Write(x+ "\t");
                                    }
                                    xDay++;
                                    if (xDay == 8)
                                    {
                                        xDay = 1;
                                    }

                                }
                            
                       }
                        
                    }
                    else
                    {
                        Console.WriteLine("Valeur doit etre comprise entre 28 et 31");
                    }
                }
                else
                {
                    Console.WriteLine("Entrez un nombre svp!");
                }
            }
        }
    }
}
