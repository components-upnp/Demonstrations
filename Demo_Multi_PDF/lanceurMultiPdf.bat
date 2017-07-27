@echo off

Rem Suppression des beans déjà créés
del %USERPROFILE%\Documents\wcomp.net\beans\*

Rem Lancement de la visionneuse de diapositives
cd .\"Lecteur Diapo"
start Visionneuse-0.0.1-SNAPSHOT-jar-with-dependencies.jar
cd ..

Rem Lancement Afficheur Likes
cd .\Java_Afficheur_Likes
start Java_Afficheur_Likes-1.0-SNAPSHOT-jar-with-dependencies.jar
cd..

Rem Lancement Liker
cd .\Java_Liker
start Java_Liker-1.0-SNAPSHOT-executable.jar
cd ..

Rem Lancement Recuperateur
cd .\Java_Recuperateur_Page
start lanceur.bat
cd ..

Rem Lancement Télécommande Maîtresse (ici Buttons)
cd .\Buttons
start Defilement_UPnP-1.0-SNAPSHOT-jar-with-dependencies.jar
cd ..

Rem Lancement script Assemblage
cd .\Assemblage
start AssemblageMultiplePdfLiker.bat
cd ..

Rem Lancement du wizard designer
cd C:\Program Files (x86)\SharpDevelop\3.0\UPnPWizardDesigner
start UPnPWizardDesigner.exe

Rem Lancement de WComp
cd C:\ProgramData\Microsoft\Windows\Start Menu\Programs\SharpDevelop 3.2
start SharpDevelop

Rem Exit
exit