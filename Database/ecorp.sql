
--Drop ALL EXISTING TABLES
 IF OBJECT_ID('dbo.Tijdlijn', 'U') IS NOT NULL
  DROP TABLE dbo.Tijdlijn;

 IF OBJECT_ID('dbo.Bericht', 'U') IS NOT NULL
DROP TABLE dbo.Bericht;
	IF OBJECT_ID('dbo.ProductLeverancier', 'U') IS NOT NULL
	DROP TABLE dbo.ProductLeverancier;
IF OBJECT_ID('dbo.Leverancier', 'U') IS NOT NULL
	DROP TABLE dbo.Leverancier;
IF OBJECT_ID('dbo.ProductOfferte', 'U') IS NOT NULL
	DROP TABLE dbo.ProductOfferte;
 IF OBJECT_ID('dbo.Account', 'U') IS NOT NULL
  DROP TABLE dbo.Account;
 IF OBJECT_ID('dbo.Offerte', 'U') IS NOT NULL
  DROP TABLE dbo.Offerte;
IF OBJECT_ID('dbo.Klant', 'U') IS NOT NULL
  DROP TABLE dbo.Klant;
IF OBJECT_ID('dbo.Klant', 'U') IS NOT NULL
  DROP TABLE dbo.Klant;
IF OBJECT_ID('dbo.Product', 'U') IS NOT NULL
  DROP TABLE dbo.Product;
IF OBJECT_ID('dbo.Medewerker', 'U') IS NOT NULL
  DROP TABLE dbo.Medewerker;
IF OBJECT_ID('dbo.Addres', 'U') IS NOT NULL
  DROP TABLE dbo.Addres;
IF OBJECT_ID('dbo.Rol', 'U') IS NOT NULL
  DROP TABLE dbo.Rol;
IF OBJECT_ID('dbo.Afdeling', 'U') IS NOT NULL
  DROP TABLE dbo.Afdeling;
IF OBJECT_ID('dbo.Dak', 'U') IS NOT NULL
  DROP TABLE dbo.Dak;
  
--Create table
create table Rol(
	ID int identity(1,1) primary key not null,
	Naam varchar
);

create table Addres(
	ID int identity(1,1) primary key not null,
	Straatnaam varchar,
	Woonplaats varchar,
	Postcode varchar,
	Huisnummer int
);

create table Afdeling(
	ID int identity(1,1) primary key not null,
	Naam varchar
	);
create table Medewerker(
	ID int identity(1,1) primary key not null,
	RolId int, 
	Telefoonnummer int,
	Naam varchar,
	Achternaam varchar,
	Email varchar unique,
	Salaris money,
	AdresId int,
	Afdeling int,

	Constraint MedewerkerRol FOREIGN KEY(RolId) REFERENCES Rol(Id),
	Constraint MedewerkerAdres FOREIGN KEY(AdresId) REFERENCES Addres(Id)
);

--Create tables
Create table Account(
	ID int identity(1,1) primary key not null,
	MedewerkerID int,
	Wachtwoord varchar,
	Gebruikersnaam Varchar unique,

	constraint MedewerkerAcoount FOREIGN KEY(MedewerkerID) REFERENCES Medewerker(ID)
)
--Gebruiker kan ook met zijn email inloggen
--Todo: email check constraint for "@"

Create Table Bericht(
	ID int identity(1,1) primary key not null,
	AccountID int,
	Inhoud varchar,
	Geplaatst date,

	constraint BerichtAccount FOREIGN KEY(AccountID) References Account(ID)
);

Create table Tijdlijn(
	ID int identity(1,1) primary key,
	BerichtID int,

	Constraint TijdlijnBericht FOREIGN KEY(BerichtID) REFERENCES Bericht(ID)
);

Create table Dak(
	ID int identity(1,1) primary key,
	Lengte int,
	Breedte int,
	Hellingshoke int
);

Create table Klant(
	ID int identity(1,1) primary key,
	Naam varchar,
	Achternaam varchar,
	email varchar unique,
	AddresId int,
	Telefoonnummer int,
	DakId int,

	CONSTRAINT KlantDak FOREIGN KEY(DakId) References Dak(ID),
	CONSTRAINT KlantAdres FOREIGN KEY(AddresId) REFERENCES Addres(ID)
)

Create table Offerte(
	ID int identity(1,1) primary key,
	KlantId int,
	MedewerkerID int,

	CONSTRAINT OfferteKlant FOREIGN KEY(KlantId) REFERENCES Klant(ID),
	CONSTRAINT OfferteMedewerker FOREIGN KEY(MedewerkerId) REFERENCES Medewerker(ID)
);

Create table Product(
	ID int identity(1,1) primary key,
	Naam varchar,
	Serienummer int unique,
	Prijs money
);

Create Table ProductOfferte(
	ID int identity(1,1) primary key,
	ProductID int,
	OfferteID int,

	Constraint Product_Offerte FOREIGN KEY(ProductId) REFERENCES Product(id),
	CONSTRAINT Offerte_Product FOREIGN KEY(OfferteId) REFERENCES Offerte(id)
);

Create table Leverancier(
	ID int identity(1,1) primary key,
	Naam varchar,
	ContactPersoon varchar,
	Prijs int
)

Create table ProductLeverancier(
	ID int identity(1,1) primary key,
	ProductId int,
	LeverancierId int,

	CONSTRAINT Product_Leverancier FOREIGN KEY(LeverancierId) REFERENCES Leverancier(id)
	);
