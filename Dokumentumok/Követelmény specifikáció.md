# Követelmény specifikáció:
## Áttekintés:
A fejlesztés célja egy olyan program létrehozása, amely a raktározórendszert könnyed kezelés mellett le egyszerűsíti az ott dolgozó illetékesnek, raktárkezelőnek. A papír alapú nyilvántartást lecseréljük számítógép által elérhető felületre, ahol átlátható körülmények között érhető el az összes termék név, kategória, cikkszám, valamint mennyiség szerint, és ezáltal szortírozhatók a különböző termékcsoportokba.
## Jelenlegi helyzet:
Az elavult kézi dokumentációkat korszerűsíteni kellene, ezáltal tudjuk csökkenteni a hibafaktort. Felgyorsítja a termékek nyomon követesének folyamatát valamit tárolási megoldását.
## Vágyálom rendszer:
A célunk, hogy átláthatóak és nyomon követhetőek legyenek a termékek a raktár területén belül. Le egyszerűsítsük a könyvelést, és eltöröljük a felesleges papírmunkát. Amennyiben elfogy az adott termék, a program küldjünk nekünk erről értesítést, hogy mielőbb pótolni tudjuk a hiányt.
## Funkcionális követelmények:
Lekérdezhető az adott termék mennyisége és helye a raktáron belül. Termékhiány esetén értesítés küldése az illetékes személynek. Új termékek felvétele a programba.
## Rendszerre vonatkozó törvény szabályok, ajánlások:
Az élelmiszereket és a vegyi árukat külön helyiségben kell raktározni. Épületen kívül, szabad területen élelmiszert még átmenetileg sem szabad tárolni! Az élelmiszer árukat a gyártótól a felhasználóig jellegüknek összetételüknek megfelelően szakosítottan kell elhelyezni, tárolni! A hűtött élelmiszert 0-(+5) °C fok közötti, illetve a gyártó által előírt hőfokon, a gyorsfagyaszott készítményeket-18 °C alatti, illetve a gyártó által meghatározott hőmérsékleten kell tárolni.
## Jelenlegi üzleti folyamatok modellje:
 - A XXI. században sajnos még mindig sokan vannak, akik az ilyen jellegű munkákat papír alapon végzik. Ezek a megoldások nem túl környezetbarátok a mai világban
 - A munkás lassan és nehezen látja át a komissziós listát papíron, ezzel párhuzamosan nő a munkavégzéshez szükséges idő
## Igényelt üzleti folyamatok: 
 - A megrendelő kérésére minden munkás lekérheti a teljes raktárkészletet
## Követelménylista:
 - Termék hozzáadása(azonosító, név, kategória, mennyiség)
 - Termék módosítása daradbszám által 
 - Termék törlése
## Fogalomtár:
 - Raktárkezelő program -- Bolti termékek tárolása egy raktárban
 - Új termék hozzáadása -- Új termék bevitele a táblázatba 
 - Termék törlése -- Meglévő termék kitörlése a táblázatból
 - Termék bevitele -- Meglévő termék darabszámának növelése
 - Termék kivitele -- Meglévő termék darabszámának csökkentése
