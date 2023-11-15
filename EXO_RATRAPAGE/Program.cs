using System;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;

class Program {
    static int resultat = 10;//seulement pour l'exo 2 et 3
    //===========================================
    static void Main() {
        choix_exo();
    }
    //========================================
    static void choix_exo() {
        int choix_ex;
        double compteur = 1;

        Console.WriteLine();//saut de ligne

        Console.WriteLine("Quel exercice voulez vous choisir (ecrivez seulement le numéro (4 par exemple) sinon 30 pour activer le mode demo" +
                          " le mode Demo permet d'executer tout les exercice a la suite");
        Console.WriteLine();
        Console.Write($"Exercice,");
        while (compteur <= 26) {
            Console.Write($" {compteur} ");
            compteur++;
        }
        Console.WriteLine("Demo");
        choix_ex = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (choix_ex) { //il faut que j'essaie de trouver une autre solution avec des boucles
            case 1:
                exo_1();
                break;
            case 2:
                exo_2();
                break;
            case 3:
                exo_3();
                break;
            case 4:
                exo_4();
                break;
            case 5:
                exo_5();
                break;
            case 6:
                exo_6();
                break;
            case 7:
                exo_7();
                break;
            case 8:
                exo_8();
                break;
            case 9:
                exo_9();
                break;
            case 10:
                exo_10();
                break;
            case 11:
                exo_11();
                break;
            case 12:
                exo_12();
                break;
            case 13:
                exo_13();
                break;
            case 14:
                exo_14();
                break;
            case 15:
                exo_15();
                break;
            case 16:
                exo_16();
                break;
            case 17:
                exo_17();
                break;
            case 18:
                exo_18();
                break;
            case 19:
                exo_19();
                break;
            case 20:
                exo_20();
                break;
            case 21:
                exo_21();
                break;
            case 22:
                exo_22();
                break;
            case 23:
                exo_23();
                break;
            case 24:
                exo_24();
                break;
            case 25:
                exo_25();
                break;
            case 26:
                exo_26();
                break;
            case 30:
                exo_1();
                exo_2();
                exo_3();
                exo_4();
                exo_5();
                exo_6();
                exo_7();
                exo_8();
                exo_9();
                exo_10();
                exo_11();
                exo_12();
                exo_13();
                exo_14();
                exo_15();
                exo_16();
                exo_17();
                exo_18();
                exo_19();
                exo_20();
                exo_21();
                exo_22();
                exo_23();
                exo_24();
                exo_25();
                exo_26();
                break;
            default:
                Console.WriteLine("Cet exercice n'existe pas.");
                break;
        }
    }
    //========================================
    static void exo_1() {
        Console.WriteLine("Bonjour, bienvenue dans votre session");
    }
    //======================================
    static void exo_2() {

        Console.WriteLine($"{resultat}");
    }
    //==============================================
    static void exo_3() {
        Console.WriteLine($"Le resultats est : {resultat}");
    }
    //==============================================
    static void exo_4() {
        int Valeur_1;

        Console.WriteLine("Veuillez introduire une valeur ");
        Valeur_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Vous avez entrez la valeur {Valeur_1}");
    }
    //============================================
    static void exo_5() {
        int Somme;
        int Valeur_2;
        int Valeur_1;

        Console.WriteLine("Veuillez introduire une premiere valeur ");
        Valeur_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Veuillez introduire une deuxième valeur ");
        Valeur_2 = Convert.ToInt32(Console.ReadLine());

        Somme = Valeur_1 + Valeur_2;

        Console.WriteLine($"La somme des deux valeurs est {Somme}");
        Console.WriteLine();
    }
    //============================================
    static void exo_6() {
        int Produit;
        int Somme;
        int Valeur_1;
        int Valeur_2;

        Console.WriteLine("Veuillez introduire une premiere valeur ");
        Valeur_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Veuillez introduire une deuxième valeur ");
        Valeur_2 = Convert.ToInt32(Console.ReadLine());

        Somme = Valeur_1 + Valeur_2;
        Console.WriteLine($"La somme des deux valeurs est {Somme}");

        Produit = Valeur_1 * Valeur_2;
        Console.WriteLine($"Le produits des deux valeurs est {Produit}");
    }
    //========================================================================
    static void exo_7() {
        int Produit;
        int Somme;
        int Valeur_1;
        int Valeur_2;

        Console.WriteLine("Veuillez introduire une premiere valeur ");
        Valeur_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Veuillez introduire une deuxième valeur ");
        Valeur_2 = Convert.ToInt32(Console.ReadLine());

        Somme = Valeur_1 + Valeur_2;
        Produit = Valeur_1 * Valeur_2;

        Console.WriteLine($"La somme entre la Valeur : {Valeur_1} et la valeur {Valeur_2} est {Somme}. Le produit est {Produit}");
    }

