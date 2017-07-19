@echo off

Rem Suppression des beans déjà créés
del %USERPROFILE%\Documents\wcomp.net\beans\*

Rem Lancement de la visionneuse de diapositives
cd .\"Lecteur Diapo"
start Visionneuse-0.0.1-SNAPSHOT-jar-with-dependencies.jar
cd ..

Rem Lancement de l'adaptateur Arduino
cd .\Java_Arduino_Adapter-1.0-SNAPSHOT-zip
start lanceur.bat
cd ..

Rem Lancement serveur Arduino Boutons
cd .\Buttons\upnp_Arduino_Buttons
start lanceurServeurArduino.bat
cd ..\..

Rem Lancement script assemblage pdf 
cd .\Assemblage
start lanceurAssemblagePdf.bat
cd ..

Rem Lancement du wizard designer
cd C:\Program Files (x86)\SharpDevelop\3.0\UPnPWizardDesigner
start UPnPWizardDesigner.exe

Rem Lancement de WComp
cd C:\ProgramData\Microsoft\Windows\Start Menu\Programs\SharpDevelop 3.2
start SharpDevelop

Rem Exit
exit