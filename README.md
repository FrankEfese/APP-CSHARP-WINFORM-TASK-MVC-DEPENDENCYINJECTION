# <div align="center"> APP-CSHARP - WINFORM - TASK - MVC - DEPENDENCYINJECTION </div>

[![portada.png](https://i.postimg.cc/pTCNJZKV/portada.png)](https://postimg.cc/k62hnWjL)

<h4 align="center">Management application built with C# and .NET using WinForms, following the MVC pattern for a clean and maintainable structure. It uses dependency injection for modularity and testability, and interacts with a RESTful API to manage business data. Asynchronous programming with Task ensures a responsive user interface during background operations.</h4>

<br>

## <div align="center">WINFORM</div>

[![menu.png](https://i.postimg.cc/QdCp8xff/menu.png)](https://postimg.cc/mPxcVRf9)

<h4 align="center">For the development of the user interface, I used Windows Forms (WinForms) with the design tools provided by Visual Studio. The interface offers a wide range of functionalities, such as viewing data, adding new records, updating existing information, deleting entries, and providing convenient options for searching and filtering data.</h4>

<br>

## <div align="center">DEPENDENCY INJECTION</div>

<p align="center">
  <img src="https://i.postimg.cc/nzhsk3N0/dependencias.png" alt="dependencias" />
</p>

<h4 align="center">The application implements dependency injection to promote a modular and loosely coupled architecture. By injecting dependencies rather than instantiating them directly, the system becomes easier to maintain, extend, and test. This approach facilitates the substitution of components (such as services, repositories, or controllers) without modifying the consuming classes, and aligns with SOLID principles—especially the Dependency Inversion Principle. Dependency injection is configured during application startup, ensuring that all necessary services are properly resolved and managed throughout the application lifecycle.</h4>

<br>

## <div align="center">MVC</div>

[![mvc.png](https://i.postimg.cc/v8Lns6tr/mvc.png)](https://postimg.cc/Th11j1S1)

<h4 align="center">The application follows the Model-View-Controller (MVC) architecture, which separates the user interface, business logic, and data management into distinct components. This structure enhances code organization, improves maintainability, and makes the application more scalable and easier to update or expand in the future.</h4>

<br>

## <div align="center">TASK</div>

[![models.png](https://i.postimg.cc/c4FXdzBB/models.png)](https://postimg.cc/QHWpb0PF)

<h4 align="center">The application performs API calls to retrieve and manipulate data, enabling real-time interaction with external services. To maintain a smooth and responsive user experience, these operations are handled asynchronously using Task. This approach prevents the user interface from freezing during data processing, allowing the application to remain efficient and responsive even when dealing with longer-running network operations.</h4>
