
USE master;
GO

IF DB_ID(N'MyWorkoutRoutines') IS NULL
    CREATE DATABASE MyWorkoutRoutines;
GO

USE MyWorkoutRoutines;
GO

-------------------------------------

--IF OBJECT_ID('Users') IS NOT NULL
--	DROP TABLE dbo.Users;
--GO
DROP TABLE IF EXISTS RoutineExercises;
DROP TABLE IF EXISTS Routine;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS RoutineHistory;

DROP TABLE IF EXISTS Exercise;


DROP TABLE IF EXISTS Reminders;

CREATE TABLE Users(
	UserID INT Not Null Primary Key Identity(1,1),
	UserName VARCHAR(100) NOT NULL,
	HashPassword VARCHAR(100) NOT NULL,
	Salt VARCHAR(100) NOT NULL,
	
);

-------------------------------------

--IF OBJECT_ID('Exercise') IS NOT NULL
--    DROP TABLE Exercise;
--GO



CREATE TABLE Exercise(
	ExerciseID INT Not Null Primary Key Identity(1,1),
	Category NVARCHAR(10),
	ExerciseName NVARCHAR(100),
	Difficulty NVARCHAR(20),
	Description TEXT,
	
);

-------------------------------------

--IF OBJECT_ID('Routine') IS NOT NULL
--    DROP TABLE Routine;
--GO



CREATE TABLE Routine(
	RoutineID INT Not Null Primary Key Identity(1,1) ,
	RoutineName NVARCHAR(100),
	UserID INT
		Constraint Routine_Users Foreign Key (UserID) References Users(UserID),
);

-------------------------------------

--IF OBJECT_ID('RoutineExercises') IS NOT NULL
--    DROP TABLE RoutineExercises;
--GO



CREATE TABLE RoutineExercises(
	RoutineExercisesID INT NOT NULL Primary Key Identity(1,1),
	Repetitions INT,
	Duration INT,
	BreakRoutine TIME,
	--RoutineID INT, 
	--ExerciseID INT,
	
	RoutineID INT not null,
    ExerciseID INT not null,
	CONSTRAINT fk_exercises FOREIGN KEY (ExerciseID) REFERENCES Exercise(ExerciseID),
	CONSTRAINT fk_routine FOREIGN KEY (RoutineID) REFERENCES Routine(RoutineID)
    --CONSTRAINT routine_exercises_routine foreign key (RoutineID) references Routine(RoutineID),
    --CONSTRAINT routine_exercises_exercises foreign key (ExerciseID) references Exercise(ExerciseID),
    --CONSTRAINT routine_exercise_routine UNIQUE (RoutineID, ExerciseID)

);

-------------------------------------

--IF OBJECT_ID('Reminders') IS NOT NULL
--    DROP TABLE Reminders;
--GO



CREATE TABLE Reminders(
  ReminderID INT Not Null Primary Key Identity(1,1), 
  CalendarDate DATETIME,
	UserID INT,
		Constraint fk_User Foreign Key (UserID) References Users(UserID),

);

-------------------------------------

--IF OBJECT_ID('RoutineHistory') IS NOT NULL
--    DROP TABLE RoutineHistory;
--GO



CREATE TABLE RoutineHistory(
	HistoryID INT Not Null Primary Key Identity(1,1),
	RoutineID INT not null,
	FOREIGN KEY (RoutineID) REFERENCES Routine(RoutineID),
	DateHistory Datetime,
	

);

-------------------------------------


-- Pause:

INSERT INTO Exercise VALUES ('Pause', 'Pause', '','Machen Sie eine Pause.');

--Bauch:

INSERT INTO Exercise VALUES ('Bauch', 'Crunch','Anf�nger','Auf den R�cken legen. Die Beine anwinkeln und die H�nde an den Schl�fen halten, Ellbogen zeigen nach au�en.
Aus der Kraft des Bauches den Schulterbereich vom Boden abheben, kurz halten, wieder absenken. 
Den R�cken dabei m�glichst gerade und den Nacken in Verl�ngerung der Wirbels�ule halten.');

INSERT INTO Exercise VALUES ('Bauch', 'Side-Crunch','Anf�nger','Auf den Boden legen, die Fersen aufstellen. Die H�nde an die Schl�fen legen, die Ellenbogen zeigen nach au�en.
Den Oberk�rper kontrolliert aufrichten und nach links, in der n�chsten Wiederholung nach rechts drehen.');

INSERT INTO Exercise VALUES ('Bauch', 'Beinheben','Anf�nger','Auf den Boden legen, die H�nde unter das Ges�� schieben und die Beine gestreckt �ber dem Boden halten.
Die Bauchmuskeln anspannen und die gestreckten Beine langsam heben, bis sie senkrecht stehen. Ebenso langsam wieder absenken, ohne sie abzulegen.');

INSERT INTO Exercise VALUES ('Bauch', 'Bergsteiger','Anf�nger','In der Liegest�tzposition abgest�tzt, die Beine und der Oberk�rper sind gerade gestreckt.
Nun werden die Knie in einer sprunghaften Bewegung abwechselnd Richtung Brustkorb gezogen. Das jeweils hintere Bein bleibt gerade gestreckt.');

INSERT INTO Exercise VALUES ('Bauch', 'Seitlicher Unterarmst�tz','Anf�nger','In Seitlage auf den Boden legen und den Oberk�rper auf den linken Unterarm st�tzen.
Das Becken anheben, bis der K�rper von Kopf bis Fu� eine gerade Linie bildet. In der H�fte stabil bleiben und die Position halten. Im n�chsten Satz die Seite wechseln.');

INSERT INTO Exercise VALUES ('Bauch', 'Beinkreisen','Fortgeschritten','Auf den Boden setzen, die Beine nach vorn ausstrecken und einige Zentimeter �ber dem Boden halten.
Den Oberk�rper nach hinten lehnen und auf den Unterarmen abst�tzen. Die Oberarme stehen senkrecht unter den Schultern.
Die gestreckten Beine in weiten, wechselnd gro�en Kreisen durch die Luft bewegen.');

INSERT INTO Exercise VALUES ('Bauch', 'Beinpendeln', 'Fortgeschritten','Auf den R�cken legen, die Arme zur Seite gestreckt ablegen und die Beine senkrecht hochheben. Die Fu�spitzen anziehen.
Die gestreckten Beine langsam so weit wie m�glich nach rechts absenken, wieder anheben, dann nach links absenken und im Wechsel fortfahren.');

INSERT INTO Exercise VALUES ('Bauch', 'Crunches mit angewinkeltem Bein', 'Fortgeschritten','R�cklings auf den Boden legen. Die Beine durchstrecken und ebenso wie die gestreckten Arme knapp �ber dem Boden halten.
Die Knie anziehen, bis die Oberschenkel in etwa senkrecht und die Unterschenkel waagerecht in der Luft stehen. 
Gleichzeitig den Schulterbereich vom Boden abheben, dabei die Arme an den Oberschenkeln vorbei weg vom K�rper schieben.');

INSERT INTO Exercise VALUES ('Bauch', 'Gestreckte Crunches', 'Fortgeschritten','R�cklings auf den Boden legen, Arme und Beine senkrecht zur Decke strecken.
Den Oberk�rper langsam anheben. Die Finger so weit es geht nach oben schieben und dabei versuchen, die Zehen zu ber�hren.');

INSERT INTO Exercise VALUES ('Bauch', 'Radfahr-Crunches', 'Fortgeschritten','R�cklings hinlegen und die Arme am Kopf vorbei ausstrecken. Die Bauchmuskeln anspannen und den Schulterbereich leicht vom Boden abheben.
Das rechte Knie anwinkeln, zur Brust ziehen und mit der linken Hand den Fu� ber�hren. Fl�ssig die Seiten wechseln: Den linken Arm neben den Kopf zur�ckschwingen, das rechte Bein strecken,
das linke beugen und den Fu� mit der rechten Hand ber�hren. Wechselseitig z�gig wiederholen, ohne Arme, Beine oder oberen R�cken abzulegen.');

-- R�cken:

INSERT INTO Exercise VALUES ('R�cken', 'Rumpfheben auf dem Bauch', 'Anf�nger','In Bauchlage hinlegen. Die Arme liegen neben dem K�rper oder Sie legen die Handr�cken auf dem Ges�� ab.
Mit der Kraft des unteren R�ckens den Oberk�rper langsam anheben. Dabei die Schulterbl�tter zusammenziehen und die H�nde in Richtung der F��e schieben.');

INSERT INTO Exercise VALUES ('R�cken', 'Kniependeln', 'Anf�nger','Hinlegen und die Knie rechtwinklig beugen. Die Arme seitlich vom K�rper ausstrecken.
Die Beine nach rechts zum Boden kippen. Kopf, Arme und Schultern bleiben auf dem Boden.
Gleich danach nach links pendeln, dann wechselseitig wie in einer Kraft�bung fortfahren.');

INSERT INTO Exercise VALUES ('R�cken', 'Katzenbuckel', 'Anf�nger','In den Vierf��lerstand begeben, die H�nde unter den Schultern und die Knie unter den H�ften platzieren.
Den Oberk�rper durchh�ngen lassen, den Blick nach vorn richten. Den Oberk�rper langsam einrollen und den runden R�cken m�glichst weit nach oben dr�cken.
Dabei das Kinn zur Brust ziehen. Die Positionen jeweils einige Sekunden halten.');

INSERT INTO Exercise VALUES ('R�cken', 'Beckenheben in R�ckenlage', 'Anf�nger','Auf den R�cken legen und die Beine anwinkeln. Fersen in den Boden dr�cken. Unterarme aufstellen, Oberarme liegen auf dem Boden auf.
Das Becken kippen und den Oberk�rper sowie das Ges�� anheben, indem Sie die Ellenbogen in den Boden dr�cken.
Die gr��te Last liegt auf den Oberarmen. Den K�rper ein wenig in Richtung Kopf schieben.');

INSERT INTO Exercise VALUES ('R�cken', 'Einbeiniges H�ftrollen', 'Anf�nger','Hinlegen und die Arme seitlich ausstrecken. Das linke Bein gestreckt senkrecht anheben.
Langsam das linke Bein �ber das rechte absenken, bis der linke Fu� auf dem Boden liegt. Der Oberk�rper bleibt dabei m�glichst gerade.
Gleich im Anschluss mit dem rechten Bein fortfahren, dann wechselseitig wiederholen.');

INSERT INTO Exercise VALUES ('R�cken', 'Arm- und Beinheben im Liegen', 'Fortgeschritten','B�uchlings auf den Boden legen und die Arme in Verl�ngerung zum K�rper ablegen.
Das Becken in den Boden dr�cken und den Rumpf anspannen. Beine, Arme und Oberk�rper gleichzeitig m�glichst weit vom Boden abheben.
Der Kopf bleibt in Verl�ngerung zur Wirbels�ule, der Blick geht zum Boden.');

INSERT INTO Exercise VALUES ('R�cken', 'R�ckenbr�cke', 'Fortgeschritten','Mit gestreckten Armen und Beinen auf den R�cken legen. Die Fersen in den Boden dr�cken und die Arme hinter dem Kopf ablegen.
Den Rumpf anspannen und die H�fte m�glichst weit anheben. In dieser Position ber�hren nur noch Fersen, Schultern und Arme den Boden.
Wenigstens drei bis f�nf Sekunden halten, dann wieder f�r kurze Zeit ganz ablegen.');

INSERT INTO Exercise VALUES ('R�cken', 'Windm�hle', 'Fortgeschritten','H�ftbreit hinstellen, die Knie leicht beugen und den Oberk�rper mit geradem R�cken etwas mehr als 45 Grad vorbeugen.
Die Arme anspannen und schulterbreit nach unten strecken. Die H�nde sind zur Unterst�tzung der Armspannung zu F�usten geballt.
Den Rumpf nach rechts aufdrehen, ohne den Neigungswinkel zu ver�ndern. Dabei den rechten Arm nach oben in der Verl�ngerung des linken Arms strecken.
Das rechte Bein etwas strecken, das linke Knie mehr beugen � dabei aber darauf achten, dass es nicht nach innen wandert.
Die Spannung im K�rper halten, dann �zur�ck in die Ausgangsstellung.
Direkt im Anschluss nach links drehen, dann wechselseitig wiederholen.');

INSERT INTO Exercise VALUES ('R�cken', 'Zwei-Punkt-Liegest�tze', 'Fortgeschritten','In die Liegest�tzposition gehen und den K�rper auf einer geraden Linie halten. Den linken Arm 
und das rechte Bein gleichzeitig vom Boden abheben und waagerecht ausstrecken. Die Position kurz halten. Im n�chsten Satz die Seiten wechseln.');

INSERT INTO Exercise VALUES ('R�cken', 'Angewinkeltes Beinheben', 'Fortgeschritten','In Bauchlage die Arme angewinkelt vor dem Kopf ablegen, die F��e vom Boden abheben und die Beine etwa 45 Grad beugen.
Ohne Schwung die Oberschenkel anheben und die Unterschenkel in Richtung Ges�� ziehen, bis die Beine etwa rechtwinklig gebeugt sind.');

-- Brust:

INSERT INTO Exercise VALUES ('Brust', 'Breite Liegest�tz auf den Knien', 'Anf�nger','In die Liegest�tzposition gehen und statt auf den Fu�spitzen, auf den Knien abst�tzen. Die H�nde doppelt schulterbreit auseinander halten
und den K�rper auf eine gerade Linie bringen. Den Oberk�rper senken, bis die K�rperlinie und die Oberarme waagerecht zum Boden stehen.
Halten und anschlie�end zur�ck in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Brust', 'Brustrotation in Seitlage', 'Anf�nger','Auf die linke K�rperseite legen. Die Knie anziehen, bis die Beine rechtwinklig gebeugt sind. Die Arme auf Schulterh�he gerade nach vorn strecken,
sodass der linke Arm auf dem Boden und der rechte dar�berliegt. Die Handfl�chen aneinanderlegen.Den rechten Arm anheben und zusammen mit dem Rumpf nach rechts drehen,
bis Schulter und Hand den Boden ber�hren. Die Beine und der linke Arm bleiben in Position und links im Bodenkontakt. 
Einige Sekunden halten, dann den Arm zur�ckf�hren. Im n�chsten Satz die Seite wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Brustdehnen mit gestrecktem Armen', 'Anf�nger','In den Vierf��lerstand gehen. Die Arme schr�g nach vorne strecken und die Handfl�chen auf dem Boden abst�tzen.
Den R�cken gerade machen, den Rumpf anspannen und die Knie auf dem Boden ablegen. Der Kopf bleibt dabei immer in Verl�ngerung der Wirbels�ule. Die F��e aufstellen, so dass der Kniewinkel etwa 90 Grad betr�gt.
Den Kopf in Richtung Boden senken und den Oberk�rper nach hinten schieben. Ges��, R�cken und Arme bilden eine abfallende Linie.');

INSERT INTO Exercise VALUES ('Brust', 'Statischer Crunch', 'Anf�nger','R�cklings hinlegen und die Beine rechtwinklig gebeugt in der Luft halten. Den Rumpf anspannen, Schultern und Kopf anheben
und die Handfl�chen mit gestreckten Armen von au�en an die Knie legen. Den Rumpf anspannen, dann halten und mit den H�nden f�r etwa f�nf Sekunden gegen die Knie dr�cken.
Nun die Handau�enseiten von innen gegen die Knie legen. Rumpfspannung aufbauen und mit den H�nden f�nf Sekunden lang nach au�en dr�cken.
L�sen, Rumpf und Arme kurz entspannen, dann die n�chste Wiederholung durchf�hren.');

INSERT INTO Exercise VALUES ('Brust', 'Einarmiges Brustdehnen an der Wand', 'Anf�nger','In Schrittstellung, der linke Fu� ist vorne, mit der linken K�rperseite vor eine Wand stellen.
Den linken Arm auf Schulterh�he zur Seite strecken und die Handfl�che gegen die Wand dr�cken. Die rechte in die H�fte stemmen.
Den Oberk�rper leicht nach rechts drehen, bis Sie eine Dehnung in der Brustmuskulatur sp�ren. Im n�chsten Satz Seite wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Aufdrehende Liegest�tze', 'Fortgeschritten','In die Liegest�tz-Position gehen und den K�rper auf einer geraden Linie halten.
Den Oberk�rper senken, bis die K�rperlinie waagerecht zum Boden steht. Mit dem linken Arm hochdr�cken und den Oberk�rper aufdrehen, so dass der rechte Arm senkrecht nach oben zeigt.
Zur�ck in die Ausgangsposition kommen. Im n�chsten Satz Seite wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Breite Liegest�tze', 'Fortgeschritten','In die Liegest�tzposition gehen, die H�nde doppelt schulterbreit auseinander halten und den K�rper auf eine gerade Linie bringen.
Den Oberk�rper senken, bis die K�rperlinie und die Oberarme waagerecht zum Boden stehen. Halten und anschlie�end zur�ck in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Brust', 'Vorw�rtslaufen auf den H�nden', 'Fortgeschritten','In die Liegest�tzposition gehen. In kleinen Schritten die F��e in Richtung der H�nde setzen, dabei das Ges�� zur Decke dr�cken. 
Die Beine und die Arme sind gestreckt, der R�cken gerade und der Kopf in Verl�ngerung der Wirbels�ule. Die H�nde abwechselnd St�ck f�r St�ck nach vorne setzen. 
Mit den H�nden soweit nach vorne wandern, bis der Oberk�rper etwa waagerecht zum Boden steht. Kurz halten und in umgekehrter Reihenfolge zur�ck in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Brust', 'Versetzte Liegest�tze', 'Fortgeschritten','In einen Liegest�tz gehen, die H�nde dabei versetzt platzieren: die linke Hand ein St�ck nach vorn in Richtung Kopf, die rechte Hand auf Brusth�he.
Die Arme beugen und den K�rper absenken, bis die Brust fast den Boden ber�hrt. Z�gig wieder hochdr�cken. Die Handpositionen wechseln, ohne die Spannung im K�rper zu vernachl�ssigen: 
Jetzt die rechte Hand weiter vorn und die linke auf Brusth�he aufsetzen. Den n�chsten Liegest�tz ausf�hren, in der Folge die Handpositionen beliebig wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Liegest�tze mit abgelegten Unterarmen', 'Fortgeschritten','In die Liegest�tzposition gehen und den K�rper auf einer geraden Linie halten.
Den Oberk�rper senken und die Unterarme auf dem Boden ablegen.');

-- Arm:

INSERT INTO Exercise VALUES ('Arm', 'Dips an einem Stuhl', 'Anf�nger','R�cklings auf einem Stuhl abst�tzen, die Handr�cken zeigen zum K�rper. Die F��e nach vorn setzen, die Oberschenkel stehen waagerecht zum Boden. 
Die Ellenbogen beugen, bis die Oberarme in etwa waagerecht stehen. Das Ges�� dabei absenken.');

INSERT INTO Exercise VALUES ('Arm', 'Curls mit Beinwiderstand', 'Anf�nger','Auf den Boden setzen, die Beine leicht angewinkelt ausstrecken und spreizen. Den linken Ellenbogen gegen die Innenseite des linken Oberschenkels stemmen und mit der linken Hand in die rechte Kniekehle fassen.
Mit rechts neben dem Ges�� abst�tzen, dann mit links das rechte Bein leicht anheben. Den linken Arm weiter beugen und das rechte Bein in Richtung Brust ziehen. Den Oberk�rper dabei halten. Bei Bedarf mit dem rechten Bein Gegendruck erzeugen.
Im n�chsten Satz die Seite wechseln.');

INSERT INTO Exercise VALUES ('Arm', 'Handstrecken', 'Anf�nger','Aufrecht und schulterbreit aufstellen. Den rechten Arm gerade nach vorne strecken und das Handgelenk im rechten Winkel nach unten beugen. Die Handfl�che zeigt nach vorn.
Mit der linken Hand die Finger der rechten Hand leicht in Richtung K�rper dr�cken, bis Sie eine Dehnung sp�ren. Im n�chsten Satz Armwechsel.');

INSERT INTO Exercise VALUES ('Arm', 'Trizepsstrecken hinter dem Kopf', 'Anf�nger','Aufrecht und schulterbreit aufstellen. Den linken Arm beugen, der Ellenbogen zeigt zur Decke, die Hand liegt auf dem Nacken. 
Mit der rechten Hand den linken Ellenbogen leicht nach unten dr�cken, bis Sie eine Dehnung sp�ren. Im n�chsten Satz Armwechsel.');

INSERT INTO Exercise VALUES ('Arm', 'Liegest�tze', 'Anf�nger','In den Liegest�tz gehen. Die Arme sind dabei fast ganz durchgestreckt, die H�nde befinden sich unter den Schultern.
R�cken gerade halten, Kopf, Ges�� und Fersen bilden eine Linie. Arme beugen und den K�rper absenken, bis die Brust knapp �ber dem Boden ist. Dann wieder nach oben dr�cken.');

INSERT INTO Exercise VALUES ('Arm', 'Trizeps-Kniebeugen', 'Anf�nger','Stellen Sie sich aufrecht hin, beugen Sie sich leicht nach vorne und legen Sie die H�nde auf Ihren Oberschenkeln knapp �ber den Knien auf.
Gehen Sie nun leicht in die Hocke, bis Ihre Arme gebeugt sind und dr�cken Sie anschlie�end Ihren Oberk�rper mit der Kraft Ihres Trizeps wieder in eine aufrechte Position.');

INSERT INTO Exercise VALUES ('Arm', 'Diamant Liegest�tze', 'Fortgeschritten','In einen Liegest�tz gehen und H�nde so nah zusammenf�hren, dass sich die beiden Daumen und die beiden Zeigefinger ber�hren.
Die Arme anwinkeln und den K�rper absenken. Die Position kurz halten und dann wieder hochdr�cken.');

INSERT INTO Exercise VALUES ('Arm', 'Liegest�tze in R�ckenlage', 'Fortgeschritten','Mit gestreckten Beinen hinsetzen und die H�nde hinter dem Ges�� platzieren.
Die H�fte hochdr�cken, bis Ihr K�rper von Kopf bis Fu� eine gerade Linie bildet. Die Schultern befinden sich direkt �ber den H�nden.
Die Arme beugen und den K�rper absenken, bis das Ges�� fast den Boden ber�hrt. Die Position halten und wieder zur�ck.');

INSERT INTO Exercise VALUES ('Arm', 'Dips mit angehobenem Bein', 'Fortgeschritten','R�cklings auf einer Bank abst�tzen, die Handr�cken zeigen zum K�rper.
Die F��e nach vorn setzen, bis Beine und Oberk�rper eine gerade Linie bilden. Das rechte Bein anheben und nach vorne strecken.
Die Ellenbogen beugen, bis die Oberarme in etwa waagerecht stehen. Das Ges�� dabei absenken. Im n�chsten Durchgang das andere Bein anheben.');

INSERT INTO Exercise VALUES ('Arm', 'Halbe fliegende Liegest�tze', 'Fortgeschritten','In einen Liegest�tz gehen. Die H�nde so aufstellen, dass die Finger zu den F��en zeigen.
Die Arme beugen, bis die Brust knapp �ber dem Boden schwebt. Kurz halten und wieder hochdr�cken.');

INSERT INTO Exercise VALUES ('Arm', 'Bergab-Liegest�tze', 'Fortgeschritten','In die Liegest�tzposition gehen, die F��e auf einem Stuhl ablegen und den K�rper auf einer geraden Linie halten.
Den Oberk�rper senken, bis die K�rperlinie schr�g nach unten zeigt und die Oberarme waagerecht zum Boden stehen. Halten und anschlie�end zur�ck in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Arm', 'Liegest�tze mit gedrehtem Oberk�rper', 'Fortgeschritten','Den Oberk�rper senken, bis die K�rperlinie schr�g nach unten zeigt und die Oberarme waagerecht zum Boden stehen.
Halten und anschlie�end zur�ck in die Ausgangsposition kommen. Die linke K�rperh�lfte zur Seite neigen, die Knie zeigen dabei nach rechts.
Wie ein Korkenzieher dreht sich Ihr K�rper leicht ein. Position kurz halten, dann wieder hochdr�cken. Bei der Wiederholung in die andere Richtung drehen.');

-- Schultern:

INSERT INTO Exercise VALUES ('Schultern', 'Wechselseitiges Armheben', 'Anf�nger','Mit jeder Hand einen schweren Gegenstand greifen. Den linken Arm waagerecht vorstrecken, der rechte Arm zeigt senkrecht nach oben.
Den linken Arm gestreckt nach oben f�hren, bis er senkrecht steht. Gleichzeitig den rechten Arm nach vorn in die Waagerechte absenken.
Den R�cken gerade halten, die Schulterbl�tter nach unten ziehen. Im Wechsel fortfahren.');

INSERT INTO Exercise VALUES ('Schultern', 'Schulterheben', 'Anf�nger','Mit einem Gewicht in jeder Hand die Arme neben dem K�rper h�ngen lassen. Die Handfl�chen zeigen zueinander. Die F��e stehen h�ftbreit auseinander, die Knie sind leicht gebeugt.
Die Arme lang lassen und den Bauch anspannen. Die Schultern so weit wie m�glich in Richtung der Ohren ziehen.');

INSERT INTO Exercise VALUES ('Schultern', 'Dynamische Br�cke mit Hochgreifen', 'Fortgeschritten','Auf den Boden setzen, leicht zur�cklehnen und mit gestreckten Armen die H�nde hinter dem Ges�� schulterbreit aufsetzen.
Die Beine leicht anwinkeln, die F��e auf die Fersen stellen und das Ges�� anheben. Das Ges�� dynamisch auf eine H�he mit Rumpf und Oberschenkeln dr�cken und die linke Hand m�glichst weit hochschieben.
In der n�chsten Wiederholung den rechten Arm strecken und dann abwechselnd z�gig fortfahren.');

INSERT INTO Exercise VALUES ('Schultern', 'Pike Schulterdr�cken', 'Fortgeschritten','Mit den H�nden kopf�ber auf dem Boden schulterbreit abst�tzen. Das Ges�� zur Decke dr�cken.
Beine und Arme durchstrecken, den R�cken gerade halten. Die Ellenbogen beugen, bis der Kopf fast den Boden ber�hrt.');

-- Beine:

INSERT INTO Exercise VALUES ('Beine', 'Kniebeugen im Ausfallsschritt', 'Anf�nger','Stehen Sie in Ausfallschrittstellung, der linke Fu� ist vor dem rechten. Verschr�nken Sie Ihre H�nde hinter dem Kopf.
Ziehen Sie Ihre Ellenbogen und Schultern nach hinten. Senken Sie Ihren K�rper so tief wie Sie k�nnen. Der untere R�cken bleibt dabei gerade,
der Oberk�rper so aufrecht wie m�glich. Ihr hinteres Knie ber�hrt fast den Boden. Im n�chsten Satz Bein wechseln.');

INSERT INTO Exercise VALUES ('Beine', 'Kniebeugen', 'Anf�nger','Im aufrechten Stand die Arme nach vorne strecken. Die F��e doppelt schulterbreit auseinander.
Schieben Sie Ihre H�fte nach hinten und beugen Sie Ihre Knie. Halten Sie den unteren R�cken gerade und senken Sie Ihren K�rper so tief Sie k�nnen.');

INSERT INTO Exercise VALUES ('Beine', 'Strecksprung', 'Anf�nger','In die Hockstellung gehen, die F��e sind etwa schulterbreit auseinander. Die H�nde an den Schl�fen halten.
Die Beine explosiv strecken und so hoch wie m�glich springen. Die Arme w�hrend der Bewegung senkrecht nach oben strecken.
Der K�rper ist jetzt komplett gestreckt. Beim Landen in den Knien nachgeben.');

INSERT INTO Exercise VALUES ('Beine', 'Fersenheben', 'Anf�nger','Im aufrechten Stand auf die Fu�ballen aufstellen. Heben Sie die Fersen so hoch wie Sie k�nnen.
Kurz halten und zur�ck in die Ausgangsposition senken.');

INSERT INTO Exercise VALUES ('Beine', 'Hohe Tritte', 'Anf�nger','Gerade hinstellen und die F��e h�ftbreit auseinandersetzen. Die Arme seitlich am K�rper h�ngen lassen.
Dynamisch das gestreckte rechte Bein vor dem K�rper auf Brusth�he schwingen. Gleichzeitig den linken Arm vorstrecken und die Fu�spitze mit der Hand ber�hren.
In der n�chsten Wiederholung die �bung mit dem linken Bein und dem rechten Arm ausf�hren, dann wechselseitig fortfahren.');

INSERT INTO Exercise VALUES ('Beine', 'Kniebeugen mit Strecksprung', 'Fortgeschritten','Im aufrechten Stand die H�nde hinter dem Kopf verschr�nken. Ziehen Sie die Ellenbogen und Schultern nach hinten.
Schieben Sie Ihre H�fte nach hinten und beugen Sie Ihre Knie. Halten Sie den unteren R�cken gerade und senken Sie Ihren K�rper so tief Sie k�nnen.
In der Hocke springen sie mit nach oben gestreckten Armen nach oben.');

INSERT INTO Exercise VALUES ('Beine', 'Unterarmst�tz-Kickbacks', 'Fortgeschritten','Einen Unterarmst�tz einnehmen: Die Ellenbogen unter den Schultern platzieren und die F��e auf den Zehen aufstellen.
Die Knie etwas angewinkelt in der Luft halten. Das rechte Bein dynamisch nach hinten oben strecken und die Ferse so weit wie m�glich wegdr�cken
 � es bildet jetzt mit Kopf und Rumpf eine gerade Linie. Den Fu� w�hrend des Satzes nicht wieder ganz abstellen. Im n�chsten Durchgang Seitenwechsel.');

INSERT INTO Exercise VALUES ('Beine', 'Sprung auf Erh�hung', 'Fortgeschritten','In die Hockstellung gehen, die F��e sind etwa schulterbreit auseinander und geradeaus nach vorne auf die Erh�hung springen. 
Versuchen Sie in einer aufrechten K�rperhaltung zu landen.');

INSERT INTO Exercise VALUES ('Beine', 'Rumpfneigen auf den Knien', 'Fortgeschritten','Auf den Boden knien, sodass Oberschenkel, H�fte und Oberk�rper eine gerade Linie bilden. Die Arme neben dem K�rper h�ngen lassen.
Beide F��e mit dem Spann ablegen und Rumpfspannung aufbauen. Rumpf und Oberschenkel langsam so weit es geht nach hinten neigen. In der Endposition f�r einige Sekunden halten, dann zur�ck.');

INSERT INTO Exercise VALUES ('Beine', 'H�ftheben mit Beinstrecken', 'Fortgeschritten','In R�ckenlage die F��e h�ftbreit und dicht vor dem Ges�� aufstellen. Die Arme nah am K�rper mit den Handfl�chen nach unten ablegen,
dann die H�fte anheben, bis Oberschenkel, Becken und Oberk�rper eine gerade Linie bilden. Den rechten Fu� vom Boden l�sen und das Bein nach vorn parallel zum linken Oberschenkel ausstrecken.
Das gestreckte Bein so weit es geht weiter nach oben in Richtung Oberk�rper bewegen. Dort halten und wieder zur�ck zu Position B. Seitenwechsel im n�chsten Satz.');