    //=========================================================================
    static void exo_8() {
        int age;

        Console.WriteLine("Veuillez saisir votre age");
        age = Convert.ToInt32(Console.ReadLine());
        if (age > 18) {
            Console.WriteLine("Vous êtes majeur");
        }
        else {
            Console.WriteLine("Vous êtes mineur");
        }
    }
    //==========================================================================
    static void exo_9() {
        int age;
        string nom;

        Console.WriteLine("Veuillez saisir votre age");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Quelle est votre nom ?");
        nom = Convert.ToString(Console.ReadLine());

        if (age > 18) {
            Console.WriteLine($"Bonjour Mr {nom} Vous êtes mineur");
        }
        else {
            Console.WriteLine($"Bonjour Mr {nom} Vous êtes majeur");
        }
    }
    //==========================================================================
    static void exo_10() {
        int nb_etoile;
        int compteur_etoile = 0;
        Console.WriteLine("Veuillez introduire une valeur positive");
        nb_etoile = Convert.ToInt32(Console.ReadLine());
        while (compteur_etoile < nb_etoile) {
            Console.Write("*");
            compteur_etoile++;
        }
        Console.WriteLine();
    }
    //===========================================================================
    static void exo_11() {
        int nb_etoile;
        int compteur_etoile = 0;
        Console.WriteLine("Veuillez introduire une valeur positive");
        nb_etoile = Convert.ToInt32(Console.ReadLine());

        if (nb_etoile <= 0) {
            Console.Write("La valeur entré n'est pas positive");
        }

        while (compteur_etoile < nb_etoile) {
            Console.Write("*");
            compteur_etoile++;
        }
        Console.WriteLine();
    }
    //===========================================================================
    static void exo_12() {
        int nb_etoile;
        int compteur_etoile = 0;
        Console.WriteLine("Veuillez introduire une valeur positive");
        nb_etoile = Convert.ToInt32(Console.ReadLine());

        while (nb_etoile <= 0) {
            Console.WriteLine("La valeur entré n'est pas positive");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Veuillez réintroduire une valeur POSITIVE");
            nb_etoile = Convert.ToInt32(Console.ReadLine());
        }

        while (compteur_etoile < nb_etoile) {
            Console.Write("*");
            compteur_etoile++;
        }
        Console.WriteLine();
    }
    //============================================================================
    static void exo_13() {
        int nb_etoile;
        int compteur_etoile = 0;
        Console.WriteLine("Veuillez introduire une valeur entre 1 et 10");
        nb_etoile = Convert.ToInt32(Console.ReadLine());

        while (nb_etoile < 1 || nb_etoile > 10) {
            Console.WriteLine("La valeur entré n'est pas comprise entre 1 et 10");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Veuillez réintroduire une valeur entre 1 et 10");
            nb_etoile = Convert.ToInt32(Console.ReadLine());
        }

        while (compteur_etoile < nb_etoile) {
            Console.Write("*");
            compteur_etoile++;
        }
        Console.WriteLine();
    }
    //=============================================================================
    static void exo_14() {

        Console.WriteLine("Veuillez saisir un nombre entier positif : ");
        int nombre = Convert.ToInt32(Console.ReadLine());

        while (nombre < 0) {
            Console.WriteLine("Ce n'est pas un nombre positif veuillez réessayer");
            nombre = Convert.ToInt32(Console.ReadLine());
        }

        int somme = 0;
        for (int compteur = 0; compteur <= nombre; compteur++) {
            somme += compteur;
        }

        Console.WriteLine($"La somme de tous les nombres de 0 jusqu'à {nombre} est : {somme}.");

    }
    //=============================================================================
    static void exo_15() {
        Console.WriteLine("Veuillez saisir un nombre entier positif : ");
        int nombre = Convert.ToInt32(Console.ReadLine());

        while (nombre < 0) {
            Console.WriteLine("Ce n'est pas un nombre positif veuillez réessayer");
            nombre = Convert.ToInt32(Console.ReadLine());
        }

        int produit = 1;
        for (int compteur = 1; compteur <= nombre; compteur++) {
            produit *= compteur;
        }

        Console.WriteLine($"Le produit de tous les nombres de 0 jusqu'à {nombre} est : {produit}.");

    }
    //==============================================================================
    static void exo_16() {
        Console.WriteLine("Veuillez entrer une valeur positive ");
        int taille = Convert.ToInt32(Console.ReadLine());

        while (taille <= 0) {
            Console.WriteLine("ERREUR: veuillez entrer une taille valide et positive : ");
            taille = Convert.ToInt32(Console.ReadLine());
        }
        for (int ligne = 0; ligne < taille; ligne++) {
            for (int colonne = 0; colonne < taille; colonne++) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    //===============================================================================
    static void exo_17() { //A REVOIR
        Console.WriteLine("Veuillez entrer la taille de la pyramide : ");
        int taille = Convert.ToInt32(Console.ReadLine());

        while (taille <= 0) {
            Console.WriteLine("Veuillez entrer une taille valide et positive : ");
            taille = Convert.ToInt32(Console.ReadLine());
        }

        for (int ligne = taille; ligne >= 1; ligne--) {
            for (int etoile = 1; etoile <= ligne; etoile++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    //===============================================================================
    static void exo_18() {
        int somme = 0;
        int nombreDeValeurs = 10;

        Console.WriteLine($"Veuillez entrer {nombreDeValeurs} valeurs : ");

        for (int compteur = 1; compteur <= nombreDeValeurs; compteur++) {
            Console.Write($"Valeur {compteur}: ");
            somme += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"La moyenne de ces {nombreDeValeurs} valeurs est {somme}");

    }
    //===============================================================================
    static void exo_19() {
        int somme = 0;
        int nombreDeValeurs = 10;

        Console.WriteLine($"Veuillez entrer {nombreDeValeurs} valeurs : ");

        for (int compteur = 1; compteur <= nombreDeValeurs; compteur++) {
            Console.Write($"Valeur {compteur}: ");
            somme += Convert.ToInt32(Console.ReadLine());
        }
        double moyenne = somme / nombreDeValeurs;
        Console.WriteLine($"La moyenne de ces {nombreDeValeurs} valeurs est {moyenne}");
    }
    //=========================================================================================
    static void exo_20() {
        int nombreDeValeurs = 10;
        int valeur = 0;
        int valeur_min = int.MaxValue;//int maxvalue permet d'initialiser la variable valeur_min a la valeur max d'un int
                                      //pour que la premiere valeur soit forcément plus petite que lui

        Console.WriteLine($"Veuillez entrer {nombreDeValeurs} valeurs : ");

        for (int compteur = 1; compteur <= nombreDeValeurs; compteur++) {
            Console.Write($"Valeur {compteur}: ");
            valeur = Convert.ToInt32(Console.ReadLine());
            if (valeur < valeur_min) {
                valeur_min = valeur;
            }
        }
        Console.WriteLine($"La valeur la plus petite est {valeur_min}");
    }
    //=================================================================================
    static void exo_21() {
        int nombreDeValeurs = 10;
        int valeur = 0;
        int valeur_min = int.MaxValue;
        int valeur_max = int.MinValue;
        int somme = 0;
        int moyenne = 0;
        Console.WriteLine($"Veuillez entrer {nombreDeValeurs} valeurs : ");

        for (int compteur = 1; compteur <= nombreDeValeurs; compteur++) {
            Console.Write($"Valeur {compteur}: ");
            valeur = Convert.ToInt32(Console.ReadLine());
            somme += valeur;
            if (valeur < valeur_min) {
                valeur_min = valeur;
            }
            if (valeur > valeur_max) {
                valeur_max = valeur;
            }
            moyenne = somme / nombreDeValeurs;
        }
        Console.WriteLine($"La moyenne des {nombreDeValeurs} valeurs est {moyenne} la plus petite est {valeur_min} et la valeur la plus grande valeur est {valeur_max}");
    }
    //======================================================================================
    static void exo_22() {
        int nb_etoile;
        int compteur_etoile = 0;
        Console.WriteLine("Veuillez introduire une valeur entre 1 et 10");
        nb_etoile = Convert.ToInt32(Console.ReadLine());

        while (nb_etoile < 1 || nb_etoile > 10) {
            Console.WriteLine("La valeur entré n'est pas comprise entre 1 et 10");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Veuillez réintroduire une valeur entre 1 et 10");
            nb_etoile = Convert.ToInt32(Console.ReadLine());
        }

        while (compteur_etoile < nb_etoile) {
            for (int compteur = 1; compteur <= nb_etoile; compteur++) {
                if (compteur % 2 == 0) {
                    Console.Write("#");
                }
                else {
                    Console.Write("*");
                }
                compteur_etoile++;
            }
            Console.WriteLine();
        }
    }
    //=============================================================================
    static void exo_23() {
        Console.WriteLine("Veuillez entrer une valeur positive : ");
        int taille = Convert.ToInt32(Console.ReadLine());

        while (taille <= 0) {
            Console.WriteLine("ERREUR: veuillez entrer une taille valide et positive : ");
            taille = Convert.ToInt32(Console.ReadLine());
        }

        for (int ligne = 0; ligne < taille; ligne++) {
            for (int colonne = 0; colonne < taille; colonne++) {
                if ((ligne + colonne) % 2 == 0) {
                    Console.Write("* ");
                }
                else {
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }
    //========================================================================================
    static void exo_24() {
        Console.WriteLine("Veuillez entrer la taille de la pyramide : ");
        int taille = Convert.ToInt32(Console.ReadLine());

        while (taille <= 0) {
            Console.WriteLine("Veuillez entrer une taille valide et positive : ");
            taille = Convert.ToInt32(Console.ReadLine());
        }

        for (int ligne = taille; ligne >= 1; ligne--) {
            for (int etoile = 1; etoile <= ligne; etoile++) {
                if (etoile % 2 == 0) {
                    Console.Write("#");
                }
                else {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
    static void exo_25() {
        Console.WriteLine("Veuillez entrer une valeur positive : ");
        int taille = Convert.ToInt32(Console.ReadLine());

        while (taille <= 0) {
            Console.WriteLine("ERREUR: veuillez entrer une taille valide et positive : ");
            taille = Convert.ToInt32(Console.ReadLine());
        }

        for (int ligne = 0; ligne < taille; ligne++) {
            for (int colonne = 0; colonne < taille; colonne++) {
                if (ligne == 0 || ligne == taille - 1 || colonne == 0 || colonne == taille - 1) {
                    Console.Write("# ");
                }
                else {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
    //===============================================================================================
    static void exo_26() {
        char symbole;

        Console.WriteLine("Quelle symbole souhaitez vous utiliser ?");
        symbole = Convert.ToChar(Console.ReadLine());     
        
        Console.WriteLine("Veuillez entrer une valeur positive : ");
        int taille = Convert.ToInt32(Console.ReadLine());

        while (taille <= 0) {
            Console.WriteLine("ERREUR: veuillez entrer une taille valide et positive : ");
            taille = Convert.ToInt32(Console.ReadLine());
        }

        for (int ligne = 0; ligne < taille; ligne++) {
            for (int colonne = 0; colonne < taille; colonne++) {
                if (ligne == 0 || ligne == taille - 1 || colonne == 0 || colonne == taille - 1) {
                    Console.Write($"{symbole} ");
                }
                else {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}