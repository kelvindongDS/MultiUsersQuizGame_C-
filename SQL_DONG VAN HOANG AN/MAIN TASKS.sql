Use Game;
DELIMITER //

#---------------SIGN IN FORM----------------------
#1. check login/register
DROP FUNCTION IF EXISTS checksignin//
CREATE FUNCTION checksignin(us VARCHAR(30), ps VARCHAR(255)) RETURNS INT
BEGIN 
DECLARE check1 INT;
DECLARE psh BINARY(32);
DECLARE check2 int;

SET check1= (SELECT COUNT(*) FROM PLAYER WHERE PlayerName = us);
SET check2= (SELECT attempt FROM PLAYER WHERE PlayerName = us);
SET psh= UNHEX(SHA2(ps, 256));
# new users
IF check1=0 THEN
	INSERT INTO player(PlayerName, Admin, Active, Available, HighestScore, Password,attempt) 
	VALUES(us,0,1,1,0,psh,0);
    RETURN  2;
ELSE
#existing user
	#check already online
	IF (SELECT Active FROM player WHERE PlayerName= us)=1 THEN RETURN 5;
    ELSE
    
		IF check2 <3 THEN
		#CHECK ADMIN
			IF us= "admin" and ps="admin" THEN RETURN 3; 
            #SIGN IN CASE   
			ELSE	
			  
				IF (psh= (SELECT Password from PLAYER WHERE PlayerName = us)) THEN 
					UPDATE player 
					SET Active = 1,
					Available=1			
					WHERE PlayerName = us;
					RETURN 1;
				ELSE RETURN 0;
                END IF;
			END IF;
            
		# TOO MANY ATTEMPT        
		ELSE RETURN 4;
        END IF;
	END IF;
END IF;			
END//

#2 increase attempt time
DROP FUNCTION IF EXISTS attemptincrease//
CREATE FUNCTION attemptincrease(prUserName VARCHAR(30)) RETURNS INT
BEGIN
DECLARE attemptValue int;
#increase attemp value 1 unit
UPDATE player 
		SET attempt = attempt +1
	    WHERE PlayerName = prUserName;
 SET attemptValue= (SELECT attempt from player WHERE PlayerName= prUserName);
RETURN attemptValue;
END//

# --------------------FOR ADMIN FORM-------------------
#3. Admin delete player
DROP FUNCTION IF EXISTS deleteplayer//
CREATE FUNCTION deleteplayer(prUserName VARCHAR(30)) RETURNS INT
BEGIN
DECLARE check1,check2 INT;
#check if player is online? 
SET check1= (SELECT Active FROM player WHERE PlayerName = prUserName);
#check if player is playing game
#SET check2= (SELECT Available FROM player WHERE PlayerName = prUserName);

IF (check1=0)  THEN
	DELETE FROM turn
	WHERE PlayerName= prUserName;
    
	DELETE FROM player
	WHERE PlayerName= prUserName;
	RETURN 1;
ELSE RETURN 0;
END IF;
END//


#4.show all players in admin screen
DROP PROCEDURE IF EXISTS showallplayer//
CREATE PROCEDURE showallplayer()
BEGIN
# list of players
SELECT  P.PlayerName,
		P.HighestScore,
        IF (P.Active=0,"OFFLINE","ONLINE") AS ONLINE_STATUS,
        
        CASE 
        WHEN P.Available=0 THEN "PLAYING"
		WHEN P.Available=1 THEN "AVAILABLE"       
		ELSE "N/A"
        END AS AVAILABILITY,
        
		CASE 
        WHEN P.Available=0 THEN (SELECT MAX( GameID) from TURN T WHERE T.PlayerName= P.PlayerName)
        Else "N/A"
        END AS OnLine_GAMEID,
        
        attempt
        
FROM game.player P

WHERE PlayerName != "admin"
ORDER BY OnLine_GAMEID,PlayerName;

END//

#5 DELETE  RUNNING GAME
DROP FUNCTION IF EXISTS deleteonlinegame//
CREATE FUNCTION deleteonlinegame(prGameID int) RETURNS INT
BEGIN
DECLARE check1 DATETIME;
#check if game is on going or not
SET check1 = (SELECT End FROM game WHERE GameID= prGameID);
IF check1 IS NUll THEN

	UPDATE game
    SET GameStatus=3
    WHERE GameID=prGameID;
	   
	RETURN 1;
ELSE RETURN 0;
END IF;
END//

