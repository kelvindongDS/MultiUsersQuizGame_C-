
USE GAME;

DROP TABLE IF EXISTS Turn;
DROP TABLE IF EXISTS Player;
DROP TABLE IF EXISTS Game;
DROP TABLE IF EXISTS Question;



#create Game table
CREATE TABLE IF NOT EXISTS Game
(
GameID INT not null AUTO_INCREMENT PRIMARY KEY,
Start DATETIME not null,
End DATETIME,
GameStatus int DEFAULT 0
)ENGINE InnoDB;

#create Question table
CREATE TABLE IF NOT EXISTS Question
(
QuestionID INT not null AUTO_INCREMENT PRIMARY KEY,
QuestionDetail  VARCHAR(255) not null,
Answer CHAR(1) not null,
Option1 VARCHAR(255) not null,
Option2 VARCHAR(255) not null,
Option3 VARCHAR(255) not null,
Option4 VARCHAR(255) not null,
AddMark INT not null,
SubtractedMark INT not null,
Level INT not null
)ENGINE InnoDB;

#create Player table
CREATE TABLE IF NOT EXISTS Player
(
PlayerName VARCHAR(30) not null PRIMARY KEY,
Admin TINYINT(1) not null,
Active TINYINT(1) not null,
Available TINYINT(1),
HighestScore INT NOT NULL DEFAULT 0,
Password BINARY(32) not null,
attempt int,
Version TIMESTAMP ON UPDATE CURRENT_TIMESTAMP NOT NULL
)ENGINE InnoDB;

#create Turn table
CREATE TABLE IF NOT EXISTS Turn
(
TurnID INT not null AUTO_INCREMENT PRIMARY KEY,
TurnNumber INT,
TurnSelection VARCHAR(10),
Result TINYINT(1),
Score INT not null,
PlayerName VARCHAR(30) not null,
QuestionID INT ,
GameID INT not null,

FOREIGN KEY (PlayerName)
      REFERENCES Player(PlayerName)
      ON UPDATE CASCADE ON DELETE CASCADE,
      
FOREIGN KEY (QuestionID)
      REFERENCES Question(QuestionID)
      ON UPDATE CASCADE ON DELETE CASCADE,  
 
FOREIGN KEY (GameID)
      REFERENCES Game(GameID)
      ON UPDATE CASCADE ON DELETE CASCADE
      
)ENGINE InnoDB;
