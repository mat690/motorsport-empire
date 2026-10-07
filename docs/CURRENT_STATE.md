# Motorsport Empire — État actuel du développement

## Environnement

- Moteur : Godot 4.7.2 .NET
- Langage : C#
- Target principal actuel : .NET 8
- Nullable Reference Types activés dans le projet
- Git et GitHub configurés
- Dépôt GitHub privé
- État actuel : 0 erreur / 0 avertissement C#

## Objectif actuel

Développement de la V0.1 : construire le squelette fonctionnel du monde et d'une saison avant d'ajouter les systèmes avancés.

Le code actuel est volontairement simple. Il constitue la fondation du jeu définitif et sera progressivement enrichi.

## Modèles actuellement créés

### Driver

Contient actuellement :
- prénom
- nom
- âge
- nationalité
- statistiques de base
- potentiel réel caché
- équipe actuelle nullable

Le pilote peut exister sans équipe, ce qui sera notamment nécessaire pour les transferts et le mode Vagabond.

### DriverKnowledge

Sépare la vraie valeur du pilote de la connaissance qu'en possède le joueur.

Contient actuellement :
- niveau de connaissance
- estimation min/max du potentiel
- biais d'évaluation

Le potentiel réel du pilote n'est pas directement exposé au joueur.

### Team

Contient actuellement :
- nom
- nationalité
- budget
- premier pilote
- deuxième pilote
- voiture

Les pilotes et la voiture peuvent être absents temporairement.

### Car

Contient actuellement :
- nom
- aérodynamique
- puissance
- grip mécanique
- fiabilité

Ces statistiques sont provisoires et seront beaucoup plus détaillées dans les versions futures.

La voiture peut calculer une performance théorique selon les caractéristiques d'un circuit.

### Circuit

Contient actuellement :
- nom
- pays réel
- importance aérodynamique
- importance puissance
- importance grip mécanique

Les circuits eux-mêmes sont fictifs mais sont situés dans des pays réels.

Deux circuits de test existent :
- Circuit des Hautes-Rives — France
- Autodrome de Valdora — Italie

Le système voiture/circuit a été validé :
- une voiture peut être meilleure sur un circuit
- une autre voiture peut reprendre l'avantage sur un circuit aux caractéristiques différentes

### Championship

Contient actuellement :
- nom
- liste des équipes
- calendrier

Test actuel :
- World Racing Championship
- Asterion Racing
- Velox Motorsport

La gestion de plusieurs équipes via List<Team> fonctionne.

### RaceWeekend

Contient actuellement :
- numéro de manche
- circuit

Le championnat possède une List<RaceWeekend> servant de calendrier.

Calendrier de test actuel :
1. Circuit des Hautes-Rives — France
2. Autodrome de Valdora — Italie

Le calendrier a été testé avec succès.

## Architecture validée actuellement

Driver
→ Team
→ Championship

Car
→ Circuit
→ performance théorique dépendante du circuit

Championship
→ Calendar
→ RaceWeekend
→ Circuit

## Tests

Le script principal de test est actuellement :

res://tests/TestDriver.cs

Il sert uniquement à vérifier les modèles pendant la construction de la V0.1.

Les GD.Print() sont temporaires et ne représentent pas l'interface finale du jeu.

## Principes architecturaux importants

- La simulation doit rester indépendante de la présentation 3D autant que possible.
- Le joueur et l'équipe devront être deux entités distinctes.
- Les vraies valeurs de simulation peuvent être différentes des informations connues du joueur.
- Les formats de week-end ne doivent pas être codés définitivement en FP1/FP2/FP3/Q1/Q2/Q3/course.
- Les réglementations devront pouvoir modifier le format sportif et les règles techniques.
- Les systèmes électriques, hybrides, batteries, récupération et déploiement énergétique feront partie des futures réglementations et du développement des groupes propulseurs.
- Les circuits sont fictifs mais utilisent des pays et nationalités réels.
- Le code actuel est un squelette destiné à évoluer, pas le niveau de profondeur final.

## État Git

Dernier checkpoint prévu/réalisé :

"Add championship calendar and race weekends"

Le projet a été push sur GitHub.

## PROCHAINE ÉTAPE EXACTE

Ne pas commencer directement la simulation complexe d'une course.

Continuer la V0.1 à partir du calendrier.

Prochaine petite étape :
créer la structure minimale permettant d'enregistrer un résultat simplifié de course.

Ensuite, progressivement :
1. résultat simplifié d'une manche
2. attribution de points
3. classement pilotes
4. classement constructeurs
5. plusieurs manches
6. saison complète
7. fin de saison
8. passage à la saison suivante
9. sauvegarde / chargement

Ne pas implémenter maintenant les systèmes avancés de R&D, stratégie, météo, essais, 3D, New Gen ou réglementations. Ils sont documentés dans VISION.md / ROADMAP.md et viendront dans leurs phases respectives.