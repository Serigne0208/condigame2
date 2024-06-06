
  Objectif
Détruisez les zombies rapidement pour gagner des points et faites en sorte que les humains restent en vie pour obtenir le meilleur score possible.
  Règles
La partie se joue sur une zone de 16000 unités de large par 9000 unités de haut. Vous contrôlez le déplacement de Ash qui dispose d'un flingue lui permettant de tuer tout zombie se trouvant dans un certain rayon autour de lui.

Ash se comporte ainsi :

    Ash peut recevoir l'ordre de se déplacer vers n'importe quel point de la zone de jeu en affichant une coordonnée X Y. Le point se situant dans le coin en haut à gauche a pour coordonnées 0 0.
    À chaque tour, Ash se déplace de 1000 unités en direction de la coordonnée cible, ou sur la cible s'il se situe à moins de 1000 unités.
    Si à la fin d'un tour, un zombie se trouve dans un rayon de 2000 unités de Ash, il tire sur le zombie pour le détruire. Le détails sur le combat est expliqué plus loin.


D'autre humains seront présents dans l'aire de jeu, mais ils ne bougent pas. Si les zombies les tuent tous alors vous perdez la partie et vous obtenez un score de 0 points pour le test en cours.

Les zombies sont placés dans la zone de jeu au début de la partie, ils doivent être détruits afin de gagner des points.

Les zombies se comportent ainsi :

    À chaque tour, chaque zombie se déplace en direction de l'humain le plus proche, incluant Ash, et par pas de 400 unités. Si le zombie se trouve à moins de 400 unités, le zombie se déplace sur la coordonnée de l'humain et le tue.
    Deux zombies peuvent se situer à la même coordonnée.


L'ordre dans lequel se déroule les actions entre deux tours est celui-ci :

    Les zombies se déplacent vers leurs cibles.
    Ash se déplace vers sa cible.
    Tout zombie se situant dans un rayon de moins de 2000 unités est détruit.
    Si un zombie se trouve sur un humain alors il le mange.


Tuer des zombies vous rapporte des points. Le nombre de points que vous gagnez par zombie est sujet à plusieurs facteurs.

Le système de points fonctionne ainsi :

    La valeur d'un zombie tué est égal au nombre d'humains encore en vie au carré et multiplié par 10, sans inclure Ash.
    Si plusieurs zombies sont détruits pendant un même tour, la valeur du nème zombie tué est multiplié par le (n+2)ème terme de la suite de Fibonacci (1, 2, 3, 5, 8, etc). Vous avez donc tout intérêt à tuer un maximum de zombies dans un même tour !


Remarque : Vous pouvez activer le mode gore dans le panneau des options () si vous avez le cran.
 
Conditions de victoire
Vous tuez tous les zombies présent à l'écran avec au moins un humain encore en vie.
 
Conditions de défaite
Les zombies tuent tous les humains (sans vous compter)
  Règles pour les experts
Le système de coordonnées utilisé pour ce jeu se base uniquement sur des nombres entiers. Si Ash ou un zombie devrait se déplacer sur une case dont les coordonnées ne seraient pas entières, alors les coordonnées sont arrondies à l'entier inférieur le plus proche.

Par exemple, supposons qu'un zombie situé en X=0, Y=0 se dirige vers un humain en X=500, Y=500. Étant donné qu'il ne peut se déplacer que de 400 unités par tour, il devrait alors se trouver aux coordonnées X=282.843, Y=282.843 après un tour, mais en réalité il se trouvera en X=282, Y=282.

Pour aider, les coordonnées futures de chaque zombie sont indiquées en plus des coordonnées actuelles.
  Exemple
Le joueur débute à la position X=8043, Y=976. Deux zombies sont proches mais le joueur décide de se déplacer près de l'humain en X=0, Y=4500.
Tour 1
Action: 0 3433.
Les zombies 0 et 1 se dirigent vers le joueur.
Tour 2
Action: 0 3833.
Le joueur se rapproche du zombie 1 et s'éloigne du zombie 0.
Tour 3
Action: 0 4233.
Le zombie 1 entre dans la zone de tir du joueur et il est donc détruit !
 
 
 
 
  Note
N'oubliez pas d'exécuter les tests en les lançant depuis la fenêtre « Jeu de tests ». Vous n'avez pas besoin de réussir l'ensemble des tests pour pouvoir rentrer dans le classement. Chaque test que vous passez vous rapportera un certain nombre de points.

Attention : les tests fournis sont similaires à ceux qui seront utilisés pour calculer votre score final mais ils sont différents. Ceci sert à éviter les solutions « codées en dur ». Ces solutions ne devraient pas rapporter de points.

Votre score est calculé à partir de la somme de tous les points gagnés à travers les tests.

N'hésitez pas à passer en mode débug () si vous êtes bloqués. Dans le mode débug, passer au dessus d'un zombie ou d'un humain permet de voir ses coordonnées.
  Entrées du jeu
Le programme doit, dans une boucle infinie, lire les données depuis l'entrée standard (position des humains et des zombies) et afficher en sortie l'instruction voulue.
Entrée pour un tour de jeu

Ligne 1 : deux entiers x et y séparés par un espace : les coordonnées de votre personnage.

Ligne 2 : un entier humanCount, le nombre d'humains encore en vie.

Les humanCount lignes suivantes : trois entiers séparés par un espace humanId, humanX et humanY, l'identifiant unique et les coordonnées d'un humain.

Ligne suivante : Un entier zombieCount, le nombre de zombies restant à détruire.

Les zombieCount lignes suivantes : cinq entiers séparés par un espace zombieId, zombieX, zombieY, zombieXNext et zombieYNext, l'identifiant unique, les coordonnées courantes et les coordonnées futures d'un zombie.
Sortie pour un tour de jeu
Une ligne unique : deux entiers targetX et targetY, les coordonnées où vous souhaitez envoyer votre personnage. Vous pouvez également ajouter un message qui sera affiché à l'écran.
Contraintes

0 ≤ x < 16000

0 ≤ y < 9000

1 ≤ humanCount < 100

1 ≤ zombieCount < 100
Temps de réponse pour un tour de jeu ≤ 100ms
