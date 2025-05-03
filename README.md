# Facade Design Pattern

### Type
Structural Design Pattern

### What problem it solves?
Large software systems often consist of multiple components with intricate interdependencies. Client system interacting directly with these subsystems face increased complexity, making the system harder to use. Also, Exposing too many internal details can lead to tight coupling between client code and system components.

### How it solves the problem?
This pattern encapsulates multiple operartions under 1 roof. It provides a single, unified interface (the Facade) that encapsulates complex subsystem logic. The Facade acts as an intermediary, forwarding client requests to appropriate components without exposing underlying complexities. It enhances encapsulation by shielding clients from unnecessary details and interactions within the subsystem. The system remains flexible—internal changes to the subsystem do not affect client code as long as the Facade’s interface remains consistent.

### Limitations
+ The Facade could become a bottleneck if overloaded with responsibilities, reducing modularity and maintainability.

### Diagram
![Facade_Pattern_Diagram drawio](https://github.com/user-attachments/assets/34c9fc28-2a48-4ac4-86f9-edca3dccc95b)
