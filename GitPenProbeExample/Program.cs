using GitPenProbeExample;

GreetingService greetingService = new GreetingService();
UserInterface userInterface = new UserInterface(greetingService);
userInterface.Run();
