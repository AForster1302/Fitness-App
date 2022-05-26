
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

INSERT INTO Exercise VALUES ('Bauch', 'Crunch','Anfänger','Auf den Rücken legen. Die Beine anwinkeln und die Hände an den Schläfen halten, Ellbogen zeigen nach außen.
Aus der Kraft des Bauches den Schulterbereich vom Boden abheben, kurz halten, wieder absenken. 
Den Rücken dabei möglichst gerade und den Nacken in Verlängerung der Wirbelsäule halten.');

INSERT INTO Exercise VALUES ('Bauch', 'Side-Crunch','Anfänger','Auf den Boden legen, die Fersen aufstellen. Die Hände an die Schläfen legen, die Ellenbogen zeigen nach außen.
Den Oberkörper kontrolliert aufrichten und nach links, in der nächsten Wiederholung nach rechts drehen.');

INSERT INTO Exercise VALUES ('Bauch', 'Beinheben','Anfänger','Auf den Boden legen, die Hände unter das Gesäß schieben und die Beine gestreckt über dem Boden halten.
Die Bauchmuskeln anspannen und die gestreckten Beine langsam heben, bis sie senkrecht stehen. Ebenso langsam wieder absenken, ohne sie abzulegen.');

INSERT INTO Exercise VALUES ('Bauch', 'Bergsteiger','Anfänger','In der Liegestützposition abgestützt, die Beine und der Oberkörper sind gerade gestreckt.
Nun werden die Knie in einer sprunghaften Bewegung abwechselnd Richtung Brustkorb gezogen. Das jeweils hintere Bein bleibt gerade gestreckt.');

INSERT INTO Exercise VALUES ('Bauch', 'Seitlicher Unterarmstütz','Anfänger','In Seitlage auf den Boden legen und den Oberkörper auf den linken Unterarm stützen.
Das Becken anheben, bis der Körper von Kopf bis Fuß eine gerade Linie bildet. In der Hüfte stabil bleiben und die Position halten. Im nächsten Satz die Seite wechseln.');

INSERT INTO Exercise VALUES ('Bauch', 'Beinkreisen','Fortgeschritten','Auf den Boden setzen, die Beine nach vorn ausstrecken und einige Zentimeter über dem Boden halten.
Den Oberkörper nach hinten lehnen und auf den Unterarmen abstützen. Die Oberarme stehen senkrecht unter den Schultern.
Die gestreckten Beine in weiten, wechselnd großen Kreisen durch die Luft bewegen.');

INSERT INTO Exercise VALUES ('Bauch', 'Beinpendeln', 'Fortgeschritten','Auf den Rücken legen, die Arme zur Seite gestreckt ablegen und die Beine senkrecht hochheben. Die Fußspitzen anziehen.
Die gestreckten Beine langsam so weit wie möglich nach rechts absenken, wieder anheben, dann nach links absenken und im Wechsel fortfahren.');

INSERT INTO Exercise VALUES ('Bauch', 'Crunches mit angewinkeltem Bein', 'Fortgeschritten','Rücklings auf den Boden legen. Die Beine durchstrecken und ebenso wie die gestreckten Arme knapp über dem Boden halten.
Die Knie anziehen, bis die Oberschenkel in etwa senkrecht und die Unterschenkel waagerecht in der Luft stehen. 
Gleichzeitig den Schulterbereich vom Boden abheben, dabei die Arme an den Oberschenkeln vorbei weg vom Körper schieben.');

INSERT INTO Exercise VALUES ('Bauch', 'Gestreckte Crunches', 'Fortgeschritten','Rücklings auf den Boden legen, Arme und Beine senkrecht zur Decke strecken.
Den Oberkörper langsam anheben. Die Finger so weit es geht nach oben schieben und dabei versuchen, die Zehen zu berühren.');

INSERT INTO Exercise VALUES ('Bauch', 'Radfahr-Crunches', 'Fortgeschritten','Rücklings hinlegen und die Arme am Kopf vorbei ausstrecken. Die Bauchmuskeln anspannen und den Schulterbereich leicht vom Boden abheben.
Das rechte Knie anwinkeln, zur Brust ziehen und mit der linken Hand den Fuß berühren. Flüssig die Seiten wechseln: Den linken Arm neben den Kopf zurückschwingen, das rechte Bein strecken,
das linke beugen und den Fuß mit der rechten Hand berühren. Wechselseitig zügig wiederholen, ohne Arme, Beine oder oberen Rücken abzulegen.');

-- Rücken:

INSERT INTO Exercise VALUES ('Rücken', 'Rumpfheben auf dem Bauch', 'Anfänger','In Bauchlage hinlegen. Die Arme liegen neben dem Körper oder Sie legen die Handrücken auf dem Gesäß ab.
Mit der Kraft des unteren Rückens den Oberkörper langsam anheben. Dabei die Schulterblätter zusammenziehen und die Hände in Richtung der Füße schieben.');

INSERT INTO Exercise VALUES ('Rücken', 'Kniependeln', 'Anfänger','Hinlegen und die Knie rechtwinklig beugen. Die Arme seitlich vom Körper ausstrecken.
Die Beine nach rechts zum Boden kippen. Kopf, Arme und Schultern bleiben auf dem Boden.
Gleich danach nach links pendeln, dann wechselseitig wie in einer Kraftübung fortfahren.');

INSERT INTO Exercise VALUES ('Rücken', 'Katzenbuckel', 'Anfänger','In den Vierfüßlerstand begeben, die Hände unter den Schultern und die Knie unter den Hüften platzieren.
Den Oberkörper durchhängen lassen, den Blick nach vorn richten. Den Oberkörper langsam einrollen und den runden Rücken möglichst weit nach oben drücken.
Dabei das Kinn zur Brust ziehen. Die Positionen jeweils einige Sekunden halten.');

INSERT INTO Exercise VALUES ('Rücken', 'Beckenheben in Rückenlage', 'Anfänger','Auf den Rücken legen und die Beine anwinkeln. Fersen in den Boden drücken. Unterarme aufstellen, Oberarme liegen auf dem Boden auf.
Das Becken kippen und den Oberkörper sowie das Gesäß anheben, indem Sie die Ellenbogen in den Boden drücken.
Die größte Last liegt auf den Oberarmen. Den Körper ein wenig in Richtung Kopf schieben.');

INSERT INTO Exercise VALUES ('Rücken', 'Einbeiniges Hüftrollen', 'Anfänger','Hinlegen und die Arme seitlich ausstrecken. Das linke Bein gestreckt senkrecht anheben.
Langsam das linke Bein über das rechte absenken, bis der linke Fuß auf dem Boden liegt. Der Oberkörper bleibt dabei möglichst gerade.
Gleich im Anschluss mit dem rechten Bein fortfahren, dann wechselseitig wiederholen.');

INSERT INTO Exercise VALUES ('Rücken', 'Arm- und Beinheben im Liegen', 'Fortgeschritten','Bäuchlings auf den Boden legen und die Arme in Verlängerung zum Körper ablegen.
Das Becken in den Boden drücken und den Rumpf anspannen. Beine, Arme und Oberkörper gleichzeitig möglichst weit vom Boden abheben.
Der Kopf bleibt in Verlängerung zur Wirbelsäule, der Blick geht zum Boden.');

INSERT INTO Exercise VALUES ('Rücken', 'Rückenbrücke', 'Fortgeschritten','Mit gestreckten Armen und Beinen auf den Rücken legen. Die Fersen in den Boden drücken und die Arme hinter dem Kopf ablegen.
Den Rumpf anspannen und die Hüfte möglichst weit anheben. In dieser Position berühren nur noch Fersen, Schultern und Arme den Boden.
Wenigstens drei bis fünf Sekunden halten, dann wieder für kurze Zeit ganz ablegen.');

INSERT INTO Exercise VALUES ('Rücken', 'Windmühle', 'Fortgeschritten','Hüftbreit hinstellen, die Knie leicht beugen und den Oberkörper mit geradem Rücken etwas mehr als 45 Grad vorbeugen.
Die Arme anspannen und schulterbreit nach unten strecken. Die Hände sind zur Unterstützung der Armspannung zu Fäusten geballt.
Den Rumpf nach rechts aufdrehen, ohne den Neigungswinkel zu verändern. Dabei den rechten Arm nach oben in der Verlängerung des linken Arms strecken.
Das rechte Bein etwas strecken, das linke Knie mehr beugen – dabei aber darauf achten, dass es nicht nach innen wandert.
Die Spannung im Körper halten, dann ­zurück in die Ausgangsstellung.
Direkt im Anschluss nach links drehen, dann wechselseitig wiederholen.');

INSERT INTO Exercise VALUES ('Rücken', 'Zwei-Punkt-Liegestütze', 'Fortgeschritten','In die Liegestützposition gehen und den Körper auf einer geraden Linie halten. Den linken Arm 
und das rechte Bein gleichzeitig vom Boden abheben und waagerecht ausstrecken. Die Position kurz halten. Im nächsten Satz die Seiten wechseln.');

INSERT INTO Exercise VALUES ('Rücken', 'Angewinkeltes Beinheben', 'Fortgeschritten','In Bauchlage die Arme angewinkelt vor dem Kopf ablegen, die Füße vom Boden abheben und die Beine etwa 45 Grad beugen.
Ohne Schwung die Oberschenkel anheben und die Unterschenkel in Richtung Gesäß ziehen, bis die Beine etwa rechtwinklig gebeugt sind.');

-- Brust:

INSERT INTO Exercise VALUES ('Brust', 'Breite Liegestütz auf den Knien', 'Anfänger','In die Liegestützposition gehen und statt auf den Fußspitzen, auf den Knien abstützen. Die Hände doppelt schulterbreit auseinander halten
und den Körper auf eine gerade Linie bringen. Den Oberkörper senken, bis die Körperlinie und die Oberarme waagerecht zum Boden stehen.
Halten und anschließend zurück in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Brust', 'Brustrotation in Seitlage', 'Anfänger','Auf die linke Körperseite legen. Die Knie anziehen, bis die Beine rechtwinklig gebeugt sind. Die Arme auf Schulterhöhe gerade nach vorn strecken,
sodass der linke Arm auf dem Boden und der rechte darüberliegt. Die Handflächen aneinanderlegen.Den rechten Arm anheben und zusammen mit dem Rumpf nach rechts drehen,
bis Schulter und Hand den Boden berühren. Die Beine und der linke Arm bleiben in Position und links im Bodenkontakt. 
Einige Sekunden halten, dann den Arm zurückführen. Im nächsten Satz die Seite wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Brustdehnen mit gestrecktem Armen', 'Anfänger','In den Vierfüßlerstand gehen. Die Arme schräg nach vorne strecken und die Handflächen auf dem Boden abstützen.
Den Rücken gerade machen, den Rumpf anspannen und die Knie auf dem Boden ablegen. Der Kopf bleibt dabei immer in Verlängerung der Wirbelsäule. Die Füße aufstellen, so dass der Kniewinkel etwa 90 Grad beträgt.
Den Kopf in Richtung Boden senken und den Oberkörper nach hinten schieben. Gesäß, Rücken und Arme bilden eine abfallende Linie.');

INSERT INTO Exercise VALUES ('Brust', 'Statischer Crunch', 'Anfänger','Rücklings hinlegen und die Beine rechtwinklig gebeugt in der Luft halten. Den Rumpf anspannen, Schultern und Kopf anheben
und die Handflächen mit gestreckten Armen von außen an die Knie legen. Den Rumpf anspannen, dann halten und mit den Händen für etwa fünf Sekunden gegen die Knie drücken.
Nun die Handaußenseiten von innen gegen die Knie legen. Rumpfspannung aufbauen und mit den Händen fünf Sekunden lang nach außen drücken.
Lösen, Rumpf und Arme kurz entspannen, dann die nächste Wiederholung durchführen.');

INSERT INTO Exercise VALUES ('Brust', 'Einarmiges Brustdehnen an der Wand', 'Anfänger','In Schrittstellung, der linke Fuß ist vorne, mit der linken Körperseite vor eine Wand stellen.
Den linken Arm auf Schulterhöhe zur Seite strecken und die Handfläche gegen die Wand drücken. Die rechte in die Hüfte stemmen.
Den Oberkörper leicht nach rechts drehen, bis Sie eine Dehnung in der Brustmuskulatur spüren. Im nächsten Satz Seite wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Aufdrehende Liegestütze', 'Fortgeschritten','In die Liegestütz-Position gehen und den Körper auf einer geraden Linie halten.
Den Oberkörper senken, bis die Körperlinie waagerecht zum Boden steht. Mit dem linken Arm hochdrücken und den Oberkörper aufdrehen, so dass der rechte Arm senkrecht nach oben zeigt.
Zurück in die Ausgangsposition kommen. Im nächsten Satz Seite wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Breite Liegestütze', 'Fortgeschritten','In die Liegestützposition gehen, die Hände doppelt schulterbreit auseinander halten und den Körper auf eine gerade Linie bringen.
Den Oberkörper senken, bis die Körperlinie und die Oberarme waagerecht zum Boden stehen. Halten und anschließend zurück in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Brust', 'Vorwärtslaufen auf den Händen', 'Fortgeschritten','In die Liegestützposition gehen. In kleinen Schritten die Füße in Richtung der Hände setzen, dabei das Gesäß zur Decke drücken. 
Die Beine und die Arme sind gestreckt, der Rücken gerade und der Kopf in Verlängerung der Wirbelsäule. Die Hände abwechselnd Stück für Stück nach vorne setzen. 
Mit den Händen soweit nach vorne wandern, bis der Oberkörper etwa waagerecht zum Boden steht. Kurz halten und in umgekehrter Reihenfolge zurück in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Brust', 'Versetzte Liegestütze', 'Fortgeschritten','In einen Liegestütz gehen, die Hände dabei versetzt platzieren: die linke Hand ein Stück nach vorn in Richtung Kopf, die rechte Hand auf Brusthöhe.
Die Arme beugen und den Körper absenken, bis die Brust fast den Boden berührt. Zügig wieder hochdrücken. Die Handpositionen wechseln, ohne die Spannung im Körper zu vernachlässigen: 
Jetzt die rechte Hand weiter vorn und die linke auf Brusthöhe aufsetzen. Den nächsten Liegestütz ausführen, in der Folge die Handpositionen beliebig wechseln.');

INSERT INTO Exercise VALUES ('Brust', 'Liegestütze mit abgelegten Unterarmen', 'Fortgeschritten','In die Liegestützposition gehen und den Körper auf einer geraden Linie halten.
Den Oberkörper senken und die Unterarme auf dem Boden ablegen.');

-- Arm:

INSERT INTO Exercise VALUES ('Arm', 'Dips an einem Stuhl', 'Anfänger','Rücklings auf einem Stuhl abstützen, die Handrücken zeigen zum Körper. Die Füße nach vorn setzen, die Oberschenkel stehen waagerecht zum Boden. 
Die Ellenbogen beugen, bis die Oberarme in etwa waagerecht stehen. Das Gesäß dabei absenken.');

INSERT INTO Exercise VALUES ('Arm', 'Curls mit Beinwiderstand', 'Anfänger','Auf den Boden setzen, die Beine leicht angewinkelt ausstrecken und spreizen. Den linken Ellenbogen gegen die Innenseite des linken Oberschenkels stemmen und mit der linken Hand in die rechte Kniekehle fassen.
Mit rechts neben dem Gesäß abstützen, dann mit links das rechte Bein leicht anheben. Den linken Arm weiter beugen und das rechte Bein in Richtung Brust ziehen. Den Oberkörper dabei halten. Bei Bedarf mit dem rechten Bein Gegendruck erzeugen.
Im nächsten Satz die Seite wechseln.');

INSERT INTO Exercise VALUES ('Arm', 'Handstrecken', 'Anfänger','Aufrecht und schulterbreit aufstellen. Den rechten Arm gerade nach vorne strecken und das Handgelenk im rechten Winkel nach unten beugen. Die Handfläche zeigt nach vorn.
Mit der linken Hand die Finger der rechten Hand leicht in Richtung Körper drücken, bis Sie eine Dehnung spüren. Im nächsten Satz Armwechsel.');

INSERT INTO Exercise VALUES ('Arm', 'Trizepsstrecken hinter dem Kopf', 'Anfänger','Aufrecht und schulterbreit aufstellen. Den linken Arm beugen, der Ellenbogen zeigt zur Decke, die Hand liegt auf dem Nacken. 
Mit der rechten Hand den linken Ellenbogen leicht nach unten drücken, bis Sie eine Dehnung spüren. Im nächsten Satz Armwechsel.');

INSERT INTO Exercise VALUES ('Arm', 'Liegestütze', 'Anfänger','In den Liegestütz gehen. Die Arme sind dabei fast ganz durchgestreckt, die Hände befinden sich unter den Schultern.
Rücken gerade halten, Kopf, Gesäß und Fersen bilden eine Linie. Arme beugen und den Körper absenken, bis die Brust knapp über dem Boden ist. Dann wieder nach oben drücken.');

INSERT INTO Exercise VALUES ('Arm', 'Trizeps-Kniebeugen', 'Anfänger','Stellen Sie sich aufrecht hin, beugen Sie sich leicht nach vorne und legen Sie die Hände auf Ihren Oberschenkeln knapp über den Knien auf.
Gehen Sie nun leicht in die Hocke, bis Ihre Arme gebeugt sind und drücken Sie anschließend Ihren Oberkörper mit der Kraft Ihres Trizeps wieder in eine aufrechte Position.');

INSERT INTO Exercise VALUES ('Arm', 'Diamant Liegestütze', 'Fortgeschritten','In einen Liegestütz gehen und Hände so nah zusammenführen, dass sich die beiden Daumen und die beiden Zeigefinger berühren.
Die Arme anwinkeln und den Körper absenken. Die Position kurz halten und dann wieder hochdrücken.');

INSERT INTO Exercise VALUES ('Arm', 'Liegestütze in Rückenlage', 'Fortgeschritten','Mit gestreckten Beinen hinsetzen und die Hände hinter dem Gesäß platzieren.
Die Hüfte hochdrücken, bis Ihr Körper von Kopf bis Fuß eine gerade Linie bildet. Die Schultern befinden sich direkt über den Händen.
Die Arme beugen und den Körper absenken, bis das Gesäß fast den Boden berührt. Die Position halten und wieder zurück.');

INSERT INTO Exercise VALUES ('Arm', 'Dips mit angehobenem Bein', 'Fortgeschritten','Rücklings auf einer Bank abstützen, die Handrücken zeigen zum Körper.
Die Füße nach vorn setzen, bis Beine und Oberkörper eine gerade Linie bilden. Das rechte Bein anheben und nach vorne strecken.
Die Ellenbogen beugen, bis die Oberarme in etwa waagerecht stehen. Das Gesäß dabei absenken. Im nächsten Durchgang das andere Bein anheben.');

INSERT INTO Exercise VALUES ('Arm', 'Halbe fliegende Liegestütze', 'Fortgeschritten','In einen Liegestütz gehen. Die Hände so aufstellen, dass die Finger zu den Füßen zeigen.
Die Arme beugen, bis die Brust knapp über dem Boden schwebt. Kurz halten und wieder hochdrücken.');

INSERT INTO Exercise VALUES ('Arm', 'Bergab-Liegestütze', 'Fortgeschritten','In die Liegestützposition gehen, die Füße auf einem Stuhl ablegen und den Körper auf einer geraden Linie halten.
Den Oberkörper senken, bis die Körperlinie schräg nach unten zeigt und die Oberarme waagerecht zum Boden stehen. Halten und anschließend zurück in die Ausgangsposition kommen.');

INSERT INTO Exercise VALUES ('Arm', 'Liegestütze mit gedrehtem Oberkörper', 'Fortgeschritten','Den Oberkörper senken, bis die Körperlinie schräg nach unten zeigt und die Oberarme waagerecht zum Boden stehen.
Halten und anschließend zurück in die Ausgangsposition kommen. Die linke Körperhälfte zur Seite neigen, die Knie zeigen dabei nach rechts.
Wie ein Korkenzieher dreht sich Ihr Körper leicht ein. Position kurz halten, dann wieder hochdrücken. Bei der Wiederholung in die andere Richtung drehen.');

-- Schultern:

INSERT INTO Exercise VALUES ('Schultern', 'Wechselseitiges Armheben', 'Anfänger','Mit jeder Hand einen schweren Gegenstand greifen. Den linken Arm waagerecht vorstrecken, der rechte Arm zeigt senkrecht nach oben.
Den linken Arm gestreckt nach oben führen, bis er senkrecht steht. Gleichzeitig den rechten Arm nach vorn in die Waagerechte absenken.
Den Rücken gerade halten, die Schulterblätter nach unten ziehen. Im Wechsel fortfahren.');

INSERT INTO Exercise VALUES ('Schultern', 'Schulterheben', 'Anfänger','Mit einem Gewicht in jeder Hand die Arme neben dem Körper hängen lassen. Die Handflächen zeigen zueinander. Die Füße stehen hüftbreit auseinander, die Knie sind leicht gebeugt.
Die Arme lang lassen und den Bauch anspannen. Die Schultern so weit wie möglich in Richtung der Ohren ziehen.');

INSERT INTO Exercise VALUES ('Schultern', 'Dynamische Brücke mit Hochgreifen', 'Fortgeschritten','Auf den Boden setzen, leicht zurücklehnen und mit gestreckten Armen die Hände hinter dem Gesäß schulterbreit aufsetzen.
Die Beine leicht anwinkeln, die Füße auf die Fersen stellen und das Gesäß anheben. Das Gesäß dynamisch auf eine Höhe mit Rumpf und Oberschenkeln drücken und die linke Hand möglichst weit hochschieben.
In der nächsten Wiederholung den rechten Arm strecken und dann abwechselnd zügig fortfahren.');

INSERT INTO Exercise VALUES ('Schultern', 'Pike Schulterdrücken', 'Fortgeschritten','Mit den Händen kopfüber auf dem Boden schulterbreit abstützen. Das Gesäß zur Decke drücken.
Beine und Arme durchstrecken, den Rücken gerade halten. Die Ellenbogen beugen, bis der Kopf fast den Boden berührt.');

-- Beine:

INSERT INTO Exercise VALUES ('Beine', 'Kniebeugen im Ausfallsschritt', 'Anfänger','Stehen Sie in Ausfallschrittstellung, der linke Fuß ist vor dem rechten. Verschränken Sie Ihre Hände hinter dem Kopf.
Ziehen Sie Ihre Ellenbogen und Schultern nach hinten. Senken Sie Ihren Körper so tief wie Sie können. Der untere Rücken bleibt dabei gerade,
der Oberkörper so aufrecht wie möglich. Ihr hinteres Knie berührt fast den Boden. Im nächsten Satz Bein wechseln.');

INSERT INTO Exercise VALUES ('Beine', 'Kniebeugen', 'Anfänger','Im aufrechten Stand die Arme nach vorne strecken. Die Füße doppelt schulterbreit auseinander.
Schieben Sie Ihre Hüfte nach hinten und beugen Sie Ihre Knie. Halten Sie den unteren Rücken gerade und senken Sie Ihren Körper so tief Sie können.');

INSERT INTO Exercise VALUES ('Beine', 'Strecksprung', 'Anfänger','In die Hockstellung gehen, die Füße sind etwa schulterbreit auseinander. Die Hände an den Schläfen halten.
Die Beine explosiv strecken und so hoch wie möglich springen. Die Arme während der Bewegung senkrecht nach oben strecken.
Der Körper ist jetzt komplett gestreckt. Beim Landen in den Knien nachgeben.');

INSERT INTO Exercise VALUES ('Beine', 'Fersenheben', 'Anfänger','Im aufrechten Stand auf die Fußballen aufstellen. Heben Sie die Fersen so hoch wie Sie können.
Kurz halten und zurück in die Ausgangsposition senken.');

INSERT INTO Exercise VALUES ('Beine', 'Hohe Tritte', 'Anfänger','Gerade hinstellen und die Füße hüftbreit auseinandersetzen. Die Arme seitlich am Körper hängen lassen.
Dynamisch das gestreckte rechte Bein vor dem Körper auf Brusthöhe schwingen. Gleichzeitig den linken Arm vorstrecken und die Fußspitze mit der Hand berühren.
In der nächsten Wiederholung die Übung mit dem linken Bein und dem rechten Arm ausführen, dann wechselseitig fortfahren.');

INSERT INTO Exercise VALUES ('Beine', 'Kniebeugen mit Strecksprung', 'Fortgeschritten','Im aufrechten Stand die Hände hinter dem Kopf verschränken. Ziehen Sie die Ellenbogen und Schultern nach hinten.
Schieben Sie Ihre Hüfte nach hinten und beugen Sie Ihre Knie. Halten Sie den unteren Rücken gerade und senken Sie Ihren Körper so tief Sie können.
In der Hocke springen sie mit nach oben gestreckten Armen nach oben.');

INSERT INTO Exercise VALUES ('Beine', 'Unterarmstütz-Kickbacks', 'Fortgeschritten','Einen Unterarmstütz einnehmen: Die Ellenbogen unter den Schultern platzieren und die Füße auf den Zehen aufstellen.
Die Knie etwas angewinkelt in der Luft halten. Das rechte Bein dynamisch nach hinten oben strecken und die Ferse so weit wie möglich wegdrücken
 – es bildet jetzt mit Kopf und Rumpf eine gerade Linie. Den Fuß während des Satzes nicht wieder ganz abstellen. Im nächsten Durchgang Seitenwechsel.');

INSERT INTO Exercise VALUES ('Beine', 'Sprung auf Erhöhung', 'Fortgeschritten','In die Hockstellung gehen, die Füße sind etwa schulterbreit auseinander und geradeaus nach vorne auf die Erhöhung springen. 
Versuchen Sie in einer aufrechten Körperhaltung zu landen.');

INSERT INTO Exercise VALUES ('Beine', 'Rumpfneigen auf den Knien', 'Fortgeschritten','Auf den Boden knien, sodass Oberschenkel, Hüfte und Oberkörper eine gerade Linie bilden. Die Arme neben dem Körper hängen lassen.
Beide Füße mit dem Spann ablegen und Rumpfspannung aufbauen. Rumpf und Oberschenkel langsam so weit es geht nach hinten neigen. In der Endposition für einige Sekunden halten, dann zurück.');

INSERT INTO Exercise VALUES ('Beine', 'Hüftheben mit Beinstrecken', 'Fortgeschritten','In Rückenlage die Füße hüftbreit und dicht vor dem Gesäß aufstellen. Die Arme nah am Körper mit den Handflächen nach unten ablegen,
dann die Hüfte anheben, bis Oberschenkel, Becken und Oberkörper eine gerade Linie bilden. Den rechten Fuß vom Boden lösen und das Bein nach vorn parallel zum linken Oberschenkel ausstrecken.
Das gestreckte Bein so weit es geht weiter nach oben in Richtung Oberkörper bewegen. Dort halten und wieder zurück zu Position B. Seitenwechsel im nächsten Satz.');


