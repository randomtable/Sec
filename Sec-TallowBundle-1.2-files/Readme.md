# Reti non sicure - Windows OS (1.0)

Per garantire la protezione su reti non sicure, si può utilizzare il bunble di questa cartella.

Il contenuto del bundle:

- Tor (The Onion Router): https://www.torproject.org/

- Tallow + WinDivert: https://reqrypt.org/tallow.html

- Script di sicurezza.

Perchè questi componenti:

Prendiamo in considerazione una macchina su una rete non sicura, dove il router è compromesso, i pacchetti vengono "sniffati" durante il transito e degli script attivi tentano di compromettere nuove macchine client.

Per garantire una protezione in uno scenario simile, ho scelto di operare tramite uno script che attiva i software necessari.

Lo script è contenuto nel bundle e si chiama "security.bat" e deve essere avviato con privilegi amministrativi.

Tale script è molto semplice e contiene le seguenti istruzioni:

cmd.exe /c netsh advfirewall reset

cmd.exe /c netsh advfirewall firewall delete rule name=all

cd "%~dp0%" && tallow.exe

Dal momento che la macchina potrebbe avere dei servizi in ascolto, e tali servizi possono essere compromessi, per bloccare eventuali richieste dannose, viene resettato lo stato di Windows Firewall tramite il comando "cmd.exe /c netsh advfirewall reset".

Questo riporterà Windows Firewall nel suo stato iniziale.

Per poter impostare Windows in "modalità client-only" viene eseguito il comando "cmd.exe /c netsh advfirewall firewall delete rule name=all".

In questo modo vengono eliminate tutte le regole.

Eliminare tutte le regole è un buon compromesso per rendere il sistema sicuro da attacchi esterni, in quanto il Firewall di Windows permetterà connessioni in uscita senza avere regole troppo rigide per Tor.

Una configurazione troppo rigida, ad esempio con IPSec, potrebbe impedire il corretto funzionamento di Tor.

Eliminando tutte le regole, inoltre, si impedisce l'esposizione di eventuali servizi vulnerabili nella rete dove si è connessi, in quanto il Firewall di Windows impedisce connessioni in ingresso dirette, se non esplicitamente dichiarate e configurate.

Una volta impedite, quindi, le minacce dirette sulla rete dove si è connessi, viene attivato Tallow e WinDivert.

Che cos'è Tallow:

Tallow è un applicativo (https://reqrypt.org/tallow.html) che permette di redirezionare tutta la propria connessione su Tor, in maniera trasparente.

Per farlo, utilizza la WinDivert (https://reqrypt.org/windivert.html), ovvero una libreria che permette di redirezionare, leggere e modificare i pacchetti in transito da e verso lo stack di rete di Windows.

La suddetta libreria viene utilizzata anche da Suricata (un Intrusion Detection and Prevention System estremamente potente).

Lo script abilita Tallow, il quale avvia Tor e attende che il bootstrap di Tor sia terminato.

Durante il bootstrap di Tor, potrebbe essere richiesto da Windows di consentire Tor. Per un corretto funzionamento, daremo il consenso a Tor.

A bootstrap terminato, cliccando sull'apposito pulsante, viene attivata la WinDivert, e tutta la connessione verrà redirezionata su Tor.

Su Windows 7:

![Alt text](https://github.com/randomtable/Sec/blob/master/win7.png)

Su Windows 10:

![Alt text](https://github.com/randomtable/Sec/blob/master/win10.png)

Questo procedimento permette di rimanere sicuri, in quanto a livello di sistema non abbiamo possibilità che altri possano connettersi direttamente alla macchina.

A livello di rete, Tor effettua uno scambio di messaggi cifrato, facendo rimbalzare la connessione su nodi esterni, impedendo che informazioni "in chiaro" possano essere sniffate dal router compromesso.

non basta un firewall più robusto e HTTPS?

Per quanto riguarda il Firewall, non è un problema di cosa si usa, ma la logica di tali sistemi, ovvero per avere una sicurezza adeguata si dovrebbe usare un IDS/IPS ben configurato, che è ben diverso dall'avere il semplice Firewall attivo sulla macchina.

Per evitare problemi, quindi, su una rete compromessa è meglio utilizzare una logica "acceso/spento", ovvero bloccare tutte le connessioni in ingresso.

Per quanto riguarda HTTPS, purtroppo i fattori in gioco sono molteplici se consideriamo che la rete di riferimento è compromessa.

Un browser, nella sua fase iniziale, scambia delle informazioni con il server, per decidere quale sia la cifratura ottimale e disponibile.

Se i software non sono perfettamente aggiornati, e se ci si connette ad un sito che non utilizza configurazioni ottimali, il risultato sarà disastroso, in quanto è come non avere nessuna sicurezza (algoritmi di cifratura obsoleti, certificati non correttamente settati, server non correttamente configurati... provate ad effettuare un test su SSLLabs inserendo qualche istituto bancario... avrete belle sorprese).

Detto questo, dato che non dipende totalmente dalla nostra connessione o computer, Tor permette di risolvere il problema senza dover fare affidamento a "variabili esterne".

E' tutto oro quello che luccica?

Assolutamente no! HTTPS è un tassello importante, nonostante gli svantaggi che può presentare.

Utilizzare Tor e connettersi ad un sito senza HTTPS vuol dire che tutte le informazioni possono essere lette dal cosiddetto "Exit Node", ovvero l'ultimo nodo che permette di "atterrare" effettivamente sul sito/server/servizio che vogliamo accedere.

Inoltre, questo approccio non è votato all'anonimato, permette solo di mantenere un livello di sicurezza adeguato su una rete compromessa.

Inoltre, l'utilizzo di Tor viene bloccato a volte da alcuni servizi o siti.

Diverso è, ovviamente, l'utilizzo di un Hidden Service.

Per gli Hidden Service Tor utilizza un protocollo di cifratura end-to-end, e non è richiesto (anzi, in alcuni casi potrebbe essere pericoloso) l'utilizzo di HTTPS su di un Hidden Service.

In conclusione questa può essere una soluzione al problema, ma comunque consiglio sempre di ragionare bene, per "risolvere" il problema e non "spostarlo".