#-------EDIT FORM---------------------
#6. Admin UPDATE Player INFO for highest score 
DROP PROCEDURE IF EXISTS updateinfo1//
CREATE PROCEDURE updateinfo1( prUserName VARCHAR(30), scoreNew INT)
BEGIN
DECLARE prVersion TIMESTAMP;
SET  prVersion = (SELECT Version FROM player WHERE PlayerName= prUserName);
	    IF scoreNew >=0 THEN
		UPDATE player 
		SET HighestScore = scoreNew
	    WHERE PlayerName = prUserName AND Version=prVersion;	
		END IF;	
END//

#7. Admin UPDATE Player INFO for password
DROP PROCEDURE IF EXISTS updateinfo2//
CREATE PROCEDURE updateinfo2( prUserName VARCHAR(30),psNew VARCHAR(255))
BEGIN
DECLARE prVersion TIMESTAMP;
DECLARE psh BINARY(32);

SET psh= UNHEX(SHA2(psNew, 256));
SET prVersion = (SELECT Version FROM player WHERE PlayerName= prUserName);
	IF psNew IS NOT NULL OR psNew !=""  THEN  
		UPDATE player 
		SET Password = psh
	    WHERE PlayerName = prUserName AND Version= prVersion;
        
	END IF;	
   
END//

#8. admin reset sign in attempt 
DROP PROCEDURE IF EXISTS resetSigninAttempt//
CREATE PROCEDURE resetSigninAttempt( prUserName VARCHAR(30))
BEGIN
	
		UPDATE player 
		SET attempt = 0
	    WHERE PlayerName = prUserName;
	
END//

#9 reset online status
DROP PROCEDURE IF EXISTS resetOnlineStatus//
CREATE PROCEDURE resetOnlineStatus( prUsername VARCHAR(30))
BEGIN
	
		UPDATE player 
		SET Active = 0,
			Available= Null
	    WHERE PlayerName = prUsername;

END//

#10 check online status, if it shows offline, close all running forms in C#.
DROP FUNCTION IF EXISTS OnlineStatus// 
CREATE FUNCTION OnlineStatus(prUserName VARCHAR(30)) RETURNS INT
BEGIN
DECLARE check1 INT;

SET check1 = (SELECT Active FROM player WHERE PlayerName= prUserName);
RETURN check1;
END//

# 11 Admin add player
DROP FUNCTION IF EXISTS addplayer//
CREATE FUNCTION addplayer(prUserName VARCHAR(30), prPassWord VARCHAR(255), psScore int) RETURNS INT 
BEGIN
DECLARE check1 INT;
DECLARE passhash BINARY(32);

SET passhash= UNHEX(SHA2(prPassWord, 256));
#check if new name exists? 
SET check1= (SELECT count(*) FROM player WHERE PlayerName = prUserName);
IF (!check1) THEN
	INSERT INTO player(PlayerName, Admin, Active, Available, HighestScore, Password,attempt) 
	VALUES(prUserName,0,0,Null,psScore,passhash,0);
    RETURN 1;
ELSE RETURN 0;    

END IF;
END//

#---------------DELETE OLD GAME FORM
#12 SHOW ALL OLD GAME
DROP PROCEDURE IF EXISTS showoldgame//
CREATE PROCEDURE showoldgame()
BEGIN
 SELECT GAMEID,START, END, GROUP_CONCAT(PlayerName SEPARATOR ' AND ') AS PLAYERS
 FROM
 
	(SELECT G.GameID,G.Start, G.End,T.PlayerName
    FROM game G
	INNER JOIN turn T on T.GameID= G.GameID
	WHERE End IS NOT NULL
	GROUP BY T.GameID,T.PlayerName) AS DATA
GROUP BY GameID;
	
END//

#13 DELETE OLD GAME
DROP PROCEDURE IF EXISTS deletegame//
CREATE PROCEDURE deletegame(prGameID int)
BEGIN
DECLARE check1 DATETIME;

	DELETE FROM game
	WHERE GameID= prGameID;

END//

#-----------Member form------------

#14 list of players
DROP PROCEDURE IF EXISTS showplayer//
CREATE PROCEDURE showplayer(prUsername VARCHAR(30))
BEGIN

SELECT PlayerName,
		HighestScore,	
		IF (Available=0,"This Player is playing","Click to select") AS PLAYER_AVAILABLE
FROM game.player
WHERE active= 1 and 
	  PlayerName not in ("admin",prUsername)
      ;
END//

