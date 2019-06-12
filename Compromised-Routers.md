# Una guida per rimanere sicuri anche dietro un router compromesso

Questa guida nasce con lo scopo di fornire dei suggerimenti per chi si trova in situazioni particolari e non può effettuare modifiche alla rete a cui è connesso (e probabilmente la rete è compromessa), pur volendo mantenere un alto livello di sicurezza.

In questa guida, il sistema operativo di riferimento è Microsoft Windows.

## Scenario

Una rete che vi serve è stata compromessa, il router è in grado di "sniffare" ogni pacchetto in entrata e in uscita, e ci sono degli script attivi che compromettono le macchine collegate alla rete.

## Risoluzione

Purtroppo la situazione presentata non è affatto "semplice" o "comoda", in quanto per rimanere sicuri dobbiamo considerare sia una protezione della macchina, per evitare possibili intrusioni, sia difendere la comunicazione che altrimenti verrebbe intercettata.

Quindi il tutto si traduce in:

- Sicurezza del sistema: bloccheremo le porte non necessarie al funzionamento della macchina come client.

- Sicurezza delle applicazioni: dobbiamo prevedere un possibile script attivo che cercherà applicazioni e protocolli vulnerabili.

- Sicurezza del trasporto: dobbiamo evitare che la connessione possa essere intercettata.

Cominciamo quindi a "mettere in sicurezza" il sistema.

Per farlo possiamo utilizzare sia il firewall di windows, sia gli strumenti messi a disposizione da "Security Policies" (secpol.msc).

