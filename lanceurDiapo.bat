@echo off

Rem Suppression des beans déjà créés
cd %USERPROFILE%
del Documents\wcomp.net\beans\*

Rem Lancement de la visionneuse de diapositives
cd %USERPROFILE%
cd IdeaProjects\upnp_pdf_reader\target
start Visionneuse-0.0.1-SNAPSHOT-jar-with-dependencies.jar

Rem Lancement de l'adaptateur Arduino
cd %USERPROFILE%
cd IdeaProjects\Java_Arduino_Adapter\target\Java_Arduino_Adapter-1.0-SNAPSHOT-zip
start lanceur.bat

Rem Lancement serveur Arduino Boutons
cd %USERPROFILE%
cd Documents\components_upnp\Buttons\upnp_Arduino_Buttons
start lanceurServeurArduino.bat

Rem Lancement script assemblage pdf 
cd %USERPROFILE%
cd IdeaProjects\Scripts_UserStory\target
start lanceurAssemblagePdf.bat

Rem Lancement du wizard designer
cd C:\Program Files (x86)\SharpDevelop\3.0\UPnPWizardDesigner
start UPnPWizardDesigner.exe

Rem Lancement de WComp
cd C:\ProgramData\Microsoft\Windows\Start Menu\Programs\SharpDevelop 3.2
start SharpDevelop

Rem Exit
exit