# ASP .NET CORE WEB API (Template)

### Description
This repository is a template for creating .Net Core Web API or APPs. It utilizes the three tier architecture for its implementation. Feel free to add more template or boilerplate code.

<br>

### Branches
- `main`
- `three-tier-architecture`

<br>

### Three Tier Architecture
- **API - Application Presentation Layer.** The top-most layer of the 3-tier architecture, and its major role is to display the results to the user, or to put it another way, to present the data that we acquire from the business access layer and offer the results to the front-end user. This is most likely where the application configuration is setup and where controllers are located.
- **BLL - Business Logic Layer.** The logic layer interacts with the data access layer and the presentation layer to process the activities that lead to logical decisions and assessments. This layer is responsible for processing data between other layers. It is composed of an *__interface__* and *__services__* that implement the interface.
- **DAL - Data Access Layer.** The main function of this layer is to access and store the data from the database and the process of the data to business access layer data goes to the presentation layer against user request. This layer can contain the following folders:
    - Contracts - define the interface that performs the desired functionalities with the database
    - Data - folder  that contains the DB Context Class. This class is very important for accessing the data from the database.
    - Migrations - contains information on all the migrations we performed during the construction of the project.
    - Models - contains entity models of the database
    - Repositories - this is where we add the repositories classes against each model. We write the CRUD function that communicates with the database using entity framework. We add the repository class that inherits the interface that is present in Contract folder.

*__Credits:__ RR*