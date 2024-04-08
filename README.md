# CQRS

**Introduction**
<br />
The Command Query Responsibility Segregation (CQRS) pattern is a widely used pattern today for splitting up the CRUD operations for a datastore into read vs update operations.
At it's core what the CQRS pattern does it that the entity model which is used as part of the database update might not the same model that we use for the reading information from the database.
When we are designing our systems our basic requirement is to read the data from the datastore which may vary from directly reading a single record from a single datastore to merging multiple records into a single DTO.
Conversely the same is true in case of insertion and deletion of records as well. We may wish to perform some sort of validation rules during insert/update on records and the update on 1 entry may impact the other records as well.

During development based on an individual needs the developer may conceptualize the implementation in his/her own way and this results in multiple domain models being created for each use case which results in increasing the overall complexity of the same.
The CQRS model comes in to reduce this complexity introduced by different conceptual models added during implementation.

The change that is introduced by CQRS is to split Command and Query operations. For reading the data we introduce models as per the requirement as Query models and for write operations we introduce Command models.

With this project we have the MediatR library to implement the CQRS pattern.

MediatR is used for the implementation of the mediator pattern to help solve the problem of decoupling the process of process of handling and processing messages.

We use the IRequest interface of the MediatR's library to create the models to be used for the Query/Command operations.

**Mediator Pattern**
<br />
The mediator design pattern's primarily aimed at decoupling the communication between classes by using a common meditor object.
This leads to less number of direct requests/responses in between multiple components of the application.
It makes it easier to create reusable components which can be later modified or extended based on requirements.
For the implementation of CQRS, Mediator pattern is widely used by using MediatR library since we can use the IMediator interface 
to act as the central hub for all communication and segregates the request to their respective handlers based on the command and queries received.

**Libraries used for implementing CQRS**
<br />
For the current project we have used multiple libraries to implement the CQRS pattern.
- MediatR (to process messages for the command and query)
- AutoMapper (to convert the query models to final DTOs)
<br />

**Project Skeleton** <br/>
The project follows the below skeleton for the implementation.
    
- Configuration
    For any configurations to be done. As of now Mapper profile has been added as part of configuration but can be later extended.

- Controllers
    It contains all the controllers and the methods that will be exposed as the API endpoints to the end user.

- Domain 
    These are the Data level models/entities which can be configured with EF Core or can be used with raw data queries to fetch the data from the database.

- Handlers
    This folder is to divide the application requirements as per the module/functional requirement and then based on module we seperate the command and query operations.
    - Module (Product)
        - Command
        - Query

- Models
    These are the final DTO (Data Transfer Object) which are returned as from the API response. The DTO may be a combination of multiple domain entities and may or may not have the same properties as the domain models.

- Repository
    It consists of the interface along with the implementation of the repositories which will be further used to connect and perform CRUD operations with the data source.
    The interfaces defined here are registered as dependencies in the Program.cs file to ensure that they can be used for the DI.

