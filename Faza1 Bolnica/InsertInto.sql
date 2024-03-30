--UNOS PODATAKA

INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Marko','Petrovic','1203990192721');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Petar','Mikrovic','0909987289309');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Filip','Filipovic','2112976273990');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Milica','Stamenkovic','2203982225668');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Dragana','Kostic','1012977253661');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Milorad','Uskokovic','2411988823417');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Zoran','Docic','0109983283094');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Lara','Rakic','2212991835617');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Luka','Aleksic','1502979481094');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Mija','Dinic','3111984481920');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Sara','Krstic','1107968374612');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Mirko','Mirkovic','2801962777368');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Milos','Lekic','0612993329109');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Ana','Vasic','0411981109288');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Djordje','Stojkovic','1510992849101');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Mina','Dikic','0912985277397');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Dusan','Dusanovic','1511980738110');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Andjela','Lukic','1902995627382');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Boban','Jankovic','1701986283911');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Nikola','Stanisavljevic','2110987266381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Danilo','Ivic','2210987266381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Matija','Matovic','1510988266381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Uros','Urosevic','1510982366381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Igor','Igorovic','1234567891234');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Matija','Mitic','1310988266381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Uros','Krstic','1411988266381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Zoran','Zoranovic','1911988266381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Ivan','Ivanovic','1103978266381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Goran','Goranovic','1510924682381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Milos','Milosevic','1510954321381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Marko','Markovic','1510912345381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Luka','Lukic','1510977126381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Andrija','Mirkovic','1510988566381');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Andjela','Tonic','3107988566481');
INSERT INTO OSOBA (ID,Ime,Prezime,MaticniBroj)VALUES
(NULL,'Mila','Milojevic','1510975475381');

INSERT INTO NEMEDICINSKO_OSOBLJE (ID,TipNemedOsoblja,Struka,IDOsobe)VALUES
(NULL,'Higijenicar','NULL',1);
INSERT INTO NEMEDICINSKO_OSOBLJE (ID,TipNemedOsoblja,Struka,IDOsobe)VALUES
(NULL,'Higijenicar','NULL',2);
INSERT INTO NEMEDICINSKO_OSOBLJE (ID,TipNemedOsoblja,Struka,IDOsobe)VALUES
(NULL,'Tehnicko odrzavanje','Inzenjer elektronike',3);
INSERT INTO NEMEDICINSKO_OSOBLJE (ID,TipNemedOsoblja,Struka,IDOsobe)VALUES
(NULL,'Tehnicko odrzavanje','Inzenjer masinstva',4);

INSERT INTO STOMATOLOSKA_STOLICA(IDStolice, Proizvodjac, DatumProizvodnje, IDTehnOdrz)VALUES
(NULL,'Castellini','30.4.2018',5);
INSERT INTO STOMATOLOSKA_STOLICA(IDStolice, Proizvodjac, DatumProizvodnje, IDTehnOdrz)VALUES
(NULL,'Siger','11.10.2021',6);
INSERT INTO STOMATOLOSKA_STOLICA(IDStolice, Proizvodjac, DatumProizvodnje, IDTehnOdrz)VALUES
(NULL,'Amiral','2.3.2020',7);
INSERT INTO STOMATOLOSKA_STOLICA(IDStolice, Proizvodjac, DatumProizvodnje, IDTehnOdrz)VALUES
(NULL,'Nardi','27.9.2016',8);

INSERT INTO ODELJENJE(ID,Sifra,Tip,DatumIzgradnje,IDSpecijaliste)VALUES(NULL,101,'Kardiologija','18.11.2001',9);
INSERT INTO ODELJENJE(ID,Sifra,Tip,DatumIzgradnje,IDSpecijaliste)VALUES(NULL,102,'Radiologija','21.7.2002',10);
INSERT INTO ODELJENJE(ID,Sifra,Tip,DatumIzgradnje,IDSpecijaliste)VALUES(NULL,103,'Infektologija','8.3.2003',11);
INSERT INTO ODELJENJE(ID,Sifra,Tip,DatumIzgradnje,IDSpecijaliste)VALUES(NULL,104,'Neurologija','14.2.2000',12);
INSERT INTO ODELJENJE(ID,Sifra,Tip,DatumIzgradnje,IDSpecijaliste)VALUES(NULL,105,'Psihijatrija','18.3.2004',13);
INSERT INTO ODELJENJE(ID,Sifra,Tip,DatumIzgradnje,IDSpecijaliste)VALUES(NULL,106,'Dermatologija','7.5.2003',14);
INSERT INTO ODELJENJE(ID,Sifra,Tip,DatumIzgradnje,IDSpecijaliste)VALUES(NULL,107,'Oftalmologija','18.6.2002',15);

INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,10,'Stomatolog',NULL,NULL,1,2,5);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,17,'Stomatolog',NULL,NULL,2,2,6);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,8,'Stomatolog',NULL,NULL,3,1,7);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,20,'Stomatolog',NULL,NULL,4,1,8);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,6,'Specijalista',NULL,'Infektolog',NULL,NULL,9);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,18,'Specijalista',NULL,'Neurolog',NULL,NULL,10);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,25,'Specijalista',NULL,'Imunolog',NULL,NULL,11);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,13,'Specijalista',NULL,'Dermatolog',NULL,NULL,12);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,17,'Specijalista',NULL,'Radiolog',NULL,NULL,13);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,10,'Specijalista',NULL,'Psihijatar',NULL,NULL,14);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,12,'Specijalista',NULL,'Oftamolog',NULL,NULL,15);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,15,'Opsta praksa',1112,NULL,NULL,NULL,16);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,11,'Opsta praksa',2134,NULL,NULL,NULL,17);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,20,'Opsta praksa',1092,NULL,NULL,NULL,18);
INSERT INTO MEDICINSKO_OSOBLJE (ID,GodineRadnogStaza,TipMedOsoblja,BrojOrdinacije,Specijalnost,IDStolice,Smena,IDOsobe)VALUES
(NULL,19,'Opsta praksa',2211,NULL,NULL,NULL,19);

INSERT INTO ODRZAVA_HIGIJENU (ID,IDHigijenicara,IDOdeljenja)VALUES
(NULL,1,2);
INSERT INTO ODRZAVA_HIGIJENU (ID,IDHigijenicara,IDOdeljenja)VALUES
(NULL,1,7);
INSERT INTO ODRZAVA_HIGIJENU (ID,IDHigijenicara,IDOdeljenja)VALUES
(NULL,2,5);
INSERT INTO ODRZAVA_HIGIJENU (ID,IDHigijenicara,IDOdeljenja)VALUES
(NULL,1,3);
INSERT INTO ODRZAVA_HIGIJENU (ID,IDHigijenicara,IDOdeljenja)VALUES
(NULL,2,1);
INSERT INTO ODRZAVA_HIGIJENU (ID,IDHigijenicara,IDOdeljenja)VALUES
(NULL,2,4);
INSERT INTO ODRZAVA_HIGIJENU (ID,IDHigijenicara,IDOdeljenja)VALUES
(NULL,1,6);

INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Stacionar',NULL,'20.2.2018.','22.2.2018.',NULL,NULL,NULL,1,12,20);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Stacionar',NULL,'11.9.2019.','19.9.2019.',NULL,NULL,NULL,2,13,21);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Stacionar',NULL,'2.4.2021.','20.4.2021.',NULL,NULL,NULL,3,14,22);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Stacionar',NULL,'27.3.2022.','31.3.2022.',NULL,NULL,NULL,4,15,23);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Stacionar',NULL,'5.1.2023.','1.2.2023.',NULL,NULL,NULL,5,12,24);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Ambulanta','Kralj Vukasin 5',NULL,NULL,NULL,NULL,NULL,NULL,13,25);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Ambulanta','Mokranjceva 12',NULL,NULL,1,'Vadjenje zuba','21.6.2022.',NULL,14,26);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Ambulanta','Cara Dusana 4',NULL,NULL,3,'Beljenje zuba','1.9.2021.',NULL,15,27);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Ambulanta','Mokranjceva 12',NULL,NULL,2,'Beljenje zuba','2.4.2022',NULL,12,28);
INSERT INTO PACIJENT (ID,TipPacijenta,Adresa,DatumPrijema,DatumOtpusta,IDStomatologa,VrstaIntervencije,DatumIntervencije,IDOdeljenja,IDLekaraOP,IDOsobe)VALUES
(NULL,'Ambulanta','Mokranjceva 14',NULL,NULL,4,'Operacija desni','25.3.2018.',NULL,13,29);