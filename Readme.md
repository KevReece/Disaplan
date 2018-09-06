Disaplan
========

First Time Setup
----------------

Powershell 5.1 (Windows Management Framework 5.1/`$PSVersionTable.PSVersion`/Always as admin) 
- `Install-Module -Name AzureRM` (installs nuget first)

Add Disaplan IIS Website
- Hostname:Disaplan.localhost
- PhysicalPath:C:\Projects\Disaplan\WebApp\WebApp

Local Run
---------

Run in Visual Studio; or build and browse to Disaplan.localhost

Local Run Tests
---------------

Install Visual Studio Specflow extension
Run in Visual Studio

Azure Manual Setup
------------------

Create account
Register subscription ResourceProvider 'Microsoft.Web' (this may only have been required due to an Microsoft datacentre outage)
Create WebApp Resource (called 'Disaplan', in EuropeWest, with ResourceGroup 'Disaplan-WebApp')
Setup deployment from GitHup to WebApp

Proposal
--------
Fitness training plan app/site.
Focus on simple core plan creation and tracking, and sharability.
Primary features:
- Create and share training plan
- Track and share training progress
Secondary features:
- excecise wiki
- fitness training articles

Technologies
------------
MVC.Net
WebApi
Azure
ReactJs
Ionic
EntityFramework
Unity
DynamoDB
BDD

Epics
-----
Business:
User 
Plan
Login
Train
App
Exercise
Articles

Tech:
Deployment