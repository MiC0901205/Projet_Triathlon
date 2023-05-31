--
-- Base de données: `TriathlonDB`
--
-- --------------------------------------------------------
create database TriathlonDB;
go
create login EntityTriathlon with password = '21Sl@mM€rm0z23';
go
use TriathlonDB;
go
create user EntityTriathlon for login EntityTriathlon;
go

-- --------------------------------------------------------
--
-- Structure de la base de données
--

CREATE TABLE TypeTriathlon (
  codeTypeT INT identity NOT NULL,
  designation VARCHAR(50),
  nom VARCHAR(50),
  distanceCyclisme INT,
  distanceNatation INT,
  distanceCourse INT,
  CONSTRAINT PK_typeFilm PRIMARY KEY (codeTypeT)
);

CREATE TABLE CategAge(
   codeAge INT identity NOT NULL,
   libelle VARCHAR(50),
   ageDebut INT,
   ageFin INT,
   CONSTRAINT PK_categAge PRIMARY KEY(codeAge)
);

CREATE TABLE ProdDopant(
   codeDop INT identity NOT NULL,
   libelle VARCHAR(50),
   tauxMax FLOAT,
   CONSTRAINT PK_prodDopant PRIMARY KEY(codeDop)
);

CREATE TABLE Triathlon(
   numTriath INT identity NOT NULL,
   nom VARCHAR(50),
   lieu VARCHAR(50),
   dateCompet DATE,
   codeTypeT INT NOT NULL,
   CONSTRAINT PK_triathlon PRIMARY KEY(numTriath),
   CONSTRAINT FK_triathlon_typeTriathlon FOREIGN KEY(codeTypeT) REFERENCES TypeTriathlon(codeTypeT)
);

CREATE TABLE Triathlete(
   numLicence INT identity NOT NULL,
   nom VARCHAR(50),
   prenom VARCHAR(50),
   adresse VARCHAR(50),
   cp INT,
   ville VARCHAR(50),
   dateNaissance DATE,
   codeAge INT,
   CONSTRAINT PK_triathlete PRIMARY KEY(numLicence),
   CONSTRAINT FK_triathlete_categAge FOREIGN KEY(codeAge) REFERENCES CategAge(codeAge)
);

CREATE TABLE Inscription(
   numTriath INT NOT NULL,
   numDossard INT NOT NULL,
   dateInscription DATE,
   tempsNatation FLOAT DEFAULT 0,
   tempsCourse FLOAT DEFAULT 0,
   tempsCyclisme FLOAT DEFAULT 0,
   numLicence INT NOT NULL,
   CONSTRAINT PK_inscription PRIMARY KEY(numTriath, numDossard),
   CONSTRAINT FK_inscription_triathlon FOREIGN KEY(numTriath) REFERENCES Triathlon(numTriath),
   CONSTRAINT FK_inscription_triathlete FOREIGN KEY(numLicence) REFERENCES Triathlete(numLicence)
);

CREATE TABLE Controler(
   codeDop INT NOT NULL,
   numTriath INT NOT NULL,
   numDossard INT NOT NULL,
   mesureEtablie FLOAT,
   CONSTRAINT PK_controller PRIMARY KEY(codeDop, numTriath, numDossard),
   CONSTRAINT FK_controller_prodDopant FOREIGN KEY(codeDop) REFERENCES ProdDopant(codeDop),
   CONSTRAINT FK_controller_inscription FOREIGN KEY(numTriath, numDossard) REFERENCES Inscription(numTriath, numDossard)
);
go

-- --------------------------------------------------------
--
-- Trigger et Procédure stocké
--
CREATE OR ALTER TRIGGER TI_TriathleteAge on Triathlete
AFTER insert
AS 
BEGIN
	UPDATE Triathlete set codeAge = (SELECT codeAge FROM CategAge WHERE DATEDIFF(YEAR, Triathlete.dateNaissance, GETDATE()) BETWEEN ageDebut and ageFin);
