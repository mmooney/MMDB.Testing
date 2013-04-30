# MMDB Website Beater Upper #

## Crudely beat your website senseless.##

Chocolatey: http://chocolatey.org/packages/MMDB.WebsiteBeaterUpper

GitHub: https://github.com/mmooney/MMDB.Testing

Need to know how a page in your website behaves under load?  Trying to find timeouts or deadlocks?

Don't have 80 gazillion dollars to spend on fancy tools?  Don't have hours to waste learning some fancy complicated system when all you need to do is bludgeon your website repeatedly until it falls over?

Well sir, MMDB's Website Beater Upper is for you.

It's free.  It's easy to setup and use.  It's proudly as stupid as it could reasonably be while still being remotely useful.

Here's how to use it:
* Step 0: You use Chocolatey, right?  If not, stop wasting your time reading this, and go over to http://chocolatey.org/ and get yourself edumacated.
* Step 1: Install the Website Beater Upper package:

```dos
    C:\> cinst MMDB.WebsiteBeaterUpper
          .SendEmail("This is the subject",                       //Give a subject
                new {FirstName="Mike", LastName="Mooney" },       //and a model object
                "Hello <b>@Model.FirstName @Model.LastName</b>!", //and a Razor view
                new List<string> {"to@example.com"},              //and a list of people to send it do
                "from@example.com"                               //and who you are
          );

* Step 2: Run it
```dos
	C:\>WebsiteBeaterUpper
