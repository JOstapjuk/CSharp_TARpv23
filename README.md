# C# Projekti dokumentatsioon

## Projekti ülevaade

See C# projekt demonstreerib erinevaid funktsionaalsusi ja toiminguid, kasutades sõnaraamatuid, funktsioone ja masiive. Projekt koosneb mitmest failist, millest igaüks teenib kindla eesmärgi. Allpool on ülevaade võtmefailidest ja nende funktsionaalsustest.

## Failid ja nende eesmärk

### 1. **Functions.cs**
   - **Kirjeldus:** Sisaldab meetodeid erinevate funktsioonide jaoks
   - **Peamised meetodid:**
     -`Korrutis`: Arvutab elementide toote täisarvulises massiivis.
     -`Keskmine`: Arvutab elementide keskmise täisarvulises massiivis.
     -`Summa`: Arvutab elementide summa täisarvulises massiivis.
     -`Arved_Massiiv`: Loob hulga täisarvu alates 'N' kuni 'M-1'.
     -`Paevad`: Muudab päevanumbri oma nimele.
     -`kõrguseKategooria`: Määrab kõrguse kategooria soo ja kõrguse põhjal.
     - `Arvuta`: Teeb etteantud funktsioonistringi põhjal matemaatilise operatsiooni.
     - `Liitmine`: Lisab kaks täisarvu.
     - `Tere`: Tervitab kasutajat.
     - `OtsiPealinn`: Otsib etteantud maakonnanime alusel pealinna.
     - `OtsiMaakond`: Otsib etteantud pealinna nime alusel maakonda.
     - `LisaUusMaakond`: Lisab sõnastikku uue maakonna ja pealinna.
     - `TestiTeadmisi`: Katsetab kasutaja teadmisi, esitades küsimusi maakondade ja pealinnade kohta.
     - `KuvaMaakonnadJaPealinnad`: Kuvab kõik maakonnad ja nende pealinnad.
     - `LisaKasutaja`: Lisab sõnastikku uue kasutaja, kontrollides olemasolevaid kasutajanimesid ja e-posti aadresse.
     - `UuendaKasutaja`: Uuendab olemasoleva kasutaja e-posti aadressi.
     - `KustutaKasutaja`: Kustutab kasutaja sõnaraamatust kasutaja kasutajanime põhjal.
     - `LoetleKasutaja`: Loetleb kõiki kasutajaid ja nende e-posti aadresse.

### 2. **Inimine.cs**
   - **Kirjeldus:** Klassis "Inimene" modelleeritakse üksikisikut, kelle atribuudid on seotud isiklike detailide ja tervisemõõdikutega. Seda klassi kasutatakse isikuandmete haldamiseks ning tervise ja aktiivsuse tasemega seotud arvutuste tegemiseks.

### 3. **Listid_sõnastikud.cs**
   - **Kirjeldus:** Klassi "Listid_sônastikud" eesmärk on käsitleda erinevaid isikuandmeid, tootehaldust ja geograafilist teavet puudutavaid toiminguid. Selles on funktsionaalsused toodete nimekirjadega suhtlemiseks, kasutaja sisendi valideerimiseks ning riikide ja pealinnadega seotud sõnastike toimingute haldamiseks.

### 4. **MainClass.cs**
   - **Kirjeldus:** Fail "MainClass.cs" sisaldab, mis on taotluse sisestuspunktiks. See näitab erinevate funktsioonide kasutamist nagu aritmeetilised operatsioonid, kasutaja sisendi käsitlemine ja kutsumismeetodid teistest klassidest.

### 5. **Massiivid_Kordus.cs**
   - **Kirjeldus:** Fail "Massiiv_Kordus.cs" sisaldab erinevaid funktsioone, mis on seotud massiivide, kasutaja sisendi ja põhitoimingutega. Klassis demonstreeritakse selliseid ülesandeid nagu juhuslike numbrite genereerimine, kasutaja sisendi käsitsemine, summade ja keskmiste arvutamine ning selliste kogudega nagu "ArrayList" ja "List" töötamine. Lisaks tutvustatakse põhifailide käsitlemist ja objektidele suunatud programmeerimist klassiga "Inimene".

### 6. **Toode.cs**
   - **Kirjeldus:** Fail "Toode.cs", mis esindab oma nime ja kalorsusega toodet. Seda klassi kasutatakse toidukaupade või muude toodete modelleerimiseks, kus kaloriteave on asjakohane. Klassi kuuluvad omadused toote nime ja selle kalorsuse säilitamiseks koos konstruktoriga nende omaduste initsialiseerimiseks.

### 7. **Ulesanne5.cs**
   - **Kirjeldus:** Fail "Ulesanne5.cs" sisaldab konsoolirakendust, mis haldab kasutaja autentimise ja kasutajahalduse toiminguid. See võimaldab kasutajatel sisse logida ja teha erinevaid toiminguid lähtuvalt nende rollidest. Rakendus toetab kahte rolli: "admin" ja "kasutaja" , kusjuures admin omab täiendavaid privileege.

### 8. **Valikute_Konstrukt.cs**
   - **Kirjeldus:** Fail "Valikute_Konstrukt.cs" sisaldab konsoolirakendust, mis demonstreerib erinevaid põhilisi programmeerimiskontseptsioone, sealhulgas sisendkäitlust, tingmärke, silmuseid ja arvutusi. Rakendus täidab mitmeid ülesandeid, mis põhinevad kasutaja sisendil, nagu põrandapinna arvutamine, allahindluste käsitlemine, kõrguse kategoriseerimine, ostlemine ja palju muud.
