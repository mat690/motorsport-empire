# MOTORSPORT EMPIRE — ÉTAT ACTUEL

## Phase actuelle

PRÉPRODUCTION — Mise en place du projet

## Version

Pré-V0.1

## Moteur

Langage principal : C#

Godot utilisé : édition .NET

Architecture prévue :
- C# pour le cœur de la simulation et la logique du jeu
- Godot pour les scènes, l'interface, la 3D, l'audio et la présentation
## État du projet

Le projet Godot est créé.

Structure actuelle :

- core/
- data/
- scenes/
- scripts/
- simulation/
- tests/
- ui/
- docs/
La migration initiale de GDScript vers C# est terminée.

Première classe fonctionnelle :
- Driver.cs

Premier test C# fonctionnel :
- TestDriver.cs

Un pilote fictif peut être créé et ses données peuvent être lues.
## Documentation

Créé :

- VISION.md
- DECISIONS.md
- CURRENT_STATE.md
- ROADMAP.md

VISION.md contient la vision générale du projet.

## Objectif actuel

Construire la V0.1 du moteur de simulation.

La V0.1 doit permettre de créer un petit univers fictif contenant :

- équipes ;
- pilotes ;
- voitures ;
- circuits ;
- championnat ;
- calendrier.

Puis simuler une première saison.

## Pas encore développé

Aucun système de gameplay n'est encore implémenté.

Aucune interface définitive.

Aucune course 3D.

Aucune IA avancée.

Aucun système R&D.

Aucun système de contrats.

Aucun système de sponsors.

Aucun système d'académie.

Aucune cinématique.

## Prochaine étape

Préparer ROADMAP.md puis commencer l'architecture de données de la V0.1.

## Règle de développement

Ne pas développer plusieurs gros systèmes simultanément.

Construire, tester et valider chaque fondation avant de passer
à la suivante.

La simulation reste indépendante de sa représentation graphique.

## Dernier point de reprise

Le projet Godot fonctionne et la documentation initiale est en cours
de création.

Prochaine action :
remplir ROADMAP.md.