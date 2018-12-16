# Project SCAP (all releases) - English Version
I do not own the rules (released by NIST), nor the tool "LGPO.exe" (released by Microsoft)!

Welcome to my Repository!
Below you can find old "Sec" Readme, useful if you want to apply USGCB rules.

Since NIST has published the "National Checklist Program" (NCP), and since there are no tools on the web (or maybe i don't found them), i decided to write my own tool.

As i want to simplify the Security Process, this project aims to bring "simplicity" to this complex matter.

The NIST releases a lot of rules, GPOs and configurations for almost all type of devices.
I decided to start with Windows, since this project is focused on it.

I'll release periodically updated tools that apply latest version of rules from NIST for Windows.
There are focused rules for IE or SQL Server, i'm implementing it in the near future.

You can find the software in the "SCAP" folders, named by release date (format of version name: "SCAP_YYYY_MM_DD").
For example, you can find the folder "SCAP_2018_12_16".
In a "version", you can find the software, NIST rules and Microsoft tool, to release a single folder that contains everything.

You can find the software here:
https://github.com/randomtable/Sec/tree/master/SCAP_2018_12_16/SCAP/bin/Release

You can apply all rules simple double clicking on "SCAP.exe" and click on the "START" button on the form.
Restart of System is needed, after rules is applied.

The tool i created, imports all ADMX files and ADML, and through "LGPO.exe" applies GPOs to local System.

Internet connection is not required, so you can easily copy entire folder and apply rules directly to your System Images too.

More information about SCAP and Checklist Program can be found here:
https://csrc.nist.gov/projects/security-content-automation-protocol/scap-releases/scap-1-3
https://nvd.nist.gov/ncp/repository

More information about Security Technical Implementation Guide (STIG):
https://iase.disa.mil/stigs/Pages/index.aspx

The "LGPO.exe" tool, can be found here:
https://blogs.technet.microsoft.com/secguide/2016/01/21/lgpo-exe-local-group-policy-object-utility-v1-0/

AS ALWAYS, TEST IT BEFORE RELEASE ON PRODUCTION SYSTEMS!

Stay safe :)

# Project SCAP (all releases) - Italian Version

Non possiedo le regole (rilasciate da NIST), né lo strumento "LGPO.exe" (rilasciato da Microsoft)!

Benvenuto nel mio repository!
Di seguito è possibile trovare il file Leggimi "Sec", utile se si desidera applicare le regole USGCB.

Dal momento che il NIST ha pubblicato il "National Checklist Program" (NCP), e dal momento che non ci sono strumenti sul web (o forse non li ho trovati), ho deciso di scrivere il mio strumento.

Dal momento che voglio semplificare il processo di sicurezza, questo progetto mira a portare "semplicità" a questa complessa questione.

Il NIST rilascia molte regole, GPO e configurazioni per quasi tutti i tipi di dispositivi.
Ho deciso di iniziare con Windows, poiché questo progetto è focalizzato su di esso.

Rilascerò strumenti periodicamente aggiornati che applicano l'ultima versione di regole da NIST per Windows.
Ci sono regole focalizzate per IE o SQL Server, le implementerò nel prossimo futuro.

È possibile trovare il software nelle cartelle "SCAP", denominate in base alla data di rilascio (formato del nome della versione: "SCAP_YYYY_MM_DD").
Ad esempio, puoi trovare la cartella "SCAP_2018_12_16".
In una "versione", puoi trovare il software, le regole NIST e lo strumento Microsoft, per rilasciare una singola cartella che contiene tutto.

Puoi trovare il software qui:
https://github.com/randomtable/Sec/tree/master/SCAP_2018_12_16/SCAP/bin/Release

È possibile applicare tutte le regole semplicemente facendo doppio clic su "SCAP.exe" e fare clic sul pulsante "START" sul form.
È necessario riavviare il sistema, dopo aver applicato le regole.

Lo strumento che ho creato, importa tutti i file ADMX e ADML, e tramite "LGPO.exe" applica gli oggetti Criteri di gruppo al sistema locale.

La connessione Internet non è necessaria, quindi puoi facilmente copiare l'intera cartella e applicare le regole direttamente anche alle immagini di sistema.

Ulteriori informazioni su SCAP e Checklist Program sono disponibili qui:
https://csrc.nist.gov/projects/security-content-automation-protocol/scap-releases/scap-1-3
https://nvd.nist.gov/ncp/repository

Ulteriori informazioni sulla Security Technical Implementation Guide (STIG):
https://iase.disa.mil/stigs/Pages/index.aspx

Lo strumento "LGPO.exe" può essere trovato qui:
https://blogs.technet.microsoft.com/secguide/2016/01/21/lgpo-exe-local-group-policy-object-utility-v1-0/

COME SEMPRE, TESTA PRIMA DI RILASCIARE IN PRODUZIONE!

Rimani sicuro! :)

=======
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

