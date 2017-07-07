# Scripts_Demo
Ce dépôt contient les exécutables et les scripts permettant de lancer les démonstrations

<strong>Prérequis : </strong>

Afin de pouvoir lancer les démonstrations présentes dans ce dépôt il faut avoir préalablement installé :

    1) IDE Arduino : https://www.arduino.cc/download_handler.php
    2) SharpDevelop 3.0 : http://www.wcomp.fr/sharpwcomp3
    3) WComp : http://www.wcomp.fr/_media/public_namespace:releases:sharpwcomp-3.2.1.1390.msi
    4) UPnPDesigner : http://www.wcomp.fr/_media/public_namespace:releases:upnpdesigner-3.2.1.1390.msi
    
<i>Attention</i> : les intallations doivent être effectuées dans l'ordre présenté ci-dessus.

Maitenant vous devez télécharger les fichiers de ce dépôt en cliquant sur le bouton "clone or download", puis "Download ZIP",
comme montré sur l'image ci_dessous :

![alt tag](https://github.com/components-upnp/Scripts_Demo/blob/master/captureDepotDemos.PNG)

Une fois le téléchargement terminé vous pouvez extraire le contenu de l'archive dans le répertoire de votre choix.

<strong>Lancement d'une démonstration :</strong>

<i><span style="color:#FD0202">Attention</span></i> : pour lancer correctement la démonstration du lecteur de diapositive il faut préalablement connecter la carte Arduino
sur laquelle sont connectés deux boutons soit connectée au PC. Vous devez vérifier sur quel port la carte est connectée
et effectuer quelques changements si besoin est comme expliqué en section "Vérification connexion et installation carte Arduino".

Le lancement des démonstrations se fait de la même manière pour chacune d'elle, il suffit pour cela de lancer le .bat correspondant.

Le script lancera un certains nombre de programmes dont SharpDevelop et UPnP Wizard Designer.
Afin que les assemblages de composants puissent avoir lieu, il faut ouvrir un conteneur WComp dans SharpDevelop. Si c'est la
première fois, choisissez Fichier -> Nouveau -> Fichier. Puis dans WComp.net choisir C# container. Enregistrez le fichier
et nommez le précisément container.cs
Si vous avez déjà créé le conteneur, ouvrez le simplement.

Une fois dans le conteneur, cliquez sur WComp.net -> Bind to UPnP Device
Du côté de UPnP Wizard Designer cliquez sur connect puis le nom du conteneur. 

Vous pouvez maintenant ajoutez des composants Android quand vous le souhaitez et obeserver les assemblages dans le 
conteneur WComp. Pour plus d'informations à propose des composants à utiliser préférablement pour chaque démo, se référer
au document explicatif présent dans chaque répertoire.

<strong>Vérification connexion et installation carte Arduino :</strong>

Pour vérifier l'état de connexion de la carte Arduino vous devez lancer l'IDE Arduino installé précédemment, puis cliquer sur 
"Outils" puis déplacer le curseur sur "COM ...". Vous verrez apparaître le port COM sur lequle la carte est connectée ainsi 
que son nom entre parenthèse, comme vous pouvez le voir sur l'image qui suit et finalement notez le nom du port et cliquez dessus.

![alt tag](https://github.com/components-upnp/Scripts_Demo/blob/master/captureArduinoPort.png)

Nous allons maitenant installer un script sur la carte. Pour cela lancer le script File > Examples > Firmata > StandardFirmata

![alt tag](https://github.com/components-upnp/Scripts_Demo/blob/master/captureArduinoFirmata.png)

La carte est maintenant prête, mais nous devons encore préciser le port de la carte au script du composant Arduino.
Pour cela ouvrez dans un éditeur de texte le fichier Buttons\upnp_Arduino_Buttons\index.js et si besoin est changez le 
port de la carte à la 3ème ligne.
