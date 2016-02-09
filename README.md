# Game Cloud

### Proof-of-concept project for StartUP Weekend Blagoevgrad (Spring 2015)

##### Description:
The goal of the project was to create a mock-up GUI application that would demonstrate the technical feasibility of cloud gaming in front of the jury and audience of the 2015 StartUP Weekend Blagoevgrad. The application served as a prototype desktop client, which customers of the cloud gaming service would use to connect to the servers that would actually run the games. Once logged in, the user would browse the game catalog and choose a title. Next, the client would deliver the request to the server and begin streaming video output from the game of choice to the user's device, while also sending any user mouse and keyboard input back to the server, in order to progress through the game. Under the hood, the application launches the Remote Desktop Connection software bundled with Windows operating systems, establishes a connection to another computer emulating the cloud server, and then streams video from an already running game back to the client's PC.  
