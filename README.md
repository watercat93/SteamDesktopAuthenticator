<h1 align="center">
  <img  src="https://raw.githubusercontent.com/Jessecar96/SteamDesktopAuthenticator/master/icon.png" height="64" width="64" />
  <br/>
  Steam Desktop Authenticator - Updated to compile on Linux with MonoDevelop <br/>

</h1>

<p align="center">
  <b>Attempting to fix the linux build <br/><br/>
 <b>If you aren't interested in fixing the issues I reccomend using WINE, NEVER download a windows version from anywhere else<br/>
   <a href="https://github.com/Jessecar96/SteamDesktopAuthenticator/releases/latest">Jessecar96 windows build here</a>
   
   </b><br>
   <h1> Issues / fixes </h1>
   
   There was a bunch of dependancy problems with Newtonsoft.Json, I had to remove and hack fix some of the code - there is no longer command line options <br/>
   <br> the BIGGEST issue is that  <h1>VIEW CONFIRMATIONS CRASHES  </h1> it used to do the same on windows 7 and I had to find a different version of microsofts vc redistributables. </br> </br> </b>
   
   Pulling from this fork should allow you to pull the project and run it without error in MonoDevelop <br/><br/>
   First pulled 27th June 2020 </br><br/>

**REMEMBER: Always make backups of your `maFiles` directory! If you lose your encryption key or delete `maFiles` by accident AND you didn't save your revocation code, you are screwed.**

**FINALLY: Using this application is a bad idea, because it COMPLETELY DEFEATS THE PURPOSE of two-factor authentication! If your desktop is infected with a virus, it will be able to hijack the authenticator app and completely subvert the protection. THIS APPLICATION DOES NOT PROTECT YOUR ACCOUNT; IT ONLY ALLOWS YOU TO USE STEAM FEATURES THAT REQUIRE THE AUTHENTICATOR WITHOUT HAVING A PHONE. If you have a phone that supports the Mobile Authenticator, you really shouldn't use this application!**

IF you lost your `maFiles` OR lost your encryption key, go [here](https://store.steampowered.com/twofactor/manage) and click "Remove Authenticator" then enter your revocation code that you wrote down when you first added your account to SDA.

If you did not follow the directions and did not write your revocation code down, you're well and truly screwed. The only option is beg to [Steam Support](https://support.steampowered.com/) and say you lost your mobile authenticator and the revocation code.