#15 logout
#update status when exit
DROP PROCEDURE IF EXISTS logout//
CREATE PROCEDURE logout(prUserName VARCHAR(30))
BEGIN
UPDATE player 
		SET Active = 0,
        Available= Null			
	    WHERE PlayerName = prUserName;
END//

#16 check if user is playing , return GameID
DROP FUNCTION IF EXISTS checkplaying//
CREATE FUNCTION checkplaying(prUserName VARCHAR(30)) RETURNS INT
BEGIN
DECLARE prGameID int;
SET prGameID= (SELECT DISTINCT t.GameID
			FROM game g
			INNER JOIN turn t on t.GameID= g.GameID
			WHERE t.PlayerName= prUserName and g.End is Null);
RETURN prGameID;
END//

#17 CHECK IN CHALLENGE, return oppennt name
DROP FUNCTION IF EXISTS P1InPlayWith//
CREATE FUNCTION P1InPlayWith(myname VARCHAR(30)) RETURNS VARCHAR(30)
BEGIN
DECLARE opponent VARCHAR(30);
DECLARE prGameID INT;
SET prGameID= (select checkplaying(myname));
SET opponent=	(SELECT DISTINCT t.PlayerName
				 FROM game g
				 INNER JOIN turn t on t.GameID= g.GameID
				 WHERE t.PlayerName != myname 
                 AND g.End is Null
                 AND t.GameID= prGameID);
RETURN opponent;
END//

#18 start game info
#Start Game
DROP PROCEDURE IF EXISTS startgame//
CREATE PROCEDURE startgame( player1 VARCHAR(30), player2 VARCHAR(30))
BEGIN
DECLARE n,x,gid int;
DECLARE check1,check2 VARCHAR(30);
Set n= (SELECT COUNT(*) FROM question);
set x= floor(RAND()*n +1);

	#insert into game
	INSERT INTO game(Start, End) 
	VALUES(Now(),Null);    
	SET gid= (SELECT LAST_INSERT_ID());
       
    #insert into Turn
	INSERT INTO Turn(TurnNumber, TurnSelection, Result,Score, PlayerName, QuestionID, GameID)
	VALUES
		(1,NULL,NUll,0,player1,x,gid),
        (1,NULL,NUll,0,player2,x,gid);
	
    #update status    
    UPDATE player
    SET Active=1,
        Available=0
	WHERE PlayerName= player1 OR  PlayerName= player2;
END//

#-----------------------Game form-----------------------

#19 get last turnid for particular user in Turn relation
DROP FUNCTION IF EXISTS getturnid//
CREATE FUNCTION getturnid(prUserName VARCHAR(30)) RETURNS INT
BEGIN
DECLARE prTurnID INT;

SET prTurnID =	 (SELECT max(TurnID) FROM turn 
			 where PlayerName= prUserName);
			
RETURN prTurnID;
END//

# 20 show nextscreen info, show turnnumber and score
DROP PROCEDURE IF EXISTS nextscreeninfo//
CREATE PROCEDURE nextscreeninfo(prUserName varchar(30))
BEGIN

SELECT TurnNumber,Score
FROM turn 
where  TurnID =  getturnid(prUserName);

END//

#21 show addmark, subtractedmark
DROP PROCEDURE IF EXISTS nextscreeninfo2//
CREATE PROCEDURE nextscreeninfo2(prUserName varchar(30))
BEGIN
DECLARE prquestionID int;
SET prquestionID= (SELECT QuestionID
					FROM turn where  TurnID =  getturnid(prUserName));

SELECT AddMark, SubtractedMark FROM question 
WHERE QuestionID= prquestionID;
	
END//

#22 show question
DROP PROCEDURE IF EXISTS nextscreeninfo3//
CREATE PROCEDURE nextscreeninfo3(prUserName varchar(30))
BEGIN
DECLARE prquestionID int;

SELECT QuestionDetail, Option1,Option2,Option3,Option4
    FROM question
    where QuestionID= (SELECT QuestionID FROM turn WHERE TurnID=getturnid(prUserName));
	
END//

#23. Add NEXT QUESTION
DROP FUNCTION IF EXISTS nextquestion//
CREATE FUNCTION  nextquestion(gid int) RETURNS INT
BEGIN
DECLARE x,n INT;  
Set n= (SELECT COUNT(*) FROM question);
label1: LOOP
    set x= floor(RAND()*n +1);
    IF x IN  
		# THIS IS A LIST OF VAILABALE QUESTIONID 
		(SELECT QuestionID from turn
		Where GameID= gid)    
    THEN     
     ITERATE label1;
    END IF;
    LEAVE label1;
  END LOOP label1;
 
 
