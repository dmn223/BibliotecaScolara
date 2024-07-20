Aplicația este menită bibliotecilor școlare, scopul acesteia fiind de a avea biblioteci moderne, care nu folosesc foi pentru a reține date. Publicul țintă este, pentru început, biblioteca liceului meu, unde pentru a împrumuta o carte trebuie realizați următorii pași:

1. Alegerea dosarului clasei - există câte un dosar pentru fiecare clasă din liceu.
2. Găsirea, din dosar, a foii proprii - fiecare elev din liceu are o foaie proprie unde sunt trecute împrumuturile din acel an.
3. Semnarea într-o agendă unde se rețin toate împrumuturile.

Se observă astfel că această metodă nu este eficientă, motiv pentru care m-am decis să fac o aplicație care să remedieze problema.

Aplicația mea permite următoarele funcționalități și funcționează împreună cu o bază de date, legate între ele prin comenzile clasice SQL:

1. Adăugarea elevilor - se completează datele cerute.
2. Adăugarea cărților - se completează datele cerute.
3. Ștergerea elevului - pe baza CNP-ului.
4. Împrumutarea cărților - se vizualizează o listă cu cărțile și se selectează cartea dorită, rămânând de completat doar datele despre elev.
5. Vizualizarea cărților împrumutate (se pot aplica filtre după titlu, autor și numele elevului pentru vizualizarea datelor dorite).
6. Returnarea cărții - se face după numărul de inventar, care este unic în baza de date.

Arhitectura: monolitică
Metodologie: secvențială

Puncte forte:
1. Publicul țintă bine definit.
2. Simplicitatea utilizării aplicației.
3. Resurse hardware minime.

Aplicația nu a fost oficial folosită, dar a primit recenzii bune de la persoanele care au testat-o (oficiali ai școlii mele, prieteni, mai mulți bibliotecari).
