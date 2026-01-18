# Four-in-a-Row Game Project

[![Platform](https://img.shields.io/badge/platform-Windows-blue.svg)](https://www.microsoft.com/windows)
[![.NET](https://img.shields.io/badge/.NET-4.5+-purple.svg)](https://dotnet.microsoft.com/)
[![Database](https://img.shields.io/badge/database-Access-red.svg)](https://www.microsoft.com/access)

## Overview
This project is a software engineering project developed by Yatir Gross, under the guidance of teacher Gamliel Zevi. The project aims to create a computerized version of the popular board game "Four-in-a-Row," providing a convenient and efficient way to play the game, including features for player registration and game management.

### ✨ Key Features
- **Fully Portable** - No hardcoded paths, works from any directory
- **Play Modes** - Two-player mode or single-player vs. computer AI
- **Game Management** - Complete player registration and game tracking
- **Game Replay** - Review any past game move-by-move
- **Statistics & Reports** - Comprehensive game and player analytics
- **Modern Architecture** - 64-bit Windows application with Access database

## Table of Contents
1. [Project Initiation Document](#project-initiation-document)
4. [Technical Details and Installation Instructions](#technical-details-and-installation-instructions)
7. [System Description](#system-description)
8. [Project Objectives](#project-objectives)
9. [Target Audience](#target-audience)
10. [System Processes](#system-processes)
11. [Database](#database)
12. [User Manual](#user-manual)

## Project Initiation Document
The project aims to develop a computerized system for playing Four-in-a-Row. The system is intended for anyone interested in playing the game, including a game manager responsible for player registration and game details management.

## Technical Details and Installation Instructions

### System Requirements
- **Operating System:** Windows 10 or later (64-bit)
- **Framework:** .NET Framework 4.5 or higher
- **Database:** Microsoft Access Database Engine 2016 (64-bit)
- **Development Environment (optional):** Visual Studio 2013 or later

### Prerequisites
Before running the application, you must install the **Microsoft Access Database Engine 2016 Redistributable (64-bit)**:

1. Download from: [Microsoft Access Database Engine 2016](https://www.microsoft.com/en-us/download/details.aspx?id=54920)
2. Choose **AccessDatabaseEngine_X64.exe** (64-bit version)
3. If you get an Office conflict error, run in Command Prompt as Administrator:
   ```
   AccessDatabaseEngine_X64.exe /passive
   ```

### Installation Instructions

#### Option 1: Run Pre-built Executable (Quick Start)
1. Clone or download this repository to any location on your computer
2. Navigate to: `Project_YatirGross\Program\FourInRow\FourInRow\bin\Debug\`
3. Double-click `FourInRow.exe` to run the application
4. (Optional) Create a desktop shortcut for easier access

#### Option 2: Build from Source
1. Clone this repository
2. Open `Project_YatirGross\Program\FourInRow\FourInRow.sln` in Visual Studio
3. Ensure the project is set to build for **x64** or **Any CPU** (with 64-bit preference)
4. Build the solution (F6 or Build → Build Solution)
5. Run the application (F5 or Debug → Start Debugging)

### Configuration Notes
- The application uses **Microsoft.ACE.OLEDB.12.0** database provider
- Database file location: `Project_YatirGross\Access\dbFourInRow.accdb`
- **Database paths are fully dynamic** - uses relative paths that work from any location
- All connection strings automatically resolve based on the executable's location
- No hardcoded paths - the project can be cloned anywhere on your system

### System Description
The system aims to facilitate and enhance the gameplay of Four-in-a-Row. It includes additional game options and stores player details along with the details and moves of all played games. Two players registered in the system can play against each other, and there is also an option to play against the computer. Additionally, it is possible to view a previously played game exactly as it was played.

## Target Audience
The system is designed for anyone, regardless of age, who wants to play Four-in-a-Row conveniently.

## System Processes
The system is divided into several processes, including:
1. **Addition and Update Processes:** Managed by the game manager to input and update data.
2. **Report Processes:** Allow players to access game data through various reports.
3. **Game Processes:** Enable gameplay between two players or one player against the computer.
4. **View Game Process:** Allows users to review past games.

## Database
#### Entities and Attributes

1. **Players Table**
   - **PlayerID** (Primary Key)
   - **FirstName**
   - **LastName**
   - **CityID** (Foreign Key)
   - **Username**
   - **Password**

2. **Cities Table**
   - **CityID** (Primary Key)
   - **CityName**

3. **Games Table**
   - **GameID** (Primary Key)
   - **Player1ID** (Foreign Key)
   - **Player2ID** (Foreign Key, nullable if playing against the computer)
   - **GameDate**

4. **Game Moves Table**
   - **MoveID** (Primary Key)
   - **GameID** (Foreign Key)
   - **PlayerID** (Foreign Key)
   - **MoveNumber**
   - **MoveColumn**

#### Relationships

1. **Players Table**
   - Each player is associated with one city (many-to-one relationship with Cities Table).
   - A player can be associated with many games (one-to-many relationship with Games Table).
   - A player can have many moves in various games (one-to-many relationship with Game Moves Table).

2. **Cities Table**
   - Each city can have multiple players (one-to-many relationship with Players Table).

3. **Games Table**
   - Each game involves two players (or one player and the computer), with foreign keys referencing the Players Table.
   - Each game consists of multiple moves (one-to-many relationship with Game Moves Table).

4. **Game Moves Table**
   - Each move is associated with a specific game (many-to-one relationship with Games Table).
   - Each move is performed by a specific player (many-to-one relationship with Players Table).

### Relationships

- Players (CityID) -> Cities (CityID)
- Games (Player1ID, Player2ID) -> Players (PlayerID)
- Game Moves (GameID) -> Games (GameID)
- Game Moves (PlayerID) -> Players (PlayerID)

This structure ensures that all relevant data about players, cities, games, and game moves is appropriately connected and can be queried for detailed game information and history.

## Troubleshooting

### Common Issues and Solutions

#### Error: "Microsoft.ACE.OLEDB.12.0 provider is not registered"
**Solution:** You need to install the Microsoft Access Database Engine 2016 Redistributable (64-bit). See [Prerequisites](#prerequisites) above.

#### Error: "Database path is not valid"
**Solution:** Ensure you've cloned the complete repository and the database file exists at `Project_YatirGross\Access\dbFourInRow.accdb`

#### Error: 32-bit/64-bit mismatch
**Solution:** 
- The application is compiled for 64-bit systems
- Install the 64-bit Access Database Engine (AccessDatabaseEngine_X64.exe)
- If you need 32-bit, rebuild the project with `PlatformTarget` set to `x86` in the project properties

#### Login Issues
**Solution:** 
- Open the Access database directly (`Project_YatirGross\Access\dbFourInRow.accdb`)
- Check the `tblPlayers` table for valid user credentials
- Default users (if any) can be found in the database

### Getting Login Credentials
To view or add users:
1. Open `Project_YatirGross\Access\dbFourInRow.accdb` with Microsoft Access
2. Navigate to the `tblPlayers` table
3. View existing player IDs and passwords
4. Add new users as needed (ensure `playerIsManager` is set appropriately)

## Project Structure
```
Four-In-A-Row/
├── Project_YatirGross/
│   ├── Access/
│   │   └── dbFourInRow.accdb          # Database file
│   ├── Program/
│   │   └── FourInRow/
│   │       ├── FourInRow.sln           # Visual Studio solution
│   │       └── FourInRow/
│   │           ├── bin/Debug/
│   │           │   └── FourInRow.exe   # Compiled executable
│   │           ├── Form*.cs            # Application forms
│   │           └── DataSet*.cs         # Database datasets
│   ├── Document/                       # Project documentation
│   └── Pictures/                       # Application images
└── README.md                           # This file
```

## User Manual
### System Operations
- **Login:** To start the system, run the `FourInRow.exe` file, enter your ID and password, and click "Login."
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/4228c86a-64a3-4a8e-9502-3fbb8d1b9785" alt="Login screen" width="500">

- **Main Menu:** From the main menu, access different system processes such as tables, addition, update, reports, game, view game, and charts.
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/2be94b99-b250-445e-ae91-17c2f944a411" alt="Main menu" width="500">

- **Tables:** Direct access to the database tables for the game manager.
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/b6f6e8a4-1a3f-46ed-85b2-efbbefccc366" alt="Tables screen" width="500">

- **Addition:** Allows the game manager to add new records.
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/730404ec-af81-4772-8db5-6c1c0b712c6d" alt="Addition screen" width="500">

- **Update:** Allows the game manager to update existing records.
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/d3d92f79-e3d0-4c19-a97a-c8d5f2fec4ce" alt="Update screen" width="500">

- **Reports:** Provides various reports on the games and players.
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/f908b831-1dc6-45a7-b3b5-b7263d21b690" alt="Reports screen" width="500">

- **Game:** Enables the actual gameplay.
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/3ee65d46-d753-4060-a50c-f76328be42c5" alt="Game screen" width="500">
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/3187db12-ce2c-41aa-a883-303f37bc6821" alt="Gameplay screen" width="500">

- **View Game:** Allows reviewing of past games.
  
  <img src="https://github.com/YatirGross/Four-In-A-Row/assets/155381822/cf5bfd4d-46a9-4b61-a461-db84b5fba17a" alt="View game screen" width="500">

## For Developers

### Building from Source

**Requirements:**
- Visual Studio 2013 or later
- .NET Framework 4.5+
- Microsoft Access Database Engine 2016 (64-bit)

**Steps:**
1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd Four-In-A-Row
   ```

2. Open `Project_YatirGross\Program\FourInRow\FourInRow.sln` in Visual Studio

3. Build the solution (F6) - Project is configured for x64 (64-bit)

4. Run with F5 or Debug → Start Debugging

### Contributing
Contributions are welcome!

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Database Connection (for developers)
The application uses **dynamic relative paths**:
- `FormLogin.cs` - Uses `AppDomain.CurrentDomain.BaseDirectory` to calculate path at runtime
- `App.config` - Uses `|DataDirectory|` placeholder with relative paths  
- All paths resolve automatically based on executable location
- No hardcoded paths anywhere in the codebase

### Technical Stack
- **Language:** C# (.NET Framework 4.5)
- **UI:** Windows Forms
- **Database:** Microsoft Access (ACE.OLEDB.12.0)
- **IDE:** Visual Studio 2013+
- **Platform:** Windows x64

## Version History
- **Current Version:** Configured for modern Windows 10/11 systems
  - Updated to 64-bit architecture
  - Modernized database connection handling
  - Improved cross-machine compatibility
- **Original Version:** Developed for Windows 10 Professional with Visual Studio 2013

## License
This project was developed as a software engineering educational project.

## Acknowledgments
- **Developer:** Yatir Gross
- **Supervisor:** Teacher Gamliel Zevi
- **Purpose:** Software Engineering Course Project

## Support
For issues, questions, or suggestions:
1. Check the [Troubleshooting](#troubleshooting) section
2. Review [SETUP.md](SETUP.md) for development issues
3. Open an issue on GitHub

---

## Conclusion
The Four-in-a-Row game project aims to modernize and improve the traditional gameplay experience, providing an efficient, computerized system with additional features for enhanced gameplay and management.

**Ready to play?** Follow the [Installation Instructions](#installation-instructions) above to get started!
