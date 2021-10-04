# Funkcionális Specifikáció

## Áttekintés:
- A fejlesztésünk célja, egy olyan raktári program, amelyben bolti termékeket fogunk tárolni.

- A program célja a könnyű kezelhetőség és átláthatóság.

- A termékeket külön kategóriába lesznek sorolva.

- A programban lesz lehetőség új termékek felvételére, módosítására és azok törlésére is.

- A termékeket név, cikkszám és kategória szerint lehet tárolni, ezek mellett megadható neki a mennyisége is.

# Jelenlegi helyzet:
Szeretnénk nyújtani egy egyszerűen használható raktár kezelő programot, ahol megkönnyítenénk a dolgozók feladatát az elavult kézi dokumentációval szemben. Felgyorsítja a termékek nyomon követesének folyamatát valamit tárolási megoldását. 

# Jelenlegi üzleti folyamatok modellje:
A XXI. században sajnos még mindig vannak, akik az ilyen jellegű adattárolást papír alapon kezelik. Ezen folyamatok egyszerűsítése és modernizálása célszerű lenne környezetvédelem és a munkafolyamat egyszerűsítése végett.

# Igényelt üzleti folyamatok modellje:
- Programunk célja, hogy leegyszerűsítsük egy raktárban tárolt termékek átláthatóságát és, hogy nyomon tudjuk követni melyik termékből mennyi áll rendelkezésünkre a raktárban és hol található az adott termék a raktárban.

- A programot gyorsan és egyszerűen lehessen használni, adatok gyors hozzáadása és módosítása vagy törlése.

- Célunk, hogyha egy termék elfogy akkor a program figyelmeztessen minket.

# Használati esetek:
Jegyzettömbben tárolt adatok:
Adatok hozzáadása, törlése, módosítása.

# Követelmény lista:
Adatok hozzáadása, törlése, módosítása

# Kifejtés:
- Adatok hozzáadása: A program megnyit egy új Form-os ablakot az ’’ Új termék hozzáadása’’ gombbal, és ezen az ablakon a szükséges adatok megadásával új terméket tud hozzáadni.
- Adatok törlése: Az datagridview adatbázisban a kijelölt termékek a ’’Termékek törlése” gomb lenyomása után törlődjön a terméklistából és a datagridview-ból.
- Adatok módosítása: A kijelölt elemnek a darbaszámát tudjuk növelni a ”Termékek bevitele” gombbal, valamint csökkenteni a darabszámot a ’’Termékek kivitele” gombbal. 

# Fogalomszótár:

# Forgatókönyv:
- Megnyitja a felhasználó az alkalmazást.
- Amennyiben rájogosult személy nyitja meg az alkalmazást, a felhasználói panel teljes hozzáférést biztosít az illetékesnek, és tud termékeket módosítani, törölni, bevinni, illetve kivenni az adott listából.

# Funkcionális-Követelmény megfeleltetés:
- Termék hozzáadása: Egy létező üres vagy bizonyos szintig feltöltött listához képes a felhasználó új terméket név, termékazonosító, termékdarab, termékkategória. 
- Termék törlése: Egy adott elemet a listából kijelölve ki tud törölni a felhasználó.
- Termék bevitele: Egy meglévő listaelemhez a felhasználó tud hozzáadni darabszámot a terméknév megadásával.
- Termék kivétele: Egy meglévő listaelemből a felhasználó el tud távolítani egy általa megadott mennyiséget a terméknév és a darabszám megadásával. 
