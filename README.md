We are translating the entire project in english... Thanks for patience :)

I am developing the new project "Cassaforte", for a complete distributed security platform.
Take a look, and let me know!

# README (English version):

Welcome,

This repository has 2 software, "Sec" and "Fire".
"Sec" is the software to perform the hardening of the operating system in a simple way, while "Fire" creates customized rules for Windows Firewall (the software is still under development and testing).

Using "Sec" you can import or generate rules, which are distributed in the package as "BASE", "USGCB" and "ULTRA".
In this folder:

https://github.com/randomtable/Sec/tree/master/Sec/Sec/bin/Release

it is possible to find the "BASE" and "USGCB" configurations plus the software already compiled, while in the root it is possible to find the "ULTRA" configuration.

Through the files described above the following rules are applied:

"BASE" - No particular configuration. Returns the system in its initial state (it is kept mandatory to press CTRL + ALT + DEL to access the Windows Login screen).

"USGCB" - This configuration sets the rules defined in the United States Government Configuration Baseline.
To be taken as a medium-level configuration.

"ULTRA" - This configuration allows the system to be set very restrictively.
In this configuration, to give an example, the audio service will not work, as it does not have the necessary permissions to start.
For example, to allow a connection in Remote Desktop, you need to set the username in "secpol.msc" both in the "Access your computer from the network" setting and in the "Allow access via Remote Desktop Services" setting, both in the Desktop settings Remote in the control panel.

The software has been tested in the versions available from Windows 7 to Windows 10, including Windows Server 2012 R2.
The settings are also functional in the "Home Edition" versions, which however do not have "secpol.msc" available.

The most appropriate operation for the safest configuration is as follows:

Open the program and click "Importa Modello".
Select "ULTRA.inf" and wait for the operations to complete.

After importing the model, check that the selected settings are the ones you want, then select "Genera e Installa".

Once this is done, the system is "strengthened".

In addition to applying the security rules, in the Windows Firewall are reset all the rules, so as not to receive incoming connections, but still be able to ensure the connectivity of the system as a client.

Since this software and these configurations are special, before using it in a production environment, it is necessary to test it thoroughly on a test machine or on a virtual machine.

Let me know what you think, any suggestions / corrections / additions are welcome.

This software does not want to be a solution to all security problems (also because it would be a utopia), but wants to be a piece of the puzzle to help users in the security issue, which lately is making a lot of talk.



# README (Italian version):

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

Questo software non vuole essere una soluzione a tutti i problemi di sicurezza (anche perchè sarebbe un’utopia), ma vuole essere un pezzo del puzzle per aiutare gli utenti nel tema della sicurezza, che ultimamente sta facendo molto parlare.

