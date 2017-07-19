@echo off

Rem Suppression des beans déjà créés
del %USERPROFILE%\Documents\wcomp.net\beans\*

Rem Lancement Polling Station
cd .\Java_Bureau_De_Vote-1.0-SNAPSHOT-zip\
start lanceur.bat
cd ..

Rem Lancement IHM
cd .\Java_Polling_Station_IHM\
start Java_Polling_Station_IHM-1.0-SNAPSHOT-jar-with-dependencies.jar
cd ..

Rem Lancement Générateur de rapport
cd .\GenerateurDeRapport\
start GenerateurDeRapport-1.0-SNAPSHOT-jar-with-dependencies.jar
cd ..

Rem Lancement Int to Direction adaptateur
cd .\Java_Int_To_Direction_Adapter-1.0-SNAPSHOT-zip\
start lanceur.bat
cd ..

Rem Lancement script assemblage vote interactif 
cd .\Assemblage\
start lanceurAssemblageVote.bat
cd ..

Rem Lancement du wizard designer
cd C:\Program Files (x86)\SharpDevelop\3.0\UPnPWizardDesigner
start UPnPWizardDesigner.exe

Rem Lancement de WComp
cd C:\ProgramData\Microsoft\Windows\Start Menu\Programs\SharpDevelop 3.2
start SharpDevelop

Rem Exit
exit