END
go

CREATE OR ALTER TRIGGER TI_InscriptionDossard on Inscription
INSTEAD OF INSERT
AS 
BEGIN
	DECLARE @maxNum smallint, @numDo smallint, @numTriath smallint, @dateInscription date, @tempsNatation float, @tempsCourse float, @tempsCyclisme float, @numLicence int

	DECLARE cursTriathlon cursor
		FOR SELECT numTriath, dateInscription, tempsNatation, tempsCourse, tempsCyclisme, numLicence FROM inserted
		OPEN cursTriathlon
		fetch next FROM cursTriathlon INTO @numTriath, @dateInscription, @tempsNatation, @tempsCourse, @tempsCyclisme, @numLicence
		while(@@FETCH_STATUS = 0)
		begin
			SELECT @maxNum = ISNULL(MAX(numDossard), 0) FROM Inscription WHERE numTriath = @numTriath

			set @numDo = @maxNum + 1

			INSERT INTO Inscription (numTriath, numDossard, dateInscription, tempsNatation, tempsCourse, tempsCyclisme, numLicence) VALUES
			(@numTriath, @numDo, @dateInscription, @tempsNatation, @tempsCourse, @tempsCyclisme, @numLicence)
		fetch next FROM cursTriathlon INTO @numTriath, @dateInscription, @tempsNatation, @tempsCourse, @tempsCyclisme, @numLicence
		end
	close cursTriathlon
	deallocate cursTriathlon
END
go

CREATE OR ALTER PROCEDURE GetClassementByTriathlon
    @numTriathlon int
    AS
        SELECT T.numLicence, numTriath, numDossard, nom, prenom, tempsCourse, tempsCyclisme, tempsNatation, SUM(tempsCourse + tempsCyclisme + tempsNatation) as tempsTotal
        FROM Triathlete T
            JOIN Inscription I on I.numLicence = T.numLicence
        WHERE numTriath = @numTriathlon
        GROUP BY T.numLicence, numTriath, numDossard, nom, prenom, tempsCourse, tempsCyclisme, tempsNatation
        ORDER BY tempsTotal;
go

-- --------------------------------------------------------
--
-- Privilège utilisateur
--
GRANT SELECT TO EntityTriathlon
GRANT INSERT ON Triathlon TO EntityTriathlon
GRANT UPDATE ON Triathlon TO EntityTriathlon
GRANT DELETE ON Triathlon to EntityTriathlon
GRANT DELETE ON Inscription TO EntityTriathlon
GRANT INSERT ON Inscription TO EntityTriathlon
GRANT INSERT ON Controler TO EntityTriathlon
GRANT UPDATE ON Controler TO EntityTriathlon
GRANT DELETE ON Controler TO EntityTriathlon
GRANT UPDATE ON TypeTriathlon to EntityTriathlon
GRANT DELETE ON TypeTriathlon to EntityTriathlon
GRANT INSERT ON ProdDopant to EntityTriathlon
GRANT UPDATE ON ProdDopant to EntityTriathlon
GRANT DELETE ON ProdDopant to EntityTriathlon
GRANT INSERT ON Triathlete to EntityTriathlon
GRANT UPDATE ON Triathlete to EntityTriathlon
GRANT DELETE ON Triathlete to EntityTriathlon
--GRANT INSERT (tempsNatation, tempsCourse, tempsCyclisme) ON Inscription TO EntityTriathlon
GRANT UPDATE (tempsNatation, tempsCourse, tempsCyclisme) ON Inscription TO EntityTriathlon
--GRANT DELETE (tempsNatation, tempsCourse, tempsCyclisme) ON Inscription TO EntityTriathlon
GRANT EXECUTE ON GetClassementByTriathlon TO EntityTriathlon

