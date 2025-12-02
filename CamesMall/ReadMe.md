# CamesMall - Application de type Alibaba

CamesMall est une application de commerce inspirée d'Alibaba, développée avec **.NET MAUI**. Elle permet de naviguer entre plusieurs pages : accueil, inscription, connexion et détails des produits.

## **Fonctionnalités principales**

- **HomePage (Accueil)**
  - Page principale affichant les produits.
  - Chaque produit peut être cliqué pour voir les détails.

- **Navigation**
  - Depuis la **HomePage**, cliquer sur un produit ouvre la page **Details**.
  - Sur la **HomePage**, cliquer sur **Get Started** redirige vers la page **Signup**.
  - Depuis **Signup**, cliquer sur **Login** redirige vers la page **Login**.
  - Depuis **Login**, cliquer sur **Login** redirige vers la **HomePage**.

- **Pages incluses**
  - `HomePage` : page d'accueil.
  - `Signup` : page d'inscription.
  - `Login` : page de connexion.
  - `Details` : page de détails du produit.
  - `HomeSales` : page des ventes (dashboard).
  - `MainPage` : dashboard principal.
  - `ProjectListPage` et `ManageMetaPage` : gestion de projets et métadonnées.

## **Navigation par Shell**

L’application utilise le **Shell de MAUI** pour la navigation avec des routes définies :

```xml
<ShellContent Title="HomePage" ContentTemplate="{DataTemplate views:HomePage}" Route="Homepage" />
<ShellContent Title="Signup" ContentTemplate="{DataTemplate views:Signup}" Route="signup" />
<ShellContent Title="Login" ContentTemplate="{DataTemplate views:login}" Route="login" />
<ShellContent Title="Details" ContentTemplate="{DataTemplate views:Details}" Route="Details" />
﻿
