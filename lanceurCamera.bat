@echo off

Rem Suppression des beans déjà créés
cd %USERPROFILE%
del Documents\wcomp.net\beans\*

Rem Ajout des beans de la caméra
cd %USERPROFILE%
copy Documents\wcomp.net\cam\* Documents\wcomp.net\beans

Rem Lancement UPnP to ONVIF adaptateur
cd %USERPROFILE%
cd IdeaProjects\JAVA_UPnP-To-Onvif-Adapter\target\JAVA_UPnP-To-Onvif-Adapter-1.0-SNAPSHOT-zip
start lanceur.bat

Rem Lancement script assemblage caméra
cd %USERPROFILE%
cd IdeaProjects\Scripts_UserStory\target
start lanceurAssemblageCamera.bat

Rem Lancement du wizard designer
cd C:\Program Files (x86)\SharpDevelop\3.0\UPnPWizardDesigner
start UPnPWizardDesigner.exe

Rem Lancement de WComp
cd C:\ProgramData\Microsoft\Windows\Start Menu\Programs\SharpDevelop 3.2
start SharpDevelop

Rem Exit
exit