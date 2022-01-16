using DieRoller;

Die testDie = new Die();
Console.WriteLine("testing");
Console.WriteLine(testDie.FaceUpValue);
testDie.IsHeld = false;

testDie.Roll();
Console.WriteLine(testDie.FaceUpValue);
