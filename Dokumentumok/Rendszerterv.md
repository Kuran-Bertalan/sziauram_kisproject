# Rendszerterv

## A rendszer célja

- A rendszer célja a raktárosok munkájának  megkönnyítése
- A program egy web alapú felületen fut, ami egy adatbázishoz van kapcsolva
- Navigációs menün keresztül lehet egyes pontokba eljutni a rendszerben
- A program célja, hogy könnyen lehessen tájékozódni a felületen


## Projektterv
**Projekt szerepkörök, felelősségek**

-   szerepkörök
    -   product owner: Tajti Tibor
    -   scrum master: Bertalan Kurán,Zsadányi Rózsa
    - junior fejlesztők: Juhász Domonkos,Ardó Balázs,Farkas Bálint,Bodó Zoltán
-   felelősségek:
    -   scrum master: A Scrum mester felügyeli és megkönnyíti a folyamat fenntartását, segíti a csapatot, ha problémába ütközik, illetve felügyeli, hogy mindenki betartja-e a Scrum alapvető szabályait.
    -   junior fejlesztő: A projekt elkészítése.


**Projekt munkások és felelősségeik**

-   Webfelület:
-   C#

## Rendszerterv 

## Üzleti folyamatok modellje

- Üzleti szereplők:
  - Raktáros
  
- Üzleti folyamatok:
  - Feladatok felvitele módosítása
  - Adatbázis hozzáférés
  - C# programozás hozzáférés

## Követelmények

 - Funkcionális
	- Webes környezetben való működés
	- A foglalások és az ehhez tartozó adatok tárolása
        - C# környezetben való működés
 - Nem funkcionális
	- Gyors működés, foglalások kilistázása
	- Egyszerű, egyértelmű kezelés
 - Törvényi előírások, szabványok
	- GDPR követelményeinek való megfelelés

## Funkcionális terv

- Rendszerszereplők
  - Raktáros
  
- Rendszerhasználati esetek és lefutásaik:
  - Raktáros
    * Adatok megtekintése
    * Adatok hozzáadása, törlése, módosítása
    * A rendszerhez való teljes hozzáférés

- Menü hierarchiák
  - Kezdőlap
    * Raktár készlet
    * Számlák

## Fizikai környezet
Kliens:
   - Eszköz: Asztali számítógép

  -  Operációs rendszer: Windows 7 vagy nagyobb

    - Szükséges applikációk: Chrome böngésző

    - Konfiguráció: Nem specifikus.

Szerver:

- Eszköz: Kliens

- Specifikáció: Klienssel ekvivalens

- Operációs rendszer: Windows 7 vagy nagyobb

- Komponensek: 

## Absztrakt domain modell
A program működése során a raktáros egy féle szerepkörben figyelhető meg. A raktáros képes polcokat foglalni, számlát kiállítani, illetve termékeket regisztrálni az adatbázisba.

## Architekturális terv
 - Backend
	A rendszerhez szükség van egy adatbázis szerverre, ebben az esetben MySql-t használunk.
	A kliensekkel JSON objektumokkal kommunikál.
 - Frontend
	Az alkalmazás C#-ban,windows form keret rendszerrel készül.


## Adatbázis terv

A raktár szolgáltatáshoz készletkezelő készül.


## Implementációs terv
Ezeket a technológiákat amennyire csak lehet külön fájlokba írva készítjük, és úgy fogjuk egymáshoz csatolni a jobb átláthatóság, könnyebb változtathatóság, és könnyebb bővítés érdekében.

## Tesztterv

A user teszteket a fejlesztés végén végezzük el a funkciók kipróbálásával és dokumentálásával. Konténerizált szerverrel.

## Telepítési terv

 - A rendszer beüzemelésekor ajánlott egy hozzá szakértő emberre bízni a beüzemelést mivel a szerver elindításához szükség van némi hozzáértéshez.
	Így elkerülve esetleges nem kívánatos hibák létre jöttét.

