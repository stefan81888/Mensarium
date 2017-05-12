
-- FAKULTETI
INSERT INTO Fakulteti values (NULL, "Elektronski fakultet");
INSERT INTO Fakulteti values (NULL, "Pravni fakultet");
INSERT INTO Fakulteti values (NULL, "Medicinski fakultet");
INSERT INTO Fakulteti values (NULL, "Filozofski fakultet");
INSERT INTO Fakulteti values (NULL, "Ekonomski fakultet");

-- MENZE
INSERT INTO Menze VALUES (NULL, "Kod elektornskog", "Elektornski fakultet", "07-20", 0);
INSERT INTO Menze VALUES (NULL, "Kod pravnog", "Pravni fakultet", "07-13", 0);
INSERT INTO Menze VALUES (NULL, "Kod medicinskog", "Medicinski fakultet", "08-20", 1);

-- KORISNICI
INSERT INTO Korisnici VALUES (NULL, "dimipage", 	"dimipage@gmail.com", 			"starwars5", "Dušuan", "Dimitrijević", 	"1995-02-18", "2017-05-12", "064 111 11 11", 1, 15069, "2018-05-12", 5, 1, "dimi.jpg");
INSERT INTO Korisnici VALUES (NULL, "dacha204", 	"dacha204@gmail.com", 			"starwars5", "Dalibor", "Aleksic", 		"1995-04-20", "2017-6-12", "064 222 11 11",  1, 15024, "2018-05-12", 5, 1, "dacha.jpg");
INSERT INTO Korisnici VALUES (NULL, "stefan81888", 	"stefan81888@gmail.com", 		"starwars5", "Stefan", "Stankovic", 	"1996-08-18", "2017-05-12", "064 333 11 11", 2, 15069, "2018-05-12", 5, 1, "stef.jpg");
INSERT INTO Korisnici VALUES (NULL, "marija95", 	"marija.stojkovic@gmail.com", 	"starwars5", "Marija", "Stojkovic", 	"1995-10-18", "2017-05-12", "064 44 11 11",  1, 15569, "2018-05-12", 5, 1, "mar.jpg");
INSERT INTO Korisnici VALUES (NULL, "savchaa1337", 	"savchaa@gmail.com", 			"starwars5", "Nikola", "Savic", 		"1995-09-18", "2017-05-12", "064 55 11 11",  3, 15869, "2018-05-12", 5, 1, "savaa.jpg");
INSERT INTO Korisnici VALUES (NULL, "hochopepa", 	"hochopepa@gmail.com", 			"starwars5", "Stevica", "Stojkovic", 	"1995-04-18", "2017-05-12", "064 66 11 11",  3, 15099, "2018-05-12", 5, 1, "root.jpg");

INSERT INTO Korisnici VALUES (NULL, "violeta", 		"violeta@gmail.com", 			"starwars5", "Violeta", "Pesic", 	"1987-04-18", "2010-01-01", "064 66 11 11",  NULL, NULL, NULL, 4, 1, "viol.jpg");
INSERT INTO Korisnici VALUES (NULL, "dzoni", 		"dzoni@gmail.com", 				"starwars5", "Dzoni", "Dep", 		"1978-04-18", "2008-05-03", "063 66 11 11",  NULL, NULL, NULL, 2, 1, "dzoni.jpg");
INSERT INTO Korisnici VALUES (NULL, "simka", 		"simka@gmail.com", 				"starwars5", "Simka", "Jovanovic", 	"1970-04-18", "2007-09-29", "064 878 1 11",  NULL, NULL, NULL, 3, 1, "simka.jpg");
INSERT INTO Korisnici VALUES (NULL, "admir", 		"admir@gmail.com", 				"starwars5", "Admir", "Beslic", 	"1990-04-18", "2013-07-18", "064 83 11 11",  NULL, NULL, NULL, 1, 1, "admir.jpg");

