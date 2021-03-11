use master
go
create database hopital
go 
use hopital
go
create table Specialite(
idSpecialite varchar(15) primary key,
libelle varchar(20));

create table Medecin(
idMedecin varchar(10) primary key,
CIN varchar(10),
Nom varchar(20),
Prenom varchar(20),
Telephone varchar(25),
idSpecialite varchar(15),
CONSTRAINT FK_idSpecialite_M  
FOREIGN KEY (idSpecialite)
REFERENCES Specialite(idSpecialite)
);

Create table Operation(
idOperation varchar(15) primary key,
code nvarchar(10),
libelle_op varchar(20)
);

create table LigneMedecinOperation(
dateOperation date primary key,
duree int,
prix money,
idOperation varchar(15),
idMedecin varchar(10),
CONSTRAINT FK_idOperation_Lin  
FOREIGN KEY (idOperation)
REFERENCES Operation(idOperation),
CONSTRAINT FK_idMedecin_Lin  
FOREIGN KEY (idMedecin)
REFERENCES Medecin(idMedecin)
);

insert into Specialite values('specialité1','libelle1');
insert into Specialite values('specialité2','libelle2');
insert into Specialite values('specialité3','libelle3');
insert into Specialite values('specialité4','libelle4');
Select *from Medecin