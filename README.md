# Blog App

You can create blogs and its description, photo, tags with admin role. The other users can see your blog contents. They can list or sort them.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them

--Check the connection string on appsettings.json file. <br>
--Change the APIKEY and SECRETKEY on appsettings.json This web site can help you https://www.avast.com/random-password-generator <br>
--Change Mail Hosting, mail, password and sockets according to your smtp settings. /Utilities/EmailHelper <br>

Project has swagger, you can create a new user on /User/Post . A code for verification will be sent to your associated e-mail address. Verify your account using that code.

Comment [NonAction] attribute from /Authentication/CreateRole endpoint. Run CreateRole endpoint for Take admin role. Uncomment [NonAction] attribute after take role.

First the request comes to the controller (BlogController), then the interface runs (IBlogService) and the interface sends a request to the Service (BlogService).

.Net version 6
Microsoft.EntityFrameworkCore 7.0.2
AspNet.Security.OAuth.Validation 2.0.0

## Authors

* ** Yusuf Bozkurt ** - *Initial work* - [softwareruless](https://github.com/softwareruless)

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