RETURN x;  
END//

#24 check result
DROP FUNCTION IF EXISTS checkresult//
CREATE FUNCTION checkresult(prAnswer VARCHAR(5), prUserName VARCHAR(30)) RETURNS INT
BEGIN
DECLARE prturnid,prQuestionID INT;
DECLARE prCorrectAnswer VARCHAR(5);

SET prturnid= getturnid(prUserName);
             
SET prQuestionID= (SELECT QuestionID from turn WHERE TurnID= prturnid);
SET prCorrectAnswer = (SELECT Answer from question WHERE QuestionID= prQuestionID);
 
IF prAnswer = '' THEN RETURN 0;
ELSE 
	IF prAnswer = prCorrectAnswer THEN RETURN 1;
    ELSE RETURN 2;
    END IF;
END IF;
END//


#25 create all elements for next screen
DROP PROCEDURE IF EXISTS Gonextscreen//
CREATE PROCEDURE Gonextscreen( prUserName VARCHAR(30),prAnswer VARCHAR(5))
BEGIN
DECLARE x,prGameid,prcheckresult,prTurnID,prTurnNum,prTurnNumNew,prScore,prScoreNew,
		prQuestionID,prQuestionIDOpponent,prAddMark,prSubtractedMark,prTurnIDNewPlayer1,prTurnIDNewPlayer2,prGameStatus int;
DECLARE prOpponent VARCHAR(30);
#set up question
SET prGameid= 
		(SELECT DISTINCT T.GameID FROM turn T 
		INNER JOIN game G ON G.GameID= T.GameID
		WHERE T.PlayerName= prUserName and 
				G.End is NULL);
SET prGameStatus = (SELECT GameStatus FROM game WHERE GameID=prGameid);

SET prTurnID= getturnid(prUserName);

SET prTurnNum= (SELECT TurnNumber FROM turn WHERE TurnID= prTurnID);

	CASE prGameStatus
	WHEN 0 THEN  
		UPDATE game
		SET GameStatus = 1;
		
	WHEN 1 THEN 
		UPDATE game
		SET GameStatus = 2;
		
	WHEN 2 THEN 
		UPDATE game
		SET GameStatus = 0; 
	
    WHEN 3 THEN 
		UPDATE game
		SET GameStatus = 4; 
        
	WHEN 4 THEN 
		UPDATE game
		SET GameStatus = 3; 
    
	END CASE;
    


SET x = nextquestion(prGameid);
                 
    
SET prcheckresult = checkresult(prAnswer,prUserName);

SET prScore= (SELECT Score FROM turn WHERE TurnID= prTurnID);

SET prQuestionID= (SELECT QuestionID FROM turn WHERE TurnID= prTurnID);
SET prAddMark= (SELECT AddMark FROM question WHERE QuestionID= prQuestionID);
SET prSubtractedMark= (SELECT SubtractedMark FROM question WHERE QuestionID= prQuestionID);

CASE prcheckresult
WHEN 0 THEN 
			SET prTurnNumNew=prTurnNum;
			UPDATE turn
            SET 
				TurnSelection= prAnswer,
                Result= prcheckresult,
                Score= prScore
                WHERE TurnID=prTurnID;
                
			
           
WHEN 1	THEN
			SET prTurnNumNew=prTurnNum+1;
            
			UPDATE turn
			SET 
				TurnSelection= prAnswer,
                Result= prcheckresult,
                Score= prScore+ prAddMark
                WHERE TurnID=prTurnID;    
                
			
			
ELSE 		
			     
			SET prTurnNumNew=prTurnNum+1;
            
			UPDATE turn
			SET 
				TurnSelection= prAnswer,
                Result= prcheckresult,
                Score= prScore-prSubtractedMark
                WHERE TurnID=prTurnID;
           
			
END CASE;


SET prScoreNew= (SELECT Score FROM turn WHERE TurnID= prTurnID);
SET prOpponent= P1InPlayWith(prUserName);
SET prTurnIDNewPlayer2= getturnid(prOpponent);

SET prQuestionIDOpponent= (SELECT QuestionID from turn WHERE TurnID= prTurnIDNewPlayer2);

