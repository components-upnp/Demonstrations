@echo off

Rem Suppression des beans déjà créés
cd %USERPROFILE%
del Documents\wcomp.net\beans\*

Rem Lancement Polling Station
cd %USERPROFILE%
cd IdeaProjects\Java_Bureau_De_Vote\target\Java_Bureau_De_Vote-1.0-SNAPSHOT-zip
start lanceur.bat

Rem Lancement IHM
cd %USERPROFILE%
cd IdeaProjects\Java_Polling_Station_IHM\target
start Java_Polling_Station_IHM-1.0-SNAPSHOT-jar-with-dependencies.jar

Rem Lancement Générateur de rapport
cd %USERPROFILE%
cd IdeaProjects\GenerateurDeRapport\target
start GenerateurDeRapport-1.0-SNAPSHOT-jar-with-dependencies.jar

Rem Lancement Int to Direction adaptateur
cd %USERPROFILE%
cd IdeaProjects\Java_Int_To_Direction_Adapter\target\Java_Int_To_Direction_Adapter-1.0-SNAPSHOT-zip
start lanceur.bat

Rem Lancement script assemblage vote interactif 
cd %USERPROFILE%
cd IdeaProjects\Scripts_UserStory\target
start lanceurAssemblageVote.bat

Rem Lancement du wizard designer
cd C:\Program Files (x86)\SharpDevelop\3.0\UPnPWizardDesigner
start UPnPWizardDesigner.exe

Rem Lancement de WComp
cd C:\ProgramData\Microsoft\Windows\Start Menu\Programs\SharpDevelop 3.2
start SharpDevelop

Rem Exit
exit