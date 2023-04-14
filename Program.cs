using System;
using System.Collections.Generic;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;
            try
            {
                Console.WriteLine("choisissez un nombre");
                int nbr = int.Parse(Console.ReadLine());
                Console.WriteLine("choisissez un multiplicatif");
                int multiplicatif = int.Parse(Console.ReadLine());
                resultat = nbr * multiplicatif;
                Console.WriteLine(nbr + " x " + multiplicatif + " = " + resultat);
            }
            catch(Exception exemple)
            {
                Console.WriteLine("du texte n'est pas admissible dans ses conditions");
            }
            finally
            {
                Console.WriteLine("merci et a la prochaine");
            }
           
            Console.WriteLine("Voulez-vous effectuer une autre multiplication");

            string userAnswer = Console.ReadLine();

            if (userAnswer == "yes" || userAnswer == "oui" || userAnswer == "ok")
            {
                Console.WriteLine("d'accord et c'est reparti");
                //  /*00000000000000000000000000000000000000000000000000000000000000000000
                int resultatRematch;

                try
                {
                    Console.WriteLine("choisissez un nombre");
                    int nbrRematch = int.Parse(Console.ReadLine());
                    Console.WriteLine("choisissez un multiplicatif");
                    int multiplicatifRematch = int.Parse(Console.ReadLine());
                    resultatRematch = nbrRematch * multiplicatifRematch;
                    Console.WriteLine(nbrRematch + " x " + multiplicatifRematch + " = " + resultatRematch);
                }
                catch (Exception exemple)
                {
                    Console.WriteLine("du texte n'est pas admissible dans ses conditions");
                }
                finally
                {
                    Console.WriteLine("merci et a la prochaine");
                }

                Console.WriteLine("Voulez-vous effectuer une autre multiplication");

                string userAnswerRematch = Console.ReadLine();

                if (userAnswerRematch == "yes" || userAnswerRematch == "oui" || userAnswerRematch == "ok")
                {
                    Console.WriteLine("d'accord et c'est reparti");
                }
                else if (userAnswerRematch == "no" || userAnswerRematch == "non" || userAnswerRematch == "jamais")
                {
                    Console.WriteLine("bon d'accord, pas de soucis. À la prochaine");
                }
                else
                {
                    //Console.WriteLine("ceci n'est pas une réponse acceptable");

                    while (userAnswerRematch != "yes" || userAnswerRematch != "oui" || userAnswerRematch != "ok" || userAnswerRematch != "no" || userAnswerRematch != "non" || userAnswerRematch != "jamais")
                    {
                        Console.WriteLine("ceci n'est pas une réponse acceptable");
                        Console.WriteLine("Voulez-vous effectuer une autre multiplication");


                        userAnswerRematch = Console.ReadLine();

                        if (userAnswerRematch == "yes" || userAnswerRematch == "oui" || userAnswerRematch == "ok")
                        {
                            Console.WriteLine("d'accord et c'est reparti");
                            break;
                        }
                        else if (userAnswerRematch == "no" || userAnswerRematch == "non" || userAnswerRematch == "jamais")
                        {
                            Console.WriteLine("bon d'accord, pas de soucis. À la prochaine");
                            break;
                        }
                        else
                        {
                            //Console.WriteLine("vous ne pou");
                        }
                    }

                }
            }

            //  */00000000000000000000000000000000000000000000000000000000000000000000000000

            else if (userAnswer == "no" || userAnswer == "non" || userAnswer == "jamais")
            {
                Console.WriteLine("bon d'accord, pas de soucis. À la prochaine");
            }
            else
            {
                //Console.WriteLine("ceci n'est pas une réponse acceptable");

                while (userAnswer != "yes" || userAnswer != "oui" || userAnswer != "ok" || userAnswer != "no" || userAnswer != "non" || userAnswer != "jamais")
                {
                    Console.WriteLine("ceci n'est pas une réponse acceptable");
                    Console.WriteLine("Voulez-vous effectuer une autre multiplication");


                    userAnswer = Console.ReadLine();

                    if (userAnswer == "yes" || userAnswer == "oui" || userAnswer == "ok")
                    {
                        Console.WriteLine("d'accord et c'est reparti");
                        break;
                    }
                    else if (userAnswer == "no" || userAnswer == "non" || userAnswer == "jamais")
                    {
                        Console.WriteLine("bon d'accord, pas de soucis. À la prochaine");
                        break;
                    }
                    else
                    {
                        //Console.WriteLine("vous ne pou");
                    }
                }

            }
            Console.WriteLine("");
            Console.WriteLine("LE PROGRAMME FONCTIONNE CORRECTEMENT");
            Console.Read();
            }
        }
        
    }


//            if(userAnswer != "yes" || userAnswer != "oui" || userAnswer != "ok" || userAnswer != "no" || userAnswer != "non" || userAnswer != "jamais")