-- --------------------------------------------------------
--
-- Jeu d'essaie
--
INSERT INTO TypeTriathlon(designation, nom, distanceCyclisme, distanceNatation, distanceCourse) VALUES
('XS', 'Triathlon découverte', 10000, 400, 2500),
('S', 'Triathlon sprint', 20000, 750, 5000),
('M', 'Triathlon courte distance', 40000, 1500, 10000),
('L', 'Triathlon normal', 80000, 3000, 20000),
('XL', 'Triathlon moyenne distance', 120000, 4000, 30000),
('XLL', 'Triathlon longue distance', 180000, 3800, 42000)


INSERT INTO Triathlon (nom, lieu, dateCompet, codeTypeT) VALUES
('Plouescat', 'Plouescat', '2023-07-24', 2),
('Garmin', 'Paris', '2023-06-27', 1),
('NatureMan', 'Var', '2023-11-01', 6),
('Audencia La Baule', 'La Baule', '2023-09-18', 3),
('Sardines Titus Triathlon de Cassis', 'Bouches-Du-Rhône', '2023-10-03', 3),
('Alpe d''Huez', 'Isère', '2022-07-26', 3),
('Gorges de l''Ardèche', 'Ardèche', '2023-07-10', 4),
('XL de Gérardmer', 'Vosges', '2023-09-04', 5),
('IronMan Pays d''Aix', 'Aix-en-provence', '2022-09-16', 6),
('Mont-Blanc', 'Haute-Savoie', '2023-08-01', 2),
('IronMan de Vichy', 'Vichy', '2023-08-22', 6),
('Just tri a Rieulay', 'Lille', '2023-11-12', 2),
('Triathlon du Valbonnais', 'Isère', '2023-09-25', 3),
('FrenchMan', 'Gironde', '2022-10-20', 1),
('Greenman Alsace', 'Alsace', '2023-12-25', 4)

INSERT INTO CategAge(libelle, ageDebut, ageFin) VALUES
('benjamin', 11, 12),
('minime', 13, 14),
('cadet', 15, 17),
('junior', 18, 20),
('senior', 21, 34),
('vétéran', 35, 59)

