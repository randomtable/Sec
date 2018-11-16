# Sec
Translation in progress... :)

# README:

ITALIAN VERSION
Benvenuti,

Questo repository conta di 2 software, “Sec” e “Fire”.
“Sec” è il software per effettuare l’hardening del sistema operativo in maniera semplice, mentre “Fire” crea delle regole personalizzate per Windows Firewall (il software è ancora in fase di sviluppo e testing).

Utilizzando “Sec” è possibile importare o generare delle regole, le quali sono distribuite nel pacchetto come “BASE”, “USGCB” e “ULTRA”.
In questa cartella è possibile trovare le configurazioni “BASE” e “USGCB” più il software già compilato, mentre nella root è possibile trovare la configurazione “ULTRA”.

Tramite i file sopra descritti vengono applicate le seguenti regole:

“BASE” - Nessuna configurazione particolare. Riporta ilk sistema nel suo stato iniziale (viene mantenuta l’obbligatorietà di premere la combinazione CTRL+ALT+CANC per accedere alla schermata di Login di Windows).

“USGCB” - Questa configurazione imposta le regole definite nel United States Government Configuration Baseline.
Da prendere come una configurazione di medio livello.

“ULTRA” - Questa configurazione permette di impostare il sistema in maniera molto restrittiva.
In questa configurazione, per fare un esempio, non funzionerà il servizio audio, in quanto non ha i permessi necessari per avviarsi.
Per permettere un collegamento in Desktop Remoto, ad esempio, è necessario impostare il nome utente in “secpol.msc” sia nella impostazione “Accedi al computer dalla rete”, che nella impostazione “Consenti accesso tramite Servizi Desktop Remoto”, sia nelle impostazioni Desktop Remoto presenti nel pannello di controllo.

Il software è stato testato nelle versioni disponibili da Windows 7 a Windows 10, compreso Windows Server 2012 R2.
Le impostazioni sono funzionanti anche nelle versioni “Home Edition”, le quali però non hanno “secpol.msc” disponibile.

Il funzionamento più consono per la configurazione più sicura, è il seguente:

Aprire il programma e cliccare “Importa Modello”.
Selezionare “ULTRA.inf” e attendere il completamento delle operazioni.

Dopo l’importazione del modello, controllare che le impostazioni selezionate siano quelle desiderate, quindi selezionare “Genera e installa”.

Fatto questo, il sistema è “rafforzato”.

Oltre ad applicare le regole di sicurezza, nel Firewall di Windows vengono azzerate tutte le regole, in maniera tale da non poter ricevere connessioni in ingresso, ma poter comunque garantire la connettività del sistema come client.

Dal momento che questo software e queste configurazioni sono particolari, prima di utilizzarlo in ambiente di produzione, è necessario testarlo a fondo su una macchina test o su una macchina virtuale.

Fatemi sapere cosa ne pensate, qualsiasi suggerimento/correzione/integrazione sono ben accette.

Questo software non vuole essere una soluzione a tutti i problemi di sicurezza (anche perchè sarebbe un’utopia), ma vuole essere un pezzo del puzzle per aiutare la PA nel tema della sicurezza, che ultimamente sta facendo molto parlare.

