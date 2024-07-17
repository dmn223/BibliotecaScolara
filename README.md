Aplicatia este menita bibliotecilor scolare, scopul acesteia fiind de a avea biblioteci moderne, ce nu folosesc foi pentru a retine date.
Publicul tinta este, pentru inceput, biblioteca liceului meu, unde pentru a imprumuta o carte trebuie realizati urmatorii pasi:
1. Alegerea dosarului clasei - exista cate un dosar pentru fiecare clasa din liceu
2. Gasirea, din dosar, a foii proprii - fiecare elev din liceu are o proprie foaie unde sunt trecute imprumuturile din acel an.
3. Semnarea intr-o agenda unde se retin toate imprumurile.

Se observa astfel ca aceasta metoda nu este eficienta, motiv pentru care m-am decis sa fac o aplicatie care sa remedieze problema.

Aplicatia mea permite urmatoarele functionalitati si functioneaza impreuna cu o baza de date, legate intre ele prin comenzile clasice SQL
1. Adaugarea elevilor - se completeaza datele cerute
2. Adaugarea cartile - se completeaza datele cerute
3. Stergerea elevului - pe baza CNP-ul
4. Imprumutarea cartilor - se vizualizeaza o lista cu cartile si se selecteaza cartea dorita, ramanand de completat doar datele despre elev
5. Vizualizarea cartilor imprumutate (se pot aplica filtre dupa titlu, autor si numele elevului pentru vizualizarea datelor dorite)
6. Returnarea cartii - se face dupa numarul de inventar, care este unic in baza de date.

Arhitectura: monolitica
Metodologie: secventiala

Puncte forte: 
1. publicul tinta bine definit
2. simplicitatea utilizarii aplicatiei
3. resurse hardware minime

Aplicatia nu a fost oficial folosita, dar a primit recenzii bune de la personalele care au testat-o (oficiali ai scolii mele, prieteni, mai multi bibliotecari)
