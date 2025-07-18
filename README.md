# Base de Développement .NET Framework 4.6.1

Ce projet fournit une base de développement réutilisable pour les applications Windows basées sur .NET Framework 4.6.1. Il contient des composants essentiels pour créer rapidement des services Windows avec interface utilisateur interactive.

## 🎯 Objectif

Cette base de code a été conçue pour servir de fondation personnelle réutilisable et être partagée avec la communauté pour faciliter le développement d'applications Windows robustes.

## 📁 Structure du Projet

### 🔧 **MonitoringService**
Service Windows principal qui peut fonctionner en deux modes :
- **Mode Service** : Exécution en arrière-plan comme service Windows
- **Mode Interactif** : Lancement d'interfaces utilisateur pour la configuration et le monitoring

### 🎨 **Models**
Bibliothèque contenant les composants d'interface utilisateur réutilisables :
- **Forms** : Formulaires Windows Forms prêts à l'emploi
- **UserControls** : Contrôles utilisateur personnalisés
- **Composants UI** : Boutons stylisés, panneaux et autres éléments d'interface

### 🛠️ **Utils**
Bibliothèque d'utilitaires essentiels :
- **LogWriter** : Système de journalisation avancé
- **Helpers** : Fonctions d'aide diverses
- **Extensions** : Méthodes d'extension utiles

### 🔗 **Common**
Interfaces et contrats communs :
- **ILogger** : Interface de journalisation
- **ILogDisplay** : Interface d'affichage des logs

## 🚀 Démarrage Rapide

### Prérequis
- Visual Studio 2017 ou supérieur
- .NET Framework 4.6.1 ou supérieur
- Windows 7 ou supérieur

### Installation et Utilisation

1. **Cloner le repository**
   ```bash
   git clone https://github.com/BekxFR/Tools_Base_DotNet_CSharp.git
   ```

2. **Ouvrir la solution**
   ```
   MonitoringService/MonitoringService.sln
   ```

3. **Compiler le projet**
   - Définir MonitoringService comme projet de démarrage
   - Compiler en mode Debug ou Release

4. **Exécution**
   - **Mode Développement** : Exécuter depuis Visual Studio (mode interactif)
   - **Mode Service** : Installer comme service Windows

## 🔧 Configuration

Le service peut être configuré via le fichier `App.config` dans le projet MonitoringService.

## 📖 Utilisation des Composants

### LogWriter
```csharp
// Exemple d'utilisation du système de logs
var logger = new LogWriter("MonApplication");
logger.WriteLog("Message d'information", LogLevel.Info);
```

### Interfaces Common
```csharp
// Implémentation de l'interface ILogger
public class MonLogger : ILogger
{
    public void Log(string message) 
    { 
        // Votre implémentation
    }
}
```

## 🤝 Contribution

Les contributions sont les bienvenues ! N'hésitez pas à :
- Signaler des bugs
- Proposer des améliorations
- Soumettre des pull requests

## 📄 Licence

Ce projet est distribué sous licence MIT. Voir le fichier `LICENSE` pour plus d'informations.

## 🏗️ Architecture

```
┌── MonitoringService (Service Windows)
├── Models (UI Components)
│   ├── Forms
│   └── UserControls
├── Utils (Utilities)
│   └── LogWriter
└── Common (Interfaces)
    ├── ILogger
    └── ILogDisplay
```

## 🎯 Cas d'Usage

Cette base est idéale pour :
- Services de monitoring système
- Applications de supervision
- Services Windows avec interface de configuration
- Applications nécessitant un système de logs robuste

## 📋 Fonctionnalités Principales

- ✅ Service Windows configurable
- ✅ Interface utilisateur interactive
- ✅ Système de journalisation avancé
- ✅ Composants UI réutilisables
- ✅ Architecture modulaire
- ✅ Compatible .NET Framework 4.6.1

## 🔄 Évolutions Futures

- Ajout de tests unitaires
- Documentation API complète
- Exemples d'utilisation étendus

---

💡 **Astuce** : Ce projet sert de base solide pour vos développements. N'hésitez pas à l'adapter selon vos besoins spécifiques.
