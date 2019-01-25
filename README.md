# AsyncInn

### To Submit this Assignment
- [ ] Create a new repo on your personal GitHub account
- [ ] Name your repo AsyncInn
- [ ] Create a branch named NAME-LAB13
- [ ] Write your code
- [ ] Commit often
- [ ] Push to your repository
- [ ] Create a pull request from your branch back your master branch.
- [ ] Submit a link to your PR in canvas
- [ ] Merge your PR back into master
- [ ] Include a README.md (contents described below)

### Directions:
Today you will be creating your initial MVC application for your Hotel management system.

#### Scaffold
- [ ] Scaffold out a basic MVC web application using the steps provided from class 11 & 13. Include a Home Controller with a basic Index action. No need to add any content to the Index view, just have it load a greeting for now. You will work more on the Home Controller a little further down.

#### Entities to Models
- [ ] Using your database schema, convert each entity into a model within your newly created MVC web application.

- [ ] Following the steps provided, in addition to what we did in class, create a new DbContext named AsyncInnDbContext.
- [ ] Within this DbContext, declare your Database tables and set your composite keys.

#### Design
Think about the design of your website. What will it look like? What pages will exist? How do the pages interact and link to each other? For our website, we will have the following pages:

- [ ]  Home Page to greet the Hotel Admin. This page will also serve as a dashboard for the other locations of the site.
- [ ] Hotels page that will allow the admin to create and edit new or existing hotels
- [ ] Rooms page where the admin will be able to create or edit new or existing rooms
- [ ] Amenities page that will allow the admin to add to their list of existing amenities
- [ ] A page where they can link the Amenities to the rooms that currently exist
- [ ] A page where they can add existing rooms to hotels
- [ ] Following the design, Create a controller for each of the pages listed above. You may “Add » Controller” on the controllers folder and scaffold out the basic CRUD operations if you wish.

#### Home Page
- [ ] Add some html and styling to your home page.
- [ ] Link the index action of each of the other controllers within the Home page.

Throughout the week, we will slowly evolve this page to be more of a “dashboard” feel, but start the design now to start the process.

### Evaluation
To gain full credit for this “feature”, your branch must consist of:

Startup File
- [ ] Explicit routing of MVC
- [ ] MVC dependency in ConfigureServices
- [ ] DBContext registered in ConfigureServices
- [ ]  of static files accepted

Controller
- [ ] Home Controller
- [ ] Controllers for each of the pages described in the Design section (you do not have to scaffold if you don’t want to)

Data
- [ ] DBContext present and properly configured
- [ ] DB Tables for each entity model (DbSet<T>)
- [ ] Composite key association present in OnModelCreating override.
- [ ] appsettings.json file present with name of database updated

Models
- [ ] Each Entity from the DB Table converted into a Model
- [ ] Proper naming conventions of Primary keys, or utilization of the [Key] data annotation
- [ ] Navigation properties present in each Model where required
- [ ] Enum present in appropriate model

#### Views
- [ ] View for home page that matches default routing

#### Home Page
- [ ] stylesheet present in web application
- [ ] stylesheet referenced on home page.
- [ ] Web application should build, compile, and redirect us to the home page upon launch. If you decided to scaffold the controllers, they should be accessible through their default actions.

### README
A Readme is a requirement. No Readme == No Grade. 
Here are the requirements for a valid readme: 

A README is a module consumer’s first – and maybe only – look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so. 

Your readme should be in introduction to your web app. Provide in your readme, your DbSchema and an overview of the relationships and how each entity is related to another.

Your job is to

- [ ] tell them what it is (with context, provide a summary)
- [ ] show them what it looks like in action (Visuals)
- [ ] show them how they use it (Step by step directions, “Happy Path” walk through)
- [ ] tell them any other relevant details 
