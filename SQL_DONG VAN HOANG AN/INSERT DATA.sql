USE game;
#INSERT INTO QUESTION TABLE
INSERT INTO Question(QuestionDetail, Answer, Option1, Option2, Option3, Option4, AddMark, SubtractedMark, Level)
VALUES 
	("Which city in New Zealand is called the 'City of Sails'?","A","Auckland","Nelson","Wellington","Christchurch",3,2,2),
    ("Which city in New Zealand  on the South Island of New Zealand, facing Tasman Bay?","B","Auckland","Nelson","Wellington","Christchurch",2,1,1),
    ("Which city is the capital of New Zealand ?","C","Auckland","Nelson","Wellington","Christchurch",2,1,1),
    ("Which city is known for its English heritage in New Zealand?","D","Auckland","Nelson","Wellington","Christchurch",3,2,2),
    ("What is Albert Einstein'DOB?","B","03/03/1866","14/03/1879","15/08/1900","11/09/1898",4,3,3),
    ("where albert einstein was born?","D","New Zealand","Vietnam","US","Germany",4,3,3),
    ("Donald Trump is the President of which country below:","C","New Zealand","Vietnam","US","Germany",2,1,1),
    ("Māori are the tangata whenua of which country below?","A","New Zealand","Vietnam","US","Germany",2,1,1),
    ("Which country is known by Son Doong cave","B","New Zealand","Vietnam","US","Germany",4,3,3),
    ("Neuschwanstein castles in Bavaria belongs to which country below","D","New Zealand","Vietnam","US","Germany",3,2,2),
    ("Kiwi is symbol of which country below?","A","New Zealand","Vietnam","US","Germany",2,1,1),
    ("Beer makes which country below become famous around the globe?","D","New Zealand","Vietnam","US","Germany",2,1,1),
    ("Frank-Walter Steinmeier is the president of ?","D","New Zealand","Vietnam","US","Germany",2,1,1),
    ("The independence day of usa is","B","15/12","04/07","01/01","13/03",2,1,1),
    ("The independence day of Vietnam is","C","15/12","04/07","02/09","13/03",2,1,1),
    ("The fastest bird in the world is?","B","Golden eagle","Peregrine falcon","Eurasian hobby","Frigatebird",3,2,2),
    ("WHich country has biggist polulation?","A","China","US","Russia","New Zealand",2,1,1),
    ("THe Largest Country in the World By Area is","C","China","US","Russia","Canada",2,1,1),
    ("Which is the largest continent in the world?","D","Africa","Australia","South America","Asia",2,1,1),
    ("Which is the smallest continent in the world?","B","Africa","Australia","South America","Asia",2,1,1),
    ("Which country is the smallest country in the world by area?","A","Vatican","Monaco","Nauru","San Marino",3,2,2);
    
#INSERT INTO PLAYER TABLE
INSERT INTO Player(PlayerName, Admin, Active, Available, HighestScore, Password,attempt)
VALUES
	("Redwarrior",0,0,NULL,9,"123",0),
    ("Martin",0,1,1,8,"1234",0),
    ("Dragon",0,1,1,12,"1234",0),
    ("BlueDragon",0,1,1,14,"a123",0),
    ("Mauro",0,0,Null,3,"abc",0),
    ("Tracy",0,1,1,13,"abc1",0),
    ("Pinky",0,1,1,10,"abc",0),
    ("admin",1,0,Null,0,"admin",0);
 
#INSERT INTO GAME TABLE
INSERT INTO game(Start, End)
VALUES 
	("2018-04-10 10:10:10","2018-04-10 10:30:38"),
    ("2018-04-10 11:15:10","2018-04-10 11:30:46"),
	('2018-04-11 08:34:34',NUll);
    
#INSERT INTO TURN TABLE
INSERT INTO Turn(TurnNumber, TurnSelection, Result,Score, PlayerName, QuestionID, GameID)
VALUES

	(1,"A",1,3,"Redwarrior",21,1),
    (1,"A",1,3,"Tracy",21,1),
    (2,"D",1,5,"Redwarrior",19,1),
    (2,"A",0,2,"Tracy",19,1),
    (3,"C",0,4,"Redwarrior",17,1),
    (3,"A",1,4,"Tracy",17,1),
    (4,"B",1,7,"Redwarrior",16,1),
    (4,"D",0,2,"Tracy",16,1),
    (5,"C",1,9,"Redwarrior",15,1),
    (5,"C",1,4,"Tracy",15,1),
    (6,"C",0,7,"Redwarrior",1,1),
    (6,"A",1,7,"Tracy",1,1),
    (7,"C",1,9,"Redwarrior",3,1),
    (7,"B",0,6,"Tracy",3,1),
    (8,"C",0,6,"Redwarrior",5,1),
    (7,Null,Null,6,"Tracy",5,1),
    (7,Null,Null,6,"Tracy",6,1),
    (8,"A",1,8,"Tracy",8,1),
    
    (1,"A",1,3,"Martin",1,2),
    (1,"B",0,0,"Pinky",1,2),
    (2,"A",0,2,"Martin",2,2),
    (2,"C",0,0,"Pinky",2,2),
    (3,"D",1,5,"Martin",4,2),
    (3,"C",0,0,"Pinky",4,2),
    (4,"D",1,9,"Martin",6,2),
    (4,"D",1,4,"Pinky",6,2),
    (5,"A",0,8,"Martin",7,2),
    (5,"C",1,6,"Pinky",7,2),
    (6,"B",0,6,"Martin",10,2),
    (6,"D",1,9,"Pinky",10,2),
    (7,"B",0,4,"Martin",21,2),
    (7,"A",1,12,"Pinky",21,2),
	(8,"B",1,8,"Martin",5,2),
    (8,"C",0,9,"Pinky",5,2)
 

    