INSERT INTO Triathlete (nom, prenom, adresse, cp, ville, dateNaissance) VALUES
('Labrosse', 'Adam', '21 Rue De Médicis', 11000, 'Carcasonne', '2004/02/14'),
('Zeblouse', 'Agathe', '36 Rue de la Mare aux Carats', 34090, 'Montpellier', '1980/05/15'),
('Epan', 'Ahmed', '14 Place Maurice-Charretier', 08000, 'Charleville-mézières', '2000/01/01'),
('Zéprofit', 'Berthe', '27 Rue de la Boétie', 78300, 'Poissy', '1990/04/02'),
('Ticoli', 'Nector', '84 Rue Bonneterie', 59370, 'Mons-en-baroeul', '2010/02/18'),
('Honête', 'Camille', '68 Chemin Du Lavarin', 46000,'Cahors', '2012/10/04'),
('Toulemonde', 'Côme', '57 Rue Cazade', 93700, 'Drancy', '1999/01/10'),
('Desrata', 'Daisy', '35 Rue Victor Hugo', 60200, 'Compiègne', '2003/03/14'),
('Dereck', 'Tom', '17 Place de la Gare', 31770, 'Colomiers', '1998/12/05'),
('Itmieu', 'Elmer', '2 Rue de la Pompe', 04100, 'Manosque', '2001/02/26'),
('Tation', 'Félicie', '96 Avenue des Pres', 34000, 'Montpellier', '1987/02/24'),
('Rest', 'Eva', '82 Rue des Dunes', 94100, 'Saint-maur-des-fosses', '2002/12/13'),
('Hencor', 'Henri', '31 Rue Michel Ange', 76600, 'Le Havre', '1983/09/02 '),
('Alamaternité', 'Inès', '99 Rue Gustave Eiffel', 69140, 'Rillieux-la-pape', '2005/10/09'),
('Ptipeu', 'Justin', '73 Rue du Paille en Queue', 33500, 'Libourne', '1996/03/26' ),
('Poulet', 'Bertrand', '23 Avenue des Étoiles', 13001, 'Marseille', '1992/09/10'),
('Biscotte', 'Marie', '8 Rue du Petit Prince', 75002, 'Paris', '1998/11/30'),
('Chaussette', 'Olivier', '47 Boulevard de la Lune', 31000, 'Toulouse', '1991/06/21'),
('Carambar', 'Manon', '9 Rue du Soleil', 44000, 'Nantes', '1994/05/17'),
('Trombone', 'Sylvain', '14 Rue du Rire', 67000, 'Strasbourg', '1993/02/28'),
('Papillon', 'Céline', '25 Rue des Nuages', 33000, 'Bordeaux', '1996/08/14'),
('Crème Brûlée', 'Léo', '7 Rue de la Gastronomie', 35000, 'Rennes', '1990/12/27'),
('Chaton', 'Eva', '3 Rue des Oiseaux', 69002, 'Lyon', '1999/03/05'),
('Pizza', 'Maxime', '11 Rue de l''Italie', 54000, 'Nancy', '1997/01/23'),
('Poussin', 'Mélanie', '6 Rue des Fleurs', 59000, 'Lille', '1993/07/12'),
('Licornia', 'Alexandre', '18 Rue de l''Enchanteur', 13008, 'Marseille', '1995/10/09'),
('Ratatouille', 'Clara', '4 Rue du Fromage', 69003, 'Lyon', '1996/12/18'),
('Moustache', 'Camille', '2 Rue des Chapeaux', 44000, 'Nantes', '1998/04/07'),
('Biscuit', 'Lucas', '1 Rue du Sucre', 31000, 'Toulouse', '1992/05/06'),
('Fusée', 'Léa', '12 Rue des Étoiles Filantes', 75011, 'Paris', '1999/11/11'),
('Papaye', 'Antoine', '15 Rue des Fruits', 33000, 'Bordeaux', '1997/03/22'),
('Cactus', 'Inès', '16 Rue des Plantes', 67000, 'Strasbourg', '1994/08/20'),
('Brioche', 'Hugo', '5 Rue du Pain', 44000, 'Nantes', '1990/01/03'),
('Croissant', 'Chloé', '10 Rue du Beurre', 69007, 'Lyon', '1991/09/16'),
('Pamplemousse', 'Arthur', '21 Rue des Agrumes', 75013, 'Paris', '1993/12/07'),
('Champignon', 'Gontran', '1 Rue des Lutins', 75001, 'Paris', '1986/09/17'),
('Pastèque', 'Eustache', '4 Avenue des Tournesols', 69002, 'Lyon', '2000/03/06'),
('Cornichon', 'Edgar', '7 Rue du Cassoulet', 33000, 'Bordeaux', '2003/04/19'),
('Radis', 'Oscar', '3 Rue de la Tomate', 44000, 'Nantes', '1986/12/24'),
('Brocoli', 'Zéphyrin', '5 Boulevard du Chou-fleur', 31000, 'Toulouse', '2002/02/10'),
('Ananas', 'Barnabé', '2 Rue de la Papaye', 13001, 'Marseille', '1993/04/16'),
('Aubergine', 'Léon', '9 Avenue des Pêches', 69003, 'Lyon', '1990/09/27'),
('Citron', 'Violette', '11 Rue de l''Abricot', 75020, 'Paris', '2010/03/30'),
('Patate', 'Hector', '6 Boulevard de la Courgette', 34000, 'Montpellier', '2012/01/05'),
('Carotte', 'Aglaé', '8 Rue du Poireau', 54000, 'Nancy', '2008/05/11'),
('Kiwi', 'Zoé', '13 Avenue des Cerises', 75008, 'Paris', '2001/02/04'),
('Fraise', 'Archibald', '12 Rue de la Noix de Coco', 69006, 'Lyon', '2009/12/31'),
('Tomate', 'Wilfrid', '15 Rue de la Banane', 44000, 'Nantes', '1980/05/30'),
('Chou rouge', 'Cunégonde', '18 Avenue des Choux de Bruxelles', 31000, 'Toulouse', '2003/09/01'),
('Rhubarbe', 'Gustave', '20 Rue de la Groseille', 13002, 'Marseille', '2007/01/08'),
('Melon', 'Octave', '22 Boulevard du Potiron', 69001, 'Lyon', '1999/05/20'),
('Poivron', 'Philomène', '25 Rue des Navets', 75014, 'Paris', '1987/07/02'),
('Courgette', 'Isidore', '29 Avenue des Poivrons', 33000, 'Bordeaux', '2005/02/10'),
('Oignon', 'Hortense', '31 Rue des Asperges', 54000, 'Nancy', '1996/06/10'),
('Poire', 'Olivier', '33 Avenue des Pommes', 69004, 'Lyon', '2011/08/24'),
('Brocoli', 'Eustache', '1 Rue des Épinards', 75001, 'Paris', '2007/03/04'),
('Poireau', 'Ariane', '2 Avenue des Artichauts', 69002, 'Lyon', '1986/09/29'),
('Tomate', 'Jules', '3 Rue des Carottes', 33000, 'Bordeaux', '2000/01/20'),
('Céleri', 'Barnabé', '4 Rue des Oignons', 44000, 'Nantes', '2008/04/04'),
('Aubergine', 'Zoé', '5 Boulevard des Bananes', 31000, 'Toulouse', '1996/09/16'),
('Carotte', 'Théophile', '6 Avenue des Courges', 13001, 'Marseille', '2001/01/15'),
('Pomme', 'Philomène', '7 Rue du Raisin', 69003, 'Lyon', '1994/05/09'),
('Chou-fleur', 'Hector', '8 Rue des Poivrons', 75020, 'Paris', '1981/09/06'),
('Navet', 'Cunégonde', '9 Avenue des Citrons', 34000, 'Montpellier', '2005/02/13'),
('Poivron', 'Archibald', '10 Rue des Courgettes', 54000, 'Nancy', '1990/06/21'),
('Pamplemousse', 'Zéphyrin', '11 Rue des Abricots', 75008, 'Paris', '2010/10/01'),
('Raisin', 'Gustave', '12 Avenue des Fruits de la Passion', 69006, 'Lyon', '1986/03/08'),
('Betterave', 'Violette', '13 Rue des Radis', 44000, 'Nantes', '2003/07/07'),
('Courge', 'Edgar', '14 Boulevard des Asperges', 31000, 'Toulouse', '1991/11/23'),
('Champignon', 'Hortense', '15 Rue des Pommes de Terre', 13002, 'Marseille', '1997/04/30'),
('Patate', 'Oscar', '16 Rue des Poireaux', 69001, 'Lyon', '1980/08/22'),
('Chou rouge', 'Isidore', '17 Rue des Haricots', 75014, 'Paris', '2000/12/31'),
('Artichaut', 'Prudence', '18 Avenue des Pêches', 33000, 'Bordeaux', '2011/01/09'),
('Citron', 'Octave', '19 Rue des Pruneaux', 54000, 'Nancy', '1990/06/16'),
('Melon', 'Aglaé', '20 Boulevard des Cerises', 69004, 'Lyon', '2006/09/29'),
('Cannelle', 'Julien', '2 Rue des Épices', 69001, 'Lyon', '1975/08/02'),
('Plume', 'Louise', '14 Rue des Nuages', 75002, 'Paris', '1996/09/07'),
('Lumière', 'Antoine', '8 Rue des Étoiles', 13006, 'Marseille', '1977/07/20'),
('Océane', 'Lucas', '5 Rue des Vagues', 44000, 'Nantes', '2001/12/18'),
('Papillon', 'Manon', '1 Rue des Fleurs', 67000, 'Strasbourg', '1979/02/04'),
('Poésie', 'Alexandre', '11 Rue des Mots', 75010, 'Paris', '2004/11/01'),
('Flamme', 'Adrien', '12 Rue des Feux', 69003, 'Lyon', '2010/10/13'),
('Espoir', 'Camille', '23 Rue des Rêves', 33000, 'Bordeaux', '2012/01/09'),
('Rythme', 'Sophie', '7 Rue des Sons', 59000, 'Lille', '1978/03/12'),
('Écho', 'Thomas', '16 Rue des Échos', 35000, 'Rennes', '2009/05/29'),
('Horizon', 'Laura', '17 Rue des Vues', 31000, 'Toulouse', '1976/04/30'),
('Ciel', 'Mathieu', '18 Rue des Étoiles', 75015, 'Paris', '1989/06/25'),
('Tempête', 'Emma', '21 Rue des Orages', 69002, 'Lyon', '2007/08/26'),
('Aube', 'Nicolas', '4 Rue des Matins', 44000, 'Nantes', '1994/01/30'),
('Liberté', 'Marie', '6 Rue des Libertés', 33000, 'Bordeaux', '2011/05/31'),
('Lapin', 'Amandine', '7 Rue des Carottes', 13008, 'Marseille', '1974/07/31'),
('Voyage', 'Felix', '14 Rue des Aventuriers', 69001, 'Lyon', '1988/08/22'),
('Soleil', 'Marine', '22 Rue des Étoiles', 75010, 'Paris', '1979/08/13'),
('Poème', 'Oliver', '6 Rue des Vers', 31000, 'Toulouse', '1984/09/23'),
('Cascade', 'Lila', '18 Rue des Chutes', 44000, 'Nantes', '2002/01/08'),
('Café', 'Maxime', '33 Rue des Expressos', 33000, 'Bordeaux', '1981/06/03'),
('Velours', 'Hélène', '16 Rue des Soies', 75015, 'Paris', '1976/04/30'),
('Bonheur', 'Lucas', '8 Rue de la Joie', 67000, 'Strasbourg', '1987/03/14'),
('Neige', 'Jade', '9 Rue des Alpes', 59000, 'Lille', '2000/01/01'),
('Fantôme', 'Simone', '3 Rue des Ombres', 69002, 'Lyon', '1982/12/25'),
('Miroir', 'Victor', '22 Rue des Reflets', 35000, 'Rennes', '1975/03/09'),
('Sourire', 'Aurélie', '6 Rue des Rires', 44000, 'Nantes', '2006/05/12'),
('Mystère', 'Henri', '2 Rue des Enigmes', 75019, 'Paris', '1983/10/28'),
('Passion', 'Cécile', '11 Rue des Amoureux', 69003, 'Lyon', '1978/02/22'),
('Ciel', 'Nathalie', '20 Rue des Nuages', 33000, 'Bordeaux', '1985/11/11')

