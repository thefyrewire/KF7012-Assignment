DROP TABLE Companies;
DROP TABLE Jobs;
DROP TABLE Engineers;
DROP TABLE Machines;
DROP TABLE Users;
DROP TABLE ScheduledJobs;
DROP TABLE ClosedJobs;

------------------
-- COMPANIES
------------------
CREATE TABLE Companies (
	companyID           INTEGER NOT NULL,
    name                VARCHAR(255),
	location            VARCHAR(255),
	-- machineID           VARCHAR(25),         <----- ??

	PRIMARY KEY (companyID)
);
INSERT INTO Companies VALUES (1, '3D Solutions', 'Slough', 'abc1234');
INSERT INTO Companies VALUES (2, 'Computer Systems Solutions', 'Maidenhead', 'der4321');
INSERT INTO Companies VALUES (3, 'IT Engineering', 'Reading', 'erw3421');
INSERT INTO Companies VALUES (4, 'ComTech Solutions', 'Brighton', 'rt3214');

------------------
-- JOBS
------------------
CREATE TABLE Jobs (
	jobID           INTEGER NOT NULL,
    companyID       INTEGER NOT NULL,
    machineID       VARCHAR(25) NOT NULL,
    description     TEXT,
    dateReported    DATE,
    priority        INTEGER,

	PRIMARY KEY (jobID),
	FOREIGN KEY (companyID) REFERENCES Companies(companyID)
);
INSERT INTO Jobs VALUES (811, 1, 'abc1234', 'strange sound from the machine', '2018-06-12', 4);
INSERT INTO Jobs VALUES (831, 2, 'der4321', 'broken conveyer belt', '2018-11-23', 1);
INSERT INTO Jobs VALUES (851, 3, 'erw3421', 'gets stuck while operating', '2018-10-12', 3);
INSERT INTO Jobs VALUES (891, 4, 'rt3214', 'fumes coming out of the machine', '2018-08-26', 2);

------------------
-- ENGINEERS
------------------
CREATE TABLE Engineers (
	engineerID      VARCHAR(25) NOT NULL,
    name            VARCHAR(255),
	profile         VARCHAR(25),
	skills          TEXT,

	PRIMARY KEY (engineerID)
);
INSERT INTO Engineers VALUES ('E231', 'Neil Thompson', 'engineer', 'automation');
INSERT INTO Engineers VALUES ('E321', 'John Tait', 'engineer', 'soldering');
INSERT INTO Engineers VALUES ('E543', 'Paul Samson', 'engineer', 'electrical');
INSERT INTO Engineers VALUES ('E432', 'Patricia Maxwell', 'lead engineer', 'automation');

------------------
-- MACHINES
------------------
CREATE TABLE Machines (
    machineID               VARCHAR(25) NOT NULL,
    companyID               INTEGER NOT NULL,
    assetTag                VARCHAR(25),
    sizeComplexity          INTEGER,

    PRIMARY KEY (machineID),
    FOREIGN KEY (companyID) REFERENCES Companies(companyID)
);
INSERT INTO Machines VALUES ('mch231', 1, 'aw4325', 4);
INSERT INTO Machines VALUES ('mch781', 2, 'tr4654325', 3);
INSERT INTO Machines VALUES ('mch543', 4, 'ahw437825', 5);
INSERT INTO Machines VALUES ('mch432', 3, 'au432589', 1);

------------------
-- USERS
------------------
CREATE TABLE Users (
	userID          INTEGER NOT NULL,
    username        VARCHAR(25),
    password        VARCHAR(50),
    profile         VARCHAR(25),

	PRIMARY KEY (userID)
);
INSERT INTO Users VALUES (765342, 'John Smith', 'user', 'iam2354@');
INSERT INTO Users VALUES (294573, 'Isacc Thomas', 'user', 'yr@2345');
INSERT INTO Users VALUES (364893, 'Shane Davies', 'admin', 'admin');
INSERT INTO Users VALUES (446895, 'Jay Black', 'user', 'rt3@e14');

------------------
-- SCHEDULED JOBS
------------------
CREATE TABLE ScheduledJobs (
	jobID                   INTEGER NOT NULL,
    priority                INTEGER,
	startDate               DATE,
	skillsNeeded            TEXT,
    completionTimeNeeded    VARCHAR(25),
    completionDate          DATE,

	PRIMARY KEY (jobID)
);

------------------
-- CLOSED JOBS
------------------
CREATE TABLE ClosedJobs (
    jobID           INTEGER NOT NULL,
    completionDate  DATE,
	closingDate     DATE,
	solution        TEXT,
    notes           TEXT,

	PRIMARY KEY (jobID)
);