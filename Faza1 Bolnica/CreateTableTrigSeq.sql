
CREATE TABLE OSOBA
(
ID NUMBER PRIMARY KEY, 
Ime VARCHAR2(20) NOT NULL,
Prezime VARCHAR2(30) NOT NULL,
MaticniBroj VARCHAR2(13) UNIQUE NOT NULL CONSTRAINT MaticniBroj_CK CHECK (LENGTH(MaticniBroj) = 13)
);
CREATE TABLE STOMATOLOSKA_STOLICA
(
IDStolice NUMBER PRIMARY KEY,
Proizvodjac VARCHAR2(50),
DatumProizvodnje DATE,
IDTehnOdrz NUMBER REFERENCES OSOBA(ID) NOT NULL
);
CREATE TABLE ODELJENJE
(
ID NUMBER PRIMARY KEY,
Sifra NUMBER,
Tip VARCHAR2(50) NOT NULL,
DatumIzgradnje DATE,
IDSpecijaliste NUMBER REFERENCES OSOBA(ID) NOT NULL 
);
CREATE TABLE MEDICINSKO_OSOBLJE
(
ID NUMBER PRIMARY KEY,
GodineRadnogStaza NUMBER(2) NOT NULL,
TipMedOsoblja VARCHAR2(50) CONSTRAINT TipMedOsoblja_CK CHECK (TipMedOsoblja IN ('Stomatolog', 'Opsta praksa','Specijalista')) NOT NULL,
BrojOrdinacije NUMBER(4),
Specijalnost VARCHAR2(40), 
Smena NUMBER(1) CONSTRAINT Smena_CK CHECK (Smena=1 OR Smena=2),
IDStolice NUMBER REFERENCES STOMATOLOSKA_STOLICA(IDStolice),
IDOsobe NUMBER REFERENCES OSOBA(ID), 
CHECK ((TipMedOsoblja='Opsta praksa' AND BrojOrdinacije IS NOT NULL)
OR (TipMedOsoblja='Specijalista' AND Specijalnost IS NOT NULL)
OR (TipMedOsoblja='Stomatolog'))
);
CREATE TABLE NEMEDICINSKO_OSOBLJE
(
ID NUMBER PRIMARY KEY,
TipNemedOsoblja VARCHAR2(50) CONSTRAINT TipNemedOsoblja_CK CHECK (TipNemedOsoblja IN ('Higijenicar', 'Tehnicko odrzavanje')) NOT NULL,
Struka VARCHAR2(50),
IDOsobe NUMBER REFERENCES OSOBA(ID),
CHECK ((TipNemedOsoblja='Tehnicko odrzavanje' AND Struka IS NOT NULL)
OR (TipNemedOsoblja='Higijenicar' ))
);
CREATE TABLE PACIJENT
(
ID NUMBER PRIMARY KEY,
TipPacijenta VARCHAR2(50) CONSTRAINT TipPacijenta_CK CHECK (TipPacijenta IN ('Ambulanta', 'Stacionar')) NOT NULL,
Adresa VARCHAR2(30),
DatumPrijema DATE,
DatumOtpusta DATE,
IDStomatologa NUMBER REFERENCES MEDICINSKO_OSOBLJE(ID),
VrstaIntervencije VARCHAR2(30),
DatumIntervencije DATE,
IDOdeljenja NUMBER REFERENCES ODELJENJE(ID),
IDLekaraOP NUMBER REFERENCES MEDICINSKO_OSOBLJE(ID),
IDOsobe NUMBER REFERENCES OSOBA(ID),
CHECK ((TipPacijenta='Ambulanta' AND Adresa IS NOT NULL)
OR (TipPacijenta='Stacionar'AND DatumPrijema IS NOT NULL AND DatumOtpusta IS NOT NULL))
);

CREATE TABLE ODRZAVA_HIGIJENU
(
ID NUMBER PRIMARY KEY,
IDHigijenicara NUMBER REFERENCES OSOBA(ID) NOT NULL, 
IDOdeljenja NUMBER REFERENCES ODELJENJE(ID) NOT NULL, 
UNIQUE(IDHigijenicara, IDOdeljenja)
);

--SEKVENCE I TRIGERI
CREATE SEQUENCE "OSOBA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE ORDER NOCYCLE;
CREATE SEQUENCE "PACIJENT_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE ORDER NOCYCLE;
CREATE SEQUENCE "ODELJENJE_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE ORDER NOCYCLE;
CREATE SEQUENCE "STOMATOLOSKA_STOLICA_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE ORDER NOCYCLE;
CREATE SEQUENCE "MEDICINSKO_OSOBLJE_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE ORDER NOCYCLE;
CREATE SEQUENCE "ODRZAVA_HIGIJENU_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE ORDER NOCYCLE;
CREATE SEQUENCE "NEMEDICINSKO_OSOBLJE_ID_SEQ" MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 START WITH 1 NOCACHE ORDER NOCYCLE;

CREATE OR REPLACE TRIGGER "OSOBA_PK"
BEFORE INSERT
ON OSOBA
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    SELECT OSOBA_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
CREATE OR REPLACE TRIGGER "PACIJENT_PK"
BEFORE INSERT
ON PACIJENT
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    SELECT PACIJENT_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
 /
CREATE OR REPLACE TRIGGER "ODELJENJE_PK"
BEFORE INSERT
ON ODELJENJE
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    SELECT ODELJENJE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
 /
CREATE OR REPLACE TRIGGER "STOMATOLOSKA_STOLICA_PK"
BEFORE INSERT
ON STOMATOLOSKA_STOLICA
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    SELECT STOMATOLOSKA_STOLICA_ID_SEQ.NEXTVAL INTO :NEW.IDStolice FROM DUAL;
END;
/
CREATE OR REPLACE TRIGGER "MEDICINSKO_OSOBLJE_PK"
BEFORE INSERT
ON MEDICINSKO_OSOBLJE
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    SELECT MEDICINSKO_OSOBLJE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
CREATE OR REPLACE TRIGGER "NEMEDICINSKO_OSOBLJE_PK"
BEFORE INSERT
ON NEMEDICINSKO_OSOBLJE
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    SELECT NEMEDICINSKO_OSOBLJE_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/
CREATE OR REPLACE TRIGGER "ODRZAVA_HIGIJENU_PK"
BEFORE INSERT
ON ODRZAVA_HIGIJENU
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    SELECT ODRZAVA_HIGIJENU_ID_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
END;
/