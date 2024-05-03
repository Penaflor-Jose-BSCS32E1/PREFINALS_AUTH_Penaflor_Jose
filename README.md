Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)<br><br>
Conceptual Understanding:<br>

Onion Architecture: (Yes/No) 
Have you heard of the Onion Architecture principle in software design? **YES**<br><br>
 
 
MVC Pattern: (Yes/No) 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?**YES**<br><br>
 
 
 
Web API: (Yes/No) 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?**YES**<br><br>
 
 
 

Application & Bottlenecks:<br>
Onion Architecture:
 
 
Benefits: (1-3 keywords)
 
 
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)<br><br>

Onion Architecture makes software development easier by keeping parts separate, simplifying testing, and allowing for changes without affecting everything. It helps focus on important tasks, promotes code reuse, and makes programs easier to understand and maintain over time.
 
 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)<br><br>
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)<br><br>
Yes, Implementing Onion Architecture can bring challenges such as making simple projects more complex than necessary, finding developers familiar with the pattern, restructuring legacy projects, potential performance impacts, and the risk of over-engineering. These challenges can slow down initial progress and require careful consideration to balance the benefits of the architecture with its complexities.


 
 

MVC:<br>
Components: (1-3 keywords each)
 
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.<br><br>
Model handles data and rules.
View shows things to users.
Controller manages user actions and talks to the Model and View.
 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)<br><br>
No but Tightly coupling the Model and Controller in MVC projects can cause problems. It makes testing controllers harder because changes in one part often mean changing others, leading to more bugs and slower development. Also, it can make code less reusable and flexible for future needs. To fix this, it's important to keep Model and Controller separate and use interfaces to connect them, making testing easier and the code more adaptable. 
 

Web API:
 
 
Differences from MVC: (Yes/No and Briefly Explain)
 
 
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.<br><br>
Traditional MVC applications are for users to interact with through interfaces, while Web APIs are for programs to talk to each other over the internet. MVC is about user interfaces, and APIs are about data exchange between software.
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
 
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)<br><br>
Yes, Traditional MVC applications can face performance issues like slow page loads due to frequent refreshes and complex data exchanges. This happens because MVC often reloads entire pages and handles data in a way that can strain servers. On the other hand, Web APIs are better for handling lots of data exchanges quickly and efficiently, making them a good choice for real-time updates and reducing the strain on servers. To improve performance in MVC, strategies like caching and optimizing data handling can help, but sometimes using Web APIs is a more effective solution.