IF prQuestionIDOpponent != NULL OR prQuestionIDOpponent= prQuestionID 
	THEN 
		INSERT INTO turn(TurnNumber, TurnSelection, Result,Score,PlayerName,GameID,QuestionID)
		VALUES(prTurnNumNew,NULL,NULL,prScoreNew,prUserName,prGameid,x);
ELSE
		INSERT INTO turn(TurnNumber, TurnSelection, Result,Score,PlayerName,GameID,QuestionID)
		VALUES(prTurnNumNew,NULL,NULL,prScoreNew,prUserName,prGameid,prQuestionIDOpponent);
END IF;


END//


# 26 get game status
DROP FUNCTION IF EXISTS gamestatus//
CREATE FUNCTION gamestatus(prUserName VARCHAR(30)) RETURNS INT
BEGIN
DECLARE prgameid,prGameStatus int;
SET prgameid= (SELECT DISTINCT GameID FROM turn WHERE TurnID= getturnid(prUserName));

SET prGameStatus= (SELECT GameStatus FROM game WHERE GameID= prgameid);
RETURN prGameStatus;
END//

# 27 reset game to particular status
DROP PROCEDURE IF EXISTS resetgamestatus//
CREATE PROCEDURE resetgamestatus(prUserName varchar(30),prGameStatus INT)
BEGIN

UPDATE game
SET GameStatus = prGameStatus
WHERE GameID= (SELECT DISTINCT GameID FROM turn WHERE TurnID= getturnid(prUserName));
	
END//

#28  update infor when game ended
DROP FUNCTION IF EXISTS endgameinfo//
CREATE FUNCTION endgameinfo(prUserName VARCHAR(30),prOpponent VARCHAR(30)) RETURNS INT
BEGIN

DECLARE prHighestScoreP1,prHighestScoreP2,prScoreP1,prScoreP2,checkwinner INT;

#SELECT HIGHEST SCORE 
SET prHighestScoreP1= (SELECT HighestScore FROM player WHERE PlayerName= prUserName);
SET prHighestScoreP2= (SELECT HighestScore FROM player WHERE PlayerName= prOpponent);

#SELECT SCORE 
SET prScoreP1= (SELECT Score FROM turn WHERE TurnID=getturnid(prUserName));
SET prScoreP2= (SELECT Score FROM turn WHERE TurnID=getturnid(prOpponent));


 #UPDATE PLAYER STATUS 
UPDATE player
    SET Active=1,
        Available=1
	WHERE PlayerName= prUserName;

#UPDATE GAME INFO 
UPDATE game
    SET End= now()       
	WHERE GameID= (SELECT DISTINCT GameID FROM turn WHERE TurnID= getturnid(prUserName));

#UPDATE HIGHEST SCORE
IF prHighestScoreP1 < prScoreP1 THEN
	UPDATE player
    SET HighestScore=prScoreP1
	WHERE PlayerName= prUserName;
END IF;

IF prHighestScoreP2 < prScoreP2 THEN
	UPDATE player
    SET HighestScore=prScoreP2
	WHERE PlayerName= prOpponent;
END IF;

#check winner
IF prScoreP1< prScoreP2 THEN  
	SET checkwinner = 1;END IF;
IF prScoreP1> prScoreP2 THEN 
	SET checkwinner =2;END IF;
IF prScoreP1= prScoreP2 THEN 
	SET checkwinner =0;END IF;

RETURN checkwinner;
END//

#29 endgame when max turn was reached
DROP PROCEDURE IF EXISTS endgame//
CREATE PROCEDURE endgame(prUserName varchar(30))
BEGIN

DECLARE prHighestScoreP1,prTurnNumber,prGameStatus int;

#SELECT SCORE 
SET prTurnNumber= (SELECT TurnNumber FROM turn WHERE TurnID=getturnid(prUserName));

#UPDATE GAME STATUS TO END
IF prTurnNumber=8 THEN 
	# ONE PLAYER REACH MAX
		UPDATE game
		SET GameStatus = 3
		WHERE GameID= (SELECT DISTINCT GameID FROM turn WHERE TurnID= getturnid(prUserName));
	
END IF;
END//


DELIMITER ;

# this is to reset the number of failure signin of admin. He should contact company for this request.
CALL resetSigninAttempt('admin');
# for database design, i still put question in turn table even it is not so good for data normalization.
#This is because all questions should be recoreded to create random questions but not repetition. I can store 
# all of them in Game table but it doesnt look logical since one game could not have many questions without turn indication.
# I though Game table should have only one question and it will update once new question created
#. However it is unable to store all info and therefore it can not created random question propperly.

