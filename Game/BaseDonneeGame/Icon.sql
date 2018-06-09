CREATE TABLE [dbo].[Icon]
(
	[Icon_Id] INT NOT NULL IDENTITY(1,1),
	[Nom] NVARCHAR(12) NOT NULL,
	[Access] NVARCHAR(40) NOT NULL,
	[Level] INT NOT NULL

	CONSTRAINT PK_IconID PRIMARY KEY (Icon_Id)
);

INSERT INTO Icon(Nom,Access,Level) VALUES ('Console','pack://application:,,,/Img/Console.png',1);
INSERT INTO Icon(Nom,Access,Level) VALUES ('Logs','pack://application:,,,/Img/Logs.png',1);
INSERT INTO Icon(Nom,Access,Level) VALUES ('Banque','pack://application:,,,/Img/Bank.png',1);
INSERT INTO Icon(Nom,Access,Level) VALUES ('Navigateur','pack://application:,,,/Img/Browser-icon.png',1);
INSERT INTO Icon(Nom,Access,Level) VALUES ('Antivirus','pack://application:,,,/Img/Antivirus.png',2);
INSERT INTO Icon(Nom,Access,Level) VALUES ('Dossier','pack://application:,,,/Img/Dossier.png',2);


