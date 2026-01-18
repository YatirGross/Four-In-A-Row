# Four-in-a-Row Game Project

## Overview
This project is a software engineering project developed by Yatir Gross, under the guidance of teacher Gamliel Zevi. The project aims to create a computerized version of the popular board game "Four-in-a-Row," providing a convenient and efficient way to play the game, including features for player registration and game management.

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
- **Computer:** Windows 10 Professional 64-bit
- **Development Environment:** Microsoft Visual Studio 2013 Express
- **Database:** Microsoft Office Access 2013

### Installation Instructions
1. Extract the system folder (Project_YatirGross) to `C:\Projects_2016`.
2. Navigate to the `bin` folder within the system folder.
3. Run the `FourInRow` executable file.
4. Optionally, create a shortcut to the executable file for easier access.

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

## Conclusion
The Four-in-a-Row game project aims to modernize and improve the traditional gameplay experience, providing an efficient, computerized system with additional features for enhanced gameplay and management.
