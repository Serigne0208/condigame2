﻿using CodinGame.Fini;

namespace CodinGameTest
{
    public class PanelCount_Test
    {
        [Fact]
        public void Cas1()
        {
            var lstp = new List<string>()
            {
                "Gender"
            };
            var lalues = new List<string>()
            {
                "Leo Male","Samuel Male","Maya Female"
                ,"Diane Female","Mael Male"
            };
            var conditions = new List<string>()
            {
                "Gender=Female"
            };

            var output = _93_PanelCount.CountOccurence(lstp,lalues,conditions);

            Assert.Equal(2, output[0]);
        }
        [Fact]
        public void Cas2()
        {
            var lstp = new List<string>()
            {
                "Town"
            };

            var values = new List<string>()
            {
                "Eliott Paris","Luna Paris","Eleonore Nantes"
                ,"Maelys Montpellier","Nathan Lille","Adam Nantes","Diane Lille"

            };
            var conditions = new List<string>()
            {
                "Town=Lille"
            };

            var output = _93_PanelCount.CountOccurence(lstp,values,conditions);

            Assert.Equal(2, output[0]);
        }
        [Fact]
        public void Cas3()
        {
            var lstp = new List<string>()
            {
                "Gender","Age","Town"
                
            };
            var values = new List<string>()
            {
                "Nina Female 27 Nantes","Mehdi Male 61 Marseille","Marius Male 6 Lyon"
                ,"Felix Male 20 Paris","Leonard Male 57 Strasbourg","Lila Female 74 Montpellier"
                ,"Victor Male 7 Toulouse","Capucine Female 82 Nantes","Faustine Female 27 Lyon"
                ,"Yanis Male 55 Lyon","Clara Female 43 Toulouse","Melissa Female 91 Lyon"

            };
            var conditions = new List<string>()
            {
                "Town=Lyon","Gender=Male"
            };

            var output = _93_PanelCount.CountOccurence(lstp,values,conditions);

            Assert.Equal(4, output[0]);
            Assert.Equal(6, output[1]);
        }
        [Fact]
        public void Cas4()
        {
            var lstp = new List<string>()
            {
                "Gender","Age","Town"
                
            };
            var values = new List<string>()
            {
                "Nina Female 27 Nantes","Mehdi Male 61 Marseille","Marius Male 6 Lyon"
                ,"Felix Male 20 Paris","Leonard Male 57 Strasbourg","Lila Female 74 Montpellier"
                ,"Victor Male 7 Toulouse","Capucine Female 82 Nantes","Faustine Female 27 Lyon"
                ,"Yanis Male 55 Lyon","Clara Female 43 Toulouse","Melissa Female 91 Lyon"

            };
            var conditions = new List<string>()
            {
                "Gender=Male AND Town=Lyon"
            };


            var output = _93_PanelCount.CountOccurence(lstp,values,conditions);

            Assert.Equal(2, output[0]);
        }
        [Fact]
        public void Cas7()
        {
            var lstp = new List<string>()
            { "Gender",
"Age",
"Town",
"CSP",
"FAI" };
            var lstString = new List<string>()
            {
"Gabriel Male 99 Marseille Retraite SFR",
"Alexandre Male 59 Bordeaux Employe SFR",
"Arthur Male 31 Marseille Agriculteur Bouygues",
"Adam Male 13 Nantes Ouvrier Orange",
"Raphael Male 98 Lyon Employe Free",
"Louis Male 55 Nantes Inactif SFR",
"Paul Male 92 Nantes Employe SFR",
"Antoine Male 78 Nice Inactif Free",
"Maxime Male 85 Nantes Employe Orange",
"Thomas Male 23 Paris Employe Free",
"Victor Male 7 Toulouse Inactif Bouygues",
"Lucas Male 20 Nice Retraite Orange",
"Jules Male 60 Nice Cadre Free",
"Nathan Male 6 Lille Employe SFR",
"Hugo Male 65 Bordeaux Artisan Free",
"Sacha Male 59 Strasbourg Agriculteur Free",
"Mohamed Male 50 Toulouse Agriculteur Bouygues",
"Enzo Male 89 Strasbourg Employe Bouygues",
"Gaspard Male 83 Strasbourg Artisan Orange",
"Clement Male 93 Marseille Inactif Free",
"Samuel Male 76 Lille Retraite Free",
"Ethan Male 50 Marseille Inactif Free",
"Leo Male 5 Nice Agriculteur SFR",
"Adrien Male 38 Lyon Inactif Orange",
"Martin Male 89 Montpellier Retraite Free",
"Rayan Male 89 Lille Retraite Bouygues",
"Baptiste Male 71 Lille Employe Free",
"Yanis Male 55 Lyon Retraite Orange",
"Simon Male 6 Paris Cadre Free",
"Joseph Male 22 Toulouse Retraite Bouygues",
"Mathis Male 80 Montpellier Inactif Free",
"Oscar Male 87 Lyon Cadre SFR",
"Alexis Male 54 Bordeaux Employe Bouygues",
"Pierre Male 79 Lille Agriculteur SFR",
"Noah Male 37 Lille Cadre Free",
"Axel Male 46 Lyon Retraite Free",
"Theo Male 50 Montpellier Inactif Free",
"Romain Male 67 Lille Retraite Bouygues",
"Valentin Male 95 Toulouse Inactif Orange",
"Augustin Male 14 Strasbourg Cadre SFR",
"Julien Male 39 Nice Employe Orange",
"Nicolas Male 54 Strasbourg Employe Free",
"Maxence Male 55 Bordeaux Employe Orange",
"Noe Male 93 Nice Artisan SFR",
"Benjamin Male 45 Marseille Retraite Bouygues",
"Quentin Male 46 Lille Artisan Bouygues",
"Tom Male 94 Nice Cadre Orange",
"Charles Male 98 Toulouse Employe Orange",
"David Male 30 Lyon Cadre SFR",
"Jean Male 50 Nice Retraite Bouygues",
"Eliott Male 69 Paris Cadre Free",
"Aaron Male 98 Montpellier Agriculteur Bouygues",
"Elias Male 46 Marseille Cadre Orange",
"Matthieu Male 87 Nice Cadre Orange",
"Tristan Male 70 Bordeaux Inactif Orange",
"Timothee Male 38 Lyon Employe SFR",
"Mathieu Male 19 Paris Artisan SFR",
"Matteo Male 4 Lille Employe Free",
"William Male 48 Strasbourg Retraite Bouygues",
"Amine Male 94 Lyon Artisan Bouygues",
"Felix Male 20 Paris Inactif Free",
"Côme Male 69 Marseille Employe Free",
"Ruben Male 48 Paris Retraite Free",
"Ulysse Male 17 Nice Employe Orange",
"Antonin Male 24 Montpellier Agriculteur Bouygues",
"Guillaume Male 6 Marseille Agriculteur Bouygues",
"Aurelien Male 26 Nantes Retraite Free",
"Robin Male 53 Montpellier Employe Free",
"Mael Male 71 Nantes Cadre Orange",
"Kevin Male 20 Marseille Retraite Bouygues",
"Mehdi Male 61 Marseille Agriculteur Free",
"Ismael Male 34 Marseille Inactif Orange",
"Liam Male 86 Strasbourg Ouvrier Orange",
"Gabin Male 78 Lyon Agriculteur Bouygues",
"Noam Male 15 Strasbourg Ouvrier SFR",
"Evan Male 81 Montpellier Ouvrier SFR",
"Marius Male 6 Lyon Agriculteur Free",
"Mathias Male 68 Marseille Retraite Bouygues",
"Isaac Male 41 Bordeaux Inactif SFR",
"Samy Male 25 Nantes Retraite SFR",
"Ibrahim Male 71 Marseille Employe Orange",
"Basile Male 99 Lille Retraite SFR",
"Daniel Male 30 Toulouse Artisan SFR",
"Emile Male 48 Toulouse Agriculteur Orange",
"Lucien Male 33 Toulouse Cadre Bouygues",
"Elie Male 26 Toulouse Retraite Bouygues",
"Rayane Male 50 Marseille Ouvrier Bouygues",
"Leonard Male 57 Strasbourg Employe SFR",
"Thibault Male 39 Nantes Retraite SFR",
"Achille Male 16 Bordeaux Artisan SFR",
"Leon Male 58 Lille Artisan Orange",
"Edouard Male 85 Paris Retraite Free",
"Hadrien Male 66 Strasbourg Employe Free",
"Lenny Male 46 Marseille Agriculteur Free",
"Matheo Male 32 Montpellier Cadre Orange",
"Malo Male 15 Lille Artisan Free",
"Titouan Male 77 Marseille Agriculteur Bouygues",
"Solal Male 32 Marseille Cadre Bouygues",
"Joshua Male 43 Lille Artisan Free",
"Max Male 76 Lyon Artisan Free",
"Louise Female 89 Marseille Retraite Bouygues",
"Camille Female 14 Lyon Agriculteur SFR",
"Emma Female 69 Lyon Inactif Free",
"Ines Female 92 Lyon Cadre Free",
"Chloe Female 56 Bordeaux Employe Bouygues",
"Sarah Female 52 Lille Inactif Bouygues",
"Alice Female 65 Nice Ouvrier Bouygues",
"Lea Female 39 Marseille Agriculteur Bouygues",
"Juliette Female 30 Lyon Employe Free",
"Jeanne Female 40 Toulouse Cadre Orange",
"Eva Female 10 Marseille Agriculteur Orange",
"Clara Female 43 Toulouse Retraite Orange",
"Lina Female 56 Paris Agriculteur Bouygues",
"Anna Female 11 Marseille Agriculteur Orange",
"Charlotte Female 25 Nantes Cadre Bouygues",
"Mathilde Female 35 Lyon Agriculteur SFR",
"Marie Female 56 Montpellier Retraite SFR",
"Manon Female 33 Montpellier Inactif Bouygues",
"Lucie Female 81 Paris Agriculteur Free",
"Anaïs Female 88 Lyon Ouvrier Orange",
"Jade Female 33 Strasbourg Ouvrier Bouygues",
"Zoe Female 76 Montpellier Artisan Bouygues",
"Nina Female 27 Nantes Artisan Orange",
"Lou Female 46 Lyon Retraite Free",
"Clemence Female 50 Marseille Artisan SFR",
"Pauline Female 26 Nantes Employe Bouygues",
"Lisa Female 92 Nice Inactif SFR",
"Adele Female 86 Strasbourg Artisan SFR",
"Gabrielle Female 92 Lyon Employe Bouygues",
"Romane Female 19 Nantes Agriculteur SFR",
"Julia Female 96 Toulouse Artisan SFR",
"Victoria Female 66 Lille Artisan Bouygues",
"Emilie Female 19 Bordeaux Artisan Free",
"Rose Female 25 Toulouse Employe Bouygues",
"Julie Female 72 Nice Cadre Bouygues",
"Margaux Female 69 Lyon Artisan Free",
"Lena Female 73 Nice Inactif SFR",
"Victoire Female 18 Toulouse Inactif Free",
"Lola Female 68 Strasbourg Ouvrier Bouygues",
"Valentine Female 57 Nantes Ouvrier SFR",
"Agathe Female 53 Bordeaux Artisan SFR",
"Alix Female 12 Toulouse Cadre Bouygues",
"Elisa Female 23 Nice Employe Orange",
"Elise Female 29 Lyon Ouvrier Bouygues",
"Margot Female 15 Marseille Artisan SFR",
"Yasmine Female 87 Lyon Cadre Bouygues",
"Laura Female 75 Nantes Agriculteur Free",
"Noa Female 98 Nantes Employe Free",
"Sofia Female 40 Strasbourg Artisan Bouygues",
"Noemie Female 19 Toulouse Retraite Free",
"Heloïse Female 95 Montpellier Ouvrier Bouygues",
"Sara Female 98 Nantes Employe Free",
"Apolline Female 59 Montpellier Cadre Bouygues",
"Salome Female 3 Marseille Ouvrier Bouygues",
"Diane Female 65 Lille Employe Free",
"Maya Female 23 Paris Employe SFR",
"Ambre Female 55 Toulouse Agriculteur Bouygues",
"Elsa Female 5 Lyon Cadre SFR",
"Josephine Female 65 Bordeaux Agriculteur Orange",
"Capucine Female 82 Nantes Employe SFR",
"Ava Female 18 Nantes Ouvrier Bouygues",
"Sasha Female 21 Montpellier Employe SFR",
"Eleonore Female 70 Nantes Inactif Free",
"Iris Female 19 Lille Inactif Free",
"Fatoumata Female 78 Montpellier Agriculteur Orange",
"Alicia Female 38 Montpellier Cadre Free",
"Eden Female 91 Nantes Retraite Free",
"Mila Female 72 Lille Employe SFR",
"Nour Female 96 Lille Artisan Orange",
"Andrea Female 67 Montpellier Ouvrier Free",
"Garance Female 63 Lille Retraite Bouygues",
"Aya Female 45 Lyon Agriculteur SFR",
"Violette Female 78 Lyon Ouvrier Free",
"Constance Female 53 Montpellier Employe SFR",
"Justine Female 53 Nice Artisan Orange",
"Melissa Female 91 Lyon Inactif Bouygues",
"Oceane Female 64 Bordeaux Retraite Bouygues",
"Olivia Female 16 Lyon Artisan Bouygues",
"Esther Female 35 Lyon Ouvrier Bouygues",
"Ines Female 94 Nice Inactif SFR",
"Luna Female 23 Paris Employe Free",
"Suzanne Female 29 Lille Ouvrier Orange",
"Mariam Female 13 Paris Agriculteur Orange",
"Maelys Female 65 Montpellier Ouvrier SFR",
"Myriam Female 98 Strasbourg Artisan Free",
"Sophie Female 98 Marseille Employe Bouygues",
"Celia Female 30 Strasbourg Retraite Bouygues",
"Lila Female 74 Montpellier Artisan Bouygues",
"Madeleine Female 36 Montpellier Employe Free",
"Marion Female 8 Paris Employe Orange",
"Anouk Female 34 Strasbourg Retraite Bouygues",
"Stella Female 86 Toulouse Agriculteur SFR",
"Eloïse Female 10 Nice Inactif Orange",
"Charlie Female 85 Paris Agriculteur SFR",
"Leonie Female 70 Nantes Agriculteur SFR",
"Chiara Female 25 Marseille Cadre Bouygues",
"Carla Female 80 Nantes Cadre Orange",
"Blanche Female 68 Montpellier Retraite Orange",
"Faustine Female 27 Lyon Retraite SFR",
"Claire Female 34 Strasbourg Employe Orange"};
    var condition = new List<string>() { 
"Gender=Male AND Town=Lyon AND FAI=Bouygues",
"CSP=Retraite AND Town=Bordeaux",
"Town=Toulouse AND Gender=Female AND FAI=Orange",
"Town=Nantes AND Gender=Male AND FAI=Orange AND CSP=Cadre AND Age=45",
"Age=50",
"CSP=Artisan",
"CSP=Cadre AND Town=Paris",
"FAI=Free AND Gender=Male",
"Gender=Male AND Age=4",
"FAI=Free AND Gender=Male AND CSP=Employe"};

            var output = _93_PanelCount.CountOccurence(lstp,lstString,condition);

            Assert.Equal(2, output[0]); // "Gender=Male AND Town=Lyon AND FAI=Bouygues"
            Assert.Equal(1, output[1]); // "CSP=Retraite AND Town=Bordeaux"
            Assert.Equal(2, output[2]); // "Town=Toulouse AND Gender=Female AND FAI=Orange"
            Assert.Equal(0, output[3]); // "Town=Toulouse AND Gender=Female AND FAI=Orange"
            Assert.Equal(6, output[4]); // "Town=Nantes AND Gender=Male AND FAI=Orange AND CSP=Cadre AND Age=45"
            Assert.Equal(28, output[5]); // "CSP=Cadre AND Town=Paris"
            Assert.Equal(2, output[6]); //"CSP=Cadre AND Town=Paris"
            Assert.Equal(32, output[7]); // "FAI=Free AND Gender=Male"
            Assert.Equal(1, output[8]); //"Gender=Male AND Age=4"
            Assert.Equal(8, output[9]); //"FAI=Free AND Gender=Male AND CSP=Employe"

        }
    }
}