-- PRACENJA
INSERT INTO Pracenja VALUES (1,3);
INSERT INTO Pracenja VALUES (1,4);
INSERT INTO Pracenja VALUES (1,5);
INSERT INTO Pracenja VALUES (1,6);
INSERT INTO Pracenja VALUES (3,1);
INSERT INTO Pracenja VALUES (3,4);
INSERT INTO Pracenja VALUES (3,5);
INSERT INTO Pracenja VALUES (3,6);
INSERT INTO Pracenja VALUES (3,7);
INSERT INTO Pracenja VALUES (4,3);
INSERT INTO Pracenja VALUES (4,5);
INSERT INTO Pracenja VALUES (4,7);
INSERT INTO Pracenja VALUES (5,6);
INSERT INTO Pracenja VALUES (5,4);
INSERT INTO Pracenja VALUES (5,7);
INSERT INTO Pracenja VALUES (6,1);
INSERT INTO Pracenja VALUES (6,3);
INSERT INTO Pracenja VALUES (6,5);
INSERT INTO Pracenja VALUES (7,3);
INSERT INTO Pracenja VALUES (7,5);
INSERT INTO Pracenja VALUES (7,6);

-- OBJAVE
INSERT INTO Objave VALUES (1, 1, "2018-05-12 18:15:12", "tekst objave 1");
INSERT INTO Objave VALUES (3, 1, "2018-05-12 12:25:13", "tekst objave 3");
INSERT INTO Objave VALUES (4, 3, "2018-05-12 07:37:43", "tekst objave 4");
INSERT INTO Objave VALUES (5, 2, "2018-05-12 17:49:41", "tekst objave 5");
INSERT INTO Objave VALUES (6, 2, "2018-05-12 19:22:21", "tekst objave 6");
INSERT INTO Objave VALUES (7, 1, "2018-05-12 14:43:03", "tekst objave 7");

-- LOGIN SESIJE
INSERT INTO LoginSesije VALUES (1, 2, "9605cc70-c838-4ba3-a6ac-bd3f461ace9d", "2018-05-12 22:03:08", "2018-06-12 22:03:08");
INSERT INTO LoginSesije VALUES (2, 1, "196f8c1c-5c07-4fa8-b51a-be4fad139703", "2018-05-11 12:19:53", "2018-06-12 12:20:53");
INSERT INTO LoginSesije VALUES (3, 2, "6b2330af-4cc2-4c75-9df7-8bd3faa6b098", "2018-05-07 16:41:23", "2018-06-12 16:41:23");


-- POZIVANJA
INSERT INTO Pozivanja VALUES (1, 1, "2018-05-12 10:31:58", "2018-05-12 11:31:58");
INSERT INTO Pozivanja VALUES (2, 4, "2018-05-12 18:21:18", "2018-05-12 19:21:18");
INSERT INTO Pozivanja VALUES (3, 5, "2018-05-12 17:02:34", NULL);

-- POZIVANJA POZVANI
INSERT INTO PozivanjaPozvani VALUES (1, 3, true);
INSERT INTO PozivanjaPozvani VALUES (1, 6, true);
INSERT INTO PozivanjaPozvani VALUES (2, 5, null);
INSERT INTO PozivanjaPozvani VALUES (2, 7, false);
INSERT INTO PozivanjaPozvani VALUES (3, 7, null);

--obroci
INSERT INTO Obroci VALUES (1, 1, 1, true, "2018-05-10 10:01:13", "2018-05-10 10:22:12", 1, 1);
INSERT INTO Obroci VALUES (2, 1, 1, false, "2018-05-10 10:01:13", NULL, 1, NULL);
INSERT INTO Obroci VALUES (3, 2, 1, false, "2018-05-10 10:01:13", null, 1, null);
INSERT INTO Obroci VALUES (4, 3, 5, true, "2018-05-10 10:01:13", "2018-05-10 18:22:12", 1, 1);