INSERT INTO Inscription(numTriath, dateInscription, tempsNatation, tempsCourse, tempsCyclisme, numLicence) VALUES
(1, '2023-02-01', 12, 23.09, 35.35, 1),
(2, '2023-01-24', 7.50, 12.10, 17.75, 5),
(3, '2022-12-14', 50, 198, 240, 6),
(15, '2022-10-20', 30, 66, 80, 8),
(5, '2023-02-05', 20, 37, 40, 9),
(5, '2022-09-29', 15, 35, 42, 10),
(4, '2022-09-15', 15, 33, 40, 2),
(10, '2023-01-15', 12.5, 25, 35.30, 11),
(2, '2022-06-20', 7, 13, 20, 7),
(3, '2023-03-02', 55, 200, 23, 3),
(12, '2023-01-05', 6.5, 11, 18, 5),
(11, '2022-08-18', 49, 195, 19, 4),
(6, '2022-07-05', 0, 0, 0, 9),
(7, '2023-02-01', 28, 60, 85,13),
(8, '2022-10-29', 40, 150, 200, 15),
(1, '2023-01-02', 12.01, 23.1, 35, 16),
(2, '2022-07-25', 7, 12.7, 18, 17),
(3, '2022-12-15', 55, 190, 238, 18),
(4, '2022-12-21', 36, 60, 81, 19),
(5, '2023-03-02', 21, 35, 42, 20),
(6, '2022-06-30', 0, 0, 0, 21),
(7, '2022-09-16', 19, 35, 41, 22),
(8, '2023-01-17', 13.5, 30, 27, 23),
(9, '2022-08-21', 0, 0, 0, 24),
(10, '2023-03-01', 56, 202, 19, 25),
(11, '2023-01-04', 6, 10.5, 18.5, 26),
(12, '2022-08-17', 50, 198, 17, 27),
(13, '2022-07-13', 17, 35, 48, 28),
(14, '2022-09-02', 0, 0, 0, 29),
(15, '2023-01-30', 41, 148, 198, 30),
(1, '2022-07-03', 12, 23.25, 34, 31),
(2, '2022-08-26', 7.5, 12.8, 18.4, 32),
(3, '2023-02-14', 52, 185, 235, 33),
(4, '2023-03-09', 32, 58, 80, 34),
(5, '2022-10-01', 20, 34, 44, 35),
(6, '2022-06-28', 0, 0, 0, 36),
(7, '2023-02-19', 20, 36, 40, 37),
(8, '2023-02-18', 13.5, 29, 29, 38),
(9, '2022-06-20', 0, 0, 0, 39),
(10, '2022-07-02', 54, 200, 19.3, 40),
(11, '2022-11-03', 6.2, 10.7, 18.7, 41),
(12, '2023-03-15', 52, 196, 18, 42),
(13, '2023-01-12', 18, 37, 50, 43),
(14, '2022-07-01', 0, 0, 0, 44),
(15, '2022-08-29', 43, 150, 190, 45),
(1, '2023-02-01', 12.4, 23.3, 34.5, 46),
(2, '2022-08-24', 7, 12, 18, 47),
(3, '2023-01-15', 51, 190, 234, 48),
(4, '2023-03-21', 33, 60, 81, 49),
(5, '2022-10-02', 22, 36, 46, 50),
(6, '2022-07-12', 0, 0, 0, 51),
(7, '2023-03-20', 21, 35, 41, 52),
(8, '2023-01-17', 14, 28.5, 29, 53),
(9, '2022-08-18', 0, 0, 0, 54),
(10, '2023-01-03', 54.6, 202, 19, 55),
(11, '2022-11-04', 6, 10, 18, 56),
(12, '2022-08-16', 52.3, 190, 17, 57),
(13, '2022-07-13', 18.6, 37.8, 49.6, 58),
(14, '2022-07-02', 0, 0, 0, 59),
(15, '2023-02-26', 44, 152, 185, 60),
(1, '2023-01-02', 12.2, 23.4, 34.9, 61),
(2, '2022-08-25', 8, 17, 19, 62),
(3, '2022-12-16', 51.5, 185, 232, 63),
(4, '2022-12-20', 35, 65, 82, 64),
(5, '2023-03-04', 25, 38, 48, 65),
(6, '2022-04-26', 0, 0, 0, 66),
(7, '2022-09-21', 21.2, 35.6, 42, 67),
(8, '2023-02-18', 16, 28.9, 24, 68),
(9, '2022-08-19', 0, 0, 0, 69),
(10, '2023-02-04', 54.8, 200, 18, 70),
(11, '2022-11-06', 7.6, 11, 25, 71),
(12, '2023-03-14', 52.6, 186, 18, 72),
(13, '2022-07-18', 17.6, 38, 49, 73),
(14, '2022-07-03', 0, 0, 0, 74),
(15, '2023-01-31', 45, 165, 190, 75),
(1, '2022-07-01', 14, 23, 35, 76),
(2, '2022-08-24', 8.5, 17.6, 19.8, 77),
(3, '2022-12-15', 52, 187, 230, 78),
(4, '2023-01-21', 36, 66, 80, 79),
(5, '2022-10-05', 27, 35, 47, 80),
(6, '2022-03-27', 0, 0, 0, 81),
(7, '2022-09-29', 21, 37, 41.6, 82),
(8, '2023-02-17', 19, 27.3, 28, 83),
(9, '2022-06-16', 0, 0, 0, 84),
(10, '2023-01-04', 54.7, 201, 19, 85),
(11, '2022-11-05', 7.7, 12, 23, 86),
(12, '2022-08-12', 52.9, 186.5, 18.4, 87),
(13, '2023-03-17', 17.9, 37, 50, 88),
(14, '2022-07-06', 0, 0, 0, 89),
(15, '2023-01-30', 48, 170, 200, 90),
(1, '2022-07-02', 13, 20, 30, 91),
(2, '2022-09-26', 8, 20, 21, 92),
(3, '2023-02-17', 55, 180, 235, 93),
(4, '2023-03-20', 37, 68, 81, 94),
(5, '2022-10-03', 27.6, 34.2, 45.3, 95),
(6, '2022-02-26', 0, 0, 0, 96),
(7, '2023-03-30', 21.7, 35.3, 42.1, 97),
(8, '2022-07-18', 21, 28, 27.3, 98),
(9, '2022-01-18', 0, 0, 0, 99),
(10, '2023-03-06', 54.9, 200.5, 20.3, 100),
(11, '2023-01-06', 7.9, 12.2, 24, 101),
(12, '2022-08-11', 8.3, 185.2, 18.8, 102),
(13, '2022-07-19', 17.4, 36, 53, 103),
(14, '2022-07-05', 0, 0, 0, 104),
(15, '2023-02-21', 48.3, 168, 198, 105)

