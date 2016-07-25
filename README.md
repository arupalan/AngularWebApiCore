# AngularWebApiCore
The objective is to show case the featues listed beow in as simple as simple can be. 
Objective is to make development and maintanibility simpler with low learning curve by proper understanding of
the purpose and the necessity of the technology in the first place.
Not all features I've currently implemented , but will be done very soon as I can manage time.

![Console Mode](http://www.alanaamy.net/wp-content/uploads/2016/07/AngularWebApiCore.png)

# Building From Source on Mac OSX or Windows (Assumed .Net Core already installed on target platform)
1. Move to your local git repository directory or any directory (with git init) in console. 
I assume you have .Net Core installed on Mac or other OS.
If not then follow this link https://www.microsoft.com/net/core#macos


2. Clone repository.

        git clone https://github.com/arupalan/AngularWebApiCore.git
        cd AngularWebApiCore
        dotnet restore
        cd src
        npm install
        bower install
        gulp
        dotnet run
        
# Remaining Features
Some remaining features like angular ui-router angular material angular e2e EntityFramework , RabbitMQ Microservices , 
Travis are work in progress.
