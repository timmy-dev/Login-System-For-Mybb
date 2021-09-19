# Login-System-For-Mybb
By: Arminius

-------------------------- Donate ---------------------------------

Bitcoin: bc1qmp8zcmm702c4g5vmfp94zxqlup493ys8e7u6gw

Ethereum: 0xA6fDB418c52b121Ca08055F154f74c8A30638d69

Doge Coin: DFwahf3PWEyizo5eJQP11ZmmZVepBpegf7

---------------------------Thank you ------------------------------


c# login system for mybb forums. You can use this to create c# app or connect this to other language app.


This system will make is so you can login with your mybb forum username and password. You can make certain usergroups get login rights as well.



**Installing Webfiles to web server**
------------------------------------

After you install the files to your computer you need to upload all the files in Web Files for login system folder to your webserver.
1. Upload all of the files in the forum root directory.
2. Once uploaded you are done with the web files.



**Getting login system setup**
------------------------------------
1. Open Login System For My bb c# folder and then open Mybb Login System.sln

Once you got the project open there is a few thing to edit 
1. Go to forum 1 and go to the code. Go to line 39 and edit http://siteurl/check.php?username= and only change 'siteurl'. Change this to your domain name and if your forum is not root directory put / the directory where it is.
2. Do the same thing on line 61 only siteurl.
3. Go to line 103 and 108 and change site url only again if you want lost password and a register button. If you do not want it then make the like buttons not visible.
4. Go to forum 4 and change the siteurl on line 42.
5. Then Build it. 
This is all you have to do to make it work with your site.


**now you can edit stuff you want to match your site and cusimize it to your liking. So if you have a app you can get rid of form 4 and make it open the other app. Or you can build your app off of form 4. Or you can do other stuff you would like.**
