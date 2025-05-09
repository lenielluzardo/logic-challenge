Coding Challenge
## Currently:
- Each challenge is built with two methods:
  - **Start():** Is in charge of running all the operations related to:
    - Printing challenge name and description.
    - Printing challenge instructions the user must follow.
    - Reading and validating the user input.
    - Parsing user input to the corresponding data type.


  - **Solve():**Is responsible for solving the challenge. It has the implementation of the corresponding steps for solving the challenge.
  The `Solve` method has different implementations based on the type and dificulty of the challenge.
  
## TO DO:
- Make console log more interactive: displays a list with the existing challenges to the user. The user can select through the command line which challenge wants to play with.

- When a new challenge is implemented automatically add it to the list that is displayed to the user (see reflection technique).

- Share code for common behavior like: display the name of the challenge, reading and validating and parsing user input. (see interfaces, abstract classes or generics)

- Invoke the correct challenge solution based on the user selection (see strategy pattern or reflection).