INSERT INTO ProdDopant(libelle, tauxMax) VALUES
('Les stéroïdes anabolisants', 0.25),
('Les bêta-stimulants', 0.12),
('L''Hormone de croissance', 0.20)

INSERT INTO Controler(codeDop, numTriath, numDossard, mesureEtablie) VALUES
(1, 1, 1, 0.30),
(2, 1, 7, 0.15),
(3, 2, 2, 0.21),
(1, 2, 6, 0.45),
(2, 3, 3, 0.75),
(3, 3, 5, 0.35),
(1, 4, 4, 0.28),
(2, 4, 3, 0.20),
(3, 5, 5, 0.30),
(1, 5, 4, 0.31),
(2, 6, 6, 0.23),
(3, 6, 2, 0.25),
(1, 7, 7, 0.30),
(2, 7, 1, 0.15),
(1, 8, 2, 0.29),
(3, 8, 3, 0.21),
(2, 9, 4, 0.24),
(3, 9, 6, 0.28),
(3, 10, 7, 0.21),
(1, 10, 4, 0.26),
(2, 11, 2, 0.16),
(1, 11, 5, 0.29),
(3, 12, 3, 0.30),
(3, 12, 7, 0.28),
(2, 13, 1, 0.18),
(2, 13, 6, 0.20),
(1, 14, 2, 0.36),
(1, 14, 4, 0.30),
(2, 15, 7, 0.14),
(3, 15, 3, 0.23)

go
CREATE OR ALTER TRIGGER TI_InscriptionClose on Inscription
AFTER insert
AS 
BEGIN
	if(EXISTS(SELECT * FROM inserted I JOIN Triathlon T on T.numTriath = I.numTriath WHERE dateCompet < GETDATE()))
		throw 50001, 'Le triathlon est déjà passé', 0
	else if(EXISTS(SELECT * FROM inserted I JOIN Triathlon T on T.numTriath = I.numTriath WHERE DATEDIFF(DAY, dateCompet, GETDATE()) <= 15 AND DATEDIFF(DAY, GETDATE(), dateCompet) <= 15))
		throw 50002, 'Les inscriptions sont closes pour ce triathlon', 0
END
go
