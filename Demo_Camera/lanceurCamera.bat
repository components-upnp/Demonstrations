@echo off

Rem Suppression des beans déjà créés
del %USERPROFILE%\Documents\wcomp.net\beans\*

Rem Ajout des beans de la caméra
copy cam\* %USERPROFILE%\Documents\wcomp.net\beans

Rem Lancement UPnP to ONVIF adaptateur
cd .\JAVA_UPnP-To-Onvif-Adapter-1.0-SNAPSHOT-zip
start lanceur.bat
cd ..

Rem Lancement script assemblage caméra
cd .\Assemblage
start lanceurAssemblageCamera.bat
cd ..

Rem Lancement du wizard designer
cd "C:\Program Files (x86)\SharpDevelop\3.0\UPnPWizardDesigner\"
start UPnPWizardDesigner.exe

Rem Lancement de WComp
cd "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\SharpDevelop 3.2\"
start SharpDevelop

Rem Exit
exit