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

A bootstrap terminato, cliccando sull'apposito pulsante, viene attivata la WinDivert a livello di sistema, e tutta la connessione verrà redirezionata su Tor.

Su Windows 7:

![Alt text](https://github.com/randomtable/Sec/blob/master/win7.png)

Su Windows 10:

![Alt text](https://github.com/randomtable/Sec/blob/master/win10.png)
