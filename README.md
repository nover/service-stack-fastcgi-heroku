service-stack-fastcgi-heroku
============================

Mono fast-cgi based bare bones hello world application in Service Stack. It supports running on Windws via IIS or via mono-fastcgi4 server.

You can publish this to Heroku by running the following commands (given that you have Heroku toolbelt installed):
    $ heroku create --buildpack http://github.com/friism/heroku-buildpack-mono.git
    $ git push heroku master
