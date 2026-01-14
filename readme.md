# Light Control

Light Control ist eine in C# entwickelte Anwendung zur zentralen Steuerung verschiedener Smart-Lighting-Systeme über eine einheitliche Oberfläche und API.

## Description

**Light Control** ermöglicht die Steuerung und Automatisierung mehrerer populärer Smart-Lampensysteme innerhalb eines einzigen Projekts.  
Aktuell unterstützt (bzw. geplant unterstützt) werden:

- Elgato Key Light
- Philips Hue
- Govee Lamps

Das Projekt richtet sich insbesondere an Streamer, Content-Creator und Entwickler, die ihre Beleuchtung dynamisch an Szenen, Tageszeiten oder externe Events anpassen möchten.  
Durch eine modulare Architektur kann die Unterstützung weiterer Hersteller problemlos ergänzt werden.

## Getting Started

### Dependencies

Folgende Voraussetzungen werden benötigt:

- .NET 7.0 oder neuer  
- Windows 10 / 11  
- Netzwerkzugriff auf die jeweiligen Lampen  
- Für Philips Hue: eine konfigurierte Hue Bridge  
- Für Govee: gültiger API-Key  

Zusätzlich verwendete Libraries (abhängig vom Projektstand):

- System.Net.Http
- Newtonsoft.Json oder System.Text.Json
- Hersteller-spezifische APIs

### Setup

1. Repository klonen:
   ```bash
   git clone https://github.com/sirmpixx/light-control.git
   ```
### Running the Application

1. Projekt bauen:
   ```bash
   dotnet build
   ```
2. Anwendung starten:
   ```bash
   dotnet run
   ```
3. Lampen über Konfiguration oder UI/API steuern

## Help

Häufige Probleme:

- Lampen reagieren nicht  
  - Netzwerkverbindung prüfen  
  - IP-Adresse korrekt?  

- Philips Hue  
  - Bridge-Button gedrückt?  
  - API-User vorhanden?  

- Govee  
  - API-Key gültig?  
  - Geräte-ID korrekt?  

## Authors

Maximilian Lanski  
[@sirmpixx](https://www.sirmpixx.de)

## Version History

- Version 1.0  


## License

Dieses Projekt steht unter der MIT License.  
Details siehe LICENSE Datei.

## Acknowledgments

- Smart-Lighting-Community  
- Hersteller-APIs (Elgato, Philips, Govee)  
- README-Vorlage:  
  https://gist.github.com/DomPizzie/7a5ff55ffa9081f2de27c315f5018afc
