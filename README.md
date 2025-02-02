# CleanArchitecture C# .NET

## Branches - Sections of Course:
- feat/1: Structured Programming
- feat/2: POO - Namespace
- feat/3: POO - encapsulation
- feat/4: POO - overriding/overloading
- feat/5: POO - abstract class
- feat/6: POO - polimorphisim w/abstract class
- feat/7: POO - interfaces
- feat/8: POO - generics & static
- feat/9: Funtional Programming
- feat/10: SOLID basic
- feat/11: SOLID Single Responsibility
- feat/12: SOLID Open/Closed
- feat/13: SOLID Liskov
- feat/14: SOLID interface segregation
- feat/15: SOLID dependency inversion
- feat/16: COMPONENTS: basic component
- feat/17: REP reusable release
- feat/18: CCP common closure
- feat/19: CRP common reuse
- feat/20: ADP acyclic dependencies
- feat/21: SDP stable dependencies
- feat/22: SAP stable abstractions
- feat/23: Software Architecture -> Communication between components
- feat/24: Software Architecture -> dependency injection
- feat/25: Clean Architecture -> Entities -Enterprise business rules
- feat/26: Clean Architecture -> Use Cases - Application business rules
- feat/27/28: Clean Architecture -> Entity Framework - Interface Adapters
- feat/29: Clean Architecture -> Repository - Interface Adapters
- feat/30: Clean Architecture -> API Creation - Frameworks and Drivers(67)
- feat/31: Clean Architecture -> Dependency Injection in API - Frameworks and Drivers(67)
- feat/32: Clean Architecture -> Models & Creation of Models Component & Generics in Interfaces - Interface Adapters (69,70,71)
- feat/33: Clean Architecture -> Return Models or Entities in the component Repository? -> Entities
- feat/34: Clean Architecture -> Presenters & Creation of Interface IPresenter (73,74)
- feat/35: Clean Architecture -> Creation of Presenters and ViewModel - Interface Adapters
- feat/36: Clean Architecture -> Mappers, DTOs & Creation of Component Mapper - Interface Adapters(76,77)
- feat/37: Clean Architecture -> Use of Mapper and DTO in API - Frameworks and Drivers(78)
- Release v1.0.0 -> branch 1.0.0-rc-1(cut from feat/37)
- feat/38: Deep Dive in Frameworks & Drivers, Interface Adapters -> Exceptions(80)
- feat/39: Deep Dive in Frameworks & Drivers, Interface Adapters -> MiddleWare Exceptions
- feat/40: Deep Dive in Frameworks & Drivers, Interface Adapters -> Validations in Framework
- feat/41: Deep Dive in Frameworks & Drivers, Interface Adapters -> Presentation Logic(new model and presenter)
- feat/42: Deep Dive in Frameworks & Drivers, Interface Adapters -> Modify Application and Enterprise for third party service(84,85)
- feat/43: Deep Dive in Frameworks & Drivers, Interface Adapters -> Adapter for third party service
- feat/44: Deep Dive in Frameworks & Drivers, Interface Adapters -> 
## Course:

- [www.udemy.com/course/clean-architecture-course](https://www.udemy.com/course/clean-architecture-course/)

## SQL Server Setup & SQL Server Management Studio:
- 1 [LocalDB Installation](https://kb.parallels.com/129699#localdb_solution)
- 2 [LocalDB Installation setup](https://www.youtube.com/watch?v=_12OOgKzi7I)
    ```bash
    Name of db: `localDB1`
    ```
- 3 
    Option 1:
    ```bash
    IN SQL SERVER MANAGEMENT:
    Servername: (LocalDB)\localDB1
    ```
    Option 2:
    ```bash
    command propmt: SqlLocalDB.exe start
    command propmt: sqllocaldb i
    command propmt: SqlLocalDB.exe info localDB1_ORNAMEOFDB
    Instance pipe name: [COPY RESULT... np:\\.\pipe\LOCALDB#9956CA7C\tsql\query..THIS_IS_AN_EXAMPLE]
    Servername: np:\\.\pipe\LOCALDB#9956CA7C\tsql\query
    ```

- Note: Instance pipe changes when computer restarts, propably repeat step 3.